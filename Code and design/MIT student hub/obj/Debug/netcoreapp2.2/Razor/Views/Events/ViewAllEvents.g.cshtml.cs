#pragma checksum "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a2a98c9d4efc1d94d47a210da22bb49ad188dca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_ViewAllEvents), @"mvc.1.0.view", @"/Views/Events/ViewAllEvents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Events/ViewAllEvents.cshtml", typeof(AspNetCore.Views_Events_ViewAllEvents))]
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
#line 1 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\_ViewImports.cshtml"
using MIT_student_hub;

#line default
#line hidden
#line 2 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\_ViewImports.cshtml"
using MIT_student_hub.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a2a98c9d4efc1d94d47a210da22bb49ad188dca", @"/Views/Events/ViewAllEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"881854d38c2d15657c4cb0fd8573d53e4f59c018", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_ViewAllEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MIT_student_hub.Models.UserDataModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
  
    ViewData["Title"] = "ViewAllEvents";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(147, 355, true);
            WriteLiteral(@"
<section>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-10 col-md-offset-2"">

                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h3 class=""panel-title"">All Accomodation Posts</h3>
                    </div>

                </div>
");
            EndContext();
#line 18 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(567, 306, true);
            WriteLiteral(@"                    <div class=""panel panel-default post"">
                        <div class=""panel-body"">
                            <div class=""row"">
                                <div class=""col-sm-2"">
                                    <a class=""post-avatar thumbnail"" href=""profile.html""><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 873, "\"", 894, 1);
#line 24 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
WriteAttributeValue("", 879, item.Userimage, 879, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(895, 21, true);
            WriteLiteral("><div class=\"center\">");
            EndContext();
            BeginContext(917, 11, false);
#line 24 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
                                                                                                                                   Write(item.Userid);

#line default
#line hidden
            EndContext();
            BeginContext(928, 365, true);
            WriteLiteral(@"</div></a>
                                </div>
                                <div class=""col-sm-10"">
                                    <div class=""bubble"">
                                        <div class=""pointer"">
                                            <center style=""padding-bottom:10px;"">
                                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1293, "\"", 1337, 2);
            WriteAttributeValue("", 1299, "data:image/jpeg;base64,", 1299, 23, true);
#line 30 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
WriteAttributeValue("", 1322, item.PostImage, 1322, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1338, 233, true);
            WriteLiteral(" height=\"100%\" width=\"100%\" style=\" display:block;align-items:center;border: 1px solid #ddd;border-radius: 4px;padding: 5px;\">\r\n                                            </center>\r\n                                            <p><b>");
            EndContext();
            BeginContext(1572, 18, false);
#line 32 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
                                             Write(item.MessageString);

#line default
#line hidden
            EndContext();
            BeginContext(1590, 348, true);
            WriteLiteral(@"</b></p>
                                        </div>
                                        <div class=""pointer-border""></div>
                                    </div><!--bubble end -->
                                    <p class=""post-action""><a href=""#"">Comment</a></p>
                                    <div class=""comment-form"">
");
            EndContext();
#line 38 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
                                         using (Html.BeginForm("CommentPost", "Events", FormMethod.Post, new { enctype = "multipart/form-data", @class = "form-inline" }))
                                        {

#line default
#line hidden
            BeginContext(2153, 72, true);
            WriteLiteral("                                            <input name=\"Postid4comment\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2225, "\"", 2257, 2);
            WriteAttributeValue("", 2230, "Postid4comment_", 2230, 15, true);
#line 40 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
WriteAttributeValue("", 2245, item.Postid, 2245, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2258, 14, true);
            WriteLiteral(" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2272, "\"", 2292, 1);
#line 40 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
WriteAttributeValue("", 2280, item.Postid, 2280, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2293, 77, true);
            WriteLiteral(" />\r\n                                            <input name=\"Userid4comment\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2370, "\"", 2402, 2);
            WriteAttributeValue("", 2375, "Userid4comment_", 2375, 15, true);
#line 41 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
WriteAttributeValue("", 2390, item.Postid, 2390, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2403, 14, true);
            WriteLiteral(" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2417, "\"", 2437, 1);
#line 41 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
WriteAttributeValue("", 2425, item.Userid, 2425, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2438, 123, true);
            WriteLiteral(" />\r\n                                            <div class=\"form-group\">\r\n                                                ");
            EndContext();
            BeginContext(2562, 141, false);
#line 43 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
                                           Write(Html.TextBox("commentmessage", null, new { @class = "form-control", @placeholder = "Enter comment", @type = "text", @requried = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(2703, 54, true);
            WriteLiteral("\r\n                                            </div>\r\n");
            EndContext();
            BeginContext(2759, 104, true);
            WriteLiteral("                                            <button type=\"submit\" class=\"btn btn-default\">Add</button>\r\n");
            EndContext();
#line 47 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2906, 194, true);
            WriteLiteral("                                    </div><!--comment form ends-->\r\n                                    <div class=\"clearfix\"></div>\r\n                                    <div class=\"comments\">\r\n");
            EndContext();
#line 51 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
                                         if (item.Comments != null)
                                        {
                                            

#line default
#line hidden
#line 53 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
                                             foreach (var comment in item.Comments)
                                            {

#line default
#line hidden
            BeginContext(3344, 172, true);
            WriteLiteral("                                                <div class=\"comment\">\r\n                                                    <a class=\"comment-avatar pull-left\" href=\"#\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3516, "\"", 3547, 1);
#line 56 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
WriteAttributeValue("", 3522, comment.commentuserimage, 3522, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3548, 146, true);
            WriteLiteral("></a>\r\n                                                    <div class=\"comment-text\">\r\n                                                        <p>");
            EndContext();
            BeginContext(3695, 19, false);
#line 58 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
                                                      Write(comment.commenttext);

#line default
#line hidden
            EndContext();
            BeginContext(3714, 122, true);
            WriteLiteral("</p>\r\n                                                    </div>\r\n                                                </div>\r\n");
            EndContext();
#line 61 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
                                            }

#line default
#line hidden
#line 61 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"
                                             
                                        }

#line default
#line hidden
            BeginContext(3926, 250, true);
            WriteLiteral("                                        <div class=\"clearfix\"></div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 69 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\ViewAllEvents.cshtml"

                }

#line default
#line hidden
            BeginContext(4197, 97, true);
            WriteLiteral("            </div><!-- col-md-8 end -->\r\n\r\n\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MIT_student_hub.Models.UserDataModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
