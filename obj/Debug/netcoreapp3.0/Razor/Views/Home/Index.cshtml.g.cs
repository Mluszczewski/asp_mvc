#pragma checksum "/home/mluszczewski/uczelnia/sem05/technologie_dotNet/projekt/tech_dot_net-Mluszczewski/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ebfa794ff62da7425cc6cc3e0aa667afeb674a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/mluszczewski/uczelnia/sem05/technologie_dotNet/projekt/tech_dot_net-Mluszczewski/Views/_ViewImports.cshtml"
using tech_dot_net_Mluszczewski;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/mluszczewski/uczelnia/sem05/technologie_dotNet/projekt/tech_dot_net-Mluszczewski/Views/_ViewImports.cshtml"
using tech_dot_net_Mluszczewski.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ebfa794ff62da7425cc6cc3e0aa667afeb674a1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6ae6cae58d65462c8d8749e1772cc2367e56551", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/mluszczewski/uczelnia/sem05/technologie_dotNet/projekt/tech_dot_net-Mluszczewski/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""6000"">
    <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""activate""></li>
    </ol>
    <div class=""carousel-inner"" role=""listbox"">
        <div class=""item acrive"">
            <img src=""https://images2.minutemediacdn.com/image/upload/c_crop,h_1890,w_3363,x_0,y_193/f_auto,q_auto,w_1100/v1565628997/shape/mentalfloss/gettyimages-944631208.jpg"" alt=""ASP.NET"" class=""img-responsive"" />
            <div class=""carousel-caption"" role=""option"">
                <p>
                    <div class =""Text""> <b>You can find here your favourites books.</b> <br/> </div>
                    <a class=""btn btn-default"" href=""/Books"">
                         See Books Collection
                    </a>
                </p>
            </div>
        </div>
    </div>
</div>
");
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
