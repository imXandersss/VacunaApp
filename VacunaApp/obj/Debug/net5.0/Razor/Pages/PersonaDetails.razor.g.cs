#pragma checksum "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48cf2d081b9dc76e2c6b8902490df64b3d8c05b5"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/personadetails")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/personadetails/{id:int}")]
    public partial class PersonaDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Insertar Vacunados</h1>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
                 persona

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
#nullable restore
#line 11 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
     if (@mensaje != "")
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "alert alert-danger");
                __builder2.AddAttribute(6, "role", "alert");
#nullable restore
#line 14 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
__builder2.AddContent(7, mensaje);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 16 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(8, "table");
                __builder2.AddAttribute(9, "class", "table");
                __builder2.OpenElement(10, "tr");
                __builder2.AddMarkupContent(11, "<td>Nombre</td>\r\n            ");
                __builder2.OpenElement(12, "td");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "class", "form-control col-sm-4");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
                                                                         persona.nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.nombre = __value, persona.nombre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n\r\n        ");
                __builder2.OpenElement(19, "tr");
                __builder2.AddMarkupContent(20, "<td>Apellido</td>\r\n            ");
                __builder2.OpenElement(21, "td");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "class", "form-control col-sm-4");
                __builder2.AddAttribute(24, "type", "text");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
                                                                         persona.apellido

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.apellido = __value, persona.apellido));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "tr");
                __builder2.AddMarkupContent(29, "<td>Cedula</td>\r\n            ");
                __builder2.OpenElement(30, "td");
                __builder2.OpenElement(31, "input");
                __builder2.AddAttribute(32, "class", "form-control col-sm-4");
                __builder2.AddAttribute(33, "type", "text");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
                                                                         persona.cedula

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.cedula = __value, persona.cedula));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.OpenElement(37, "tr");
                __builder2.AddMarkupContent(38, "<td>Telefono</td>\r\n            ");
                __builder2.OpenElement(39, "td");
                __builder2.OpenElement(40, "input");
                __builder2.AddAttribute(41, "class", "form-control col-sm-4");
                __builder2.AddAttribute(42, "type", "text");
                __builder2.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
                                                                         persona.telefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.telefono = __value, persona.telefono));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 40 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
         if (vacunas == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(45, "<p><em>Loading..</em></p>");
#nullable restore
#line 43 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(46, "tr");
                __builder2.AddMarkupContent(47, "<td>Vacuna</td>\r\n                ");
                __builder2.OpenElement(48, "td");
                __builder2.OpenElement(49, "select");
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
                                                        persona.vacunaRecibida

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.vacunaRecibida = __value, persona.vacunaRecibida));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(53, "option");
                __builder2.AddAttribute(54, "selected");
                __builder2.AddContent(55, "Seleccione la vacuna");
                __builder2.CloseElement();
#nullable restore
#line 52 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
                         foreach (var vacuna in vacunas)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(56, "option");
#nullable restore
#line 54 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
__builder2.AddContent(57, vacuna.nombreVacuna);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 55 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 59 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
         if (provincias == null)
        {



#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(58, "<p><em>Loading..</em></p>");
#nullable restore
#line 66 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(59, "tr");
                __builder2.AddMarkupContent(60, "<td>Provincias</td>\r\n                ");
                __builder2.OpenElement(61, "td");
                __builder2.OpenElement(62, "select");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 72 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
                                                        persona.provincia

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.provincia = __value, persona.provincia));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(66, "option");
                __builder2.AddContent(67, "Seleccione la provincia");
                __builder2.CloseElement();
#nullable restore
#line 75 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
                         foreach (var prov in provincias)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(68, "option");
#nullable restore
#line 77 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
__builder2.AddContent(69, prov.nombreProvincia);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 78 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 82 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(70, "tr");
                __builder2.AddMarkupContent(71, "<td>Fecha de Nacimiento</td>\r\n            ");
                __builder2.OpenElement(72, "td");
                __builder2.OpenElement(73, "input");
                __builder2.AddAttribute(74, "class", "form-control col-sm-4");
                __builder2.AddAttribute(75, "type", "text");
                __builder2.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 87 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
                                                                         persona.fechaNacimiento

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.fechaNacimiento = __value, persona.fechaNacimiento));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n\r\n        ");
                __builder2.OpenElement(79, "tr");
                __builder2.AddMarkupContent(80, "<td>Fecha</td>\r\n            ");
                __builder2.OpenElement(81, "td");
                __builder2.OpenElement(82, "input");
                __builder2.AddAttribute(83, "class", "form-control col-sm-4");
                __builder2.AddAttribute(84, "type", "text");
                __builder2.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 92 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
                                                                         persona.fecha

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.fecha = __value, persona.fecha));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n\r\n        ");
                __builder2.OpenElement(88, "tr");
                __builder2.OpenElement(89, "td");
                __builder2.AddAttribute(90, "colspan", "2");
                __builder2.AddAttribute(91, "style", "text-align:center");
                __builder2.OpenElement(92, "input");
                __builder2.AddAttribute(93, "class", "btn btn-success");
                __builder2.AddAttribute(94, "type", "submit");
                __builder2.AddAttribute(95, "value", "Save");
                __builder2.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
                                                                                    savePersona

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n                ");
                __builder2.AddMarkupContent(98, "<a href=\"/personalist\"><input class=\"btn btn-danger\" type=\"button\" value=\"Cancel\"></a>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\PersonaDetails.razor"
       

    [Parameter]
    public int id { get; set; }



    private Persona persona = new Persona();
    public IEnumerable<Provincia> provincias;
    public IEnumerable<Vacuna> vacunas;
    private string mensaje="";
    protected override async Task OnInitializedAsync()
    {


        try
        {
            if (id != 0)
            {
                persona = await PersonaService.getPersonaDetails(id);
            }

            vacunas = await VacunaService.getAllVacunas();
            provincias = await ProvinciaService.getAllProvincias();
        }
        catch (Exception e)
        {
            throw e;
        }
    }


    protected async Task savePersona()
    {
        if (persona.nombre == null & persona.apellido == null & persona.cedula == null & persona.provincia == null & persona.vacunaRecibida == null)
        {
            mensaje = $"No puede haber campos nulos";
        }
        else
        {
            try
            {
                await PersonaService.savePersona(persona);
                NavigationManager.NavigateTo("/personalist");
            }
            catch (Exception e)
            {
                throw e;
            }
        }



    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVacunaServices VacunaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProvinciaServices ProvinciaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonasServices PersonaService { get; set; }
    }
}
#pragma warning restore 1591
