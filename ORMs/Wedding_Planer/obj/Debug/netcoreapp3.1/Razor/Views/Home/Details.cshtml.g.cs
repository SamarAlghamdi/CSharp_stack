#pragma checksum "/Users/faisalal-qabbani/Desktop/Bootcamp/assigments/c#/ASP/Wedding_Planer/Views/Home/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ac613aa1800f857f73acbc86b5d1bcab7f782c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "/Users/faisalal-qabbani/Desktop/Bootcamp/assigments/c#/ASP/Wedding_Planer/Views/_ViewImports.cshtml"
using Wedding_Planer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/faisalal-qabbani/Desktop/Bootcamp/assigments/c#/ASP/Wedding_Planer/Views/_ViewImports.cshtml"
using Wedding_Planer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ac613aa1800f857f73acbc86b5d1bcab7f782c8", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b389c0e8a7cb76db43d82f04711e7be59a156de", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1 class=\'text-muted my-2\'>");
#nullable restore
#line 3 "/Users/faisalal-qabbani/Desktop/Bootcamp/assigments/c#/ASP/Wedding_Planer/Views/Home/Details.cshtml"
                       Write(Model.WedderOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" and ");
#nullable restore
#line 3 "/Users/faisalal-qabbani/Desktop/Bootcamp/assigments/c#/ASP/Wedding_Planer/Views/Home/Details.cshtml"
                                            Write(Model.WedderTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s Wedding</h1>\n<h3 class=\"text-muted\">Date: ");
#nullable restore
#line 4 "/Users/faisalal-qabbani/Desktop/Bootcamp/assigments/c#/ASP/Wedding_Planer/Views/Home/Details.cshtml"
                        Write(Model.Date.ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<h3>Guests:</h3>\n<ul>\n");
#nullable restore
#line 7 "/Users/faisalal-qabbani/Desktop/Bootcamp/assigments/c#/ASP/Wedding_Planer/Views/Home/Details.cshtml"
     foreach(var item in Model.Guests){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 8 "/Users/faisalal-qabbani/Desktop/Bootcamp/assigments/c#/ASP/Wedding_Planer/Views/Home/Details.cshtml"
       Write(item.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "/Users/faisalal-qabbani/Desktop/Bootcamp/assigments/c#/ASP/Wedding_Planer/Views/Home/Details.cshtml"
                            Write(item.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 9 "/Users/faisalal-qabbani/Desktop/Bootcamp/assigments/c#/ASP/Wedding_Planer/Views/Home/Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591