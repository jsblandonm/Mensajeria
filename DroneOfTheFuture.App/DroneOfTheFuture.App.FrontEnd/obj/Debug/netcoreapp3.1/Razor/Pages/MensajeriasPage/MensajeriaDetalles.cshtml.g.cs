#pragma checksum "C:\Users\jsbla\Desktop\MTIC\Desarrollo de Software\Drones_1\DroneOfTheFuture.App\DroneOfTheFuture.App.FrontEnd\Pages\MensajeriasPage\MensajeriaDetalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49f844c278015c667c1f8c8b992ebfa2065b1870"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DroneOfTheFuture.App.FrontEnd.Pages.MensajeriasPage.Pages_MensajeriasPage_MensajeriaDetalles), @"mvc.1.0.razor-page", @"/Pages/MensajeriasPage/MensajeriaDetalles.cshtml")]
namespace DroneOfTheFuture.App.FrontEnd.Pages.MensajeriasPage
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49f844c278015c667c1f8c8b992ebfa2065b1870", @"/Pages/MensajeriasPage/MensajeriaDetalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a58395e053038731b0b029536861a153a83f3b1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MensajeriasPage_MensajeriaDetalles : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\jsbla\Desktop\MTIC\Desarrollo de Software\Drones_1\DroneOfTheFuture.App\DroneOfTheFuture.App.FrontEnd\Pages\MensajeriasPage\MensajeriaDetalles.cshtml"
  
    ViewData["Title"] = "MensajeriaDetalles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\jsbla\Desktop\MTIC\Desarrollo de Software\Drones_1\DroneOfTheFuture.App\DroneOfTheFuture.App.FrontEnd\Pages\MensajeriasPage\MensajeriaDetalles.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div>
    <table>
        <table class=""table"">
            <tr>
                <th>Cantidad de drones</th>
                <th>Empleado a cargo</th>
                <th>Fecha de despacho</th>
            </tr>
            <tr>
                <td>");
#nullable restore
#line 18 "C:\Users\jsbla\Desktop\MTIC\Desarrollo de Software\Drones_1\DroneOfTheFuture.App\DroneOfTheFuture.App.FrontEnd\Pages\MensajeriasPage\MensajeriaDetalles.cshtml"
               Write(Model.laMensajeria.Drones);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\jsbla\Desktop\MTIC\Desarrollo de Software\Drones_1\DroneOfTheFuture.App\DroneOfTheFuture.App.FrontEnd\Pages\MensajeriasPage\MensajeriaDetalles.cshtml"
               Write(Model.laMensajeria.Empleados);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\jsbla\Desktop\MTIC\Desarrollo de Software\Drones_1\DroneOfTheFuture.App\DroneOfTheFuture.App.FrontEnd\Pages\MensajeriasPage\MensajeriaDetalles.cshtml"
               Write(Model.laMensajeria.Drieccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DroneOfTheFuture.App.FrontEnd.Pages.MensajeriasPage.MensajeriaDetalles> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DroneOfTheFuture.App.FrontEnd.Pages.MensajeriasPage.MensajeriaDetalles> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DroneOfTheFuture.App.FrontEnd.Pages.MensajeriasPage.MensajeriaDetalles>)PageContext?.ViewData;
        public DroneOfTheFuture.App.FrontEnd.Pages.MensajeriasPage.MensajeriaDetalles Model => ViewData.Model;
    }
}
#pragma warning restore 1591
