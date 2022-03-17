#pragma checksum "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a3d6c69228b1233b80ff46c102df0dc926bc567"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/personalist")]
    public partial class PersonaList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div><a href=\"/personadetails\"><i>Agregar vacunado</i></a></div>");
#nullable restore
#line 9 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaList.razor"
 if (personas == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading..</em></p>");
#nullable restore
#line 12 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaList.razor"
}
else {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><th>Nombre</th>\r\n    <th>Apellido</th>\r\n    <th>Cedula</th>\r\n    <th>Vacuna</th>\r\n    <th>Provincia</th>\r\n    <th></th>\r\n    <th></th></thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 27 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaList.razor"
             foreach (var persona in personas)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
#nullable restore
#line 30 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaList.razor"
__builder.AddContent(8, persona.nombre);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "td");
#nullable restore
#line 31 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaList.razor"
__builder.AddContent(11, persona.apellido);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 32 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaList.razor"
__builder.AddContent(14, persona.cedula);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 33 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaList.razor"
__builder.AddContent(17, persona.vacunaRecibida);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 34 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaList.razor"
__builder.AddContent(20, persona.provincia);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", "/personadetails/" + (
#nullable restore
#line 35 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaList.razor"
                                          persona.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "td");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "href", "/personadelete/" + (
#nullable restore
#line 36 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaList.razor"
                                         persona.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Eliminar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaList.razor"
       
    public IEnumerable<Persona> personas { get; set; }
    public string mensaje;
    protected override async Task OnInitializedAsync()
    {
        try
        {
            personas = await PersonaService.getAllPersonas();

        }catch(Exception error)
        {
            mensaje = error.Message;
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonasServices PersonaService { get; set; }
    }
}
#pragma warning restore 1591
