#pragma checksum "C:\Users\D-bugging\source\repos\ExemploMVC-SalesWeb\ExemploMVC_SalesWeb\Views\Sellers\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ea70a20c8319c9cc852e1b5134bc5ca88a13e93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sellers_Delete), @"mvc.1.0.view", @"/Views/Sellers/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sellers/Delete.cshtml", typeof(AspNetCore.Views_Sellers_Delete))]
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
#line 1 "C:\Users\D-bugging\source\repos\ExemploMVC-SalesWeb\ExemploMVC_SalesWeb\Views\_ViewImports.cshtml"
using ExemploMVC_SalesWeb;

#line default
#line hidden
#line 2 "C:\Users\D-bugging\source\repos\ExemploMVC-SalesWeb\ExemploMVC_SalesWeb\Views\_ViewImports.cshtml"
using ExemploMVC_SalesWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ea70a20c8319c9cc852e1b5134bc5ca88a13e93", @"/Views/Sellers/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28105f1cf6c05e83d72fa218834c3630d7da3f2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Sellers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExemploMVC_SalesWeb.Models.Seller>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\D-bugging\source\repos\ExemploMVC-SalesWeb\ExemploMVC_SalesWeb\Views\Sellers\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(87, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(94, 17, false);
#line 7 "C:\Users\D-bugging\source\repos\ExemploMVC-SalesWeb\ExemploMVC_SalesWeb\Views\Sellers\Delete.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(111, 143, true);
            WriteLiteral("</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n\r\n<div>\r\n    <h4>Seller</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>");
            EndContext();
            BeginContext(255, 40, false);
#line 15 "C:\Users\D-bugging\source\repos\ExemploMVC-SalesWeb\ExemploMVC_SalesWeb\Views\Sellers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(295, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(315, 36, false);
#line 16 "C:\Users\D-bugging\source\repos\ExemploMVC-SalesWeb\ExemploMVC_SalesWeb\Views\Sellers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(351, 21, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>");
            EndContext();
            BeginContext(373, 41, false);
#line 18 "C:\Users\D-bugging\source\repos\ExemploMVC-SalesWeb\ExemploMVC_SalesWeb\Views\Sellers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(414, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(434, 37, false);
#line 19 "C:\Users\D-bugging\source\repos\ExemploMVC-SalesWeb\ExemploMVC_SalesWeb\Views\Sellers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(471, 21, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>");
            EndContext();
            BeginContext(493, 45, false);
#line 21 "C:\Users\D-bugging\source\repos\ExemploMVC-SalesWeb\ExemploMVC_SalesWeb\Views\Sellers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(538, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(558, 41, false);
#line 22 "C:\Users\D-bugging\source\repos\ExemploMVC-SalesWeb\ExemploMVC_SalesWeb\Views\Sellers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(599, 21, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>");
            EndContext();
            BeginContext(621, 46, false);
#line 24 "C:\Users\D-bugging\source\repos\ExemploMVC-SalesWeb\ExemploMVC_SalesWeb\Views\Sellers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(667, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(687, 42, false);
#line 25 "C:\Users\D-bugging\source\repos\ExemploMVC-SalesWeb\ExemploMVC_SalesWeb\Views\Sellers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(729, 24, true);
            WriteLiteral("</dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(753, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc741f2ff04a42338a8a5cec4ce08935", async() => {
                BeginContext(779, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(789, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb41c8edb1a147699ccf0764c302adbc", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 29 "C:\Users\D-bugging\source\repos\ExemploMVC-SalesWeb\ExemploMVC_SalesWeb\Views\Sellers\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(825, 81, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n        ");
                EndContext();
                BeginContext(906, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02f55042fef44e93b262527f5a5309a9", async() => {
                    BeginContext(928, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(944, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(957, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExemploMVC_SalesWeb.Models.Seller> Html { get; private set; }
    }
}
#pragma warning restore 1591
