#pragma checksum "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66fa0bacf9c03ea510d2ec47ff573d940a981417"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Story_ListSaved), @"mvc.1.0.view", @"/Views/Story/ListSaved.cshtml")]
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
#line 1 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
using BookStory.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66fa0bacf9c03ea510d2ec47ff573d940a981417", @"/Views/Story/ListSaved.cshtml")]
    #nullable restore
    public class Views_Story_ListSaved : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<BookStory.Models.Chapter>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
  
    ViewBag.Title = "List Saved";
    Layout = "_StoryLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"" id=""list-page"">
    <div class=""col-xs-12 col-sm-12 col-md-9 col-truyen-main"">
        <div class=""text-center""></div>
        <div class=""list list-truyen col-xs-12"">
            <div class=""title-list"">
                <h2>Các chương đã lưu</h2>
            </div>
");
#nullable restore
#line 19 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
             if (Model.Count > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
                 foreach (Chapter c in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\" itemscope>\r\n                        <div class=\"col-xs-12\">\r\n                            <div>\r\n                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 862, "\"", 876, 1);
#nullable restore
#line 26 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
WriteAttributeValue("", 870, c.Sid, 870, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"id\" id=\"sid\">\r\n                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 951, "\"", 972, 1);
#nullable restore
#line 27 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
WriteAttributeValue("", 959, c.Chapnumber, 959, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"id1\" id=\"chapnumber\">\r\n                                <button onclick=\"unsavechapter()\" class=\"btn btn-danger\">Bỏ lưu</button>\r\n                                <h3 class=\"truyen-title\" itemprop=\"name\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1222, "\"", 1264, 4);
            WriteAttributeValue("", 1229, "/Story/Content/", 1229, 15, true);
#nullable restore
#line 30 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
WriteAttributeValue("", 1244, c.Sid, 1244, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1250, "/", 1250, 1, true);
#nullable restore
#line 30 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
WriteAttributeValue("", 1251, c.Chapnumber, 1251, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", "\r\n                               title=\"", 1265, "\"", 1312, 1);
#nullable restore
#line 31 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
WriteAttributeValue("", 1305, c.Name, 1305, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" itemprop=\"url\">\r\n                                        ");
#nullable restore
#line 32 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
                                   Write(c.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Chương ");
#nullable restore
#line 32 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
                                                    Write(c.Chapnumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </h3>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 39 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
           Write(Html.PagedListPager(Model, id1 => Url.Action("ListSaved", new { id = ViewBag.CurrentId, id1 })));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
                                                                                                                
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"truyen-title\">Trống</div>\r\n");
#nullable restore
#line 45 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\ListSaved.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
