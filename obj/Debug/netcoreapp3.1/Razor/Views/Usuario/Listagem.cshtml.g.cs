#pragma checksum "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\Usuario\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c1d0f44d85568f9c66b39684abcb0eb3405e431"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listagem), @"mvc.1.0.view", @"/Views/Usuario/Listagem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c1d0f44d85568f9c66b39684abcb0eb3405e431", @"/Views/Usuario/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6651aec79e6a314ad43af80a8c6eb7c082427b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\Usuario\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de usuários";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Usuarios Listados</h1>\r\n<br>\r\n\r\n<table class=\"table table-dark\">\r\n    <tr>\r\n        <td>ID</td>\r\n        <td>Nome</td>\r\n        <td>Login</td>\r\n        <td>Senha</td>\r\n        <td>Data de Nascimento</td>\r\n        <td>Operações</td>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\Usuario\Listagem.cshtml"
     foreach (Usuario u in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\Usuario\Listagem.cshtml"
           Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\Usuario\Listagem.cshtml"
           Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\Usuario\Listagem.cshtml"
           Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\Usuario\Listagem.cshtml"
           Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\Usuario\Listagem.cshtml"
           Write(u.DataNascimento.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 604, "\"", 635, 2);
            WriteAttributeValue("", 611, "/Usuario/Editar?Id=", 611, 19, true);
#nullable restore
#line 29 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 630, u.Id, 630, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a> |\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 670, "\"", 702, 2);
            WriteAttributeValue("", 677, "/Usuario/Excluir?Id=", 677, 20, true);
#nullable restore
#line 30 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 697, u.Id, 697, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Deseja mesmo Excluir este ítem\');\">Remover</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\felip\OneDrive\Documentos\Conjunto ATV-2\ATV-2 UC4\Views\Usuario\Listagem.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
