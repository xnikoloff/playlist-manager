#pragma checksum "D:\Work\C# Development\PlaylistManager\PlaylistManager.WebApplication\Views\Songs\FilterByArtist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0d414a7323ccde8d63e538bff3ea983f529b6bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Songs_FilterByArtist), @"mvc.1.0.view", @"/Views/Songs/FilterByArtist.cshtml")]
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
#line 1 "D:\Work\C# Development\PlaylistManager\PlaylistManager.WebApplication\Views\_ViewImports.cshtml"
using PlaylistManager.WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\C# Development\PlaylistManager\PlaylistManager.WebApplication\Views\_ViewImports.cshtml"
using PlaylistManager.WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0d414a7323ccde8d63e538bff3ea983f529b6bb", @"/Views/Songs/FilterByArtist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6d2aad0dca123d5e18f5dd25ed7b764609fc7c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Songs_FilterByArtist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<PlaylistManager.WebApplication.Models.Song>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Work\C# Development\PlaylistManager\PlaylistManager.WebApplication\Views\Songs\FilterByArtist.cshtml"
  
    ViewData["Title"] = "FilterByArtist";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 9 "D:\Work\C# Development\PlaylistManager\PlaylistManager.WebApplication\Views\Songs\FilterByArtist.cshtml"
         foreach (var song in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 col-md-8 col-lg-4 text-center\">\r\n                <div class=\"card\" style=\"width: 18rem;\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 14 "D:\Work\C# Development\PlaylistManager\PlaylistManager.WebApplication\Views\Songs\FilterByArtist.cshtml"
                                          Write(song.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" by ");
#nullable restore
#line 14 "D:\Work\C# Development\PlaylistManager\PlaylistManager.WebApplication\Views\Songs\FilterByArtist.cshtml"
                                                         Write(song.PerformingArtist.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <hr>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 585, "\"", 601, 1);
#nullable restore
#line 16 "D:\Work\C# Development\PlaylistManager\PlaylistManager.WebApplication\Views\Songs\FilterByArtist.cshtml"
WriteAttributeValue("", 592, song.Url, 592, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Listen</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 20 "D:\Work\C# Development\PlaylistManager\PlaylistManager.WebApplication\Views\Songs\FilterByArtist.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<PlaylistManager.WebApplication.Models.Song>> Html { get; private set; }
    }
}
#pragma warning restore 1591
