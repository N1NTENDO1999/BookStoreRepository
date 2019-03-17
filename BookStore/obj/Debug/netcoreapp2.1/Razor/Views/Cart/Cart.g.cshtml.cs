#pragma checksum "D:\Git\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af70b20e1070203e07daff9fe01d413e6905312c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Cart), @"mvc.1.0.view", @"/Views/Cart/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Cart.cshtml", typeof(AspNetCore.Views_Cart_Cart))]
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
#line 1 "D:\Git\BookStoreRepository\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#line 2 "D:\Git\BookStoreRepository\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af70b20e1070203e07daff9fe01d413e6905312c", @"/Views/Cart/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CartLine>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Cart/BuyAll/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Books/Index/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Git\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
  
    ViewBag.Title = "BookStore: your cart";

#line default
#line hidden
            BeginContext(75, 357, true);
            WriteLiteral(@"
<h2>Your cart</h2>

    <table  class=""table"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Author</th>
                <th class=""text-left"">Genre</th>
                <th class=""text-left"">Year</th>
                <th class=""text-left"">Quantity</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 19 "D:\Git\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
             foreach (var line in Model)
            {

#line default
#line hidden
            BeginContext(489, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(528, 14, false);
#line 22 "D:\Git\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
               Write(line.Book.Name);

#line default
#line hidden
            EndContext();
            BeginContext(542, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(570, 16, false);
#line 23 "D:\Git\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
               Write(line.Book.Author);

#line default
#line hidden
            EndContext();
            BeginContext(586, 45, true);
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
            EndContext();
            BeginContext(632, 15, false);
#line 24 "D:\Git\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
                                 Write(line.Book.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(647, 45, true);
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
            EndContext();
            BeginContext(693, 14, false);
#line 25 "D:\Git\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
                                 Write(line.Book.Year);

#line default
#line hidden
            EndContext();
            BeginContext(707, 45, true);
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
            EndContext();
            BeginContext(753, 13, false);
#line 26 "D:\Git\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
                                 Write(line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(766, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 28 "D:\Git\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
            }

#line default
#line hidden
            BeginContext(807, 209, true);
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"3\" class=\"text-right\">  ");
            EndContext();
            BeginContext(1016, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efff82b092fe45e28c0832fd4be5591f", async() => {
                BeginContext(1041, 7, true);
                WriteLiteral("Buy all");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1052, 99, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n\r\n    <div class=\"text-center\">\r\n        ");
            EndContext();
            BeginContext(1151, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60ddd3fc929c4f638306e33fd5d65831", async() => {
                BeginContext(1176, 8, true);
                WriteLiteral("Continue");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1188, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CartLine>> Html { get; private set; }
    }
}
#pragma warning restore 1591