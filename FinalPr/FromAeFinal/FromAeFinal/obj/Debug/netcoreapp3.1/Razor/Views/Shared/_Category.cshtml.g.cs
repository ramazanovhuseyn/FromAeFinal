#pragma checksum "C:\Users\Code\source\repos\FromAeFinal\FromAeFinal\Views\Shared\_Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b35dfd324372789ce6d28b1c655346f117b6774"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Category), @"mvc.1.0.view", @"/Views/Shared/_Category.cshtml")]
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
#line 1 "C:\Users\Code\source\repos\FromAeFinal\FromAeFinal\Views\_ViewImports.cshtml"
using FromAeFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Code\source\repos\FromAeFinal\FromAeFinal\Views\_ViewImports.cshtml"
using FromAeFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b35dfd324372789ce6d28b1c655346f117b6774", @"/Views/Shared/_Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3314c8d98455f1c49fe29ed08d812d913eb728ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FromAeFinal.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Code\source\repos\FromAeFinal\FromAeFinal\Views\Shared\_Category.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Code\source\repos\FromAeFinal\FromAeFinal\Views\Shared\_Category.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-3\" >\r\n        <div class=\"card\" style=\"width: 100%;\">\r\n            <div class=\"card-body\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 244, "\"", 304, 1);
#nullable restore
#line 11 "C:\Users\Code\source\repos\FromAeFinal\FromAeFinal\Views\Shared\_Category.cshtml"
WriteAttributeValue("", 251, Url.Action("index","ProductsPage",new { id=item.Id}), 251, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black;\" class=\"card-text\">");
#nullable restore
#line 11 "C:\Users\Code\source\repos\FromAeFinal\FromAeFinal\Views\Shared\_Category.cshtml"
                                                                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 418, "\"", 443, 2);
            WriteAttributeValue("", 424, "/images/", 424, 8, true);
#nullable restore
#line 13 "C:\Users\Code\source\repos\FromAeFinal\FromAeFinal\Views\Shared\_Category.cshtml"
WriteAttributeValue("", 432, item.Image, 432, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                 alt=\"Card image cap\">\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Users\Code\source\repos\FromAeFinal\FromAeFinal\Views\Shared\_Category.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FromAeFinal.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
