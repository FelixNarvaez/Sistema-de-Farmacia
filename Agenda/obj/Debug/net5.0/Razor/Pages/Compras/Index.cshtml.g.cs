#pragma checksum "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fea4a7e8f77076d660e028a45243bb079646c9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Farmacia.Pages.Compras.Pages_Compras_Index), @"mvc.1.0.razor-page", @"/Pages/Compras/Index.cshtml")]
namespace Farmacia.Pages.Compras
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
#line 1 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\_ViewImports.cshtml"
using Farmacia;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fea4a7e8f77076d660e028a45243bb079646c9d", @"/Pages/Compras/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e8e87c29709650926ddf13edb979bf9c6cbef46", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Compras_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Compras/Crear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Compras/Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Compras/Borrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
  

    ViewData["Title"] = "Lista de Compras";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-sm-9\">\r\n\r\n            <h2 class=\"text-info\">Lista de Compras</h2>\r\n\r\n        </div>\r\n\r\n        <div class=\"col-3\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fea4a7e8f77076d660e028a45243bb079646c9d5315", async() => {
                WriteLiteral("Crear Nueva Compra");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 25 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
     if (Model.Compras.Count() > 0)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <table id=\"tblCompras\" class=\"table table-striped table-bordered\" style=\"width: 100%;\">\r\n\r\n            <thead>\r\n                <tr>\r\n                    <th></th>\r\n\r\n");
            WriteLiteral("\r\n                    <th> ");
#nullable restore
#line 36 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Compras.FirstOrDefault().Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 38 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Compras.FirstOrDefault().Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 40 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Compras.FirstOrDefault().FechaCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 42 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Compras.FirstOrDefault().Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 44 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Compras.FirstOrDefault().Laboratorio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 46 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Compras.FirstOrDefault().Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 48 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Compras.FirstOrDefault().Empleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n\r\n\r\n                    <th></th>\r\n\r\n                </tr>\r\n            </thead>\r\n\r\n            <tbody>\r\n\r\n");
#nullable restore
#line 59 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                 foreach (var Compra in Model.Compras)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
#nullable restore
#line 64 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                   Write(Html.DisplayFor(m => Compra.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 66 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                   Write(Html.DisplayFor(m => Compra.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 68 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                   Write(Html.DisplayFor(m => Compra.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 70 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                   Write(Html.DisplayFor(m => Compra.FechaCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 72 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                   Write(Html.DisplayFor(m => Compra.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 74 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                   Write(Html.DisplayFor(m => Compra.Laboratorio.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 76 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                   Write(Html.DisplayFor(m => Compra.Categoria.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 78 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                   Write(Html.DisplayFor(m => Compra.Empleado.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                    <td>\r\n\r\n");
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fea4a7e8f77076d660e028a45243bb079646c9d12014", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                                                                                  WriteLiteral(Compra.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fea4a7e8f77076d660e028a45243bb079646c9d14306", async() => {
                WriteLiteral("Borrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
                                                                                 WriteLiteral(Compra.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 93 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n\r\n        </table>\r\n");
#nullable restore
#line 100 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"
    }

    else
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <p> No hay Compras </p>\r\n");
#nullable restore
#line 106 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Compras\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Farmacia.Pages.Compras.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Farmacia.Pages.Compras.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Farmacia.Pages.Compras.IndexModel>)PageContext?.ViewData;
        public Farmacia.Pages.Compras.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591