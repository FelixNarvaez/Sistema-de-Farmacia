#pragma checksum "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b791518bdc5efd8364f40b3a4491127adba05e13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Farmacia.Pages.Medicamentos.Pages_Medicamentos_Estado), @"mvc.1.0.razor-page", @"/Pages/Medicamentos/Estado.cshtml")]
namespace Farmacia.Pages.Medicamentos
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b791518bdc5efd8364f40b3a4491127adba05e13", @"/Pages/Medicamentos/Estado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e8e87c29709650926ddf13edb979bf9c6cbef46", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Medicamentos_Estado : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"
  

    ViewData["Title"] = "Lista de Medicamentos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-sm-9\">\r\n\r\n            <h2 class=\"text-info\">Lista de Medicamentos Eliminados</h2>\r\n\r\n        </div>\r\n\r\n       \r\n    </div>\r\n\r\n");
#nullable restore
#line 21 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"
     if (Model.Medicamentos.Count() > 0)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <table id=\"tblMedicamentos\" class=\"table table-striped table-bordered\" style=\"width: 100%;\">\r\n\r\n            <thead>\r\n                <tr>\r\n                    <th></th>\r\n");
            WriteLiteral("\r\n                    <th> ");
#nullable restore
#line 31 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"
                    Write(Html.DisplayNameFor(m => m.Medicamentos.FirstOrDefault().Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 33 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"
                    Write(Html.DisplayNameFor(m => m.Medicamentos.FirstOrDefault().ViaAdministracion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 35 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"
                    Write(Html.DisplayNameFor(m => m.Medicamentos.FirstOrDefault().FechaVencimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <th> ");
#nullable restore
#line 37 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"
                    Write(Html.DisplayNameFor(m => m.Medicamentos.FirstOrDefault().Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n");
            WriteLiteral("\r\n                    <th>Laboratorio</th>\r\n\r\n                </tr>\r\n            </thead>\r\n\r\n            <tbody>\r\n\r\n");
#nullable restore
#line 48 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"
                 foreach (var Medicamento in Model.Medicamentos)
                {
                    if(Medicamento.Estado==false)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p></p>\r\n<p></p>\r\n");
#nullable restore
#line 55 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"
                    }
                    else { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
#nullable restore
#line 59 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"
                   Write(Html.DisplayFor(m => Medicamento.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 61 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"
                   Write(Html.DisplayFor(m => Medicamento.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 63 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"
                   Write(Html.DisplayFor(m => Medicamento.ViaAdministracion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 65 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"
                   Write(Html.DisplayFor(m => Medicamento.FechaVencimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 67 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"
                   Write(Html.DisplayFor(m => Medicamento.Categoria.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 69 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"
                   Write(Html.DisplayFor(m => Medicamento.Categoria.Laboratorio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    \r\n                </tr>\r\n");
#nullable restore
#line 73 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"
                    }

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n\r\n        </table>\r\n");
#nullable restore
#line 80 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"
    }

    else
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <p> No hay Medicamentos </p>\r\n");
#nullable restore
#line 86 "C:\Users\usuario\Desktop\Farmacia\Agenda\Pages\Medicamentos\Estado.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Farmacia.Pages.Medicamentos.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Farmacia.Pages.Medicamentos.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Farmacia.Pages.Medicamentos.IndexModel>)PageContext?.ViewData;
        public Farmacia.Pages.Medicamentos.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
