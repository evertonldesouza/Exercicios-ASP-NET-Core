#pragma checksum "D:\github\Exercicios-ASP-NET-Core\exerciciosAspNetCoreRazor-main\Pages\Repeticao\Enquanto\Exercicio3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd6d446d018f4a32d40a1dbf89cc72aaaf2b8a1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjetosWeb.Pages.Repeticao.Enquanto.Pages_Repeticao_Enquanto_Exercicio3), @"mvc.1.0.razor-page", @"/Pages/Repeticao/Enquanto/Exercicio3.cshtml")]
namespace ProjetosWeb.Pages.Repeticao.Enquanto
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\github\Exercicios-ASP-NET-Core\exerciciosAspNetCoreRazor-main\Pages\_ViewImports.cshtml"
using ProjetosWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd6d446d018f4a32d40a1dbf89cc72aaaf2b8a1e", @"/Pages/Repeticao/Enquanto/Exercicio3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cea47c1dec60d7a6a88f78d8cd7630707b7504b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Repeticao_Enquanto_Exercicio3 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-4 offset-md-4 col-sm-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\github\Exercicios-ASP-NET-Core\exerciciosAspNetCoreRazor-main\Pages\Repeticao\Enquanto\Exercicio3.cshtml"
  
    ViewData["Title"] = "Fatorial";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"text-center display-4\">Estrutura de Repetição - WHILE</h1>\n<h2 class=\"text-center display-4\">Exercício 3</h2>\n\n<p class=\"text-center\">\n   Faça um algoritmo que calcula o fatorial de um número inteiro fornecido pelo usuário\n</p>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd6d446d018f4a32d40a1dbf89cc72aaaf2b8a1e4335", async() => {
                WriteLiteral("\n    <div class=\"form-group\">\n        <label for=\"Numero\">Informe o número</label>\n        <input type=\"number\" class=\"form-control\" id=\"Numero\" name=\"Numero\" required>\n    </div>\n   \n    <button type=\"submit\" class=\"btn btn-primary\">Calcular</button>\n");
#nullable restore
#line 21 "D:\github\Exercicios-ASP-NET-Core\exerciciosAspNetCoreRazor-main\Pages\Repeticao\Enquanto\Exercicio3.cshtml"
     if(ViewData["Fatorial"] != null){

#line default
#line hidden
#nullable disable
                WriteLiteral("        <table class=\"table table-striped my-3\">\n");
#nullable restore
#line 23 "D:\github\Exercicios-ASP-NET-Core\exerciciosAspNetCoreRazor-main\Pages\Repeticao\Enquanto\Exercicio3.cshtml"
             foreach (var linha in ViewBag.Fatorial)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 26 "D:\github\Exercicios-ASP-NET-Core\exerciciosAspNetCoreRazor-main\Pages\Repeticao\Enquanto\Exercicio3.cshtml"
                   Write(linha);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 28 "D:\github\Exercicios-ASP-NET-Core\exerciciosAspNetCoreRazor-main\Pages\Repeticao\Enquanto\Exercicio3.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\n");
#nullable restore
#line 30 "D:\github\Exercicios-ASP-NET-Core\exerciciosAspNetCoreRazor-main\Pages\Repeticao\Enquanto\Exercicio3.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script src=\"//cdn.jsdelivr.net/npm/sweetalert2@11\"></script>\n    <script type=\"text/javascript\">\n    let erro = \'");
#nullable restore
#line 36 "D:\github\Exercicios-ASP-NET-Core\exerciciosAspNetCoreRazor-main\Pages\Repeticao\Enquanto\Exercicio3.cshtml"
           Write(Html.Raw(ViewData["Erro"]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\n    if (erro != \'\'){\n        Swal.fire(\n            \'");
#nullable restore
#line 39 "D:\github\Exercicios-ASP-NET-Core\exerciciosAspNetCoreRazor-main\Pages\Repeticao\Enquanto\Exercicio3.cshtml"
        Write(Html.Raw(ViewData["Title"]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\n            erro,\n            \'error\'\n        );\n    }\n    </script>\n");
            }
            );
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exercicios.Pages.Repeticao.Enquanto.Exercicio3Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicios.Pages.Repeticao.Enquanto.Exercicio3Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicios.Pages.Repeticao.Enquanto.Exercicio3Model>)PageContext?.ViewData;
        public Exercicios.Pages.Repeticao.Enquanto.Exercicio3Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
