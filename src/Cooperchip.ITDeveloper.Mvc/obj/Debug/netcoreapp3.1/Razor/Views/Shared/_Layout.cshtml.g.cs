#pragma checksum "C:\Users\hugo\Desktop\NetCore\Zero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1be68430251973741f14efac09a138d964dedd3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\hugo\Desktop\NetCore\Zero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hugo\Desktop\NetCore\Zero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1be68430251973741f14efac09a138d964dedd3d", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b3e663f05881c1a02705e8d4fa32659c73b82bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hugo\Desktop\NetCore\Zero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("PartialViews/_layout_original"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!doctype html>\r\n<!--[if lt IE 8]><html class=\"no-js lt-ie8\"> <![endif]-->\r\n<html class=\"no-js\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\hugo\Desktop\NetCore\Zero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("PartialViews/_head"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1be68430251973741f14efac09a138d964dedd3d3872", async() => {
                WriteLiteral(@"
    <!--[if lt IE 9]>
      <p class=""browsehappy"">You are using an <strong>outdated</strong> browser. Please <a href=""http://browsehappy.com/"">upgrade your browser</a> to improve your experience.</p>
    <![endif]-->
    <!-- .page-navbar -->
    <div id=""header"" class=""page-navbar"">
        <!-- .navbar-brand -->
        <a href=""index.html"" class=""navbar-brand hidden-xs hidden-sm"">
            <img src=""img/logo.png"" class=""logo hidden-xs"" alt=""Dynamic logo"">
            <img src=""img/logosm.png"" class=""logo-sm hidden-lg hidden-md"" alt=""Dynamic logo"">
        </a>
        <!-- / navbar-brand -->
        <!-- .no-collapse -->
        <div id=""navbar-no-collapse"" class=""navbar-no-collapse"">
            <!-- top left nav -->
            ");
#nullable restore
#line 25 "C:\Users\hugo\Desktop\NetCore\Zero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
       Write(await Html.PartialAsync("PartialViews/_nav_top_left"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <!-- / top left nav -->\r\n            <!-- top right nav -->\r\n            ");
#nullable restore
#line 28 "C:\Users\hugo\Desktop\NetCore\Zero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
       Write(await Html.PartialAsync("PartialViews/_nav_top_right"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <!-- / top right nav -->\r\n        </div>\r\n        <!-- / collapse -->\r\n    </div>\r\n    <!-- / page-navbar -->\r\n    <!-- #wrapper -->\r\n    <div id=\"wrapper\">\r\n\r\n        ");
#nullable restore
#line 37 "C:\Users\hugo\Desktop\NetCore\Zero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("PartialViews/_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <!-- .page-content -->
        <div class=""page-content sidebar-page right-sidebar-page clearfix"">
            <!-- .page-content-wrapper -->
            <div class=""page-content-wrapper"">
                <div class=""page-content-inner"">
                    
                    ");
#nullable restore
#line 45 "C:\Users\hugo\Desktop\NetCore\Zero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
               Write(await Html.PartialAsync("PartialViews/_sub_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    ");
#nullable restore
#line 47 "C:\Users\hugo\Desktop\NetCore\Zero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n\r\n                </div>\r\n                <!-- / .page-content-inner -->\r\n            </div>\r\n            <!-- / page-content-wrapper -->\r\n        </div>\r\n        <!-- / page-content -->\r\n\r\n    </div>\r\n    <!-- / #wrapper -->\r\n\r\n\r\n    ");
#nullable restore
#line 60 "C:\Users\hugo\Desktop\NetCore\Zero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("PartialViews/_footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- Back to top -->\r\n    <div id=\"back-to-top\">\r\n        <a href=\"#\">Back to Top</a>\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 67 "C:\Users\hugo\Desktop\NetCore\Zero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("PartialViews/_scripts"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
