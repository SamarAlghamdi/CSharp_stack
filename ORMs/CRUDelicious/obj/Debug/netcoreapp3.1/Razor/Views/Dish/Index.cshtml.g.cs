#pragma checksum "C:\Users\sfn7\Desktop\wepDev\C#_stack\ORMs\CRUDelicious\Views\Dish\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2fdd8b0b795e695b49c556114f2d9d0518c0350"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dish_Index), @"mvc.1.0.view", @"/Views/Dish/Index.cshtml")]
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
#line 1 "C:\Users\sfn7\Desktop\wepDev\C#_stack\ORMs\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sfn7\Desktop\wepDev\C#_stack\ORMs\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2fdd8b0b795e695b49c556114f2d9d0518c0350", @"/Views/Dish/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Dish_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"text-center\">Welcome to CRUDelicious</h1>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n    <h3 class=\"col-10\">Check out some recent dishes</h3>\r\n    <a class=\" col-2\" href=\"/new\">Add a dish</a>\r\n    </div>\r\n    <hr/>\r\n    <ul>\r\n");
#nullable restore
#line 11 "C:\Users\sfn7\Desktop\wepDev\C#_stack\ORMs\CRUDelicious\Views\Dish\Index.cshtml"
         foreach(Dishe d in ViewBag.AllDishes){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 314, "\"", 331, 1);
#nullable restore
#line 12 "C:\Users\sfn7\Desktop\wepDev\C#_stack\ORMs\CRUDelicious\Views\Dish\Index.cshtml"
WriteAttributeValue("", 321, d.DisheId, 321, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "C:\Users\sfn7\Desktop\wepDev\C#_stack\ORMs\CRUDelicious\Views\Dish\Index.cshtml"
                                Write(d.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> by ");
#nullable restore
#line 12 "C:\Users\sfn7\Desktop\wepDev\C#_stack\ORMs\CRUDelicious\Views\Dish\Index.cshtml"
                                               Write(d.Chef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 13 "C:\Users\sfn7\Desktop\wepDev\C#_stack\ORMs\CRUDelicious\Views\Dish\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n");
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
