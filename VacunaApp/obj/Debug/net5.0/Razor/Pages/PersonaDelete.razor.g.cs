#pragma checksum "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d63606a41f373c0a501ebc0f11a4cd929897d64"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/personadelete/{id:int}")]
    public partial class PersonaDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<p style=\"color:red; text-align:center\">¿Estás seguro de que quieres eliminarlo?</p>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDelete.razor"
                 persona

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "table");
                __builder2.AddAttribute(5, "class", "table");
                __builder2.OpenElement(6, "tr");
                __builder2.AddMarkupContent(7, "<td>Nombre</td>\r\n            ");
                __builder2.OpenElement(8, "td");
                __builder2.OpenElement(9, "input");
                __builder2.AddAttribute(10, "class", "form-control col-sm-4");
                __builder2.AddAttribute(11, "type", "text");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDelete.razor"
                                                                         persona.nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.nombre = __value, persona.nombre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n\r\n        ");
                __builder2.OpenElement(15, "tr");
                __builder2.AddMarkupContent(16, "<td>Apellido</td>\r\n            ");
                __builder2.OpenElement(17, "td");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "class", "form-control col-sm-4");
                __builder2.AddAttribute(20, "type", "text");
                __builder2.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDelete.razor"
                                                                         persona.apellido

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.apellido = __value, persona.apellido));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenElement(24, "tr");
                __builder2.AddMarkupContent(25, "<td>Cedula</td>\r\n            ");
                __builder2.OpenElement(26, "td");
                __builder2.OpenElement(27, "input");
                __builder2.AddAttribute(28, "class", "form-control col-sm-4");
                __builder2.AddAttribute(29, "type", "text");
                __builder2.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDelete.razor"
                                                                         persona.cedula

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.cedula = __value, persona.cedula));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenElement(33, "tr");
                __builder2.AddMarkupContent(34, "<td>Telefono</td>\r\n            ");
                __builder2.OpenElement(35, "td");
                __builder2.OpenElement(36, "input");
                __builder2.AddAttribute(37, "class", "form-control col-sm-4");
                __builder2.AddAttribute(38, "type", "text");
                __builder2.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDelete.razor"
                                                                         persona.telefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.telefono = __value, persona.telefono));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.OpenElement(42, "tr");
                __builder2.AddMarkupContent(43, "<td>Fecha de Nacimiento</td>\r\n            ");
                __builder2.OpenElement(44, "td");
                __builder2.OpenElement(45, "input");
                __builder2.AddAttribute(46, "class", "form-control col-sm-4");
                __builder2.AddAttribute(47, "type", "text");
                __builder2.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDelete.razor"
                                                                         persona.fechaNacimiento

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.fechaNacimiento = __value, persona.fechaNacimiento));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n\r\n        ");
                __builder2.OpenElement(51, "tr");
                __builder2.AddMarkupContent(52, "<td>Fecha</td>\r\n            ");
                __builder2.OpenElement(53, "td");
                __builder2.OpenElement(54, "input");
                __builder2.AddAttribute(55, "class", "form-control col-sm-4");
                __builder2.AddAttribute(56, "type", "text");
                __builder2.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDelete.razor"
                                                                         persona.fecha

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.fecha = __value, persona.fecha));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n\r\n        ");
                __builder2.OpenElement(60, "tr");
                __builder2.OpenElement(61, "td");
                __builder2.AddAttribute(62, "colspan", "2");
                __builder2.AddAttribute(63, "style", "text-align:center");
                __builder2.OpenElement(64, "input");
                __builder2.AddAttribute(65, "class", "btn btn-success");
                __builder2.AddAttribute(66, "type", "submit");
                __builder2.AddAttribute(67, "value", "Delete");
                __builder2.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDelete.razor"
                                                                                      deletePersona

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                ");
                __builder2.AddMarkupContent(70, "<a href=\"/personalist\"><input class=\"btn btn-danger\" type=\"button\" value=\"Cancel\"></a>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDelete.razor"
       
    [Parameter]
    public int id { get; set; }

    private Persona persona = new Persona();

    protected override async Task OnInitializedAsync()
    {
        persona = await PersonaService.getPersonaDetails(id);
    }


    protected async Task deletePersona()
    {
        await PersonaService.deletePersona(id);
        NavigationManager.NavigateTo("/personalist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonasServices PersonaService { get; set; }
    }
}
#pragma warning restore 1591
