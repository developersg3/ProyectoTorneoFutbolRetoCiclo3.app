#pragma checksum "C:\Users\SOLID\Documents\TorneoFutbolRetoCiclo3.app\TorneoFutbolRetoCiclo3.App.Frontend\Pages\Desempeno_equipos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07d157c87499306a7c7298283632a4b8404335a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TorneoFutbolRetoCiclo3.App.Frontend.Pages.Desempeno_equipos.Pages_Desempeno_equipos_Details), @"mvc.1.0.razor-page", @"/Pages/Desempeno_equipos/Details.cshtml")]
namespace TorneoFutbolRetoCiclo3.App.Frontend.Pages.Desempeno_equipos
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
#line 1 "C:\Users\SOLID\Documents\TorneoFutbolRetoCiclo3.app\TorneoFutbolRetoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using TorneoFutbolRetoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07d157c87499306a7c7298283632a4b8404335a0", @"/Pages/Desempeno_equipos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a08f8b36c02e73fb38f3b5a7589978e07cef4e2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Desempeno_equipos_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalles del Desempeño</h1>\r\n<table class=\"table table-dark\">\r\n    <tr>\r\n        <th scope=\"col\" asp-for=\"desempeno_equipo.cantidad_partidos_jugados\">Cantidad de partidos jugados</th>\r\n        <td>");
#nullable restore
#line 9 "C:\Users\SOLID\Documents\TorneoFutbolRetoCiclo3.app\TorneoFutbolRetoCiclo3.App.Frontend\Pages\Desempeno_equipos\Details.cshtml"
       Write(Model.desempeno_equipo.cantidad_partidos_jugados);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\" asp-for=\"desempeno_equipo.cantidad_partidos_ganados\">Cantidad de partidos ganados</th>\r\n        <td>");
#nullable restore
#line 13 "C:\Users\SOLID\Documents\TorneoFutbolRetoCiclo3.app\TorneoFutbolRetoCiclo3.App.Frontend\Pages\Desempeno_equipos\Details.cshtml"
       Write(Model.desempeno_equipo.cantidad_partidos_ganados);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\" asp-for=\"desempeno_equipo.cantidad_partidos_empatados\">Cantidad de partidos empatados</th>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\SOLID\Documents\TorneoFutbolRetoCiclo3.app\TorneoFutbolRetoCiclo3.App.Frontend\Pages\Desempeno_equipos\Details.cshtml"
       Write(Model.desempeno_equipo.cantidad_partidos_empatados);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\" asp-for=\"desempeno_equipo.cantidad_goles_a_favor\">Cantidad goles a favor</th>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\SOLID\Documents\TorneoFutbolRetoCiclo3.app\TorneoFutbolRetoCiclo3.App.Frontend\Pages\Desempeno_equipos\Details.cshtml"
       Write(Model.desempeno_equipo.cantidad_goles_a_favor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\" asp-for=\"desempeno_equipo.cantidad_goles_en_contra\">Cantidad goles en contra</th>\r\n        <td>");
#nullable restore
#line 25 "C:\Users\SOLID\Documents\TorneoFutbolRetoCiclo3.app\TorneoFutbolRetoCiclo3.App.Frontend\Pages\Desempeno_equipos\Details.cshtml"
       Write(Model.desempeno_equipo.cantidad_goles_en_contra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\" asp-for=\"desempeno_equipo.cantidad_puntos\">Cantidad puntos</th>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\SOLID\Documents\TorneoFutbolRetoCiclo3.app\TorneoFutbolRetoCiclo3.App.Frontend\Pages\Desempeno_equipos\Details.cshtml"
       Write(Model.desempeno_equipo.cantidad_puntos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\" asp-for=\"desempeno_equipo.EquipoId\">Nombre del equipo</th>\r\n        <td>");
#nullable restore
#line 33 "C:\Users\SOLID\Documents\TorneoFutbolRetoCiclo3.app\TorneoFutbolRetoCiclo3.App.Frontend\Pages\Desempeno_equipos\Details.cshtml"
       Write(Model.desempeno_equipo.EquipoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d157c87499306a7c7298283632a4b8404335a07059", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TorneoFutbolRetoCiclo3.App.Frontend.Pages.Desempeno_equipos.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbolRetoCiclo3.App.Frontend.Pages.Desempeno_equipos.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbolRetoCiclo3.App.Frontend.Pages.Desempeno_equipos.DetailsModel>)PageContext?.ViewData;
        public TorneoFutbolRetoCiclo3.App.Frontend.Pages.Desempeno_equipos.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
