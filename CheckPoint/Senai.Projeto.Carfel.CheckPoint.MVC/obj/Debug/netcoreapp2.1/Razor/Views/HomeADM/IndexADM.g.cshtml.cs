#pragma checksum "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\HomeADM\IndexADM.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22cb627ffe8791236cdd7ef9d74c6e7faf8b9bfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeADM_IndexADM), @"mvc.1.0.view", @"/Views/HomeADM/IndexADM.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HomeADM/IndexADM.cshtml", typeof(AspNetCore.Views_HomeADM_IndexADM))]
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
#line 1 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\HomeADM\IndexADM.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22cb627ffe8791236cdd7ef9d74c6e7faf8b9bfe", @"/Views/HomeADM/IndexADM.cshtml")]
    public class Views_HomeADM_IndexADM : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\HomeADM\IndexADM.cshtml"
  
    if(Context.Session.GetString("idUsuario") == null){
        Layout = "MasterPageDeslogado";
        }
    else{
        Layout = "MasterPageLogadoADM";
    }

#line default
#line hidden
            BeginContext(212, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f6f35c59e2144fbaa904aa46aa465dc", async() => {
                BeginContext(218, 53, true);
                WriteLiteral("\r\n    <link href=\"/css/Home.css\" rel=\"stylesheet\" >\r\n");
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
            BeginContext(278, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(280, 5910, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23affb03474d4696a1805665c593062b", async() => {
                BeginContext(286, 5897, true);
                WriteLiteral(@"
    
    <main>
        <div class=""Banner"">
            <div class=""conteudo-banner"">
                <div class=""Banner-image-left"" style=""background-image: url(https://i.pinimg.com/564x/cd/d0/4b/cdd04b91a9153c7244c1d275ad55a824.jpg)""
                    data-text=""CheckPoint
            Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quis nostrum quidem eligendi est itaque perferendis, asperiores repudiandae ducimus quasi, molestias soluta nulla explicabo, aut ratione vitae consequatur earum deserunt ipsum?""></div>
                <div class=""Banner-image-right-top"" style=""background-image: url(https://i.pinimg.com/564x/85/03/cd/8503cdd2ce836397def016347684463a.jpg)""
                    data-text=""CheckPoint
            Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quis nostrum quidem eligendi est itaque perferendis, asperiores repudiandae ducimus quasi, molestias soluta nulla explicabo, aut ratione vitae consequatur earum deserunt ipsum?""></div>
                <div class");
                WriteLiteral(@"=""Banner-image-right-bottom"" style=""background-image: url(https://i.pinimg.com/564x/39/2a/da/392ada3a9258aaad4eb230e957adbea8.jpg)""
                    data-text=""CheckPoint
            Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quis nostrum quidem eligendi est itaque perferendis, asperiores repudiandae ducimus quasi, molestias soluta nulla explicabo, aut ratione vitae consequatur earum deserunt ipsum?""></div>
            </div>
        </div>
        <div class=""divisao"">
            <img src=""/Arquivo_img/Home_imagens/quebra-logo-checkpoint.png"" alt=""Logo do serviço checkpoint oferecido pela empresa Carfel"">
            <h1 id=""planos"">Planos</h1>
            <div class=""retangulo-divisao""></div>
        </div>
        <section>
            <div class=""container-fluid"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-sm4"">
                            <div class=""box"">
                                <div cla");
                WriteLiteral(@"ss=""imgBox"">
                                    <img src=""/Arquivo_img/Home_imagens/left-image.jpg"" alt=""imagem do produto"">
                                </div>
                                <div class=""content"">
                                    <h3>Plano Grátis</h3>
                                    <p>Utilize o produto gratuitamente com suporte para 2 funcionários.</p>
                                    <br>
                                    <button class=""btn btn-default
                                    btnD"">Read More</button>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm4"">
                            <div class=""box"">
                                <div class=""imgBox"">
                                    <img src=""/Arquivo_img/Home_imagens/left-image.jpg"" alt=""imagem do produto"">
                                </div>
                                <div class=""content");
                WriteLiteral(@""">
                                    <h3>Plano R$19,99</h3>
                                    <p>Utilize o produto por apenas R$19,99 e tenha suporte para até 10 funcionários.</p>
                                    <br>
                                    <button class=""btn btn-default
                                    btnD"">Read More</button>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm4"">
                            <div class=""box"">
                                <div class=""imgBox"">
                                    <img src=""/Arquivo_img/Home_imagens/left-image.jpg"" alt=""imagem do produto"">
                                </div>
                                <div class=""content"">
                                    <h3>Plano 99,99</h3>
                                    <p>Utilize o produto por apenas R$99,99 e tenha suporte ilimitado para todos
                            ");
                WriteLiteral(@"            funcionários.</p>
                                    <br>
                                    <button class=""btn btn-default
                                    btnD"">Read More</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
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
                <li class=""other"">Como posso lhe aj");
                WriteLiteral(@"udar?</li>
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



    <script src=""/JavaScript/Home/index.js""></script>
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