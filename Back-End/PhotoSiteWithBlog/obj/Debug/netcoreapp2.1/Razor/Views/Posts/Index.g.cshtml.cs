#pragma checksum "C:\Users\ivoik\Desktop\Web project\Back-And\PhotoSiteWithBlog\PhotoSiteWithBlog\Views\Posts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3dcd0d43245b98aaf1d5ffe30bdbbb9a80347d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Index), @"mvc.1.0.view", @"/Views/Posts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Posts/Index.cshtml", typeof(AspNetCore.Views_Posts_Index))]
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
#line 1 "C:\Users\ivoik\Desktop\Web project\Back-And\PhotoSiteWithBlog\PhotoSiteWithBlog\Views\_ViewImports.cshtml"
using PhotoSiteWithBlog;

#line default
#line hidden
#line 2 "C:\Users\ivoik\Desktop\Web project\Back-And\PhotoSiteWithBlog\PhotoSiteWithBlog\Views\_ViewImports.cshtml"
using PhotoSiteWithBlog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3dcd0d43245b98aaf1d5ffe30bdbbb9a80347d5", @"/Views/Posts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e989e5573ff6ca90d4261a1cc02833d118582809", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PhotoSiteWithBlog.Data.Models.Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ivoik\Desktop\Web project\Back-And\PhotoSiteWithBlog\PhotoSiteWithBlog\Views\Posts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(99, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(128, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc26442ab897404fad935a047a9bb972", async() => {
                BeginContext(151, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(165, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(258, 41, false);
#line 16 "C:\Users\ivoik\Desktop\Web project\Back-And\PhotoSiteWithBlog\PhotoSiteWithBlog\Views\Posts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(299, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(355, 52, false);
#line 19 "C:\Users\ivoik\Desktop\Web project\Back-And\PhotoSiteWithBlog\PhotoSiteWithBlog\Views\Posts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ShortDescription));

#line default
#line hidden
            EndContext();
            BeginContext(407, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(463, 43, false);
#line 22 "C:\Users\ivoik\Desktop\Web project\Back-And\PhotoSiteWithBlog\PhotoSiteWithBlog\Views\Posts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(506, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 27 "C:\Users\ivoik\Desktop\Web project\Back-And\PhotoSiteWithBlog\PhotoSiteWithBlog\Views\Posts\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(601, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(650, 40, false);
#line 30 "C:\Users\ivoik\Desktop\Web project\Back-And\PhotoSiteWithBlog\PhotoSiteWithBlog\Views\Posts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(690, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(746, 51, false);
#line 33 "C:\Users\ivoik\Desktop\Web project\Back-And\PhotoSiteWithBlog\PhotoSiteWithBlog\Views\Posts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShortDescription));

#line default
#line hidden
            EndContext();
            BeginContext(797, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(853, 42, false);
#line 36 "C:\Users\ivoik\Desktop\Web project\Back-And\PhotoSiteWithBlog\PhotoSiteWithBlog\Views\Posts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
            EndContext();
            BeginContext(895, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(951, 48, false);
#line 39 "C:\Users\ivoik\Desktop\Web project\Back-And\PhotoSiteWithBlog\PhotoSiteWithBlog\Views\Posts\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(999, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1020, 54, false);
#line 40 "C:\Users\ivoik\Desktop\Web project\Back-And\PhotoSiteWithBlog\PhotoSiteWithBlog\Views\Posts\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1074, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1095, 52, false);
#line 41 "C:\Users\ivoik\Desktop\Web project\Back-And\PhotoSiteWithBlog\PhotoSiteWithBlog\Views\Posts\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 44 "C:\Users\ivoik\Desktop\Web project\Back-And\PhotoSiteWithBlog\PhotoSiteWithBlog\Views\Posts\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1186, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PhotoSiteWithBlog.Data.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
