#pragma checksum "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\DominandoTestesDeSoftware\Testes De Software\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87815c9b2d7922fa84bf3993efca34f7ffcb9cdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vitrine_Index), @"mvc.1.0.view", @"/Views/Vitrine/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vitrine/Index.cshtml", typeof(AspNetCore.Views_Vitrine_Index))]
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
#line 1 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\DominandoTestesDeSoftware\Testes De Software\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC;

#line default
#line hidden
#line 2 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\DominandoTestesDeSoftware\Testes De Software\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87815c9b2d7922fa84bf3993efca34f7ffcb9cdc", @"/Views/Vitrine/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246ad970dd91c7456f8d33f4d8e9926f7afca0fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Vitrine_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NerdStore.Catalogo.Application.ViewModels.ProdutoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vitrine", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProdutoDetalhe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\DominandoTestesDeSoftware\Testes De Software\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
  
    ViewData["Title"] = "Vitrine";

#line default
#line hidden
            BeginContext(125, 602, true);
            WriteLiteral(@"<style>
    h4 {
        font-weight: 600;
    }

    p {
        font-size: 12px;
        margin-top: 5px;
    }

    .price {
        font-size: 30px;
        margin: 0 auto;
        color: #333;
    }

    .right {
        float: right;
        border-bottom: 2px solid #4B8E4B;
    }

    .thumbnail {
        opacity: 0.70;
        -webkit-transition: all 0.5s;
        transition: all 0.5s;
    }

        .thumbnail:hover {
            opacity: 1.00;
            box-shadow: 0px 0px 10px #4bc6ff;
        }

    .line {
        margin-bottom: 5px;
    }

    ");
            EndContext();
            BeginContext(728, 504, true);
            WriteLiteral(@"@media screen and (max-width: 770px) {
        .right {
            float: left;
            width: 100%;
        }
    }

    .product_view .modal-dialog {
        max-width: 800px;
        width: 100%;
    }

    .pre-cost {
        text-decoration: line-through;
        color: #a5a5a5;
    }

    .space-ten {
        padding: 10px 0;
    }
</style>
<div class=""container"">

    <h1>Vitrine de Produtos</h1>
    <br />
    <div class=""row"">
        <!-- BEGIN PRODUCTS -->
");
            EndContext();
#line 69 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\DominandoTestesDeSoftware\Testes De Software\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
          
            foreach (var produto in Model.OrderBy(p=>p.CategoriaId))
            {

#line default
#line hidden
            BeginContext(1329, 107, true);
            WriteLiteral("            <div class=\"col-md-3 col-sm-6\">\r\n                <span class=\"thumbnail\">\r\n                    ");
            EndContext();
            BeginContext(1436, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87815c9b2d7922fa84bf3993efca34f7ffcb9cdc7119", async() => {
                BeginContext(1519, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "87815c9b2d7922fa84bf3993efca34f7ffcb9cdc7383", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1554, "~/Images/", 1554, 9, true);
#line 74 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\DominandoTestesDeSoftware\Testes De Software\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
AddHtmlAttributeValue("", 1563, produto.Imagem, 1563, 15, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\DominandoTestesDeSoftware\Testes De Software\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
                                                                              WriteLiteral(produto.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1586, 26, true);
            WriteLiteral("\r\n                    <h4>");
            EndContext();
            BeginContext(1613, 12, false);
#line 75 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\DominandoTestesDeSoftware\Testes De Software\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
                   Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1625, 37, true);
            WriteLiteral("</h4>\r\n                    <p>Apenas ");
            EndContext();
            BeginContext(1663, 25, false);
#line 76 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\DominandoTestesDeSoftware\Testes De Software\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
                         Write(produto.QuantidadeEstoque);

#line default
#line hidden
            EndContext();
            BeginContext(1688, 41, true);
            WriteLiteral(" em estoque!</p>\r\n                    <p>");
            EndContext();
            BeginContext(1730, 17, false);
#line 77 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\DominandoTestesDeSoftware\Testes De Software\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
                  Write(produto.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(1747, 186, true);
            WriteLiteral("</p>\r\n                    <hr class=\"line\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6 col-sm-6\">\r\n                            <p class=\"price\">");
            EndContext();
            BeginContext(1934, 27, false);
#line 81 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\DominandoTestesDeSoftware\Testes De Software\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
                                        Write(produto.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1961, 111, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </span>\r\n            </div>\r\n");
            EndContext();
#line 86 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\DominandoTestesDeSoftware\Testes De Software\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(2098, 55, true);
            WriteLiteral("\r\n        <!-- END PRODUCTS -->\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NerdStore.Catalogo.Application.ViewModels.ProdutoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591