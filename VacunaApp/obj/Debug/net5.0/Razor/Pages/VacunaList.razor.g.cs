#pragma checksum "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12368446feaecccbdd38349fd5e13d3344dda7ed"
// <auto-generated/>
#pragma warning disable 1591
namespace VacunaApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\_Imports.razor"
using VacunaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\_Imports.razor"
using VacunaApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\_Imports.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vacunalist")]
    public partial class VacunaList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div><a href=\"/vacunadetails\"><i>Agregar vacuna</i></a></div>");
#nullable restore
#line 8 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaList.razor"
 if (vacunas == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading..</em></p>");
#nullable restore
#line 11 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaList.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><th>Nombre</th>\r\n        <th></th></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 21 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaList.razor"
             foreach (var vacuna in vacunas)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
#nullable restore
#line 24 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaList.razor"
__builder.AddContent(8, vacuna.nombreVacuna);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "href", "/vacunadetails/" + (
#nullable restore
#line 25 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaList.razor"
                                             vacuna.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "href", "/vacunadelete/" + (
#nullable restore
#line 26 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaList.razor"
                                            vacuna.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Eliminar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaList.razor"
       
    public IEnumerable<Vacuna> vacunas { get; set; }
    public string mensaje;
    protected override async Task OnInitializedAsync()
    {
        try
        {
            vacunas = await VacunaService.getAllVacunas();

        }
        catch (Exception error)
        {
            mensaje = error.Message;
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVacunaServices VacunaService { get; set; }
    }
}
#pragma warning restore 1591
