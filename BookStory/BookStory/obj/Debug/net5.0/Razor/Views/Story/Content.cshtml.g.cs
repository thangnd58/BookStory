#pragma checksum "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbda7af879906b111e068dfe65bbd1a5e999b376"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Story_Content), @"mvc.1.0.view", @"/Views/Story/Content.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
using BookStory.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbda7af879906b111e068dfe65bbd1a5e999b376", @"/Views/Story/Content.cshtml")]
    #nullable restore
    public class Views_Story_Content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
  
    ViewBag.Title = "Content";
    Layout = "_StoryLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""chapter-big-container"" class=""container chapter"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <button type=""button""
                    class=""btn btn-responsive btn-success toggle-nav-open"">
                <span class=""glyphicon glyphicon-menu-updownswitch""></span>
            </button>
            <a class=""truyen-title""");
            BeginWriteAttribute("href", "\r\n               href=\"", 517, "\"", 574, 2);
            WriteAttributeValue("", 540, "/Story/Detail/", 540, 14, true);
#nullable restore
#line 17 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 554, ViewBag.Chapter.Sid, 554, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 575, "\"", 604, 1);
#nullable restore
#line 17 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 583, ViewBag.Chapter.Name, 583, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                                                  Write(ViewBag.Chapter.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            <h2>\r\n                <a class=\"chapter-title\"");
            BeginWriteAttribute("href", " href=\"", 691, "\"", 761, 4);
            WriteAttributeValue("", 698, "/Story/Content/", 698, 15, true);
#nullable restore
#line 19 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 713, ViewBag.Chapter.Sid, 713, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 733, "/", 733, 1, true);
#nullable restore
#line 19 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 734, ViewBag.Chapter.Chapnumber, 734, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", "\r\n                   title=\"", 762, "\"", 814, 1);
#nullable restore
#line 20 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 790, ViewBag.Chapter.Subname, 790, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <span class=\"chapter-text\"><span>");
#nullable restore
#line 21 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                Write(ViewBag.Chapter.Subname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></span>\r\n                </a>\r\n            </h2>\r\n            <hr class=\"chapter-start\">\r\n");
#nullable restore
#line 25 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
             if (Context.Session.GetString("user") != null)
            {
                if (ViewBag.IsSave == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1155, "\"", 1222, 4);
            WriteAttributeValue("", 1162, "/Story/Save/", 1162, 12, true);
#nullable restore
#line 29 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 1174, ViewBag.Chapter.Sid, 1174, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1194, "/", 1194, 1, true);
#nullable restore
#line 29 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 1195, ViewBag.Chapter.Chapnumber, 1195, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-success\">Lưu chương</button></a>\r\n");
#nullable restore
#line 30 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1363, "\"", 1432, 4);
            WriteAttributeValue("", 1370, "/Story/UnSave/", 1370, 14, true);
#nullable restore
#line 33 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 1384, ViewBag.Chapter.Sid, 1384, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1404, "/", 1404, 1, true);
#nullable restore
#line 33 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 1405, ViewBag.Chapter.Chapnumber, 1405, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-success\">Bỏ lưu chương</button></a>\r\n");
#nullable restore
#line 34 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 1579, "\"", 1646, 4);
            WriteAttributeValue("", 1586, "/Story/Save/", 1586, 12, true);
#nullable restore
#line 38 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 1598, ViewBag.Chapter.Sid, 1598, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1618, "/", 1618, 1, true);
#nullable restore
#line 38 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 1619, ViewBag.Chapter.Chapnumber, 1619, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-success\">Lưu chương</button></a>\r\n");
#nullable restore
#line 39 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"margin-top: 30px\" class=\"chapter-nav\" id=\"chapter-nav-top\">\r\n                <input type=\"hidden\" id=\"ten-truyen\" value=\"co-vo-que-mua-tong-tai-tham-sau\">\r\n                <div class=\"btn-group\">\r\n                    <a");
            BeginWriteAttribute("class", " class=\"", 1963, "\"", 2058, 4);
            WriteAttributeValue("", 1971, "btn", 1971, 3, true);
            WriteAttributeValue(" ", 1974, "btn-success", 1975, 12, true);
            WriteAttributeValue(" ", 1986, "btn-chapter-nav", 1987, 16, true);
#nullable restore
#line 43 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue(" ", 2002, ViewBag.Chapter.Chapnumber.Equals("1")?"disabled":"", 2003, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", "\r\n                       href=\"", 2059, "\"", 2170, 4);
            WriteAttributeValue("", 2090, "/Story/Content/", 2090, 15, true);
#nullable restore
#line 44 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 2105, ViewBag.Chapter.Sid, 2105, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2125, "/", 2125, 1, true);
#nullable restore
#line 44 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 2126, int.Parse(ViewBag.Chapter.Chapnumber) - 1, 2126, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""prev_chap"" data-cid="""">
                        <span class=""glyphicon glyphicon-chevron-left""></span> <span class=""hidden-xs"">
                            Chương
                        </span>trước
                    </a>
                    <select class=""btn btn-success btn-chapter-nav"" onchange=""window.location.href=this.value"">
