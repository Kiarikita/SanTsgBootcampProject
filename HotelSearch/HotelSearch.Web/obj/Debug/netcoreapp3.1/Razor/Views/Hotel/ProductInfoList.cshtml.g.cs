#pragma checksum "C:\Users\Asus\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\ProductInfoList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef0a5d7dcdaa9facda82613fa6c35adcd457b336"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_ProductInfoList), @"mvc.1.0.view", @"/Views/Hotel/ProductInfoList.cshtml")]
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
#line 1 "C:\Users\Asus\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\_ViewImports.cshtml"
using HotelSearch.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\_ViewImports.cshtml"
using HotelSearch.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef0a5d7dcdaa9facda82613fa6c35adcd457b336", @"/Views/Hotel/ProductInfoList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"113b11eb6e038eaa1d0bb12cd832db1db84d1616", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Hotel_ProductInfoList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelSearch.Web.Models.Response.ProductInfoResponse.Hotel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HotelList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<table class=""mt-4 table table-hover table-bordered table-sm"">
    <thead>
        <tr>
            <td>Görsel</td>
            <td>Seasons</td>
            <td>Adres</td>
            <td>Fax Number</td> 
            <td>Listele</td> 
             
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "C:\Users\Asus\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\ProductInfoList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Asus\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\ProductInfoList.cshtml"
               Write(item.thumbnail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Asus\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\ProductInfoList.cshtml"
               Write(item.seasons);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Asus\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\ProductInfoList.cshtml"
               Write(item.address.addressLines);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Asus\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\ProductInfoList.cshtml"
               Write(item.faxNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                <td class=\"align-middle\">\r\n                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef0a5d7dcdaa9facda82613fa6c35adcd457b3365846", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-square\"></i>Listele ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "C:\Users\Asus\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\ProductInfoList.cshtml"
AddHtmlAttributeValue("", 760, "window.location.href='" + @Url.Action("HotelList", "HotelController") + "'", 760, 79, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 839, ";", 839, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Asus\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\ProductInfoList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelSearch.Web.Models.Response.ProductInfoResponse.Hotel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
