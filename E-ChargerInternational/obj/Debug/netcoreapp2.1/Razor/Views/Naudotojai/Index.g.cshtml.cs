#pragma checksum "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Naudotojai\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54541271938ea2c3545d74da09174ad119f06294"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Naudotojai_Index), @"mvc.1.0.view", @"/Views/Naudotojai/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Naudotojai/Index.cshtml", typeof(AspNetCore.Views_Naudotojai_Index))]
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
#line 1 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\_ViewImports.cshtml"
using E_ChargerInternational;

#line default
#line hidden
#line 2 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\_ViewImports.cshtml"
using E_ChargerInternational.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54541271938ea2c3545d74da09174ad119f06294", @"/Views/Naudotojai/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a9a57acfba1983842a16a93a0c5cd7031c56b24", @"/Views/_ViewImports.cshtml")]
    public class Views_Naudotojai_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Naudotojai\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 51, true);
            WriteLiteral("\r\n<h2>Naudotojai</h2>\r\nČia bus naudotojai.\r\n<div><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 94, "\"", 136, 1);
#line 8 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Naudotojai\Index.cshtml"
WriteAttributeValue("", 101, Url.Action("Create", "Naudotojai"), 101, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(137, 132, true);
            WriteLiteral(">KURTI</a></div> <div><a href=\"#\">Filtruoti</a></div>\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>Pavadinimas</td>\r\n        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 269, "\"", 311, 1);
#line 12 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Naudotojai\Index.cshtml"
WriteAttributeValue("", 276, Url.Action("Delete", "Naudotojai"), 276, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(312, 14, true);
            WriteLiteral(">Trinti</a> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 326, "\"", 366, 1);
#line 12 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Naudotojai\Index.cshtml"
WriteAttributeValue("", 333, Url.Action("Edit", "Naudotojai"), 333, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(367, 37, true);
            WriteLiteral(">Keisti</a></td>\r\n    </tr>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
