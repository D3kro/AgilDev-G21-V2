#pragma checksum "D:\Escritorio\MisionTicAutos\AGILDEV-G21\frontend\Pages\Shared\_navView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e16044a4e2059c37c2d41dcb2dea8ee4a9393375"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(frontend.Pages.Shared.Pages_Shared__navView), @"mvc.1.0.view", @"/Pages/Shared/_navView.cshtml")]
namespace frontend.Pages.Shared
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
#line 1 "D:\Escritorio\MisionTicAutos\AGILDEV-G21\frontend\Pages\_ViewImports.cshtml"
using frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e16044a4e2059c37c2d41dcb2dea8ee4a9393375", @"/Pages/Shared/_navView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"900db365c46cea34bb4e0129831d6a7fb099d04c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__navView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<nav class=""nav"">
    <ol>
        <li><a href=""/views/RegistrarRevisiones"">Registrar Revisiones</a></li>
        <li><a href=""/views/ConsultarRevisiones"">Consultar Revisiones</a></li>
        <li><a href=""/views/ConsultarCliente"">Consultar Clientes</a></li>
        <li><a href=""/"">Salir</a></li>
    </ol>
</nav>");
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
