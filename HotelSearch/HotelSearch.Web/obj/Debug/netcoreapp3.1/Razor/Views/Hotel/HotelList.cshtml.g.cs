#pragma checksum "C:\Users\Asus\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\HotelList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6d49a453eebe37a4d54b54debfdb3f9073b6a36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_HotelList), @"mvc.1.0.view", @"/Views/Hotel/HotelList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6d49a453eebe37a4d54b54debfdb3f9073b6a36", @"/Views/Hotel/HotelList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"113b11eb6e038eaa1d0bb12cd832db1db84d1616", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Hotel_HotelList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelSearch.Web.Models.Response.HotelProduct.GetArrivalAutocompleteResponse.Item>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductInfoList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n <h1> Otel Listesi</h1>\r\n<table class=\"mt-4 table table-hover table-bordered table-sm\">\r\n    <thead>\r\n        <tr> \r\n            <td>Şehir</td>\r\n            <td>Otel</td> \r\n            <td>Listele</td> \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\Asus\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\HotelList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\Asus\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\HotelList.cshtml"
               Write(item.city.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                <td>");
#nullable restore
#line 17 "C:\Users\Asus\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\HotelList.cshtml"
               Write(item.hotel.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">\r\n                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6d49a453eebe37a4d54b54debfdb3f9073b6a365167", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-square\"></i>Listele");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "C:\Users\Asus\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\HotelList.cshtml"
AddHtmlAttributeValue("", 641, "window.location.href='" + @Url.Action("ProductInfoList", "HotelController") + "'", 641, 85, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 726, ";", 726, 1, true);
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
#line 22 "C:\Users\Asus\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\HotelList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelSearch.Web.Models.Response.HotelProduct.GetArrivalAutocompleteResponse.Item>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
