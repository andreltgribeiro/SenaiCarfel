#pragma checksum "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\ComentarioDeslogado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecf89cda661bc60140f2a15af806cd78ea1b811f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentarios_ComentarioDeslogado), @"mvc.1.0.view", @"/Views/Comentarios/ComentarioDeslogado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentarios/ComentarioDeslogado.cshtml", typeof(AspNetCore.Views_Comentarios_ComentarioDeslogado))]
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
#line 1 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\ComentarioDeslogado.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\ComentarioDeslogado.cshtml"
using Senai.Projeto.Carfel.CheckPoint.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecf89cda661bc60140f2a15af806cd78ea1b811f", @"/Views/Comentarios/ComentarioDeslogado.cshtml")]
    public class Views_Comentarios_ComentarioDeslogado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 4 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\ComentarioDeslogado.cshtml"
  
    if(Context.Session.GetString("idUsuario") == null){
        Layout = "MasterPageDeslogado";
        }
    else{
        Layout = "MasterPageLogado";
    }
    

#line default
#line hidden
            BeginContext(267, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a13e222e9704140bb10f0594f4d651e", async() => {
                BeginContext(273, 60, true);
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
            BeginContext(340, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(342, 1481, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9b96fb026d649a68c6bc77d9eb9d058", async() => {
                BeginContext(348, 450, true);
                WriteLiteral(@"
<!-- Contenedor Principal -->
	<div class=""comments-container"">
		<div class=""divisao"">
            <img src=""/Arquivo_img/Home_imagens/quebra-logo-checkpoint.png"" alt=""Logo do serviço checkpoint oferecido pela empresa Carfel"">
            <h1 id=""Comentarios"">Comentarios</h1>
            <div class=""retangulo-divisao""></div>
        </div>

		<ul id=""comments-list"" class=""comments-list"">
			<li>
				<div class=""comment-main-level"">
");
                EndContext();
#line 28 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\ComentarioDeslogado.cshtml"
                     foreach(ComentarioModel comentario in ViewData["Comentarios"] as List<ComentarioModel>){

#line default
#line hidden
                BeginContext(894, 626, true);
                WriteLiteral(@"						<div class=""comment-main-level"">
							<!-- Avatar -->
							<div class=""comment-avatar""><img src=""https://png2.kisspng.com/sh/a842adb43f8dd35c071d93865c0c99d1/L0KzQYm3VsI2N6F8iJH0aYP2gLBuTfNwdaF6jNd7LXnmf7B6TfF3aaVmip9rdYPsfrb6k71kd551jeZucj32f7f7lBFzbV56i9d7LXH5ccXokr02amQ1UalvY3TpRrW7Ub42OWc4T6o7NEG4QoqCUcEzQWMASac7LoDxd1==/kisspng-computer-icons-avatar-business-computer-software-user-avatar-5b3097fcdf6d41.5163782415299112929152.png"" alt=""""></div>
							<!-- Contenedor del Comentario -->
							<div class=""comment-box"">
								<div class=""comment-head"">
									<h6 class=""comment-name by-author""><a>");
                EndContext();
                BeginContext(1521, 22, false);
#line 35 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\ComentarioDeslogado.cshtml"
                                                                     Write(comentario.nomeUsuario);

#line default
#line hidden
                EndContext();
                BeginContext(1543, 26, true);
                WriteLiteral("</a></h6>\r\n\t\t\t\t\t\t\t\t\t<span>");
                EndContext();
                BeginContext(1570, 22, false);
#line 36 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\ComentarioDeslogado.cshtml"
                                     Write(comentario.DataCriacao);

#line default
#line hidden
                EndContext();
                BeginContext(1592, 110, true);
                WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t<i class=\"fa fa-heart\"></i>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"comment-content\">\r\n\t\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(1703, 16, false);
#line 40 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\ComentarioDeslogado.cshtml"
                           Write(comentario.Texto);

#line default
#line hidden
                EndContext();
                BeginContext(1719, 59, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<br>\r\n");
                EndContext();
#line 45 "C:\Users\44680479841\Desktop\Projeto Check_Point\CheckPoint\Senai.Projeto.Carfel.CheckPoint.MVC\Views\Comentarios\ComentarioDeslogado.cshtml"
					}

#line default
#line hidden
                BeginContext(1786, 30, true);
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