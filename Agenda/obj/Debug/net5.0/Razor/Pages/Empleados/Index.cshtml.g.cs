#pragma checksum "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3255d4d41a3739c23abd6f085e896420914a22d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Farmacia.Pages.Empleados.Pages_Empleados_Index), @"mvc.1.0.razor-page", @"/Pages/Empleados/Index.cshtml")]
namespace Farmacia.Pages.Empleados
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3255d4d41a3739c23abd6f085e896420914a22d6", @"/Pages/Empleados/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e8e87c29709650926ddf13edb979bf9c6cbef46", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Empleados_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Empleados/Crear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Empleados/Detalle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Empleados/Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Empleados/Borrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
  

    ViewData["Title"] = "Lista de Empleados";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-sm-9\">\r\n\r\n            <h2 class=\"text-info\">Lista de Empleados</h2>\r\n\r\n        </div>\r\n\r\n        <div class=\"col-3\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3255d4d41a3739c23abd6f085e896420914a22d66009", async() => {
                WriteLiteral("Crear Nuevo Empleado");
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
#line 25 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
     if (Model.Empleados.Count() > 0)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <table id=\"tblEmpleados\" class=\"table table-striped table-bordered\" style=\"width: 100%;\">\r\n\r\n            <thead>\r\n\r\n                <tr>\r\n                    <th></th>\r\n");
            WriteLiteral("\r\n                    <th> ");
#nullable restore
#line 36 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Empleados.FirstOrDefault().Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 38 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Empleados.FirstOrDefault().ApellidoPaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 40 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Empleados.FirstOrDefault().ApellidoMaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 42 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Empleados.FirstOrDefault().Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 44 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Empleados.FirstOrDefault().Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 46 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                    Write(Html.DisplayNameFor(m => m.Empleados.FirstOrDefault().Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th></th>\r\n\r\n                </tr>\r\n            </thead>\r\n\r\n\r\n            <tbody>\r\n\r\n");
#nullable restore
#line 56 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                 foreach (var empleado in Model.Empleados)
                {
                    if(empleado.Estado ==true)
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("<p></p>\r\n");
#nullable restore
#line 63 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                    }
                    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
#nullable restore
#line 67 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                   Write(Html.DisplayFor(m => empleado.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 69 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                   Write(Html.DisplayFor(m => empleado.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 70 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                   Write(Html.DisplayFor(m => empleado.ApellidoPaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 71 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                   Write(Html.DisplayFor(m => empleado.ApellidoMaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 72 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                   Write(Html.DisplayFor(m => empleado.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 73 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                   Write(Html.DisplayFor(m => empleado.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 74 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                   Write(Html.DisplayFor(m => empleado.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3255d4d41a3739c23abd6f085e896420914a22d612425", async() => {
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
#line 78 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                                                                                     WriteLiteral(empleado.Id);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3255d4d41a3739c23abd6f085e896420914a22d614725", async() => {
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
#line 80 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                                                                                    WriteLiteral(empleado.Id);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3255d4d41a3739c23abd6f085e896420914a22d617023", async() => {
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
#line 82 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                                                                                   WriteLiteral(empleado.Id);

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
#line 87 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
                    }

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n\r\n        </table>\r\n");
#nullable restore
#line 94 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"
    }

    else
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <p> No hay Empleados </p>\r\n");
#nullable restore
#line 100 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Empleados\Index.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Farmacia.Pages.Empleados.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Farmacia.Pages.Empleados.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Farmacia.Pages.Empleados.IndexModel>)PageContext?.ViewData;
        public Farmacia.Pages.Empleados.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
