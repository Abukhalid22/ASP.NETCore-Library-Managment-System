#pragma checksum "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c5b52f25fd432e60e6e360cdf34d8418a74e0b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Detail), @"mvc.1.0.view", @"/Views/Catalog/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Detail.cshtml", typeof(AspNetCore.Views_Catalog_Detail))]
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
#line 1 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
using Library.Web.Models.Catalog;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c5b52f25fd432e60e6e360cdf34d8418a74e0b0", @"/Views/Catalog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9563fb38f882024b1f92469471656110c9ee5850", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Web.Models.Catalog.AssetDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Hold", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkLost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkFound", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
  
    ViewBag.Title = @Model.Title;

#line default
#line hidden
            BeginContext(124, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(142, 603, true);
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.1.1.slim.min.js"" integrity=""sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js"" integrity=""sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js"" integrity=""sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn"" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            BeginContext(747, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(764, 222, true);
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css\" integrity=\"sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ\" crossorigin=\"anonymous\">\n");
                EndContext();
            }
            );
            BeginContext(988, 294, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">View Library Item</h2>
    </div>

    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div>
                    <img class=""detailImage""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1282, "\"", 1303, 1);
#line 26 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
WriteAttributeValue("", 1288, Model.ImageUrl, 1288, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1304, 115, true);
            WriteLiteral(" />\n                </div>\n            </div>\n            <div class=\"col-md-4\">\n                <p id=\"itemTitle\">");
            EndContext();
            BeginContext(1420, 11, false);
#line 30 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                             Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1431, 40, true);
            WriteLiteral("</p>\n                <p id=\"itemAuthor\">");
            EndContext();
            BeginContext(1472, 22, false);
#line 31 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                              Write(Model.AuthorOrDirector);

#line default
#line hidden
            EndContext();
            BeginContext(1494, 40, true);
            WriteLiteral("</p>\n                <p id=\"itemStatus\">");
            EndContext();
            BeginContext(1535, 12, false);
#line 32 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                              Write(Model.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1547, 38, true);
            WriteLiteral("</p>\n                <p id=\"itemType\">");
            EndContext();
            BeginContext(1586, 10, false);
#line 33 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                            Write(Model.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1596, 57, true);
            WriteLiteral("</p>\n                <p id=\"itemLocation\">Last Location: ");
            EndContext();
            BeginContext(1654, 21, false);
#line 34 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                                               Write(Model.CurrentLocation);

