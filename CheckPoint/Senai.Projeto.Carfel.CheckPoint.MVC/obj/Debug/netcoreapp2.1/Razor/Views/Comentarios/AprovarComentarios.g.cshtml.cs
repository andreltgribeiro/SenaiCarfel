#pragma checksum "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b75b869582cb740ed8212d125c5bb7aebe5c338"
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
#line 1 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
using Senai.Projeto.Carfel.CheckPoint.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b75b869582cb740ed8212d125c5bb7aebe5c338", @"/Views/Comentarios/AprovarComentarios.cshtml")]
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
#line 4 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
  
    if(Context.Session.GetString("idUsuario") == null){
        Layout = "MasterPageDeslogado";
        }
    else{
        Layout = "MasterPageLogadoADM";
    }
    

#line default
#line hidden
            BeginContext(270, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afc070fdfd914ff0be784f85f27db621", async() => {
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
            BeginContext(345, 1628, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7169445790914c12823a9d9a505e5f3c", async() => {
                BeginContext(351, 308, true);
                WriteLiteral(@"
<!-- Contenedor Principal -->
	<div class=""comments-container"">
		<div class=""divisao"">
            <img src=""/Arquivo_img/Home_imagens/quebra-logo-checkpoint.png"" alt=""Logo do serviço checkpoint oferecido pela empresa Carfel"">
            <h1 id=""Comentarios"">Aprovar ou Reprovar Comentarios</h1>
			");
                EndContext();
                BeginContext(660, 20, false);
#line 22 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
       Write(TempData["Mensagem"]);

#line default
#line hidden
                EndContext();
                BeginContext(680, 167, true);
                WriteLiteral("\r\n            <div class=\"retangulo-divisao\"></div>\r\n        </div>\r\n\r\n\t\t<ul id=\"comments-list\" class=\"comments-list\">\r\n\t\t\t<li>\r\n\t\t\t\t<div class=\"comment-main-level\">\r\n");
                EndContext();
#line 29 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
                     foreach(ComentarioModel comentario in ViewData["Comentarios"] as List<ComentarioModel>){

#line default
#line hidden
                BeginContext(943, 583, true);
                WriteLiteral(@"						<div class=""comment-main-level"">
							<!-- Avatar -->
							<div class=""comment-avatar""><img src=""https://png2.kisspng.com/sh/a842adb43f8dd35c071d93865c0c99d1/L0KzQYm3VsI2N6F8iJH0aYP2gLBuTfNwdaF6jNd7LXnmf7B6TfF3aaVmip9rdYPsfrb6k71kd551jeZucj32f7f7lBFzbV56i9d7LXH5ccXokr02amQ1UalvY3TpRrW7Ub42OWc4T6o7NEG4QoqCUcEzQWMASac7LoDxd1==/kisspng-computer-icons-avatar-business-computer-software-user-avatar-5b3097fcdf6d41.5163782415299112929152.png"" alt=""""></div>
							<div class=""comment-box"">
								<div class=""comment-head"">
									<h6 class=""comment-name by-author""><a>");
                EndContext();
                BeginContext(1527, 22, false);
#line 35 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
                                                                     Write(comentario.nomeUsuario);

#line default
#line hidden
                EndContext();
                BeginContext(1549, 26, true);
                WriteLiteral("</a></h6>\r\n\t\t\t\t\t\t\t\t\t<span>");
                EndContext();
                BeginContext(1576, 22, false);
#line 36 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
                                     Write(comentario.DataCriacao);

#line default
#line hidden
                EndContext();
                BeginContext(1598, 20, true);
                WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t<a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1618, "\"", 1663, 2);
                WriteAttributeValue("", 1625, "/Comentarios/Excluir?id=", 1625, 24, true);
#line 37 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
WriteAttributeValue("", 1649, comentario.Id, 1649, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1664, 45, true);
                WriteLiteral("><i class=\"fa fa-times\"></i></a>\r\n\t\t\t\t\t\t\t\t\t<a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1709, "\"", 1754, 2);
                WriteAttributeValue("", 1716, "/Comentarios/Aprovar?id=", 1716, 24, true);
#line 38 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
WriteAttributeValue("", 1740, comentario.Id, 1740, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1755, 97, true);
                WriteLiteral("><i class=\"fa fa-heart\"></i></a>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"comment-content\">\r\n\t\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(1853, 16, false);
#line 41 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
                           Write(comentario.Texto);

#line default
#line hidden
                EndContext();
                BeginContext(1869, 59, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<br>\r\n");
                EndContext();
#line 46 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\AprovarComentarios.cshtml"
					}

#line default
#line hidden
                BeginContext(1936, 30, true);
                WriteLiteral("\t\t\t\t</div>\r\n\t\t</ul>\r\n\t</div>\r\n");
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
