#pragma checksum "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62fdaad9bcadef808fe90b24c5f4e88bf8d0ae1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
#line 5 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Login.cshtml"
using UniversityRegistrar.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62fdaad9bcadef808fe90b24c5f4e88bf8d0ae1d", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Login.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(66, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(89, 57, true);
            WriteLiteral("\n<h1>Log in with your account</h1>\n<div class=\"content\">\n");
            EndContext();
#line 11 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Login.cshtml"
   using (Html.BeginForm())
  {
      

#line default
#line hidden
            BeginContext(185, 27, false);
#line 13 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Login.cshtml"
 Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(220, 29, false);
#line 14 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Login.cshtml"
 Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(258, 30, false);
#line 16 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Login.cshtml"
 Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(296, 33, false);
#line 17 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Login.cshtml"
 Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(331, 57, true);
            WriteLiteral("      <input type=\"submit\" value=\"Log in\" class=\"btn\" />\n");
            EndContext();
#line 20 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Login.cshtml"
  }

#line default
#line hidden
            BeginContext(392, 33, true);
            WriteLiteral("</div>\n\n<div class=\"links\">\n  <p>");
            EndContext();
            BeginContext(426, 51, false);
#line 24 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Login.cshtml"
Write(Html.ActionLink("No Account? Register", "Register"));

#line default
#line hidden
            EndContext();
            BeginContext(477, 10, true);
            WriteLiteral("</p>\n  <p>");
            EndContext();
            BeginContext(488, 32, false);
#line 25 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Login.cshtml"
Write(Html.ActionLink("Back", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(520, 11, true);
            WriteLiteral("</p>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
