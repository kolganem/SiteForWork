#pragma checksum "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e589a2a135cef86f05325a57f0e41ccfe59008f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Devices_Index), @"mvc.1.0.view", @"/Views/Devices/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Devices/Index.cshtml", typeof(AspNetCore.Views_Devices_Index))]
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
#line 1 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\_ViewImports.cshtml"
using MyDiplom;

#line default
#line hidden
#line 2 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\_ViewImports.cshtml"
using MyDiplom.Models;

#line default
#line hidden
#line 4 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e589a2a135cef86f05325a57f0e41ccfe59008f", @"/Views/Devices/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38c111333518eaa1b8ff8a5ce98a3aecdd7a8bd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Devices_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyDiplom.Models.Device>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-light bg-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Devices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowFailures", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFailure", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(87, 98, true);
            WriteLiteral("\r\n<h1>Info about devices</h1>\r\n<table>\r\n    <tr>      \r\n        <td class=\"leftcol\">\r\n            ");
            EndContext();
            BeginContext(185, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e589a2a135cef86f05325a57f0e41ccfe59008f5334", async() => {
                BeginContext(249, 70, true);
                WriteLiteral("\r\n                <span class=\"fa fa-plus fa-2x\"></span>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            BeginContext(323, 402, true);
            WriteLiteral(@"
        </td>
        <td class=""spacer""></td>
        <td class=""rightcol"">
            <div class=""text text-center text-dark"">
                <text>
                    Add device
                </text>
            </div>
        </td>
        
    </tr>
</table> 

<table class=""table table-hover"" >
    <thead class=""thead-dark"">
        <tr>
            <th>
                ");
            EndContext();
            BeginContext(726, 41, false);
#line 31 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Stand));

#line default
#line hidden
            EndContext();
            BeginContext(767, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(823, 48, false);
#line 34 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlaceOnStand));

#line default
#line hidden
            EndContext();
            BeginContext(871, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(927, 46, false);
#line 37 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.typeDevice));

#line default
#line hidden
            EndContext();
            BeginContext(973, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1029, 48, false);
#line 40 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumberDevice));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1133, 46, false);
#line 43 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.YearDevice));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1235, 45, false);
#line 46 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateCheck));

#line default
#line hidden
            EndContext();
            BeginContext(1280, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1336, 51, false);
#line 49 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateFutureCheck));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 55 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1522, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1583, 40, false);
#line 59 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Stand));

#line default
#line hidden
            EndContext();
            BeginContext(1623, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1691, 47, false);
#line 62 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PlaceOnStand));

#line default
#line hidden
            EndContext();
            BeginContext(1738, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1806, 45, false);
#line 65 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.typeDevice));

#line default
#line hidden
            EndContext();
            BeginContext(1851, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1919, 47, false);
#line 68 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumberDevice));

#line default
#line hidden
            EndContext();
            BeginContext(1966, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2034, 45, false);
#line 71 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.YearDevice));

#line default
#line hidden
            EndContext();
            BeginContext(2079, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2147, 44, false);
#line 74 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateCheck));

#line default
#line hidden
            EndContext();
            BeginContext(2191, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2259, 50, false);
#line 77 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateFutureCheck));

#line default
#line hidden
            EndContext();
            BeginContext(2309, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
            BeginContext(2684, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2704, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e589a2a135cef86f05325a57f0e41ccfe59008f13786", async() => {
                BeginContext(2782, 6, true);
                WriteLiteral("Отказы");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
                                                                            WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2792, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2816, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e589a2a135cef86f05325a57f0e41ccfe59008f16382", async() => {
                BeginContext(2892, 14, true);
                WriteLiteral("Добавить отказ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2910, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 87 "D:\Learning\BGUIR\MyDiplom\For send\MyDiplom\MyDiplom\Views\Devices\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2965, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyDiplom.Models.Device>> Html { get; private set; }
    }
}
#pragma warning restore 1591
