#pragma checksum "E:\.net_framework\Raj.net_work\Assignments\Module 4\Module4ass\Module4Que22\Views\Default\ViewState.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5773bc84381090efc3d9095ed39c65b4caf2e0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_ViewState), @"mvc.1.0.view", @"/Views/Default/ViewState.cshtml")]
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
#line 1 "E:\.net_framework\Raj.net_work\Assignments\Module 4\Module4ass\Module4Que22\Views\_ViewImports.cshtml"
using Module4Que22;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.net_framework\Raj.net_work\Assignments\Module 4\Module4ass\Module4Que22\Views\_ViewImports.cshtml"
using Module4Que22.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5773bc84381090efc3d9095ed39c65b4caf2e0b", @"/Views/Default/ViewState.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64d8c73a58112b59d667f652641ab244fa4cf112", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_ViewState : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Module4Que22.CountryDb.StateTable>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddState", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\.net_framework\Raj.net_work\Assignments\Module 4\Module4ass\Module4Que22\Views\Default\ViewState.cshtml"
  
    ViewData["Title"] = "ViewState";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewState</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5773bc84381090efc3d9095ed39c65b4caf2e0b3809", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "E:\.net_framework\Raj.net_work\Assignments\Module 4\Module4ass\Module4Que22\Views\Default\ViewState.cshtml"
           Write(Html.DisplayNameFor(model => model.StateId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "E:\.net_framework\Raj.net_work\Assignments\Module 4\Module4ass\Module4Que22\Views\Default\ViewState.cshtml"
           Write(Html.DisplayNameFor(model => model.StateName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "E:\.net_framework\Raj.net_work\Assignments\Module 4\Module4ass\Module4Que22\Views\Default\ViewState.cshtml"
           Write(Html.DisplayNameFor(model => model.CountryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "E:\.net_framework\Raj.net_work\Assignments\Module 4\Module4ass\Module4Que22\Views\Default\ViewState.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "E:\.net_framework\Raj.net_work\Assignments\Module 4\Module4ass\Module4Que22\Views\Default\ViewState.cshtml"
           Write(Html.DisplayFor(modelItem => item.StateId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "E:\.net_framework\Raj.net_work\Assignments\Module 4\Module4ass\Module4Que22\Views\Default\ViewState.cshtml"
           Write(Html.DisplayFor(modelItem => item.StateName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "E:\.net_framework\Raj.net_work\Assignments\Module 4\Module4ass\Module4Que22\Views\Default\ViewState.cshtml"
           Write(Html.DisplayFor(modelItem => item.CountryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "E:\.net_framework\Raj.net_work\Assignments\Module 4\Module4ass\Module4Que22\Views\Default\ViewState.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 41 "E:\.net_framework\Raj.net_work\Assignments\Module 4\Module4ass\Module4Que22\Views\Default\ViewState.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 42 "E:\.net_framework\Raj.net_work\Assignments\Module 4\Module4ass\Module4Que22\Views\Default\ViewState.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "E:\.net_framework\Raj.net_work\Assignments\Module 4\Module4ass\Module4Que22\Views\Default\ViewState.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Module4Que22.CountryDb.StateTable>> Html { get; private set; }
    }
}
#pragma warning restore 1591
