#pragma checksum "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Shared\MasterPageDeslogadoCadastroADM.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c37ad3493e340f3626a68367e6efbeaa861a151"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MasterPageDeslogadoCadastroADM), @"mvc.1.0.view", @"/Views/Shared/MasterPageDeslogadoCadastroADM.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MasterPageDeslogadoCadastroADM.cshtml", typeof(AspNetCore.Views_Shared_MasterPageDeslogadoCadastroADM))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c37ad3493e340f3626a68367e6efbeaa861a151", @"/Views/Shared/MasterPageDeslogadoCadastroADM.cshtml")]
    public class Views_Shared_MasterPageDeslogadoCadastroADM : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 52, true);
            WriteLiteral("<html>\r\n    <!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n\r\n");
            EndContext();
            BeginContext(52, 738, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e17bb23dc3143eb9dfd240b0c507661", async() => {
                BeginContext(58, 683, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>CheckPoint - Carfel</title>
    <link href=""/css/MasterPageDeslogado.css"" rel=""stylesheet"" >
    <link href=""https://fonts.googleapis.com/css?family=Lato"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.3.1/css/all.css"" integrity=""sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU""
        crossorigin=""anonymous"">
    <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css'>
    
    ");
                EndContext();
                BeginContext(742, 39, false);
#line 16 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Shared\MasterPageDeslogadoCadastroADM.cshtml"
Write(RenderSection("style", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(781, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(790, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(794, 5496, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bab98fd35004101a9c4035a561e874e", async() => {
                BeginContext(800, 5058, true);
                WriteLiteral(@"

    <div class=""Menu"">
        <div class=""Barra-Top"">
            <div id=""Inside-Barra-Top"">
                <img id=""imagm"" src=""/Arquivo_img/Home_imagens/logo-checkpoint.png"" alt=""Logo do serviço checkpoint oferecido pela empresa Carfel"">
                <div class=""Container-Pesquisa"">
                    <input class=""Input-Busca"" type=""text"" placeholder=""O que você está buscando?"">
                    <input class=""btn"" type=""button"" value=""Buscar"">
                </div>
                <div class=""Login"">
                    <img src=""/Arquivo_img/Home_imagens/img-men-login.png"" alt=""Login"">
                    <div class=""a"">
                    <a href=""/Usuario/CadastroAdmin"">Cadastro</a>
                     <a href=""/Usuario/Deslogar"">Sair</a>
                    </div>
                </div>
                <div data-toggler=""#barraMenu"" class=""clickable Responsive-menu"">
                    <img src=""/Arquivo_img/Home_imagens/menu-burger.png"" alt=""Menu"">
                </");
                WriteLiteral(@"div>
            </div>
        </div>
        <div class=""Responsive-barra-menu"">
            <div id=""barraMenu"" class=""Barra-Menu"">
                <div class=""Menu-left"">
                    <ul>
                        <li>
                            <a href=""/Home/Index"">Home</a>
                        </li>
                        <li>
                            <a href=""#"">Serviços</a>
                        </li>
                        <li>
                            <a href=""/ComentariosDeslogado"">Comentários</a>
                        </li>
                    </ul>
                </div>
                <div class=""Menu-fotos-middle"">
                    <ul>
                        <li>
                            <img src=""/Arquivo_img/Home_imagens/logo-whatsapp.png"" alt=""logo-Whatsapp"">
                        </li>
                        <li>
                            <img src=""/Arquivo_img/Home_imagens/logo-facebook.png"" alt=""logo-Facebook"">
                ");
                WriteLiteral(@"        </li>
                        <li>
                            <img src=""/Arquivo_img/Home_imagens/logo-twitter.png"" alt=""logo-Twitter"">
                        </li>
                        <li>
                            <img src=""/Arquivo_img/Home_imagens/logo-instagram.png"" alt=""logo-Instagram"">
                        </li>
                        <li>
                            <img src=""/Arquivo_img/Home_imagens/logo-linkedin.png"" alt=""logo-Linkedin"">
                        </li>
                        <li>
                            <img src=""/Arquivo_img/Home_imagens/logo-google-plus.png"" alt=""logo-Google-Plus"">
                        </li>
                    </ul>
                </div>
                <div class=""Menu-Right"">
                    <ul>
                        <li>
                            <a href=""/Formulario/Index"">Formulário</a>
                        </li>
                        <li>
                            <a href=""/Faq/Index"">FAQ</a>");
                WriteLiteral(@"
                        </li>
                        <li>
                            <a href=""/Empresa/Index"">Empresa</a>
                        </li>
                    </ul>
                </div>
                <div class=""Responsive-barra-menu-icon"">
                    <div id=""barraMenu"" class=""Barra-Menu-icon"">
                        <div class=""Menu-left-icon"">
                            <ul>
                                <li>
                                    <a href=""/Home/Index""><img src=""/Arquivo_img/Home_imagens/home.png"" alt=""home""></a>
                                </li>
                                <li>
                                    <a href=""#""><img src=""/Arquivo_img/Home_imagens/service.png"" alt=""serviços""></a>
                                </li>
                                <li>
                                    <a href=""/Comentarios/ComentarioDeslogado""><img src=""/Arquivo_img/Home_imagens/contact.png"" alt=""contato""></a>
                       ");
                WriteLiteral(@"         </li>
                            </ul>
                        </div>
                        <div class=""Menu-Right-icon"">
                            <ul>
                                <li>
                                    <a href=""/Formulario/Index""><img src=""/Arquivo_img/Home_imagens/form.png"" alt=""Formulário""></a>
                                </li>
                                <li>
                                    <a href=""/Faq/Index""><img src=""/Arquivo_img/Home_imagens/faq.png"" alt=""FAQ""></a>
                                </li>
                                <li>
                                    <a href=""/Empresa/Index""><img src=""/Arquivo_img/Home_imagens/history.png"" alt=""História""></a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
    ");
                EndContext();
                BeginContext(5859, 12, false);
#line 125 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Shared\MasterPageDeslogadoCadastroADM.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(5871, 369, true);
                WriteLiteral(@"
    <!-- Footer -->
    <footer>
        <div class=""pagefooter"">
            <div class=""conteudo-footer"">
                <p>Sobre o carfel</p>
                <p>Carreiras Profissionais</p>
                <p>Comunidade</p>
                <p>Eventos</p>
                <p>Programa e Parceria</p>
            </div>
        </div>

    </footer>
    ");
                EndContext();
                BeginContext(6241, 40, false);
#line 139 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Shared\MasterPageDeslogadoCadastroADM.cshtml"
Write(RenderSection("script", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(6281, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6290, 9, true);
            WriteLiteral("\r\n</html>");
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
