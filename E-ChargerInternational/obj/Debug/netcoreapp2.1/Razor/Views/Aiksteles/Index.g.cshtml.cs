#pragma checksum "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e990fedcd6ba3fbb99760520fe88efb1a95b87e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aiksteles_Index), @"mvc.1.0.view", @"/Views/Aiksteles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aiksteles/Index.cshtml", typeof(AspNetCore.Views_Aiksteles_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e990fedcd6ba3fbb99760520fe88efb1a95b87e9", @"/Views/Aiksteles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a9a57acfba1983842a16a93a0c5cd7031c56b24", @"/Views/_ViewImports.cshtml")]
    public class Views_Aiksteles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EChargerInternational.EChargerInternational.Aikstele>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "atsiliepimai", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(117, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(146, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51398f64155c4c01aaeb8a812845f4a1", async() => {
                BeginContext(169, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(183, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(276, 47, false);
#line 16 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pavadinimas));

#line default
#line hidden
            EndContext();
            BeginContext(323, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(379, 51, false);
#line 19 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TelefonoNumeris));

#line default
#line hidden
            EndContext();
            BeginContext(430, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(486, 48, false);
#line 22 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DarboPradzia));

#line default
#line hidden
            EndContext();
            BeginContext(534, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(590, 48, false);
#line 25 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DarboPabaiga));

#line default
#line hidden
            EndContext();
            BeginContext(638, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(694, 43, false);
#line 28 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Saugoma));

#line default
#line hidden
            EndContext();
            BeginContext(737, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(793, 49, false);
#line 31 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ElektrosKaina));

#line default
#line hidden
            EndContext();
            BeginContext(842, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(898, 54, false);
#line 34 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PapildomasMokestis));

#line default
#line hidden
            EndContext();
            BeginContext(952, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1008, 62, false);
#line 37 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PapildomoMokescioAprasymas));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1126, 43, false);
#line 40 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Miestas));

#line default
#line hidden
            EndContext();
            BeginContext(1169, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1225, 41, false);
#line 43 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gatve));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1322, 42, false);
#line 46 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NamoNr));

#line default
#line hidden
            EndContext();
            BeginContext(1364, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1420, 47, false);
#line 49 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.KoordinateX));

#line default
#line hidden
            EndContext();
            BeginContext(1467, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1523, 47, false);
#line 52 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.KoordinateY));

#line default
#line hidden
            EndContext();
            BeginContext(1570, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1626, 46, false);
#line 55 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PastoKodas));

#line default
#line hidden
            EndContext();
            BeginContext(1672, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1728, 45, false);
#line 58 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Aprasymas));

#line default
#line hidden
            EndContext();
            BeginContext(1773, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1829, 66, false);
#line 61 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FkKlientasidKlientasNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1895, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 67 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2013, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2062, 46, false);
#line 70 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pavadinimas));

#line default
#line hidden
            EndContext();
            BeginContext(2108, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2164, 50, false);
#line 73 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TelefonoNumeris));

#line default
#line hidden
            EndContext();
            BeginContext(2214, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2270, 47, false);
#line 76 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DarboPradzia));

#line default
#line hidden
            EndContext();
            BeginContext(2317, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2373, 47, false);
#line 79 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DarboPabaiga));

#line default
#line hidden
            EndContext();
            BeginContext(2420, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2476, 42, false);
#line 82 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Saugoma));

#line default
#line hidden
            EndContext();
            BeginContext(2518, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2574, 48, false);
#line 85 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ElektrosKaina));

#line default
#line hidden
            EndContext();
            BeginContext(2622, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2678, 53, false);
#line 88 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PapildomasMokestis));

#line default
#line hidden
            EndContext();
            BeginContext(2731, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2787, 61, false);
#line 91 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PapildomoMokescioAprasymas));

#line default
#line hidden
            EndContext();
            BeginContext(2848, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2904, 42, false);
#line 94 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Miestas));

#line default
#line hidden
            EndContext();
            BeginContext(2946, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3002, 40, false);
#line 97 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gatve));

#line default
#line hidden
            EndContext();
            BeginContext(3042, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3098, 41, false);
#line 100 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NamoNr));

#line default
#line hidden
            EndContext();
            BeginContext(3139, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3195, 46, false);
#line 103 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.KoordinateX));

#line default
#line hidden
            EndContext();
            BeginContext(3241, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3297, 46, false);
#line 106 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.KoordinateY));

#line default
#line hidden
            EndContext();
            BeginContext(3343, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3399, 45, false);
#line 109 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PastoKodas));

#line default
#line hidden
            EndContext();
            BeginContext(3444, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3500, 44, false);
#line 112 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Aprasymas));

#line default
#line hidden
            EndContext();
            BeginContext(3544, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3600, 75, false);
#line 115 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FkKlientasidKlientasNavigation.Aprasymas));

#line default
#line hidden
            EndContext();
            BeginContext(3675, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3730, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e97b3ef34273494da4a6db4788dc0dba", async() => {
                BeginContext(3783, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 118 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
                                       WriteLiteral(item.IdAikstele);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3791, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3811, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93bdf6ed4a3a4d43979916e6014de9d0", async() => {
                BeginContext(3867, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 119 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
                                          WriteLiteral(item.IdAikstele);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3878, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3898, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2f1a8baad894a77b57609dab91559b7", async() => {
                BeginContext(3953, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 120 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
                                         WriteLiteral(item.IdAikstele);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3963, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3981, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d584a3b22c146b2913a29c542ee9c8f", async() => {
                BeginContext(4066, 10, true);
                WriteLiteral("Atsiliepti");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 121 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
                                                                       WriteLiteral(item.IdAikstele);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4080, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 124 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Views\Aiksteles\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4119, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EChargerInternational.EChargerInternational.Aikstele>> Html { get; private set; }
    }
}
#pragma warning restore 1591