");
#nullable restore
#line 50 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                         foreach (Chapter c in ViewBag.AllChapters)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 2650, "\"", 2693, 4);
            WriteAttributeValue("", 2658, "/Story/Content/", 2658, 15, true);
#nullable restore
#line 52 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 2673, c.Sid, 2673, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2679, "/", 2679, 1, true);
#nullable restore
#line 52 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 2680, c.Chapnumber, 2680, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 52 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                                            Write(c.Chapnumber == @ViewBag.Chapter.Chapnumber?"selected":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(">Chương ");
#nullable restore
#line 52 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                                                                                                               Write(c.Chapnumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 53 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                    <a");
            BeginWriteAttribute("class", " class=\"", 2867, "\"", 2995, 4);
            WriteAttributeValue("", 2875, "btn", 2875, 3, true);
            WriteAttributeValue(" ", 2878, "btn-success", 2879, 12, true);
            WriteAttributeValue(" ", 2890, "btn-chapter-nav", 2891, 16, true);
#nullable restore
#line 55 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue(" ", 2906, ViewBag.Chapter.Chapnumber.Equals(ViewBag.AllChapters.Count.ToString())?"disabled":"", 2907, 88, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", "\r\n                       href=\"", 2996, "\"", 3107, 4);
            WriteAttributeValue("", 3027, "/Story/Content/", 3027, 15, true);
#nullable restore
#line 56 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 3042, ViewBag.Chapter.Sid, 3042, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3062, "/", 3062, 1, true);
#nullable restore
#line 56 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 3063, int.Parse(ViewBag.Chapter.Chapnumber) + 1, 3063, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                       id=""next_chap"" data-cid=""2834632"">
                        <span class=""hidden-xs"">Chương </span>tiếp <span class=""glyphicon glyphicon-chevron-right""></span>
                    </a>
                </div>
            </div><br />
            <hr class=""chapter-end"">
            <div id=""chapter-c"" class=""chapter-c"">
                ");
