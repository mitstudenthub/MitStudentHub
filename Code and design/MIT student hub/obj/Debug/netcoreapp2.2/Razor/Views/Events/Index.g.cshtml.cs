#pragma checksum "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2171221e77909287a447ecc12c81601ff5e2ee09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Index), @"mvc.1.0.view", @"/Views/Events/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Events/Index.cshtml", typeof(AspNetCore.Views_Events_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2171221e77909287a447ecc12c81601ff5e2ee09", @"/Views/Events/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"881854d38c2d15657c4cb0fd8573d53e4f59c018", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MIT_student_hub.Models.UserDataModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 367, true);
            WriteLiteral(@"
<section>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">

                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h3 class=""panel-title"">Add New Events and Happenings</h3>
                    </div>
                    <div class=""panel-body"">

");
            EndContext();
#line 18 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
                         using (Html.BeginForm("PostForm", "Events", FormMethod.Post, new { enctype = "multipart/form-data" }))
                        {

#line default
#line hidden
            BeginContext(662, 403, true);
            WriteLiteral(@"                            <div class=""form-group"">
                                <center style=""padding-bottom:10px;"">
                                    <img alt=""Smiley face"" id=""img_event_post"" height=""25%"" width=""25%"" style="" display:none;align-items:center;border: 1px solid #ddd;border-radius: 4px;padding: 5px;"">
                                </center>
                                ");
            EndContext();
            BeginContext(1066, 127, false);
#line 24 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
                           Write(Html.TextArea("PostMessage", null, new { @class = "form-control", @placeholder = "Write on the wall", @requried = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 40, true);
            WriteLiteral("\r\n\r\n                            </div>\r\n");
            EndContext();
            BeginContext(1235, 978, true);
            WriteLiteral(@"                            <input class=""btn btn-default"" value=""Submit"" id=""btn_event_post"" style=""border-color:#ccc;color:#fff;font-family: Arial, Helvetica, sans-serif;background-image:linear-gradient(#dd112a, #930b1c 60%, #4f060f);font-size: 14px;"" />
                            <input type=""submit"" id=""btn_submitform_event"" style=""display:none"" />
                            <div class=""pull-right"">
                                <div class=""btn-group"">
                                    <input name=""Imagebase64"" id=""Imagebase64"" type=""hidden"" />
                                    <input type=""file"" name=""ImageFile"" style=""display:none;"" id=""input_upload_img_event_post"" />
                                    <button type=""button"" class=""btn btn-default"" id=""btn_imgupload_event_post"" onclick=""EventHandleBrowseClick();""><i class=""fa fa-picture-o""></i> Attach Image</button>

                                </div>
                            </div>
");
            EndContext();
#line 38 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2240, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 42 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2359, 306, true);
            WriteLiteral(@"                    <div class=""panel panel-default post"">
                        <div class=""panel-body"">
                            <div class=""row"">
                                <div class=""col-sm-2"">
                                    <a class=""post-avatar thumbnail"" href=""profile.html""><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2665, "\"", 2686, 1);
#line 48 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
WriteAttributeValue("", 2671, item.Userimage, 2671, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2687, 21, true);
            WriteLiteral("><div class=\"center\">");
            EndContext();
            BeginContext(2709, 11, false);
#line 48 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
                                                                                                                                   Write(item.Userid);

#line default
#line hidden
            EndContext();
            BeginContext(2720, 365, true);
            WriteLiteral(@"</div></a>
                                </div>
                                <div class=""col-sm-10"">
                                    <div class=""bubble"">
                                        <div class=""pointer"">
                                            <center style=""padding-bottom:10px;"">
                                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3085, "\"", 3129, 2);
            WriteAttributeValue("", 3091, "data:image/jpeg;base64,", 3091, 23, true);
#line 54 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
WriteAttributeValue("", 3114, item.PostImage, 3114, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3130, 233, true);
            WriteLiteral(" height=\"100%\" width=\"100%\" style=\" display:block;align-items:center;border: 1px solid #ddd;border-radius: 4px;padding: 5px;\">\r\n                                            </center>\r\n                                            <p><b>");
            EndContext();
            BeginContext(3364, 18, false);
#line 56 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
                                             Write(item.MessageString);

#line default
#line hidden
            EndContext();
            BeginContext(3382, 348, true);
            WriteLiteral(@"</b></p>
                                        </div>
                                        <div class=""pointer-border""></div>
                                    </div><!--bubble end -->
                                    <p class=""post-action""><a href=""#"">Comment</a></p>
                                    <div class=""comment-form"">
");
            EndContext();
#line 62 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
                                         using (Html.BeginForm("CommentPost", "Events", FormMethod.Post, new { enctype = "multipart/form-data", @class = "form-inline" }))
                                        {

#line default
#line hidden
            BeginContext(3945, 72, true);
            WriteLiteral("                                            <input name=\"Postid4comment\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4017, "\"", 4049, 2);
            WriteAttributeValue("", 4022, "Postid4comment_", 4022, 15, true);
#line 64 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
WriteAttributeValue("", 4037, item.Postid, 4037, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4050, 14, true);
            WriteLiteral(" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4064, "\"", 4084, 1);
#line 64 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
WriteAttributeValue("", 4072, item.Postid, 4072, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4085, 77, true);
            WriteLiteral(" />\r\n                                            <input name=\"Userid4comment\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4162, "\"", 4194, 2);
            WriteAttributeValue("", 4167, "Userid4comment_", 4167, 15, true);
#line 65 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
WriteAttributeValue("", 4182, item.Postid, 4182, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4195, 14, true);
            WriteLiteral(" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4209, "\"", 4229, 1);
#line 65 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
WriteAttributeValue("", 4217, item.Userid, 4217, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4230, 123, true);
            WriteLiteral(" />\r\n                                            <div class=\"form-group\">\r\n                                                ");
            EndContext();
            BeginContext(4354, 141, false);
#line 67 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
                                           Write(Html.TextBox("commentmessage", null, new { @class = "form-control", @placeholder = "Enter comment", @type = "text", @requried = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(4495, 54, true);
            WriteLiteral("\r\n                                            </div>\r\n");
            EndContext();
            BeginContext(4551, 104, true);
            WriteLiteral("                                            <button type=\"submit\" class=\"btn btn-default\">Add</button>\r\n");
            EndContext();
#line 71 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4698, 194, true);
            WriteLiteral("                                    </div><!--comment form ends-->\r\n                                    <div class=\"clearfix\"></div>\r\n                                    <div class=\"comments\">\r\n");
            EndContext();
#line 75 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
                                         if (item.Comments != null)
                                        {
                                            

#line default
#line hidden
#line 77 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
                                             foreach (var comment in item.Comments)
                                            {

#line default
#line hidden
            BeginContext(5136, 172, true);
            WriteLiteral("                                                <div class=\"comment\">\r\n                                                    <a class=\"comment-avatar pull-left\" href=\"#\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5308, "\"", 5339, 1);
#line 80 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
WriteAttributeValue("", 5314, comment.commentuserimage, 5314, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5340, 146, true);
            WriteLiteral("></a>\r\n                                                    <div class=\"comment-text\">\r\n                                                        <p>");
            EndContext();
            BeginContext(5487, 19, false);
#line 82 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
                                                      Write(comment.commenttext);

#line default
#line hidden
            EndContext();
            BeginContext(5506, 122, true);
            WriteLiteral("</p>\r\n                                                    </div>\r\n                                                </div>\r\n");
            EndContext();
#line 85 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
                                            }

#line default
#line hidden
#line 85 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
                                             
                                        }

#line default
#line hidden
            BeginContext(5718, 250, true);
            WriteLiteral("                                        <div class=\"clearfix\"></div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 93 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"

                }

#line default
#line hidden
            BeginContext(5989, 409, true);
            WriteLiteral(@"            </div><!-- col-md-8 end -->
            <div class=""col-md-4"">
                <div class=""panel panel-default groups"">
                    <div class=""panel-heading"">
                        <h3 class=""panel-title"">Latest Updates</h3>
                    </div>
                    <div class=""panel-body"">
                        <div class=""group-item"">
                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 6398, "", 6447, 1);
#line 103 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
WriteAttributeValue("", 6403, Url.Content("~/assets/Home/img/events.png"), 6403, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6447, 113, true);
            WriteLiteral(">\r\n                            <h4><a href=\"#\">Events and Happenings</a></h4>\r\n                            <p><b>");
            EndContext();
            BeginContext(6561, 24, false);
#line 105 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
                             Write(ViewData["AllEventlist"]);

#line default
#line hidden
            EndContext();
            BeginContext(6585, 218, true);
            WriteLiteral("</b></p>\r\n                        </div>\r\n                        <div class=\"clearfix\"></div>\r\n                        <a class=\"btn btn-primary\" style=\"background-image:linear-gradient(#dd112a, #930b1c 60%, #4f060f)\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6803, "\"", 6847, 1);
#line 108 "D:\Hot Topics\MIT Student Hub\MIT student hub\Views\Events\Index.cshtml"
WriteAttributeValue("", 6810, Url.Action("ViewAllEvents","Events"), 6810, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6848, 140, true);
            WriteLiteral(">View All Events</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n\r\n");
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
