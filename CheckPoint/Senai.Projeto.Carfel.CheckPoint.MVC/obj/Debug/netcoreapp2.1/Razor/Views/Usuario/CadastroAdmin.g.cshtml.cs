#pragma checksum "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Usuario\CadastroAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "833d47eaba0abdfcef2f388f1f1799f44562db93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_CadastroAdmin), @"mvc.1.0.view", @"/Views/Usuario/CadastroAdmin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/CadastroAdmin.cshtml", typeof(AspNetCore.Views_Usuario_CadastroAdmin))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"833d47eaba0abdfcef2f388f1f1799f44562db93", @"/Views/Usuario/CadastroAdmin.cshtml")]
    public class Views_Usuario_CadastroAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Usuario\CadastroAdmin.cshtml"
  
    Layout = "MasterPageLogadoADM";

#line default
#line hidden
            BeginContext(44, 215, true);
            WriteLiteral("<html>\r\n    <link href=\"/css/CadastroUsuario.css\" rel=\"stylesheet\">\r\n<div class=\"formulario\">\r\n        <div class=\"form-header\">\r\n            <h1>Cadastro de usuário administrador</h1>\r\n            <p>\r\n            ");
            EndContext();
            BeginContext(260, 16, false);
#line 10 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Usuario\CadastroAdmin.cshtml"
       Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(276, 730, true);
            WriteLiteral(@"
            </p> 
           
        </div>
        <div class=""form-container"">
            <form action=""/Usuario/CadastroAdmin"" method=""Post"">

                <label>Nome</label>
                <input type=""text"" name=""nome"" required = ""true"">
                <br>
            
                <label>E-mail</label>
                <input type=""email"" name=""email"" required = ""true"">

                <label>
                Senha
                <input type=""password"" name=""senha"" required = ""true"">
                </label>
                <br>
                <br>
                <button type=""submit"">Salvar</button>          
            </form>
        </div>
    </div>
    </form>
</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
