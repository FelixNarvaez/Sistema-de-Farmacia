#pragma checksum "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Categorias\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1a958367ac09df5a44978068e090a21252fd1ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Farmacia.Pages.Categorias.Pages_Categorias_Detalle), @"mvc.1.0.razor-page", @"/Pages/Categorias/Detalle.cshtml")]
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
#line 1 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\_ViewImports.cshtml"
using Farmacia;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1a958367ac09df5a44978068e090a21252fd1ab", @"/Pages/Categorias/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e8e87c29709650926ddf13edb979bf9c6cbef46", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Categorias_Detalle : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Categorias\Detalle.cshtml"
  

  ViewData["Title"] = "Detalle de Categoría";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n  <div class=\"row\">\r\n\r\n    <div class=\"col-8 offset-2\">\r\n\r\n      <h2 class=\"text-info\">Detalle de  Categoría:");
#nullable restore
#line 14 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Categorias\Detalle.cshtml"
                                             Write(Html.DisplayFor(m => m.Categoria.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n      <ul class=\"list-group\">\r\n          <li class=\"list-group-item\">ID:");
#nullable restore
#line 18 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Categorias\Detalle.cshtml"
                                    Write(Html.DisplayFor(m => m.Categoria.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n          <li class=\"list-group-item\">Nombre:");
#nullable restore
#line 19 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Categorias\Detalle.cshtml"
                                        Write(Html.DisplayFor(m => m.Categoria.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n          <li class=\"list-group-item\">Descripcion:");
#nullable restore
#line 20 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Categorias\Detalle.cshtml"
                                             Write(Html.DisplayFor(m => m.Categoria.DescripcionCategoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n          <li class=\"list-group-item\">Laboratorio:");
#nullable restore
#line 21 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Categorias\Detalle.cshtml"
                                             Write(Html.DisplayFor(m => m.Categoria.Laboratorio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n          <li class=\"list-group-item\">Fecha de Creacion:");
#nullable restore
#line 22 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Categorias\Detalle.cshtml"
                                                   Write(Html.DisplayFor(m => m.Categoria.FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n      </ul>\r\n\r\n\r\n    </div>\r\n\r\n  </div>\r\n\r\n  <div class=\"row\">\r\n\r\n    <div class=\"col-6\">\r\n\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1a958367ac09df5a44978068e090a21252fd1ab6095", async() => {
                WriteLiteral("volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n  </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Farmacia.Pages.Categorias.DetalleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Farmacia.Pages.Categorias.DetalleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Farmacia.Pages.Categorias.DetalleModel>)PageContext?.ViewData;
        public Farmacia.Pages.Categorias.DetalleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
