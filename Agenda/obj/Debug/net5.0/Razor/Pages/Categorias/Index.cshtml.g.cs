#pragma checksum "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ecff55a9cd6ebe4108c0a209b2ea32d8a72151e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Farmacia.Pages.Categorias.Pages_Categorias_Index), @"mvc.1.0.razor-page", @"/Pages/Categorias/Index.cshtml")]
namespace Farmacia.Pages.Categorias
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
#line 1 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\_ViewImports.cshtml"
using Farmacia;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ecff55a9cd6ebe4108c0a209b2ea32d8a72151e", @"/Pages/Categorias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e8e87c29709650926ddf13edb979bf9c6cbef46", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Categorias_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Categorias/Crear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Categorias/Detalle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Categorias/Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Categorias/Borrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
  

    ViewData["Title"] = "Lista de Categorías";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-sm-9\">\r\n\r\n            <h2 class=\"text-info\">Lista de Categorías</h2>\r\n\r\n        </div>\r\n\r\n        <div class=\"col-3\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ecff55a9cd6ebe4108c0a209b2ea32d8a72151e6071", async() => {
                WriteLiteral("Crear Nueva Categoría");
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
#line 25 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
     if (Model.Categorias.Count() > 0)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <table id=\"tblCategorias\" class=\"table table-striped table-bordered\" style=\"width: 100%;\">\r\n\r\n            <thead>\r\n\r\n                <tr>\r\n\r\n                    <th> ");
#nullable restore
#line 34 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Categorias.FirstOrDefault().Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 36 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Categorias.FirstOrDefault().Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 38 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Categorias.FirstOrDefault().DescripcionCategoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 40 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Categorias.FirstOrDefault().Laboratorio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 42 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Categorias.FirstOrDefault().FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th></th>\r\n\r\n                </tr>\r\n            </thead>\r\n\r\n\r\n            <tbody>\r\n\r\n");
#nullable restore
#line 52 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
                 foreach (var categoria in Model.Categorias)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
#nullable restore
#line 57 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
                   Write(Html.DisplayFor(m => categoria.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 59 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
                   Write(Html.DisplayFor(m => categoria.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
                   Write(Html.DisplayFor(m => categoria.DescripcionCategoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 61 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
                   Write(Html.DisplayFor(m => categoria.Laboratorio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 62 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
                   Write(Html.DisplayFor(m => categoria.FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ecff55a9cd6ebe4108c0a209b2ea32d8a72151e11456", async() => {
                WriteLiteral("Detalle");
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
#line 66 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
                                                                                      WriteLiteral(categoria.Id);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ecff55a9cd6ebe4108c0a209b2ea32d8a72151e13775", async() => {
                WriteLiteral("Editar");
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
#line 68 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
                                                                                     WriteLiteral(categoria.Id);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ecff55a9cd6ebe4108c0a209b2ea32d8a72151e16092", async() => {
                WriteLiteral("Borrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
                                                                                    WriteLiteral(categoria.Id);

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
#line 75 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n\r\n        </table>\r\n");
#nullable restore
#line 81 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"
    }

    else
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <p> No hay Categorías </p>\r\n");
#nullable restore
#line 87 "C:\Users\usuario\Desktop\SistemaFarmacia\Farmacia\Agenda\Pages\Categorias\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    \r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Farmacia.Pages.Categorias.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Farmacia.Pages.Categorias.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Farmacia.Pages.Categorias.IndexModel>)PageContext?.ViewData;
        public Farmacia.Pages.Categorias.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
