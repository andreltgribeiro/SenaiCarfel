#pragma checksum "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4067faff67faeb4a986d414af875e94794e563cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentarios_AprovarComentarios), @"mvc.1.0.view", @"/Views/Comentarios/AprovarComentarios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentarios/AprovarComentarios.cshtml", typeof(AspNetCore.Views_Comentarios_AprovarComentarios))]
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
#line 1 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
using Senai.Projeto.Carfel.CheckPoint.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4067faff67faeb4a986d414af875e94794e563cf", @"/Views/Comentarios/AprovarComentarios.cshtml")]
    public class Views_Comentarios_AprovarComentarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
  
    if(Context.Session.GetString("idUsuario") == null){
        Layout = "MasterPageDeslogado";
        }
    else{
        Layout = "MasterPageLogadoADM";
    }
    

#line default
#line hidden
            BeginContext(270, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c643d025eff4d3da2ba52ad430ccf08", async() => {
                BeginContext(276, 60, true);
                WriteLiteral("\r\n    <link href=\"/css/Comentarios.css\" rel=\"stylesheet\" >\r\n");
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
            BeginContext(343, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(345, 1992, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9703aeb739fe42af9101782696027c23", async() => {
                BeginContext(351, 331, true);
                WriteLiteral(@"

<!-- Contenedor Principal -->
	<div class=""comments-container"">
		<div class=""divisao"">
            <img src=""/Arquivo_img/Home_imagens/quebra-logo-checkpoint.png"" alt=""Logo do serviço checkpoint oferecido pela empresa Carfel"">
            <h1 id=""Comentarios"">Aprovar ou Reprovar Comentarios</h1>
			<h3 class=""mensagem"">");
                EndContext();
                BeginContext(683, 20, false);
#line 23 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
                            Write(TempData["Mensagem"]);

#line default
#line hidden
                EndContext();
                BeginContext(703, 172, true);
                WriteLiteral("</h3>\r\n            <div class=\"retangulo-divisao\"></div>\r\n        </div>\r\n\r\n\t\t<ul id=\"comments-list\" class=\"comments-list\">\r\n\t\t\t<li>\r\n\t\t\t\t<div class=\"comment-main-level\">\r\n");
                EndContext();
#line 30 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
                     foreach(ComentarioModel comentario in ViewData["Comentarios"] as List<ComentarioModel>){

#line default
#line hidden
                BeginContext(971, 317, true);
                WriteLiteral(@"						<div id=""popup1"" class=""overlay"">
							<div class=""popup"">
								<h2 class=""Text-head-popup"">Confirmar Exclusão</h2>
								<a class=""close"" href=""#"">&times;</a>
								<div class=""content"">
									<p>Deseja excluir permanentemente este comentário</p>
									<div class=""excluira"">
										<a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1288, "\"", 1333, 2);
                WriteAttributeValue("", 1295, "/Comentarios/Excluir?id=", 1295, 24, true);
#line 38 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
WriteAttributeValue("", 1319, comentario.Id, 1319, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1334, 87, true);
                WriteLiteral(">Excluir Comentario</a>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n");
                EndContext();
                BeginContext(1423, 379, true);
                WriteLiteral(@"						<div class=""comment-main-level"">
							
							<div class=""comment-avatar""><img src=""https://banner2.kisspng.com/20180625/req/kisspng-computer-icons-avatar-business-computer-software-user-avatar-5b3097fcae25c3.3909949015299112927133.jpg"" alt=""""></div>
							<div class=""comment-box"">
								<div class=""comment-head"">
									<h6 class=""comment-name by-author""><a>");
                EndContext();
                BeginContext(1803, 22, false);
#line 49 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
                                                                     Write(comentario.nomeUsuario);

#line default
#line hidden
                EndContext();
                BeginContext(1825, 26, true);
                WriteLiteral("</a></h6>\r\n\t\t\t\t\t\t\t\t\t<span>");
                EndContext();
                BeginContext(1852, 22, false);
#line 50 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
                                     Write(comentario.DataCriacao);

#line default
#line hidden
                EndContext();
                BeginContext(1874, 81, true);
                WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t<a href=\"#popup1\"\t><i class=\"fa fa-times\"></i></a>\r\n\t\t\t\t\t\t\t\t\t<a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1955, "\"", 2000, 2);
                WriteAttributeValue("", 1962, "/Comentarios/Aprovar?id=", 1962, 24, true);
#line 52 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
WriteAttributeValue("", 1986, comentario.Id, 1986, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2001, 97, true);
                WriteLiteral("><i class=\"fa fa-heart\"></i></a>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"comment-content\">\r\n\t\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(2099, 16, false);
#line 55 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
                           Write(comentario.Texto);

#line default
#line hidden
                EndContext();
                BeginContext(2115, 59, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<br>\r\n");
                EndContext();
#line 60 "C:\Users\44680479841\SenaiCarfel\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
					}

#line default
#line hidden
                BeginContext(2182, 148, true);
                WriteLiteral("\t\t\t\t\t\r\n\t\t\t\t</div>\r\n\t\t</ul>\r\n\t</div>\r\n\t<div class=\"excluira\">\r\n\t\t<a  href=\"/Comentarios/ComentariosAprovados\">Excluir Comentarios</a></h1>\r\n\t</div>\r\n");
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
