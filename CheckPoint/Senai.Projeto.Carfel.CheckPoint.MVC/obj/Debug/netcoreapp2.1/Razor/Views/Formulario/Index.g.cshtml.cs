#pragma checksum "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Formulario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c75b4690bd7c2d21d4f8a2b63d820a54b9cae3a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Formulario_Index), @"mvc.1.0.view", @"/Views/Formulario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Formulario/Index.cshtml", typeof(AspNetCore.Views_Formulario_Index))]
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
#line 1 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Formulario\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c75b4690bd7c2d21d4f8a2b63d820a54b9cae3a0", @"/Views/Formulario/Index.cshtml")]
    public class Views_Formulario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Formulario\Index.cshtml"
  
    if(Context.Session.GetString("idUsuario") == null){
        Layout = "MasterPageDeslogado";
        }
    else{
        Layout = "MasterPageLogado";
    }

#line default
#line hidden
            BeginContext(209, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("script", async() => {
                BeginContext(229, 138, true);
                WriteLiteral("\r\n        <script src=\"/JavaScript/Formulario/default.js\"></script>\r\n        <script src=\"/JavaScript/Formulario/index.js\"></script>\r\n    ");
                EndContext();
            }
            );
            BeginContext(370, 5, true);
            WriteLiteral("     ");
            EndContext();
            DefineSection("style", async() => {
                BeginContext(391, 67, true);
                WriteLiteral("\r\n        <link href=\"/css/Formulario.css\" rel=\"stylesheet\" >\r\n    ");
                EndContext();
            }
            );
            BeginContext(461, 2533, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2806b5165708418a87212e2e3c02dcbd", async() => {
                BeginContext(467, 2520, true);
                WriteLiteral(@"
    <div class=""divisao"">
        <img src=""/Arquivo_img/Form_imagens/quebra-logo-checkpoint.png"" alt=""Logo do serviço checkpoint oferecido pela empresa Carfel"">
        <h1 id=""planos"">Formulário</h1>
        <div class=""retangulo-divisao""></div>
    </div>
    <main>
        <div class=""formulario"">
            <div class=""form-header"">
                <h2>Formulário para contato</h2>
            </div>
            <div class=""form-container"">
                <form>
                    <label>Seu nome</label>
                    <input type=""text"" name=""name"" placeholder=""Seu nome"">
                    <label>E-mail</label>
                    <input type=""text"" name=""email"" placeholder=""Endereço de E-mail"">
                    <label>Telefone para contato</label>
                    <input type=""text"" name=""contato"" placeholder=""Seu numero"">
                    <label>Mensagem</label>
                    <textarea name=""Mensagem"" rows=""6"" cols=""15"" placeholder=""Mensagem""></textarea>
 ");
                WriteLiteral(@"                   <input type=""submit"" value=""Enviar Mensagem"" id=""submit"">
                </form>
            </div>
        </div>
        <!-- Alteravel -->
    </main>
    <!-- chat -->
    <div class=""floating-chat"">
        <i class=""fa fa-comments"" aria-hidden=""true""></i>
        <div class=""chat"">
            <div class=""header"">
                <span class=""title"">
                    Tire suas dúvidas rápidas
                </span>
                <button>
                    <i class=""fa fa-times"" aria-hidden=""true""></i>
                </button>

            </div>
            <ul class=""messages"">
                <li class=""other"">Olá!</li>
                <li class=""self"">Olá</li>
                <li class=""other"">Como posso lhe ajudar?</li>
                <li class=""self"">Não estou entendendo como o software funciona</li>
                <li class=""other"">Ok, digite seu e-mail que todas as instruções serão encaminhadas</li>
                <li class=""self"">president");
                WriteLiteral(@"e@hotmail.com</li>
                <li class=""other"">Obrigado, as informações estão lá te esperando</li>
            </ul>
            <div class=""footer"">
                <div class=""text-box"" contenteditable=""true"" disabled=""true""></div>
                <button id=""sendMessage"">send</button>
            </div>
        </div>
    </div>
    <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.1.1/jquery.min.js'></script>
    <!-- fim do chat -->

");
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
            BeginContext(2994, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
