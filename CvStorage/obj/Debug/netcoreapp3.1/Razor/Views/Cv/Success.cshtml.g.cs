#pragma checksum "C:\Users\88016\Downloads\CvStorage (2)\CvStorage\Views\Cv\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19e6c798b3d26d0f34fc4a01ff10b8077bae8d2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cv_Success), @"mvc.1.0.view", @"/Views/Cv/Success.cshtml")]
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
#line 1 "C:\Users\88016\Downloads\CvStorage (2)\CvStorage\Views\_ViewImports.cshtml"
using CvStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\88016\Downloads\CvStorage (2)\CvStorage\Views\_ViewImports.cshtml"
using CvStorage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19e6c798b3d26d0f34fc4a01ff10b8077bae8d2c", @"/Views/Cv/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"399c7f1e688ab144593f63e73bb5235c021c4476", @"/Views/_ViewImports.cshtml")]
    public class Views_Cv_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\88016\Downloads\CvStorage (2)\CvStorage\Views\Cv\Success.cshtml"
 if (ViewBag.isSuccess)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1> You have successfully added user with id ");
#nullable restore
#line 9 "C:\Users\88016\Downloads\CvStorage (2)\CvStorage\Views\Cv\Success.cshtml"
                                             Write(ViewBag.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n");
#nullable restore
#line 10 "C:\Users\88016\Downloads\CvStorage (2)\CvStorage\Views\Cv\Success.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
