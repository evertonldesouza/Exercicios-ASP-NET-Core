#pragma checksum "C:\Users\everton.souza\source\exerciciosAspNetCoreRazor-main\Pages\Condicionais\Escolha\Exercicio1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2b7769e9a8ff068c598948b981323a849374280"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjetosWeb.Pages.Condicionais.Escolha.Pages_Condicionais_Escolha_Exercicio1), @"mvc.1.0.razor-page", @"/Pages/Condicionais/Escolha/Exercicio1.cshtml")]
namespace ProjetosWeb.Pages.Condicionais.Escolha
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
#line 1 "C:\Users\everton.souza\source\exerciciosAspNetCoreRazor-main\Pages\_ViewImports.cshtml"
using ProjetosWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2b7769e9a8ff068c598948b981323a849374280", @"/Pages/Condicionais/Escolha/Exercicio1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cea47c1dec60d7a6a88f78d8cd7630707b7504b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Condicionais_Escolha_Exercicio1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-6 offset-md-3 col-sm-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\everton.souza\source\exerciciosAspNetCoreRazor-main\Pages\Condicionais\Escolha\Exercicio1.cshtml"
  
    ViewData["Title"]="IMC";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center display-4"">Estrutura Condicional - Switch</h1>
<h2 class=""text-center display-4"">Exercício 1</h2>
<p>Construa um algoritmo para determinar se o indivíduo está com um peso favorável.
    Essa situação é determinada através do IMC (Índice de Massa Corpórea), que é 
    definida como sendo a relação entre o peso e o quadrado da altura do indivíduo.
    Em seguida, verificar a situação da pessoa.
</p>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2b7769e9a8ff068c598948b981323a8493742804508", async() => {
                WriteLiteral(@"
    <div class=""form-row"">
        <div class=""form-group col-md-6 col-sm-12"">
            <label for=""Peso"">Informe seu peso</label>
            <input type=""text"" placeholder= ""Peso"" class=""form-control"" id=""Peso"" name=""Peso"" required>
        </div>
        <div class=""form-group col-md-6 col-sm-12"">
            <label for=""Altura"">Altura</label>
            <input type=""text"" placeholder=""Altura"" class=""form-control"" id=""Altura"" name=""Altura"" required>
        </div>
    </div>
    <button type=""submit"" class=""btn btn-primary"">Calcular</button>
    <h1 class= ""mt-3 text-center"">");
#nullable restore
#line 27 "C:\Users\everton.souza\source\exerciciosAspNetCoreRazor-main\Pages\Condicionais\Escolha\Exercicio1.cshtml"
                             Write(ViewData["Resultado"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exercicios.Pages.Condicionais.Escolha.Exercicio1Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicios.Pages.Condicionais.Escolha.Exercicio1Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicios.Pages.Condicionais.Escolha.Exercicio1Model>)PageContext?.ViewData;
        public Exercicios.Pages.Condicionais.Escolha.Exercicio1Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
