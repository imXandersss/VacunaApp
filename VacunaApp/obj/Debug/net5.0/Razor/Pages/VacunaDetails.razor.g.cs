#pragma checksum "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0923da74f74200b8e60a2d9331278dd43b88d6a2"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/vacunadetails")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/vacunadetails/{id:int}")]
    public partial class VacunaDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Vacuna </h1>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaDetails.razor"
                 vacuna

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
#nullable restore
#line 9 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaDetails.razor"
     if (@mensaje != "")
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "alert alert-danger");
                __builder2.AddAttribute(6, "role", "alert");
#nullable restore
#line 12 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaDetails.razor"
__builder2.AddContent(7, mensaje);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 14 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaDetails.razor"
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
#line 19 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaDetails.razor"
                                                                         vacuna.nombreVacuna

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vacuna.nombreVacuna = __value, vacuna.nombreVacuna));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenElement(19, "tr");
                __builder2.OpenElement(20, "td");
                __builder2.AddAttribute(21, "colspan", "2");
                __builder2.AddAttribute(22, "style", "text-align:center");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "class", "btn btn-success");
                __builder2.AddAttribute(25, "type", "submit");
                __builder2.AddAttribute(26, "value", "Save");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaDetails.razor"
                                                                                    saveVacuna

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.AddMarkupContent(29, "<a href=\"/vacunalist\"><input class=\"btn btn-danger\" type=\"button\" value=\"Cancel\"></a>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\VacunaDetails.razor"
       
    [Parameter]
    public int id { get; set; }

    Vacuna vacuna = new Vacuna();
    private string mensaje = "";

    protected override async Task OnInitializedAsync()
    {
        try
        {
            if (id != 0)
            {
                vacuna = await VacunaService.getVacunaDetails(id);
            }
        }catch(Exception e)
        {
            throw e;
        }
    }



    protected async Task saveVacuna()
    {
        if (vacuna.nombreVacuna==null)
        {
            mensaje = $"No puede haber campos nulos";

        }
        else
        {
            try
            {
                await VacunaService.saveVacuna(vacuna);
                NavigationManager.NavigateTo("/vacunalist");
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVacunaServices VacunaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
