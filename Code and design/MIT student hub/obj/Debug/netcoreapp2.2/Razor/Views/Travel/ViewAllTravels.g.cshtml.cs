#pragma checksum "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42ff3c55fd32be5f63eb071a86bff5e6d379b18a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Travel_ViewAllTravels), @"mvc.1.0.view", @"/Views/Travel/ViewAllTravels.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Travel/ViewAllTravels.cshtml", typeof(AspNetCore.Views_Travel_ViewAllTravels))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42ff3c55fd32be5f63eb071a86bff5e6d379b18a", @"/Views/Travel/ViewAllTravels.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"881854d38c2d15657c4cb0fd8573d53e4f59c018", @"/Views/_ViewImports.cshtml")]
    public class Views_Travel_ViewAllTravels : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MIT_student_hub.Models.UserDataModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
  
    ViewData["Title"] = "ViewAllTravels";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(148, 349, true);
            WriteLiteral(@"
<section>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-10 col-md-offset-2"">

                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h3 class=""panel-title"">All Travel Posts</h3>
                    </div>

                </div>
");
            EndContext();
#line 18 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(562, 306, true);
            WriteLiteral(@"                    <div class=""panel panel-default post"">
                        <div class=""panel-body"">
                            <div class=""row"">
                                <div class=""col-sm-2"">
                                    <a class=""post-avatar thumbnail"" href=""profile.html""><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 868, "\"", 889, 1);
#line 24 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
WriteAttributeValue("", 874, item.Userimage, 874, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(890, 21, true);
            WriteLiteral("><div class=\"center\">");
            EndContext();
            BeginContext(912, 11, false);
#line 24 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
                                                                                                                                   Write(item.Userid);

#line default
#line hidden
            EndContext();
            BeginContext(923, 365, true);
            WriteLiteral(@"</div></a>
                                </div>
                                <div class=""col-sm-10"">
                                    <div class=""bubble"">
                                        <div class=""pointer"">
                                            <center style=""padding-bottom:10px;"">
                                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1288, "\"", 1332, 2);
            WriteAttributeValue("", 1294, "data:image/jpeg;base64,", 1294, 23, true);
#line 30 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
WriteAttributeValue("", 1317, item.PostImage, 1317, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1333, 233, true);
            WriteLiteral(" height=\"100%\" width=\"100%\" style=\" display:block;align-items:center;border: 1px solid #ddd;border-radius: 4px;padding: 5px;\">\r\n                                            </center>\r\n                                            <p><b>");
            EndContext();
            BeginContext(1567, 18, false);
#line 32 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
                                             Write(item.MessageString);

#line default
#line hidden
            EndContext();
            BeginContext(1585, 348, true);
            WriteLiteral(@"</b></p>
                                        </div>
                                        <div class=""pointer-border""></div>
                                    </div><!--bubble end -->
                                    <p class=""post-action""><a href=""#"">Comment</a></p>
                                    <div class=""comment-form"">
");
            EndContext();
#line 38 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
                                         using (Html.BeginForm("CommentPost", "Job", FormMethod.Post, new { enctype = "multipart/form-data", @class = "form-inline" }))
                                        {

#line default
#line hidden
            BeginContext(2145, 72, true);
            WriteLiteral("                                            <input name=\"Postid4comment\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2217, "\"", 2249, 2);
            WriteAttributeValue("", 2222, "Postid4comment_", 2222, 15, true);
#line 40 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
WriteAttributeValue("", 2237, item.Postid, 2237, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2250, 14, true);
            WriteLiteral(" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2264, "\"", 2284, 1);
#line 40 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
WriteAttributeValue("", 2272, item.Postid, 2272, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2285, 77, true);
            WriteLiteral(" />\r\n                                            <input name=\"Userid4comment\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2362, "\"", 2394, 2);
            WriteAttributeValue("", 2367, "Userid4comment_", 2367, 15, true);
#line 41 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
WriteAttributeValue("", 2382, item.Postid, 2382, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2395, 14, true);
            WriteLiteral(" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2409, "\"", 2429, 1);
#line 41 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
WriteAttributeValue("", 2417, item.Userid, 2417, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2430, 123, true);
            WriteLiteral(" />\r\n                                            <div class=\"form-group\">\r\n                                                ");
            EndContext();
            BeginContext(2554, 141, false);
#line 43 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
                                           Write(Html.TextBox("commentmessage", null, new { @class = "form-control", @placeholder = "Enter comment", @type = "text", @requried = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(2695, 54, true);
            WriteLiteral("\r\n                                            </div>\r\n");
            EndContext();
            BeginContext(2751, 104, true);
            WriteLiteral("                                            <button type=\"submit\" class=\"btn btn-default\">Add</button>\r\n");
            EndContext();
#line 47 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2898, 194, true);
            WriteLiteral("                                    </div><!--comment form ends-->\r\n                                    <div class=\"clearfix\"></div>\r\n                                    <div class=\"comments\">\r\n");
            EndContext();
#line 51 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
                                         if (item.Comments != null)
                                        {
                                            

#line default
#line hidden
#line 53 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
                                             foreach (var comment in item.Comments)
                                            {

#line default
#line hidden
            BeginContext(3336, 172, true);
            WriteLiteral("                                                <div class=\"comment\">\r\n                                                    <a class=\"comment-avatar pull-left\" href=\"#\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3508, "\"", 3539, 1);
#line 56 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
WriteAttributeValue("", 3514, comment.commentuserimage, 3514, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3540, 146, true);
            WriteLiteral("></a>\r\n                                                    <div class=\"comment-text\">\r\n                                                        <p>");
            EndContext();
            BeginContext(3687, 19, false);
#line 58 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
                                                      Write(comment.commenttext);

#line default
#line hidden
            EndContext();
            BeginContext(3706, 122, true);
            WriteLiteral("</p>\r\n                                                    </div>\r\n                                                </div>\r\n");
            EndContext();
#line 61 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
                                            }

#line default
#line hidden
#line 61 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"
                                             
                                        }

#line default
#line hidden
            BeginContext(3918, 250, true);
            WriteLiteral("                                        <div class=\"clearfix\"></div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 69 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Travel\ViewAllTravels.cshtml"

                }

#line default
#line hidden
            BeginContext(4189, 93, true);
            WriteLiteral("            </div><!-- col-md-8 end -->\r\n\r\n\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n\r\n\r\n\r\n");
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