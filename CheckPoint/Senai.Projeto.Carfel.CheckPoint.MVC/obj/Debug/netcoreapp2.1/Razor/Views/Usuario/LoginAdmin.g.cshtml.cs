#pragma checksum "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Usuario\LoginAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fbfdb26ab1f4e86a13b7218ea29356628e878c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_LoginAdmin), @"mvc.1.0.view", @"/Views/Usuario/LoginAdmin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/LoginAdmin.cshtml", typeof(AspNetCore.Views_Usuario_LoginAdmin))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fbfdb26ab1f4e86a13b7218ea29356628e878c7", @"/Views/Usuario/LoginAdmin.cshtml")]
    public class Views_Usuario_LoginAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Usuario\LoginAdmin.cshtml"
  
    Layout = "MasterPageDeslogadoCadastroADM";

#line default
#line hidden
            BeginContext(55, 204, true);
            WriteLiteral("<html>\r\n    <link href=\"/css/LoginUsuario.css\" rel=\"stylesheet\">\r\n<div class=\"formulario\">\r\n        <div class=\"form-header\">\r\n            <h1>Fazer Login Administrador</h1>\r\n            <p>\r\n            ");
            EndContext();
            BeginContext(260, 18, false);
#line 10 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Usuario\LoginAdmin.cshtml"
       Write(ViewBag.LoginFalha);

#line default
#line hidden
            EndContext();
            BeginContext(278, 619, true);
            WriteLiteral(@"
            </p> 
        </div>
        <div class=""form-container"">
            <form action=""/Usuario/CadastroAdmin"" method=""Post"">           
                <label>E-mail</label>
                <input type=""email"" name=""email"" required = ""true"">
                
                <label>
                Senha
                <input type=""password"" name=""senha"" required = ""true"">
                </label>
                <br>
                <br>
                <button type=""submit"">Entrar</button>
                         
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
