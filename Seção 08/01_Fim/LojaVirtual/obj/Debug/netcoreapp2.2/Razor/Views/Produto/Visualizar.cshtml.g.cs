#pragma checksum "C:\Users\alyss\Desktop\ASPNETCoreMVCLojaVirtual\Seção 08\01_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "519ed3f85f0481175d98c752ef98e2fcf530629f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Visualizar.cshtml", typeof(AspNetCore.Views_Produto_Visualizar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"519ed3f85f0481175d98c752ef98e2fcf530629f", @"/Views/Produto/Visualizar.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\alyss\Desktop\ASPNETCoreMVCLojaVirtual\Seção 08\01_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
  
    ViewData["Title"] = "Visualizar";

#line default
#line hidden
            BeginContext(81, 23, true);
            WriteLiteral("\r\n<h2>Produto</h2>\r\n<b>");
            EndContext();
            BeginContext(105, 8, false);
#line 7 "C:\Users\alyss\Desktop\ASPNETCoreMVCLojaVirtual\Seção 08\01_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(113, 15, true);
            WriteLiteral("</b><br />\r\n<b>");
            EndContext();
            BeginContext(129, 10, false);
#line 8 "C:\Users\alyss\Desktop\ASPNETCoreMVCLojaVirtual\Seção 08\01_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(139, 15, true);
            WriteLiteral("</b><br />\r\n<b>");
            EndContext();
            BeginContext(155, 15, false);
#line 9 "C:\Users\alyss\Desktop\ASPNETCoreMVCLojaVirtual\Seção 08\01_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
Write(Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(170, 15, true);
            WriteLiteral("</b><br />\r\n<b>");
            EndContext();
            BeginContext(186, 25, false);
#line 10 "C:\Users\alyss\Desktop\ASPNETCoreMVCLojaVirtual\Seção 08\01_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
Write(Model.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(211, 10, true);
            WriteLiteral("</b>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