#nullable restore
#line 64 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
           Write(Html.Raw(ViewBag.Chapter.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <hr class=\"chapter-end\">\r\n");
#nullable restore
#line 67 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
             if (Context.Session.GetString("user") != null)
            {
                if (ViewBag.IsSave == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 3732, "\"", 3799, 4);
            WriteAttributeValue("", 3739, "/Story/Save/", 3739, 12, true);
#nullable restore
#line 71 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 3751, ViewBag.Chapter.Sid, 3751, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3771, "/", 3771, 1, true);
#nullable restore
#line 71 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 3772, ViewBag.Chapter.Chapnumber, 3772, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-success\">Lưu chương</button></a>\r\n");
#nullable restore
#line 72 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 3940, "\"", 4009, 4);
            WriteAttributeValue("", 3947, "/Story/UnSave/", 3947, 14, true);
#nullable restore
#line 75 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 3961, ViewBag.Chapter.Sid, 3961, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3981, "/", 3981, 1, true);
#nullable restore
#line 75 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 3982, ViewBag.Chapter.Chapnumber, 3982, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-success\">Bỏ lưu chương</button></a>\r\n");
#nullable restore
#line 76 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"margin-top: 30px\" class=\"chapter-nav\" id=\"chapter-nav-bot\">\r\n                <div class=\"btn-group\">\r\n                    <a");
            BeginWriteAttribute("class", " class=\"", 4253, "\"", 4348, 4);
            WriteAttributeValue("", 4261, "btn", 4261, 3, true);
            WriteAttributeValue(" ", 4264, "btn-success", 4265, 12, true);
            WriteAttributeValue(" ", 4276, "btn-chapter-nav", 4277, 16, true);
#nullable restore
#line 80 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue(" ", 4292, ViewBag.Chapter.Chapnumber.Equals("1")?"disabled":"", 4293, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", "\r\n                       href=\"", 4349, "\"", 4460, 4);
            WriteAttributeValue("", 4380, "/Story/Content/", 4380, 15, true);
#nullable restore
#line 81 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 4395, ViewBag.Chapter.Sid, 4395, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4415, "/", 4415, 1, true);
#nullable restore
#line 81 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 4416, int.Parse(ViewBag.Chapter.Chapnumber) - 1, 4416, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <span class=""glyphicon glyphicon-chevron-left""></span> <span class=""hidden-xs"">
                            Chương
                        </span>trước
                    </a>
                    <select class=""btn btn-success btn-chapter-nav"" onchange=""window.location.href=this.value"">
");
#nullable restore
#line 87 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                         foreach (Chapter c in ViewBag.AllChapters)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 4913, "\"", 4956, 4);
            WriteAttributeValue("", 4921, "/Story/Content/", 4921, 15, true);
#nullable restore
#line 89 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 4936, c.Sid, 4936, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4942, "/", 4942, 1, true);
#nullable restore
#line 89 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 4943, c.Chapnumber, 4943, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 89 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                                            Write(c.Chapnumber == @ViewBag.Chapter.Chapnumber?"selected":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(">Chương ");
#nullable restore
#line 89 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                                                                                                               Write(c.Chapnumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 90 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                    <a");
            BeginWriteAttribute("class", " class=\"", 5130, "\"", 5258, 4);
            WriteAttributeValue("", 5138, "btn", 5138, 3, true);
            WriteAttributeValue(" ", 5141, "btn-success", 5142, 12, true);
            WriteAttributeValue(" ", 5153, "btn-chapter-nav", 5154, 16, true);
#nullable restore
#line 92 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue(" ", 5169, ViewBag.Chapter.Chapnumber.Equals(ViewBag.AllChapters.Count.ToString())?"disabled":"", 5170, 88, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", "\r\n                       href=\"", 5259, "\"", 5370, 4);
            WriteAttributeValue("", 5290, "/Story/Content/", 5290, 15, true);
#nullable restore
#line 93 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 5305, ViewBag.Chapter.Sid, 5305, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5325, "/", 5325, 1, true);
#nullable restore
#line 93 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 5326, int.Parse(ViewBag.Chapter.Chapnumber) + 1, 5326, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <span class=""hidden-xs"">Chương </span>tiếp <span class=""glyphicon glyphicon-chevron-right""></span>
                    </a>
                </div>
            </div>
        </div>
    </div>
    <div class=""panel-body"">
        <div class=""story-comment-wrapper"">
            <div class=""media"">
                <div class=""panel-heading"">
                    <h3 class=""panel-title pull-left"">
                        <i class=""fa fa-comments""></i>
                        <span>Đang có ");
#nullable restore
#line 106 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                 Write(ViewBag.ListComments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" bình luận</span>
                    </h3><div class=""clearfix"">
                    </div>
                </div>
                <div class=""media-body"" style=""width: 100%;"">
                    <form action=""/Story/CommentChapter"" method=""post"">
                        <div>
                            <input type=""hidden"" name=""ctid""");
            BeginWriteAttribute("value", " value=\"", 6273, "\"", 6302, 1);
#nullable restore
#line 113 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 6281, ViewBag.Chapter.Ctid, 6281, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input type=\"hidden\" name=\"chapnumber\"");
            BeginWriteAttribute("value", " value=\"", 6372, "\"", 6407, 1);
#nullable restore
#line 114 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 6380, ViewBag.Chapter.Chapnumber, 6380, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input type=\"hidden\" name=\"sid\"");
            BeginWriteAttribute("value", " value=\"", 6470, "\"", 6498, 1);
#nullable restore
#line 115 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 6478, ViewBag.Chapter.Sid, 6478, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <textarea name=""comment"" id=""comment-content-area"" class=""form-control"" maxlength=""500"" required></textarea>
                        </div>
                        <div class=""clearfix mt-15"">
                            <div class=""pull-left"">
                                <p> <small>Bạn cần đăng nhập để đánh giá và bình luận.</small></p>
                            </div>
                            <div class=""pull-right"" style=""margin: 10px 0px"">
                                <button type=""submit"" class=""btn btn-sm btn-info"" id=""sky-comment"">Gửi bình luận </button>
                            </div>
                            <div class=""clearfix""></div>
                        </div>
                    </form>
                </div>
            </div>
            <div id=""list-comments-media"" class=""mt-10"">
                <div class=""media"">

                    <div class=""media-body"">
");
#nullable restore
#line 134 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                         if (ViewBag.ListComments != null)
                        {
                            foreach (Rating item in ViewBag.ListComments)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"panel panel-default\">\r\n                                    <div class=\"panel-heading\">\r\n                                        <h4 class=\"media-heading pull-left\">\r\n");
#nullable restore
#line 141 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                              
                                                StoryDBContext storyDBContext = new StoryDBContext();
                                                List<User> listU = storyDBContext.Users.ToList();
                                                foreach (User u in listU)
                                                {
                                                    if (item.Uid == u.Uid)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span>\r\n                                                            ");
#nullable restore
#line 149 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                       Write(u.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </span>\r\n");
#nullable restore
#line 151 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                    }
                                                }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </h4>\r\n                                        <div class=\"pull-right\">\r\n                                            <small> <span class=\"text-muted\"> <i class=\"fa fa-clock-o\"></i>&nbsp;&nbsp; <time class=\"timer\">");
#nullable restore
#line 156 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                                                                                                       Write(item.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</time> </span> </small>
                                        </div>
                                        <div class=""clearfix""></div>
                                    </div>
                                    <div class=""panel-body "">
                                        <span class=""form-content pull-left"">");
#nullable restore
#line 161 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                                        Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 164 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"list-childs\"></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
