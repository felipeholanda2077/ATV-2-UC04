#pragma checksum "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\PacotesTuristicos\ListagemPT.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9028adb243251ad2d682941e87a43bf52c440951"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PacotesTuristicos_ListagemPT), @"mvc.1.0.view", @"/Views/PacotesTuristicos/ListagemPT.cshtml")]
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
#line 1 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\_ViewImports.cshtml"
using ATV_2_UC4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\_ViewImports.cshtml"
using ATV_2_UC4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9028adb243251ad2d682941e87a43bf52c440951", @"/Views/PacotesTuristicos/ListagemPT.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6651aec79e6a314ad43af80a8c6eb7c082427b49", @"/Views/_ViewImports.cshtml")]
    public class Views_PacotesTuristicos_ListagemPT : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PacotesTuristicos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\PacotesTuristicos\ListagemPT.cshtml"
  
    ViewData["Title"] = "ListagemPT";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>PacotesTuristicos</h1>
<br>

<table class=""table table table-dark"">
    <tr>
        <td>Id</td>
        <td>Nome</td>
        <td>Origem</td>
        <td>Destino</td>
        <td>Atrativos</td>
        <td>Saida</td>
        <td>Retorno</td>
    </tr>

");
#nullable restore
#line 21 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\PacotesTuristicos\ListagemPT.cshtml"
     foreach (PacotesTuristicos pt in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\PacotesTuristicos\ListagemPT.cshtml"
           Write(pt.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\PacotesTuristicos\ListagemPT.cshtml"
           Write(pt.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\PacotesTuristicos\ListagemPT.cshtml"
           Write(pt.Origem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\PacotesTuristicos\ListagemPT.cshtml"
           Write(pt.Destino);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\PacotesTuristicos\ListagemPT.cshtml"
           Write(pt.Atrativos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\PacotesTuristicos\ListagemPT.cshtml"
           Write(pt.Saida.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\PacotesTuristicos\ListagemPT.cshtml"
           Write(pt.Retorno.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\PacotesTuristicos\ListagemPT.cshtml"
           Write(pt.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 760, "\"", 802, 2);
            WriteAttributeValue("", 767, "/PacotesTuristicos/Editar?Id=", 767, 29, true);
#nullable restore
#line 33 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\PacotesTuristicos\ListagemPT.cshtml"
WriteAttributeValue("", 796, pt.Id, 796, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a> |\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 837, "\"", 880, 2);
            WriteAttributeValue("", 844, "/PacotesTuristicos/Excluir?Id=", 844, 30, true);
#nullable restore
#line 34 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\PacotesTuristicos\ListagemPT.cshtml"
WriteAttributeValue("", 874, pt.Id, 874, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Deseja mesmo Excluir este ítem\');\">Remover</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\PacotesTuristicos\ListagemPT.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PacotesTuristicos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
