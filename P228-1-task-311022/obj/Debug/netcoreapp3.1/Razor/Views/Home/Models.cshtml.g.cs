#pragma checksum "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Models.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93941acbee0a08209e092e7a27f03577e5278827"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Models), @"mvc.1.0.view", @"/Views/Home/Models.cshtml")]
namespace AspNetCore
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
#line 2 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\_ViewImports.cshtml"
using P228_1_task_311022.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\_ViewImports.cshtml"
using P228_1_task_311022.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93941acbee0a08209e092e7a27f03577e5278827", @"/Views/Home/Models.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4d74f386ec3bb6db02459234c4903170e2cab3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Models : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Models.cshtml"
  
    ViewData["Title"] = "Models"; 
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Models</h1>\n<p>id: ");
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Models.cshtml"
  Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(", name:");
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Models.cshtml"
                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n");
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Models.cshtml"
     if (Model.Cars != null && Model.Cars.Count > 0)
     {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Models.cshtml"
         foreach (Car car in Model.Cars)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\n                <a asp-controller=\"home\"  asp-action=\"models\"");
            BeginWriteAttribute("asp-route-id", "asp-route-id=\"", 303, "\"", 324, 1);
#nullable restore
#line 14 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Models.cshtml"
WriteAttributeValue("", 317, car.Id, 317, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> id: ");
#nullable restore
#line 14 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Models.cshtml"
                                                                                    Write(car.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , name: ");
#nullable restore
#line 14 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Models.cshtml"
                                                                                                    Write(car.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n            </p>\n");
#nullable restore
#line 16 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Models.cshtml"
         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Models.cshtml"
                   
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Model> Html { get; private set; }
    }
}
#pragma warning restore 1591
