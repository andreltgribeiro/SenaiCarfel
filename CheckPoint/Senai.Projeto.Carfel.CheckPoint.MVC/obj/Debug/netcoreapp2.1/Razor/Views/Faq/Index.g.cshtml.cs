#pragma checksum "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Faq\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "155a95960a77c5ea7085aade5d8af132fec8b0a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faq_Index), @"mvc.1.0.view", @"/Views/Faq/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Faq/Index.cshtml", typeof(AspNetCore.Views_Faq_Index))]
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
#line 1 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Faq\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"155a95960a77c5ea7085aade5d8af132fec8b0a1", @"/Views/Faq/Index.cshtml")]
    public class Views_Faq_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 3 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Faq\Index.cshtml"
  
    if(Context.Session.GetString("idUsuario") == null){
        Layout = "MasterPageDeslogado";
        }
    else{
        Layout = "MasterPageLogadoADM";
    }

#line default
#line hidden
            DefineSection("script", async() => {
                BeginContext(229, 186, true);
                WriteLiteral("\r\n        <script src=\"/JavaScript/FAQ/default.js\"></script>\r\n        <script src=\"/JavaScript/FAQ/index.js\"></script>\r\n        <script src=\"/JavaScript/FAQ/indexform.js\"></script>\r\n    ");
                EndContext();
            }
            );
            DefineSection("style", async() => {
                BeginContext(439, 60, true);
                WriteLiteral("\r\n        <link href=\"/css/FAQ.css\" rel=\"stylesheet\" >\r\n    ");
                EndContext();
            }
            );
            BeginContext(502, 12144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d55fc8e59dd4342a33b133da4ab44da", async() => {
                BeginContext(508, 12131, true);
                WriteLiteral(@"
    <div class=""divisao"">
        <img src=""/Arquivo_img/Faq_imagens/quebra-logo-checkpoint.png"" alt=""Logo do serviço checkpoint oferecido pela empresa Carfel"">
        <h1 id=""planos"">FAQ</h1>
        <div class=""retangulo-divisao""></div>
    </div>
    <main>
        <section class=""cd-faq"">
            <ul class=""cd-faq-categories"">
                <li>
                    <a class=""selected"" href=""#basics"">Basicos</a>
                </li>
                <li>
                    <a href=""#mobile"">Mobile</a>
                </li>
                <li>
                    <a href=""#account"">Conta</a>
                </li>
                <li>
                    <a href=""#payments"">Pagamentos</a>
                </li>
                <li>
                    <a href=""#privacy"">Privacidade</a>
                </li>
                <li>
                    <a href=""#delivery"">Entrega</a>
                </li>
            </ul>
            <!-- cd-faq-categories -->

            ");
                WriteLiteral(@"<div class=""cd-faq-items"">
                <ul id=""basics"" class=""cd-faq-group"">
                    <li class=""cd-faq-title"">
                        <h2>Basicos</h2>
                    </li>
                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Como mudo minha senha?
                        </a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Como me registro?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Posso remover um funcionário?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq");
                WriteLiteral(@"-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Como vejo meu trabalho?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>
                </ul>
                <!-- cd-faq-group -->

                <ul id=""mobile"" class=""cd-faq-group"">
                    <li class=""cd-faq-title"">
                        <h2>Mobile</h2>
                    </li>
                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Como funciona a sincronização?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Como eu faço o upload dos meus arquivos pelo celular ou tablet?</a>
                        <");
                WriteLiteral(@"div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Como eu cadastro um funcionário?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>
                </ul>
                <!-- cd-faq-group -->

                <ul id=""account"" class=""cd-faq-group"">
                    <li class=""cd-faq-title"">
                        <h2>Account</h2>
                    </li>
                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Como eu mudo minha senha</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" h");
                WriteLiteral(@"ref=""#0"">Como deleto minha conta?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Como mudo as configurações da minha conta?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Esqueci minha senha, como consigo outra?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>
                </ul>
                <!-- cd-faq-group -->

                <ul id=""payments"" class=""cd-faq-group"">
                    <li class=""cd-faq-title"">
                        <h2>Payments</h2>
            ");
                WriteLiteral(@"        </li>
                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Posso ter uma fatura da minha assinatura?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Por que meu pagamento com cartão de crédito ou PayPal falhou?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Por que meu extrato bancário mostra várias cobranças por um upgrade?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>
                </ul>
                <!-- cd-faq-group -->

   ");
                WriteLiteral(@"             <ul id=""privacy"" class=""cd-faq-group"">
                    <li class=""cd-faq-title"">
                        <h2>Privacy</h2>
                    </li>
                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Posso especificar minha própria chave privada?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Meus arquivos estão faltando! Como faço para recuperá-los?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Como posso acessar os dados da minha conta?</a>
                        <div class=""cd-faq-content"">

                        </div>
            ");
                WriteLiteral(@"            <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Como posso controlar se outros mecanismos de pesquisa podem vincular ao meu perfil?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>
                </ul>
                <!-- cd-faq-group -->

                <ul id=""delivery"" class=""cd-faq-group"">
                    <li class=""cd-faq-title"">
                        <h2>Delivery</h2>
                    </li>
                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">O que devo fazer se o meu pedido ainda não tiver sido entregue?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""");
                WriteLiteral(@"cd-faq-trigger"" href=""#0"">Como posso encontrar suas informações de entrega internacional?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Quem cuida do envio?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Como os retornos ou reembolsos funcionam?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Como faço para usar perfis de envio?</a>
                        <div class=""cd-faq-content"">

  ");
                WriteLiteral(@"                      </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Como funciona o seu serviço de entrega no dia seguinte?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Como funciona o seu serviço de entrega no dia seguinte?</a>
                        <div class=""cd-faq-content"">

                        </div>
                        <!-- cd-faq-content -->
                    </li>

                    <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Quando meu pedido chegará?</a>
                        <div class=""cd-faq-content"">
                        </div>
                        <!-- cd-faq-content -->
                    </li>

        ");
                WriteLiteral(@"            <li>
                        <a class=""cd-faq-trigger"" href=""#0"">Quando meu pedido será enviado?</a>
                        <div class=""cd-faq-content"">
                        </div>
                        <!-- cd-faq-content -->
                    </li>
                </ul>
                <!-- cd-faq-group -->
            </div>
            <!-- cd-faq-items -->
            <a href=""#0"" class=""cd-close-panel"">Close</a>
        </section>
        <!-- cd-faq -->
        <!-- Resource jQuery -->
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
            <ul class=""");
                WriteLiteral(@"messages"">
                <li class=""other"">Olá!</li>
                <li class=""self"">Olá</li>
                <li class=""other"">Como posso lhe ajudar?</li>
                <li class=""self"">Não estou entendendo como o software funciona</li>
                <li class=""other"">Ok, digite seu e-mail que todas as instruções serão encaminhadas</li>
                <li class=""self"">presidente@hotmail.com</li>
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
            BeginContext(12646, 2, true);
            WriteLiteral("\r\n");
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
