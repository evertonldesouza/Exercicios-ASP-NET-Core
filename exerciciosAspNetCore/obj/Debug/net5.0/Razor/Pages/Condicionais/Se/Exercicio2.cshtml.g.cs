#pragma checksum "C:\Users\everton.souza\source\exerciciosAspNetCoreRazor-main\Pages\Condicionais\Se\Exercicio2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09b227704afff1399b327e1bf945128e7ffa9e1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjetosWeb.Pages.Condicionais.Se.Pages_Condicionais_Se_Exercicio2), @"mvc.1.0.razor-page", @"/Pages/Condicionais/Se/Exercicio2.cshtml")]
namespace ProjetosWeb.Pages.Condicionais.Se
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09b227704afff1399b327e1bf945128e7ffa9e1d", @"/Pages/Condicionais/Se/Exercicio2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cea47c1dec60d7a6a88f78d8cd7630707b7504b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Condicionais_Se_Exercicio2 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\everton.souza\source\exerciciosAspNetCoreRazor-main\Pages\Condicionais\Se\Exercicio2.cshtml"
  
    ViewData["Title"]="Banco";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1 class=""text-center display-4"">Estrutura Condicional - If</h1>
<h2 class=""text-center display-4"">Exerc??cio 2</h2>
<p>Crie um formul??rio para ler: n??mero da conta do cliente, saldo, d??bito e cr??dito. Ap??s, calcular e
escrever o saldo atual (saldo atual = saldo - d??bito + cr??dito). Tamb??m testar se saldo atual for maior
ou igual a zero escrever a mensagem 'Saldo Positivo', sen??o escrever a mensagem 'Saldo Negativo'.</p>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09b227704afff1399b327e1bf945128e7ffa9e1d4100", async() => {
                WriteLiteral("\n   \n    <h1 class= \"mt-3 text-center\">");
#nullable restore
#line 14 "C:\Users\everton.souza\source\exerciciosAspNetCoreRazor-main\Pages\Condicionais\Se\Exercicio2.cshtml"
                             Write(ViewData["Resultado"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
    <div class=""form-row"">
        <div class=""form-group col-5"">
            <label for=""Conta"">N??mero da conta</label>
            <input type=""number"" class=""form-control"" id=""Conta"" name=""Conta"" required>
        </div>
        <div class=""form-group col-5 "">
            <label for=""Saldo"">Saldo</label>
            <input type=""number"" class=""form-control"" id=""Saldo"" name=""Saldo"" required>
        </div>
        <div class=""form-group col-5"">
            <label for=""Debito"">D??bito</label>
            <input type=""number"" class=""form-control"" id=""Debito"" name=""Debito"" required>
        </div>
        <div class=""form-group col-5 "">
            <label for=""Credito"">Cr??dito</label>
            <input type=""number"" class=""form-control"" id=""Credito"" name=""Credito"" required>
        </div>
    </div>
    <button type=""submit"" class=""btn btn-primary"">Calcular</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exercicios.Pages.Condicionais.Se.Exercicio2Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicios.Pages.Condicionais.Se.Exercicio2Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicios.Pages.Condicionais.Se.Exercicio2Model>)PageContext?.ViewData;
        public Exercicios.Pages.Condicionais.Se.Exercicio2Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
