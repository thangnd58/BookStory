﻿using BookStory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace BookStory.Controllers
{
    public class StoryController : Controller
    {
        readonly StoryDBContext context = new();

        public IActionResult Detail(int id, int? page)
        {
            Story s = null;
            s = context.Stories.FirstOrDefault(x => x.Sid == id);
            Author author = null;
            author = context.Authors.FirstOrDefault(x => x.Aid == context.StoriesAuthors.FirstOrDefault(s => s.Sid == id).Aid);
            ViewBag.Author = author;
            List<Category> categoriesOfStory = new();
            List<Category> listAllCategories = context.Categories.ToList();
            List<StoriesCategory> storiesCategories = null;
            storiesCategories = context.StoriesCategories.Where(x => x.Sid == id).ToList();
            foreach (StoriesCategory sc in storiesCategories)
            {
                foreach (Category c in context.Categories.ToList())
                {
                    if (sc.Cid == c.Cid)
                    {
                        categoriesOfStory.Add(c);
                    }
                }
            }
            List<Chapter> chapters = context.Chapters.Where(x => x.Sid == id).ToList();
            ViewBag.Categories = categoriesOfStory;
            ViewBag.AllCategories = listAllCategories;
            ViewBag.Story = s;
            ViewBag.StoryAuthors = context.Stories.Where(s => s.StoriesAuthors.Where(x => x.Aid == author.Aid && x.Sid != id).Any()).Take(5).ToList();
            ViewBag.StoryHighestView = context.Stories.OrderByDescending(x => x.View).Take(10).ToList();
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var chaptersPage = chapters.ToList();
            return View(chaptersPage.ToPagedList(pageNumber, pageSize));
        }

        public IActionResult Content(int id, int page)
        {

            Chapter c = null;
            List<Category> listAllCategories = context.Categories.ToList();
            c = context.Chapters.FirstOrDefault(x => x.Sid == id && x.Chapnumber == page.ToString());
            Story s = context.Stories.FirstOrDefault(x => x.Sid == id);
            s.View++;
            context.SaveChanges();
            ViewBag.AllCategories = listAllCategories;
            ViewBag.AllChapters = context.Chapters.Where(x => x.Sid == id).ToList();
            User u = null;
            string json = HttpContext.Session.GetString("user");
            if (json != null)
            {
                u = JsonConvert.DeserializeObject<User>(json);
                bool IsSave = false;
                foreach (Reading r in context.Readings.ToList())
                {
                    if (r.Uid == u.Uid && r.Ctid == c.Ctid)
                    {
                        IsSave = true;
                    }
                }
                ViewBag.IsSave = IsSave;
            }
            return View(c);
        }

        [HttpPost]
        [HttpGet]
        public IActionResult Search(string id, int? page)
        {
            ViewBag.AllCategories = context.Categories.ToList();
            ViewBag.StoryHighestView = context.Stories.OrderByDescending(x => x.View).Take(10).ToList();
            _ = context.Chapters.ToList();
            _ = context.StoriesAuthors.ToList();
            ViewBag.Authors = context.Authors.ToList();
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var storiesPage = context.Stories.Where(x => x.StoriesCategories.Where(s => s.Cid.ToString() == id).Any()).ToList();
            if (storiesPage.Count == 0)
            {
                storiesPage = context.Stories.Where(x => x.Name.Contains(id) || x.Keyword.Contains(id)).ToList();
                if (storiesPage.Count == 0)
                {
                    storiesPage = GetStoryByAuthor(id);
                }
            }
            ViewBag.CurrentId = id;
            return View(storiesPage.ToPagedList(pageNumber, pageSize));
        }

        public List<Story> GetStoryByAuthor(string authorname)
        {
            List<Story> stories = new();
            foreach (Author a in context.Authors.ToList())
            {
                foreach (StoriesAuthor sa in context.StoriesAuthors.ToList())
                {
                    if (a.Aid == sa.Aid && a.Name.ToLower().Equals(authorname.ToLower()))
                    {
                        stories.AddRange(context.Stories.Where(x => x.Sid == sa.Sid).ToList());
                    }
                }
            }
            return stories;
        }

        public IActionResult Save(int id, int page)
        {
            User u = null;
            string json = HttpContext.Session.GetString("user");
            if (json != null) u = JsonConvert.DeserializeObject<User>(json);
            List<Reading> readings = context.Readings.ToList();
            int rid = 0;
            if (readings.Count > 0)
            {
                rid = readings.ElementAt(readings.Count - 1).Rid;
            }
            else
            {
                rid = 1;
            }
            int ctid = context.Chapters.FirstOrDefault(x => x.Chapnumber.Equals(page.ToString()) && x.Sid == id).Ctid;
            int count = context.Readings.Where(x => x.Ctid == ctid && x.Uid == u.Uid).ToList().Count;
            if (count == 0)
            {
                Reading r = new();
                r.Rid = rid + 1;
                r.Uid = u.Uid;
                r.Ctid = ctid;
                context.Add<Reading>(r);
                context.SaveChanges();
            }
            return RedirectToAction("Content", "Story", new { id = id, page = page });
        }

        public IActionResult UnSave(int id, int page, int? id2, int? id3)
        {
            int ctid = context.Chapters.FirstOrDefault(x => x.Chapnumber.Equals(page.ToString()) && x.Sid == id).Ctid;
            Reading r = context.Readings.FirstOrDefault(x => x.Ctid == ctid);
            context.Readings.Remove(r);
            context.SaveChanges();
            if (id2 == null)
            {
                return RedirectToAction("Content", "Story", new { id = id, page = page });
            } else
            {
                return RedirectToAction("ListSaved", "Story", new { id = id2, page = id3});
            }
        }

        public IActionResult ListSaved(int id, int? page)
        {
            ViewBag.AllCategories = context.Categories.ToList();
            var SaveChapters = context.Chapters.OrderByDescending(s => s.Sid).Where(x => x.Readings.Where(r => r.Ctid == x.Ctid && r.Uid == id).Any()).ToList();
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            ViewBag.CurrentId = id;
            ViewBag.CurrentPage = page;
            return View(SaveChapters.ToPagedList(pageNumber, pageSize));
        }

    }
}