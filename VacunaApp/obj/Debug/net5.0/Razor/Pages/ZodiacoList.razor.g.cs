#pragma checksum "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4169961d82b75464484ba314c88b1591283b092"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/zodiacolist")]
    public partial class ZodiacoList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><b>Reporte de Signos del Zodiaco</b></h3>\r\n<br>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-bordered");
            __builder.AddMarkupContent(3, "<thead><tr><th>Signo</th>\r\n            <th>Cantidad</th></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
#nullable restore
#line 13 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(7, signo[0]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "td");
#nullable restore
#line 14 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(10, capri);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
#nullable restore
#line 17 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(14, signo[1]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 18 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(17, acua);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
#nullable restore
#line 21 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(21, signo[2]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 22 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(24, pis);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "tr");
            __builder.OpenElement(27, "td");
#nullable restore
#line 25 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(28, signo[3]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "td");
#nullable restore
#line 26 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(31, ari);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "tr");
            __builder.OpenElement(34, "td");
#nullable restore
#line 29 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(35, signo[4]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "td");
#nullable restore
#line 30 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(38, tau);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "tr");
            __builder.OpenElement(41, "td");
#nullable restore
#line 33 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(42, signo[5]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "td");
#nullable restore
#line 34 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(45, gem);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "tr");
            __builder.OpenElement(48, "td");
#nullable restore
#line 37 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(49, signo[6]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "td");
#nullable restore
#line 38 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(52, can);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "tr");
            __builder.OpenElement(55, "td");
#nullable restore
#line 41 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(56, signo[7]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "td");
#nullable restore
#line 42 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(59, leo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.OpenElement(61, "tr");
            __builder.OpenElement(62, "td");
#nullable restore
#line 45 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(63, signo[8]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.OpenElement(65, "td");
#nullable restore
#line 46 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(66, vir);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.OpenElement(68, "tr");
            __builder.OpenElement(69, "td");
#nullable restore
#line 49 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(70, signo[9]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "td");
#nullable restore
#line 50 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(73, lib);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.OpenElement(75, "tr");
            __builder.OpenElement(76, "td");
#nullable restore
#line 53 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(77, signo[10]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.OpenElement(79, "td");
#nullable restore
#line 54 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(80, esc);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.OpenElement(82, "tr");
            __builder.OpenElement(83, "td");
#nullable restore
#line 57 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(84, signo[11]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.OpenElement(86, "td");
#nullable restore
#line 58 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
__builder.AddContent(87, sag);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\xander\source\repos\VacunaApp\VacunaApp\Pages\ZodiacoList.razor"
       
    MyPersonaContext db = new MyPersonaContext();
    List<Persona> lstPersonas = new List<Persona>();
    DateTime fecha = new DateTime();
    string zodiaco;
    int capri, acua, pis, ari, tau, gem, can, leo, vir, lib, esc, sag;
    List<string> signo = new List<string>() { "Capricornio", "Acuario", "Piscis", "Aries", "Tauro", "Geminis", "Cancer", "Leo", "Virgo", "Libra", "Escorpio", "Sagitario" };
    List<int> fechas = new List<int>() { 20, 19, 20, 20, 21, 21, 22, 22, 22, 22, 22, 21 };


    protected override void OnInitialized()
    {
        lstPersonas = db.Personas.ToList();
        foreach (var i in lstPersonas)
        {
            fecha = Convert.ToDateTime(i.fechaNacimiento);

            int dia = fecha.Day;
            int mes = fecha.Month;
            int year = fecha.Year;

            mes = mes - 1;
            if (dia > fechas[mes])
            {
                mes = mes + 1;
            }
            zodiaco = signo[mes];

            if (zodiaco == "Capricornio")
            {
                capri++;
            }
            else if (zodiaco == "Acuario")
            {
                acua++;
            }
            else if (zodiaco == "Piscis")
            {
                pis++;
            }
            else if (zodiaco == "Aries")
            {
                ari++;
            }
            else if (zodiaco == "Tauro")
            {
                tau++;
            }
            else if (zodiaco == "Geminis")
            {
                gem++;
            }
            else if (zodiaco == "Cancer")
            {
                can++;
            }
            else if (zodiaco == "Leo")
            {
                leo++;
            }
            else if (zodiaco == "Virgo")
            {
                vir++;
            }
            else if (zodiaco == "Libra")
            {
                lib++;
            }
            else if (zodiaco == "Escorpio")
            {
                esc++;
            }
            else if (zodiaco == "Sagitario")
            {
                sag++;
            }
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591