#pragma checksum "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87e92711adf331272fff0052bf8a0d89169b1c09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Checkout), @"mvc.1.0.view", @"/Views/Catalog/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Checkout.cshtml", typeof(AspNetCore.Views_Catalog_Checkout))]
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
#line 1 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#line 1 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Checkout.cshtml"
using Library.Web.Models.CheckoutModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e92711adf331272fff0052bf8a0d89169b1c09", @"/Views/Catalog/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9563fb38f882024b1f92469471656110c9ee5850", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Web.Models.CheckoutModels.CheckoutModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Checkout.cshtml"
  
    ViewBag.Title = @Model.Title;

#line default
#line hidden
            BeginContext(135, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(170, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(188, 603, true);
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.1.1.slim.min.js"" integrity=""sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js"" integrity=""sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js"" integrity=""sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn"" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            BeginContext(793, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(810, 222, true);
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css\" integrity=\"sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ\" crossorigin=\"anonymous\">\n");
                EndContext();
            }
            );
            BeginContext(1034, 292, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">Checkout Library Item</h2>
    </div>

    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-3"">
                <div>
                    <p id=""itemTitle"">");
            EndContext();
            BeginContext(1327, 11, false);
#line 28 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Checkout.cshtml"
                                 Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1338, 49, true);
            WriteLiteral("</p>\n                    <img class=\"detailImage\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1387, "\"", 1408, 1);
#line 29 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Checkout.cshtml"
WriteAttributeValue("", 1393, Model.ImageUrl, 1393, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1409, 46, true);
            WriteLiteral(" />\n                </div>\n            </div>\n");
            EndContext();
            BeginContext(1503, 35, true);
            WriteLiteral("            <div class=\"col-md-9\">\n");
            EndContext();
#line 35 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Checkout.cshtml"
                 using (Html.BeginForm("PlaceCheckout", "Catalog", FormMethod.Post))
                {
                    

#line default
#line hidden
            BeginContext(1756, 28, false);
#line 37 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Checkout.cshtml"
               Write(Html.HiddenFor(a=>a.AssetId));

#line default
#line hidden
            EndContext();
            BeginContext(1785, 107, true);
            WriteLiteral("                    <div>\n                        Please insert a Library Card ID.\n                        ");
            EndContext();
            BeginContext(1893, 36, false);
#line 40 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Checkout.cshtml"
                   Write(Html.TextBoxFor(a=> a.LibraryCardId));

#line default
#line hidden
            EndContext();
            BeginContext(1929, 2, true);
            WriteLiteral(" \n");
            EndContext();
            BeginContext(2030, 176, true);
            WriteLiteral("                    </div>\n                    <div>\n                        <button type=\"submit\" class=\"btn btn-success btn-lg\">Check out</button>\n                    </div>\n");
            EndContext();
#line 46 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Checkout.cshtml"
                }

#line default
#line hidden
            BeginContext(2224, 52, true);
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Web.Models.CheckoutModels.CheckoutModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
