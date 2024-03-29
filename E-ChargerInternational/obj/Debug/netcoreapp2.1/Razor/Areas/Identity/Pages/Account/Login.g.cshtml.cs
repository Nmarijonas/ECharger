#pragma checksum "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d001e836c0d09cdb48039b4b6d343fde6083fa0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Login), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Login.cshtml", typeof(AspNetCore.Areas_Identity_Pages_Account_Login), null)]
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
#line 1 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using EChargerInternational.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d001e836c0d09cdb48039b4b6d343fde6083fa0e", @"/Areas/Identity/Pages/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31d8a18a4d68ad0d99d0126c04ff9e1fcf538c2c", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3ac2ff449f3b380e8d548ff3a0b283095637896", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Login.cshtml"
  
    ViewData["Title"] = "Log in";

#line default
#line hidden
            BeginContext(70, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(77, 17, false);
#line 8 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Login.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(94, 1089, true);
            WriteLiteral(@"</h2>
<div class=""row"">
    <div class=""col-md-4"">
        <section>
            <form method=""post"">
                <h4>Use a local account to log in.</h4>
                <hr />
                <div asp-validation-summary=""All"" class=""text-danger""></div>
                <div class=""form-group"">
                    <label asp-for=""Input.Email""></label>
                    <input asp-for=""Input.Email"" class=""form-control"" />
                    <span asp-validation-for=""Input.Email"" class=""text-danger""></span>
                </div>
                <div class=""form-group"">
                    <label asp-for=""Input.Password""></label>
                    <input asp-for=""Input.Password"" class=""form-control"" />
                    <span asp-validation-for=""Input.Password"" class=""text-danger""></span>
                </div>
                <div class=""form-group"">
                    <div class=""checkbox"">
                        <label asp-for=""Input.RememberMe"">
                            <");
            WriteLiteral("input asp-for=\"Input.RememberMe\" />\r\n                            ");
            EndContext();
            BeginContext(1184, 44, false);
#line 30 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Login.cshtml"
                       Write(Html.DisplayNameFor(m => m.Input.RememberMe));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 485, true);
            WriteLiteral(@"
                        </label>
                    </div>
                </div>
                <div class=""form-group"">
                    <button type=""submit"" class=""btn btn-default"">Log in</button>
                </div>
                <div class=""form-group"">
                    <p>
                        <a asp-page=""./ForgotPassword"">Forgot your password?</a>
                    </p>
                    <p>
                        <a asp-page=""./Register""");
            EndContext();
            BeginWriteAttribute("asp-route-returnUrl", " asp-route-returnUrl=\"", 1713, "\"", 1751, 1);
#line 42 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Login.cshtml"
WriteAttributeValue("", 1735, Model.ReturnUrl, 1735, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1752, 268, true);
            WriteLiteral(@">Register as a new user</a>
                    </p>
                </div>
            </form>
        </section>
    </div>
    <div class=""col-md-6 col-md-offset-2"">
        <section>
            <h4>Use another service to log in.</h4>
            <hr />
");
            EndContext();
#line 52 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Login.cshtml"
              
                if ((Model.ExternalLogins?.Count ?? 0) == 0)
                {

#line default
#line hidden
            BeginContext(2117, 404, true);
            WriteLiteral(@"                    <div>
                        <p>
                            There are no external authentication services configured. See <a href=""https://go.microsoft.com/fwlink/?LinkID=532715"">this article</a>
                            for details on setting up this ASP.NET application to support logging in via external services.
                        </p>
                    </div>
");
            EndContext();
#line 61 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Login.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2581, 52, true);
            WriteLiteral("                    <form asp-page=\"./ExternalLogin\"");
            EndContext();
            BeginWriteAttribute("asp-route-returnUrl", " asp-route-returnUrl=\"", 2633, "\"", 2671, 1);
#line 64 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Login.cshtml"
WriteAttributeValue("", 2655, Model.ReturnUrl, 2655, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2672, 105, true);
            WriteLiteral(" method=\"post\" class=\"form-horizontal\">\r\n                        <div>\r\n                            <p>\r\n");
            EndContext();
#line 67 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Login.cshtml"
                                 foreach (var provider in Model.ExternalLogins)
                                {

#line default
#line hidden
            BeginContext(2893, 97, true);
            WriteLiteral("                                    <button type=\"submit\" class=\"btn btn-default\" name=\"provider\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2990, "\"", 3012, 1);
#line 69 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Login.cshtml"
WriteAttributeValue("", 2998, provider.Name, 2998, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3013, "\"", 3068, 6);
            WriteAttributeValue("", 3021, "Log", 3021, 3, true);
            WriteAttributeValue(" ", 3024, "in", 3025, 3, true);
            WriteAttributeValue(" ", 3027, "using", 3028, 6, true);
            WriteAttributeValue(" ", 3033, "your", 3034, 5, true);
#line 69 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Login.cshtml"
WriteAttributeValue(" ", 3038, provider.DisplayName, 3039, 21, false);

#line default
#line hidden
            WriteAttributeValue(" ", 3060, "account", 3061, 8, true);
            EndWriteAttribute();
            BeginContext(3069, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3071, 20, false);
#line 69 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Login.cshtml"
                                                                                                                                                                            Write(provider.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(3091, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 70 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Login.cshtml"
                                }

#line default
#line hidden
            BeginContext(3137, 95, true);
            WriteLiteral("                            </p>\r\n                        </div>\r\n                    </form>\r\n");
            EndContext();
#line 74 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Login.cshtml"
                }
            

#line default
#line hidden
            BeginContext(3266, 42, true);
            WriteLiteral("        </section>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3326, 52, true);
                WriteLiteral("\r\n    <partial name=\"_ValidationScriptsPartial\" />\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoginModel>)PageContext?.ViewData;
        public LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
