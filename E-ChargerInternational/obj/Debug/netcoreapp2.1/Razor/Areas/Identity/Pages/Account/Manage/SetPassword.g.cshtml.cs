#pragma checksum "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Manage\SetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14e82137946d0eee8f1ce2c782c0e5624c8b5ad3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_SetPassword), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/SetPassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Manage/SetPassword.cshtml", typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_SetPassword), null)]
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
#line 1 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using EChargerInternational.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14e82137946d0eee8f1ce2c782c0e5624c8b5ad3", @"/Areas/Identity/Pages/Account/Manage/SetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31d8a18a4d68ad0d99d0126c04ff9e1fcf538c2c", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3ac2ff449f3b380e8d548ff3a0b283095637896", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47999c590ecab62f577be5cdfbd4d3d87ee77f94", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_SetPassword : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Manage\SetPassword.cshtml"
  
    ViewData["Title"] = "Set password";
    ViewData["ActivePage"] = ManageNavPages.ChangePassword;

#line default
#line hidden
            BeginContext(141, 30, true);
            WriteLiteral("\r\n<h4>Set your password</h4>\r\n");
            EndContext();
            BeginContext(172, 51, false);
#line 9 "C:\Users\Nmarijonas\Desktop\ISPagrindai\E-ChargerInternational\E-ChargerInternational\Areas\Identity\Pages\Account\Manage\SetPassword.cshtml"
Write(Html.Partial("_StatusMessage", Model.StatusMessage));

#line default
#line hidden
            EndContext();
            BeginContext(223, 1039, true);
            WriteLiteral(@"
<p class=""text-info"">
    You do not have a local username/password for this site. Add a local
    account so you can log in without an external login.
</p>
<div class=""row"">
    <div class=""col-md-6"">
        <form id=""set-password-form"" method=""post"">
            <div asp-validation-summary=""All"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Input.NewPassword""></label>
                <input asp-for=""Input.NewPassword"" class=""form-control"" />
                <span asp-validation-for=""Input.NewPassword"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Input.ConfirmPassword""></label>
                <input asp-for=""Input.ConfirmPassword"" class=""form-control"" />
                <span asp-validation-for=""Input.ConfirmPassword"" class=""text-danger""></span>
            </div>
            <button type=""submit"" class=""btn btn-default"">Set password</button>
        </form>
    </d");
            WriteLiteral("iv>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1280, 52, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SetPasswordModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SetPasswordModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SetPasswordModel>)PageContext?.ViewData;
        public SetPasswordModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
