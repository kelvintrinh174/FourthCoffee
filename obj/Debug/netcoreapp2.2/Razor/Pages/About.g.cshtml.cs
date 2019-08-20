#pragma checksum "D:\Project\FourthCoffee\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "233d26479d7c1d5bbe3b2b024e5b145b32010a24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FourthCoffee.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/About.cshtml", typeof(FourthCoffee.Pages.Pages_About), null)]
namespace FourthCoffee.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Project\FourthCoffee\Pages\_ViewImports.cshtml"
using FourthCoffee;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"233d26479d7c1d5bbe3b2b024e5b145b32010a24", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aacf103d4f644b7fa781044ba1bccc1e8a08e4ce", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Project\FourthCoffee\Pages\About.cshtml"
  
    ViewData["Title"] = "About Us";

#line default
#line hidden
            BeginContext(89, 928, true);
            WriteLiteral(@"
<section id=""main"">
    <h1>A little bit about Fourth Coffee</h1>
    <p>
        Fourth Coffee was founded in 2010 and delivers coffee and fresh baked goods right to your door. 
        In another life, Bill Baker was a developer by day and pastry chef by night.  
        But soon Bill's innate skills with all things involving butter, flour and sugar put him 
        even more in demand than his programming talents and what started out as a way to satisfy 
        his own sweet tooth became all-consuming.  Fourth Coffee is not only a candy-coated wonderland 
        of coffee, pastries, cookies and cakes, it also honors his tech background by employing a state 
        of the art online ordering system that makes it easy for anybody with internet access to 
        order his all natural, locally-sourced confections and have them delivered to their 
        door within 24 hours.
    </p>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FourthCoffee.Pages.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FourthCoffee.Pages.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FourthCoffee.Pages.AboutModel>)PageContext?.ViewData;
        public FourthCoffee.Pages.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
