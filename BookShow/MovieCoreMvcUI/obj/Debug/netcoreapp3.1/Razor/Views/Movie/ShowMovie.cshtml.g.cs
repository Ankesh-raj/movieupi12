#pragma checksum "C:\Users\ankesh.raj\Desktop\Evening-main\BookShow\MovieCoreMvcUI\Views\Movie\ShowMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90eb1a8bbde9f912ecc99c6515086f4c34c7e2e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_ShowMovie), @"mvc.1.0.view", @"/Views/Movie/ShowMovie.cshtml")]
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
#line 1 "C:\Users\ankesh.raj\Desktop\Evening-main\BookShow\MovieCoreMvcUI\Views\_ViewImports.cshtml"
using MovieCoreMvcUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankesh.raj\Desktop\Evening-main\BookShow\MovieCoreMvcUI\Views\_ViewImports.cshtml"
using MovieCoreMvcUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90eb1a8bbde9f912ecc99c6515086f4c34c7e2e2", @"/Views/Movie/ShowMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3b992a324c06f956b856bf0c5d27af3b208b773", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movie_ShowMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MovieEntry", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ankesh.raj\Desktop\Evening-main\BookShow\MovieCoreMvcUI\Views\Movie\ShowMovie.cshtml"
  
    ViewData["Title"] = "ShowMovie";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ShowMovie</h1>\r\n\r\n\r\n\r\n<div>\r\n    <hr />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90eb1a8bbde9f912ecc99c6515086f4c34c7e2e24094", async() => {
                WriteLiteral("Movie Entry");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <hr />\r\n    \r\n\r\n\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 19 "C:\Users\ankesh.raj\Desktop\Evening-main\BookShow\MovieCoreMvcUI\Views\Movie\ShowMovie.cshtml"
        foreach (var movie in Model)
      {
        string imageBase64Data =
        Convert.ToBase64String(movie.ImgPoster);
        string imageDataURL =
        string.Format("data:image/jpg;base64,{0}",
        imageBase64Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 504, "\"", 510, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 30 "C:\Users\ankesh.raj\Desktop\Evening-main\BookShow\MovieCoreMvcUI\Views\Movie\ShowMovie.cshtml"
                                      Write(movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5 class=\"card-text\">");
#nullable restore
#line 31 "C:\Users\ankesh.raj\Desktop\Evening-main\BookShow\MovieCoreMvcUI\Views\Movie\ShowMovie.cshtml"
                                     Write(movie.MovieType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 32 "C:\Users\ankesh.raj\Desktop\Evening-main\BookShow\MovieCoreMvcUI\Views\Movie\ShowMovie.cshtml"
                                    Write(movie.MovieDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 38 "C:\Users\ankesh.raj\Desktop\Evening-main\BookShow\MovieCoreMvcUI\Views\Movie\ShowMovie.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>

</div>
<div class=""row"">
    <div class=""col-12"">

        <h1 style=""text-align:center; color:aquamarine"">Movie</h1>
        <hr />
        <table class=""table table-light table-bordered table-hover"">
            <thead>
                <tr>
                    <th>Movie Id</th>
                    <th>Movie Name</th>
                    <th>Movie Desc</th>
                    <th>Movie Type</th>
                    <th>Movie Poster</th>
                    <th>Edit</th>
                    <th>Delete</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 61 "C:\Users\ankesh.raj\Desktop\Evening-main\BookShow\MovieCoreMvcUI\Views\Movie\ShowMovie.cshtml"
                 foreach (var movie in Model)
                {
                    string imageBase64Data =
                    Convert.ToBase64String(movie.ImgPoster);
                    string imageDataURL =
                    string.Format("data:image/jpg;base64,{0}",
                    imageBase64Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 69 "C:\Users\ankesh.raj\Desktop\Evening-main\BookShow\MovieCoreMvcUI\Views\Movie\ShowMovie.cshtml"
                       Write(movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 70 "C:\Users\ankesh.raj\Desktop\Evening-main\BookShow\MovieCoreMvcUI\Views\Movie\ShowMovie.cshtml"
                       Write(movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 71 "C:\Users\ankesh.raj\Desktop\Evening-main\BookShow\MovieCoreMvcUI\Views\Movie\ShowMovie.cshtml"
                       Write(movie.MovieDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 72 "C:\Users\ankesh.raj\Desktop\Evening-main\BookShow\MovieCoreMvcUI\Views\Movie\ShowMovie.cshtml"
                       Write(movie.MovieType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><img height=\"50\" width=\"50\"");
            BeginWriteAttribute("src", " src=\"", 2110, "\"", 2129, 1);
#nullable restore
#line 73 "C:\Users\ankesh.raj\Desktop\Evening-main\BookShow\MovieCoreMvcUI\Views\Movie\ShowMovie.cshtml"
WriteAttributeValue("", 2116, imageDataURL, 2116, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n\r\n\r\n");
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 86 "C:\Users\ankesh.raj\Desktop\Evening-main\BookShow\MovieCoreMvcUI\Views\Movie\ShowMovie.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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