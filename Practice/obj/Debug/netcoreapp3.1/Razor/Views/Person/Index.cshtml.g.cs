#pragma checksum "D:\Ivan\Git\C#\Core\Practice\Practice\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91c579d605422fa4ebd6c01d725039b8f4eb58c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
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
#line 1 "D:\Ivan\Git\C#\Core\Practice\Practice\Views\_ViewImports.cshtml"
using Practice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ivan\Git\C#\Core\Practice\Practice\Views\_ViewImports.cshtml"
using Practice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c579d605422fa4ebd6c01d725039b8f4eb58c9", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd757ed8785d7859154d904007503f4f18d9d71", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PersonViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Ivan\Git\C#\Core\Practice\Practice\Views\Person\Index.cshtml"
 foreach (var person in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 5 "D:\Ivan\Git\C#\Core\Practice\Practice\Views\Person\Index.cshtml"
  Write(person.Fname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 6 "D:\Ivan\Git\C#\Core\Practice\Practice\Views\Person\Index.cshtml"
  Write(person.Lname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 7 "D:\Ivan\Git\C#\Core\Practice\Practice\Views\Person\Index.cshtml"
  Write(person.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 8 "D:\Ivan\Git\C#\Core\Practice\Practice\Views\Person\Index.cshtml"
  Write(person.Bdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 9 "D:\Ivan\Git\C#\Core\Practice\Practice\Views\Person\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PersonViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
