#pragma checksum "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ea15e8058fee08362566e687f924785b02f8751"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HoaDons_Delete), @"mvc.1.0.view", @"/Views/HoaDons/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HoaDons/Delete.cshtml", typeof(AspNetCore.Views_HoaDons_Delete))]
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
#line 1 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\_ViewImports.cshtml"
using NETCKTEAM30;

#line default
#line hidden
#line 2 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\_ViewImports.cshtml"
using NETCKTEAM30.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea15e8058fee08362566e687f924785b02f8751", @"/Views/HoaDons/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0613840a446b3e0d199dc06641aec1324a2f2111", @"/Views/_ViewImports.cshtml")]
    public class Views_HoaDons_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NETCKTEAM30.Models.HoaDon>
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(78, 167, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>HoaDon</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(246, 45, false);
#line 15 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NguoiDung));

#line default
#line hidden
            EndContext();
            BeginContext(291, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(335, 53, false);
#line 18 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NguoiDung.NguoiDungID));

#line default
#line hidden
            EndContext();
            BeginContext(388, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(432, 43, false);
#line 21 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NgayDat));

#line default
#line hidden
            EndContext();
            BeginContext(475, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(519, 39, false);
#line 24 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NgayDat));

#line default
#line hidden
            EndContext();
            BeginContext(558, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(602, 44, false);
#line 27 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NgayNhan));

#line default
#line hidden
            EndContext();
            BeginContext(646, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(690, 40, false);
#line 30 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NgayNhan));

#line default
#line hidden
            EndContext();
            BeginContext(730, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(774, 41, false);
#line 33 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(815, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(859, 37, false);
#line 36 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(896, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(940, 42, false);
#line 39 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(982, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1026, 38, false);
#line 42 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1108, 45, false);
#line 45 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ThanhToan));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1197, 53, false);
#line 48 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ThanhToan.ThanhToanID));

#line default
#line hidden
            EndContext();
            BeginContext(1250, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1294, 45, false);
#line 51 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VanChuyen));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1383, 53, false);
#line 54 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VanChuyen.VanChuyenID));

#line default
#line hidden
            EndContext();
            BeginContext(1436, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1480, 48, false);
#line 57 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhiVanChuyen));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1572, 44, false);
#line 60 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhiVanChuyen));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1660, 45, false);
#line 63 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TrangThai));

#line default
#line hidden
            EndContext();
            BeginContext(1705, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1749, 53, false);
#line 66 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TrangThai.TrangThaiID));

#line default
#line hidden
            EndContext();
            BeginContext(1802, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1846, 42, false);
#line 69 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GhiChu));

#line default
#line hidden
            EndContext();
            BeginContext(1888, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1932, 38, false);
#line 72 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GhiChu));

#line default
#line hidden
            EndContext();
            BeginContext(1970, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2008, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cdd57ace6aa4baf92e0575c7190f1eb", async() => {
                BeginContext(2034, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2044, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e3ea55ad83947b9802e4bf6c04a4eec", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "C:\Users\Mcuong.FIT\Desktop\NETCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HoaDonID);

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
                BeginContext(2086, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2170, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69f7169538594e969f4550fd853521f6", async() => {
                    BeginContext(2192, 12, true);
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
                BeginContext(2208, 6, true);
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
            BeginContext(2221, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NETCKTEAM30.Models.HoaDon> Html { get; private set; }
    }
}
#pragma warning restore 1591