#line default
#line hidden
            EndContext();
            BeginContext(1675, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 35 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                 if (Model.Status == "Checked Out")
                {

#line default
#line hidden
            BeginContext(1750, 55, true);
            WriteLiteral("                    <p id=\"itemPatron\">Checked Out By: ");
            EndContext();
            BeginContext(1806, 16, false);
#line 37 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                                                  Write(Model.PatronName);

#line default
#line hidden
            EndContext();
            BeginContext(1822, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 38 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(1845, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 40 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                 if (@Model.Status != "Lost")
                {
                    

#line default
#line hidden
#line 42 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                     if (@Model.Status == "Available")
                    {

#line default
#line hidden
            BeginContext(1987, 27, true);
            WriteLiteral("                        <p>");
            EndContext();
            BeginContext(2014, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8737f53ad84c4867a9caa8ec6a9a97e6", async() => {
                BeginContext(2136, 9, true);
                WriteLiteral("Check Out");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                                                                                                                         WriteLiteral(Model.AssetId);

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
            BeginContext(2149, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 45 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                    }

#line default
#line hidden
#line 47 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                     if (@Model.Status == "Checked Out")
                    {

#line default
#line hidden
            BeginContext(2256, 27, true);
            WriteLiteral("                        <p>");
            EndContext();
            BeginContext(2283, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fffd9d2e0864f0d966219d6ced239f0", async() => {
                BeginContext(2407, 8, true);
                WriteLiteral("Check In");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                                                                                                                           WriteLiteral(Model.AssetId);

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
            BeginContext(2419, 32, true);
            WriteLiteral("</p>\n                        <p>");
            EndContext();
            BeginContext(2451, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4760eda67c0c486e8f1cbb866360514c", async() => {
                BeginContext(2572, 10, true);
                WriteLiteral("Place Hold");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                                                                                                                        WriteLiteral(Model.AssetId);

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
            BeginContext(2586, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 51 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(2614, 23, true);
            WriteLiteral("                    <p>");
            EndContext();
            BeginContext(2637, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07b4d85918664f7ba850713026c7193c", async() => {
                BeginContext(2761, 14, true);
                WriteLiteral("Mark Item Lost");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                                                                                                                       WriteLiteral(Model.AssetId);

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
            BeginContext(2779, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 54 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                }

                else
                {

#line default
#line hidden
            BeginContext(2842, 101, true);
            WriteLiteral("                    <p>This item has been lost. It cannot be checked out.</p>\n                    <p>");
            EndContext();
            BeginContext(2943, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62eb05df8506470995b3d6a1da6e78b5", async() => {
                BeginContext(3069, 15, true);
                WriteLiteral("Mark Item Found");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                                                                                                                         WriteLiteral(Model.AssetId);

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
            BeginContext(3088, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 60 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(3111, 217, true);
            WriteLiteral("\n            </div>\n            <div class=\"col-md-4 detailInfo\">\n                <table>\n                    <tr>\n                       <td class=\"itemLabel\">ISBN: </td>\n                       <td class=\"itemValue\">");
            EndContext();
            BeginContext(3329, 10, false);
#line 67 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                                        Write(Model.Isbn);

#line default
#line hidden
            EndContext();
            BeginContext(3339, 166, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                       <td class=\"itemLabel\">Call Number: </td>\n                       <td class=\"itemValue\">");
            EndContext();
            BeginContext(3506, 11, false);
#line 71 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                                        Write(Model.Dewey);

#line default
#line hidden
            EndContext();
            BeginContext(3517, 172, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                       <td class=\"itemLabel\">Replacement Cost: </td>\n                       <td class=\"itemValue\">$");
            EndContext();
            BeginContext(3690, 10, false);
#line 75 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                                         Write(Model.Cost);

#line default
#line hidden
            EndContext();
            BeginContext(3700, 562, true);
            WriteLiteral(@"</td>
                    </tr>
                </table>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-lg-6"">
            <h4>Checkout History</h4>
            <table class=""table table-bordered table-hover table-condensed"">
                <thead>
                    <tr>
                        <th>Date Loaned</th>
                        <th>Date Returned</th>
                        <th>Card Id</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 95 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                     foreach (var checkout in @Model.CheckoutHistory)
                    {

#line default
#line hidden
            BeginContext(4354, 94, true);
            WriteLiteral("                        <tr>\n                            <td>\n                                ");
            EndContext();
            BeginContext(4449, 19, false);
#line 99 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                           Write(checkout.CheckedOut);

#line default
#line hidden
            EndContext();
            BeginContext(4468, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(4569, 18, false);
#line 102 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                           Write(checkout.CheckedIn);

#line default
#line hidden
            EndContext();
            BeginContext(4587, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(4688, 23, false);
#line 105 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                           Write(checkout.LibraryCard.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4711, 65, true);
            WriteLiteral("\n                            </td>\n                        </tr>\n");
            EndContext();
#line 108 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(4798, 413, true);
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div class=""col-lg-6"">
            <h4>Current Holds</h4>
            <table class=""table table-bordered table-hover table-condensed"">
                <thead>
                    <tr>
                        <th>Hold Placed</th>
                        <th>Patron</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 122 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                     foreach (var hold in @Model.CurrentHolds)
                    {

#line default
#line hidden
            BeginContext(5296, 94, true);
            WriteLiteral("                        <tr>\n                            <td>\n                                ");
            EndContext();
            BeginContext(5391, 15, false);
#line 126 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                           Write(hold.HoldPlaced);

#line default
#line hidden
            EndContext();
            BeginContext(5406, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(5507, 15, false);
#line 129 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                           Write(hold.PatronName);

#line default
#line hidden
            EndContext();
            BeginContext(5522, 65, true);
            WriteLiteral("\n                            </td>\n                        </tr>\n");
            EndContext();
#line 132 "C:\Users\Husse\Downloads\library-management-system-master\ASP.NET Core Library Managment\Library.Web\Views\Catalog\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(5609, 79, true);
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Web.Models.Catalog.AssetDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
