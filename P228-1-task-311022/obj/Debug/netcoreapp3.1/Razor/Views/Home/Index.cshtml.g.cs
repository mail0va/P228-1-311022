#pragma checksum "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0802ea60b643ee84ce054cc89d3b9ba13a321cd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Index.cshtml"
using P228_1_task_311022.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0802ea60b643ee84ce054cc89d3b9ba13a321cd1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4d74f386ec3bb6db02459234c4903170e2cab3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Home Index</h1>\r\n\r\n<h2>\r\n    Brands\r\n</h2>\r\n");
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Index.cshtml"
 foreach (Brand brand in Model.Brands)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    <a  asp-controller=\"home\" asp-action=\"models\"");
            BeginWriteAttribute("asp-route-id", "asp-route-id=\"", 240, "\"", 263, 1);
#nullable restore
#line 13 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Index.cshtml"
WriteAttributeValue("", 254, brand.Id, 254, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Index.cshtml"
                                                                     Write(brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</p>");
#nullable restore
#line 14 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>\r\n    Models\r\n</h2>\r\n");
#nullable restore
#line 19 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Index.cshtml"
 foreach (Model modell in Model.Models)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    <a  asp-controller=\"home\" asp-action=\"cars\"");
            BeginWriteAttribute("asp-route-id", "asp-route-id=\"", 412, "\"", 436, 1);
#nullable restore
#line 22 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Index.cshtml"
WriteAttributeValue("", 426, modell.Id, 426, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Index.cshtml"
                                                                    Write(modell.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</p>");
#nullable restore
#line 23 "C:\Users\Lenovo\source\repos\P228-1-task-311022\P228-1-task-311022\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
