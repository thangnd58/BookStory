#pragma checksum "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf1fbd2eefb4b89e24c40d6f6f553ad88f7a073a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Story_Detail), @"mvc.1.0.view", @"/Views/Story/Detail.cshtml")]
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
#line 1 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
using BookStory.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf1fbd2eefb4b89e24c40d6f6f553ad88f7a073a", @"/Views/Story/Detail.cshtml")]
    #nullable restore
    public class Views_Story_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<BookStory.Models.Chapter>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("itemprop", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
  
    ViewBag.Title = "Detail";
    Layout = "_StoryLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container csstransforms3d\" id=\"truyen\">\r\n    <div class=\"col-xs-12 col-sm-12 col-md-9 col-truyen-main\">\r\n        <div class=\"col-xs-12 col-info-desc\" itemscope");
            BeginWriteAttribute("itemtype", " itemtype=\"", 430, "\"", 441, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"title-list book-intro\">\r\n                <h2>Thông tin truyện</h2>\r\n            </div>\r\n            <h3 class=\"title\" itemprop=\"name\">");
#nullable restore
#line 17 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                         Write(ViewBag.Story.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <div class=\"col-xs-12 col-sm-4 col-md-4 info-holder\">\r\n                <div class=\"books\">\r\n                    <div class=\"book\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf1fbd2eefb4b89e24c40d6f6f553ad88f7a073a4990", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 807, "~/StoriesImage/", 807, 15, true);
#nullable restore
#line 21 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
AddHtmlAttributeValue("", 822, ViewBag.Story.Image, 822, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 22 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
AddHtmlAttributeValue("", 879, ViewBag.Story.Name, 879, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"info\">\r\n                    <div>\r\n                        <h3>Tác giả:</h3><a itemprop=\"author\"");
            BeginWriteAttribute("href", "\r\n                                            href=\"", 1095, "\"", 1181, 2);
            WriteAttributeValue("", 1147, "/Story/Search/", 1147, 14, true);
#nullable restore
#line 28 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 1161, ViewBag.Author.Name, 1161, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", "\r\n                                            title=\"", 1182, "\"", 1255, 1);
#nullable restore
#line 29 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 1235, ViewBag.Author.Name, 1235, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                                                    Write(ViewBag.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                    <div>\r\n                        <h3>Thể loại:</h3>\r\n");
#nullable restore
#line 33 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                         foreach (Category c in ViewBag.CategoriesOfStory)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a itemprop=\"genre\"");
            BeginWriteAttribute("href", " href=\"", 1532, "\"", 1559, 2);
            WriteAttributeValue("", 1539, "/Story/Search/", 1539, 14, true);
#nullable restore
#line 35 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 1553, c.Cid, 1553, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", "\r\n                           title=\"", 1560, "\"", 1604, 1);
#nullable restore
#line 36 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 1596, c.Title, 1596, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                       Write(c.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 37 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div>\r\n                        <h3>Nguồn:</h3><span class=\"source\">");
#nullable restore
#line 40 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                                       Write(ViewBag.Story.Source);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div>\r\n                        <h3>Trạng thái:</h3>\r\n");
#nullable restore
#line 44 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                         if (@ViewBag.Story.Status == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"text-success\">Full</span>\r\n");
#nullable restore
#line 47 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"text-primary\">Đang ra</span>\r\n");
#nullable restore
#line 51 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div>\r\n                        <h3>Lượt xem:</h3><span class=\"source\">");
#nullable restore
#line 54 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                                          Write(ViewBag.Story.View);

#line default
#line hidden
#nullable disable
            WriteLiteral(" lượt</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-xs-12 col-sm-8 col-md-8 desc\">\r\n                <div class=\"desc-text desc-text-full\" itemprop=\"description\"><p>");
#nullable restore
#line 59 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                                                           Write(Html.Raw(ViewBag.Story.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n                <div class=\"l-chapter\">\r\n                    <div class=\"l-title\">\r\n                        <h3>Các chương mới nhất</h3>\r\n                    </div>\r\n                    <ul class=\"l-chapters\">\r\n");
#nullable restore
#line 65 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                         foreach (Chapter c in ViewBag.NewChapters)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><span class=\"glyphicon glyphicon-certificate\"></span> <a");
            BeginWriteAttribute("href", " href=\"", 3034, "\"", 3076, 4);
            WriteAttributeValue("", 3041, "/Story/Content/", 3041, 15, true);
#nullable restore
#line 67 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 3056, c.Sid, 3056, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3062, "/", 3062, 1, true);
#nullable restore
#line 67 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 3063, c.Chapnumber, 3063, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3077, "\"", 3095, 1);
#nullable restore
#line 67 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 3085, c.Subname, 3085, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"chapter-text\"></span>");
#nullable restore
#line 67 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                                                                                                                                                                    Write(c.Subname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 68 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-xs-12\">\r\n            <div class=\"title-list\">\r\n                <h2>Danh sách chương</h2>\r\n            </div>\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 78 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                 foreach (Chapter c in @Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n                        <ul class=\"list-chapter\">\r\n                            <li>\r\n                                <span class=\"glyphicon glyphicon-certificate\"></span> <a");
            BeginWriteAttribute("href", " href=\"", 3736, "\"", 3778, 4);
            WriteAttributeValue("", 3743, "/Story/Content/", 3743, 15, true);
#nullable restore
#line 83 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 3758, c.Sid, 3758, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3764, "/", 3764, 1, true);
#nullable restore
#line 83 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 3765, c.Chapnumber, 3765, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", "\r\n                                                                                     title=\"", 3779, "\"", 3891, 2);
#nullable restore
#line 84 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 3873, c.Subname, 3873, 10, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue(" ", 3883, c.Name, 3884, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <span class=\"chapter-text\"><span>");
#nullable restore
#line 85 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                                                Write(c.Subname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></span>\r\n                                </a>\r\n                            </li>\r\n\r\n                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 91 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            ");
#nullable restore
#line 93 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
       Write(Html.PagedListPager(Model, id1 => Url.Action("Detail", new { id1 })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"panel-body\">\r\n            <div class=\"rate\">\r\n                Đánh giá của bạn\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 4382, "\"", 4390, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-score=""6.7"" style=""cursor: pointer;"">
                    <img id=""img1"" onmouseout=""rateOut(1)"" onmouseover=""rateIn(1)"" onclick=""rated(1)"" src=""//static.8cache.com/lib/raty/images/star-on.png"" title=""Không còn gì để nói..."">&nbsp;
                    <img id=""img2"" onmouseout=""rateOut(2)"" onmouseover=""rateIn(2)"" onclick=""rated(2)"" src=""//static.8cache.com/lib/raty/images/star-off.png"" title=""WTF"">&nbsp;
                    <img id=""img3"" onmouseout=""rateOut(3)"" onmouseover=""rateIn(3)"" onclick=""rated(3)"" src=""//static.8cache.com/lib/raty/images/star-off.png"" title=""Cái gì thế này ?!"">&nbsp;
                    <img id=""img4"" onmouseout=""rateOut(4)"" onmouseover=""rateIn(4)"" onclick=""rated(4)"" src=""//static.8cache.com/lib/raty/images/star-off.png"" title=""Haizz"">&nbsp;
                    <img id=""img5"" onmouseout=""rateOut(5)"" onmouseover=""rateIn(5)"" onclick=""rated(5)"" src=""//static.8cache.com/lib/raty/images/star-off.png"" title=""Tạm"">&nbsp;
                    <img id=""img6"" onmouseout=""rateOut(6)"" o");
            WriteLiteral(@"nmouseover=""rateIn(6)"" onclick=""rated(6)"" src=""//static.8cache.com/lib/raty/images/star-off.png"" title=""Cũng được"">&nbsp;
                    <img id=""img7"" onmouseout=""rateOut(7)"" onmouseover=""rateIn(7)"" onclick=""rated(7)"" src=""//static.8cache.com/lib/raty/images/star-off.png"" title=""Khá đấy"">&nbsp;
                    <img id=""img8"" onmouseout=""rateOut(8)"" onmouseover=""rateIn(8)"" onclick=""rated(8)"" src=""//static.8cache.com/lib/raty/images/star-off.png"" title=""Được"">&nbsp;
                    <img id=""img9"" onmouseout=""rateOut(9)"" onmouseover=""rateIn(9)"" onclick=""rated(9)"" src=""//static.8cache.com/lib/raty/images/star-off.png"" title=""Hay"">&nbsp;
                    <img id=""img10"" onmouseout=""rateOut(10)"" onmouseover=""rateIn(10)"" onclick=""rated(10)"" src=""//static.8cache.com/lib/raty/images/star-off.png"" title=""Tuyệt đỉnh!"">
                    <input name=""score"" id=""score"" type=""hidden"">
                </div>
                <em class=""rate-text""></em>
                <div class=""small"" itemprop=""a");
            WriteLiteral("ggregateRating\"");
            BeginWriteAttribute("itemscope", " itemscope=\"", 6454, "\"", 6466, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <em>Đánh giá: <strong><span itemprop=\"ratingValue\">");
#nullable restore
#line 113 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                                                  Write(ViewBag.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></strong>/<span class=\"text-muted\" itemprop=\"bestRating\">10</span> từ <strong><span itemprop=\"ratingCount\">");
#nullable restore
#line 113 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                                                                                                                                                                                  Write(ViewBag.TotalRating);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> lượt</strong></em>
                </div>
            </div>
            <div class=""story-comment-wrapper"">
                <div class=""media"">
                    <div class=""panel-heading"">
                        <h3 class=""panel-title"">
                            <i class=""fa fa-comments""></i>
                            <span>Đang có ");
#nullable restore
#line 121 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                     Write(ViewBag.ListComments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" bình luận</span>
                        </h3><div class=""clearfix"">
                        </div>
                    </div>
                    <div class=""media-body"" style=""width: 100%;"">
                        <form action=""/Story/RatingStory"" method=""post"">
                            <div>
                                <input type=""hidden"" name=""star"" id=""rating-star""");
            BeginWriteAttribute("value", " value=\"", 7464, "\"", 7487, 1);
#nullable restore
#line 128 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 7472, ViewBag.Rating, 7472, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <input type=\"hidden\" name=\"sid\"");
            BeginWriteAttribute("value", " value=\"", 7554, "\"", 7580, 1);
#nullable restore
#line 129 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 7562, ViewBag.Story.Sid, 7562, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <textarea name=""comment"" id=""comment-content-area"" class=""form-control"" maxlength=""500""></textarea>
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
                <div id=""list-comments-media"" class=""mt-10""");
            BeginWriteAttribute("style", " style=\"", 8505, "\"", 8513, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"media\">\r\n\r\n                        <div class=\"media-body\">\r\n");
#nullable restore
#line 148 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                             if (ViewBag.ListComments != null)
                            {
                                foreach (Rating item in ViewBag.ListComments)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"panel panel-default\">\r\n                                        <div class=\"panel-heading\">\r\n                                            <h4 class=\"media-heading pull-left\">\r\n");
#nullable restore
#line 155 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                                  
                                                    StoryDBContext storyDBContext = new StoryDBContext();
                                                    List<User> listU = storyDBContext.Users.ToList();
                                                    foreach (User u in listU)
                                                    {
                                                        if(item.Uid == u.Uid)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <span>");
#nullable restore
#line 162 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                                             Write(u.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 163 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                                        }
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </h4>
                                            <div class=""pull-right"">
                                                <small> <span class=""text-muted""> <i class=""fa fa-clock-o""></i>&nbsp;&nbsp; <time class=""timer"">");
#nullable restore
#line 168 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                                                                                                                           Write(item.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</time> </span> </small>
                                            </div>
                                            <div class=""clearfix""></div>
                                        </div>
                                        <div class=""panel-body"">
                                            <span class=""form-content"">");
#nullable restore
#line 173 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                                                  Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 176 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""list-childs""></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""visible-md-block visible-lg-block col-md-3 text-center col-truyen-side"">
");
#nullable restore
#line 186 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
         if (ViewBag.StoryAuthors.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"list list-truyen col-xs-12\">\r\n                <div class=\"title-list\">\r\n                    <h4>Truyện cùng tác giả</h4>\r\n                </div>\r\n");
#nullable restore
#line 192 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                 foreach (Story s in ViewBag.StoryAuthors)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n                        <div class=\"col-xs-12\">\r\n                            <span class=\"glyphicon glyphicon-chevron-right\"></span>\r\n                            <h3>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 11456, "\"", 11483, 2);
            WriteAttributeValue("", 11463, "/Story/Detail/", 11463, 14, true);
#nullable restore
#line 198 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 11477, s.Sid, 11477, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", "\r\n                           title=\"", 11484, "\"", 11527, 1);
#nullable restore
#line 199 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 11520, s.Name, 11520, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 200 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                               Write(s.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </h3>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 205 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 207 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"list list-truyen list-side col-xs-12\">\r\n\r\n            <div class=\"title-list\">\r\n                <h4>Truyện đang hot</h4>\r\n            </div>\r\n\r\n");
#nullable restore
#line 214 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
             for (int i = 0; i < ViewBag.StoryHighestView.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row top-item\">\r\n                    <div class=\"col-xs-12\">\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 12126, "\"", 12152, 3);
            WriteAttributeValue("", 12134, "top-num", 12134, 7, true);
            WriteAttributeValue(" ", 12141, "top-", 12142, 5, true);
#nullable restore
#line 218 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 12146, i+1, 12146, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 218 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"s-title\">\r\n                            <h3>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 12283, "\"", 12336, 2);
            WriteAttributeValue("", 12290, "/Story/Detail/", 12290, 14, true);
#nullable restore
#line 221 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 12304, ViewBag.StoryHighestView[i].Sid, 12304, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", "\r\n                               title=\"", 12337, "\"", 12410, 1);
#nullable restore
#line 222 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
WriteAttributeValue("", 12377, ViewBag.StoryHighestView[i].Name, 12377, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 222 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                                                                    Write(ViewBag.StoryHighestView[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h3>\r\n                        </div>\r\n                        <div>\r\n                            ");
#nullable restore
#line 226 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
                       Write(ViewBag.StoryHighestView[i].View);

#line default
#line hidden
#nullable disable
            WriteLiteral(" lượt xem\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 230 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<BookStory.Models.Chapter>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
