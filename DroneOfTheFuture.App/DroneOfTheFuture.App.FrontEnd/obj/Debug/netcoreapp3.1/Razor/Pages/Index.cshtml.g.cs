#pragma checksum "C:\Users\jsbla\Desktop\MTIC\Desarrollo de Software\Drones_1\DroneOfTheFuture.App\DroneOfTheFuture.App.FrontEnd\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "215be2ae0be9e95a07151537ef004a611f18d393"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DroneOfTheFuture.App.FrontEnd.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace DroneOfTheFuture.App.FrontEnd.Pages
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
#line 1 "C:\Users\jsbla\Desktop\MTIC\Desarrollo de Software\Drones_1\DroneOfTheFuture.App\DroneOfTheFuture.App.FrontEnd\Pages\_ViewImports.cshtml"
using DroneOfTheFuture.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"215be2ae0be9e95a07151537ef004a611f18d393", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a58395e053038731b0b029536861a153a83f3b1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\jsbla\Desktop\MTIC\Desarrollo de Software\Drones_1\DroneOfTheFuture.App\DroneOfTheFuture.App.FrontEnd\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-center"">
    <h1 class=""display-4"">Bienvenidos</h1>
    <p>Ingrese a La Tienda y<a href=""https://www.mercadolibre.com.co/"">Compra tus articulos</a>.</p>
</div>
<div>
    <h1>
        <img src=""https://img.freepik.com/vector-gratis/hombre-recibiendo-paquete-dron_23-2147702671.jpg?w=2000"" alt=""Drones"" class=""center"">
    </h1>
    <h5 class=""texto"">
        Las restricciones de circulación que imponen muchas ciudades,los crecientes atascos y retenciones en los
        momentos pico
        del día, así como los problemas de estacionamiento en muchas áreas o la limitada flexibilidad que ofrece el
        transporte
        por carretera ante las demandas de inmediatez y agilidad de los clientes del siglo XXI.
        Por todo esto, desarrollamos un sistema como alternativa que solvente todos estos problemas. Y, de paso,
        ofrezcan un mejor
        servicio a los consumidores y reduzcan la huella medioambiental en los desplazamientos de mercancías.
        Drones voladores ");
            WriteLiteral(@"capaces de entregarnos sus pedidos en la puerta de su casa.
        Somos comprometidos con la entrega de paquetes y mensajería, tenemos un sistema que comunica en tiempo real el
        estado
        del paquete mientras espera por el. Nuestros clientes son la prioridad por ello se asigna un encargado que hace
        seguimiento del pedido, y el cual está disponible para solventar todas sus dudas.
    </h5>

</div>

<div  class=""table"">
");
#nullable restore
#line 33 "C:\Users\jsbla\Desktop\MTIC\Desarrollo de Software\Drones_1\DroneOfTheFuture.App\DroneOfTheFuture.App.FrontEnd\Pages\Index.cshtml"
     if(User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-sm\">\r\n");
#nullable restore
#line 36 "C:\Users\jsbla\Desktop\MTIC\Desarrollo de Software\Drones_1\DroneOfTheFuture.App\DroneOfTheFuture.App.FrontEnd\Pages\Index.cshtml"
         foreach (var claim in User.Claims)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\jsbla\Desktop\MTIC\Desarrollo de Software\Drones_1\DroneOfTheFuture.App\DroneOfTheFuture.App.FrontEnd\Pages\Index.cshtml"
               Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\jsbla\Desktop\MTIC\Desarrollo de Software\Drones_1\DroneOfTheFuture.App\DroneOfTheFuture.App.FrontEnd\Pages\Index.cshtml"
               Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\jsbla\Desktop\MTIC\Desarrollo de Software\Drones_1\DroneOfTheFuture.App\DroneOfTheFuture.App.FrontEnd\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 44 "C:\Users\jsbla\Desktop\MTIC\Desarrollo de Software\Drones_1\DroneOfTheFuture.App\DroneOfTheFuture.App.FrontEnd\Pages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591