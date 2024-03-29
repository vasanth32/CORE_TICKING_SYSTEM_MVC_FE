#pragma checksum "E:\@udemy\TicketingSystem\TicketingSystemUI\TicketingSystemUI\Views\Home\TicketPriorities.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f1db046b860a79e5c01b16e15ac269945ba92c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TicketPriorities), @"mvc.1.0.view", @"/Views/Home/TicketPriorities.cshtml")]
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
#line 1 "E:\@udemy\TicketingSystem\TicketingSystemUI\TicketingSystemUI\Views\_ViewImports.cshtml"
using TicketingSystemUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\@udemy\TicketingSystem\TicketingSystemUI\TicketingSystemUI\Views\_ViewImports.cshtml"
using TicketingSystemUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f1db046b860a79e5c01b16e15ac269945ba92c5", @"/Views/Home/TicketPriorities.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7317a0a7260671647d2cac3f5b844838e881807", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_TicketPriorities : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"content\">\n    <header class=\"content__title\">\n\n        <div class=\"actions\">\n            <a");
            BeginWriteAttribute("href", " href=\"", 107, "\"", 114, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"actions__item zmdi zmdi-trending-up\"></a>\n            <a");
            BeginWriteAttribute("href", " href=\"", 179, "\"", 186, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""actions__item zmdi zmdi-check-all""></a>

            <div class=""dropdown actions__item"">
                <i data-toggle=""dropdown"" class=""zmdi zmdi-more-vert""></i>
                <div class=""dropdown-menu dropdown-menu-right"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 446, "\"", 453, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""dropdown-item"">Refresh</a>
                </div>
            </div>
        </div>
    </header>

    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Admin - Tickets Priorities</h4>
            <div class=""col-sm-6"">
                <button class=""btn btn-primary"">Add New</button>
            </div>
            <div class=""table-responsive"">
                <table id=""data-table"" class=""table table-bordered"">
                    <thead class=""thead-default"">
                        <tr>
                            <th>Priority Id</th>
                            <th>Priority Level</th>
                        </tr>
                    </thead>
                  
                    <tbody>
                        <tr>
                            <td>1</td>
                            <td>High</td>                        
                        </tr>
                        <tr>
                            <td>1</td>
                            <td>Medium</td>
  ");
            WriteLiteral(@"                      </tr>
                        <tr>
                            <td>1</td>
                            <td>Low</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>

    <footer class=""footer hidden-xs-down"">
        <p>© Ticketing System. All rights reserved.</p>

        <ul class=""nav footer__nav"">
            <a class=""nav-link""");
            BeginWriteAttribute("href", " href=\"", 1913, "\"", 1920, 0);
            EndWriteAttribute();
            WriteLiteral(">Homepage</a>\n\n            <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 1967, "\"", 1974, 0);
            EndWriteAttribute();
            WriteLiteral(">Company</a>\n\n            <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 2020, "\"", 2027, 0);
            EndWriteAttribute();
            WriteLiteral(">Support</a>\n\n            <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 2073, "\"", 2080, 0);
            EndWriteAttribute();
            WriteLiteral(">News</a>\n\n            <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 2123, "\"", 2130, 0);
            EndWriteAttribute();
            WriteLiteral(">Contacts</a>\n        </ul>\n    </footer>\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
