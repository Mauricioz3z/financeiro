#pragma checksum "C:\Users\mauricio.souza\Documents\mine\financeiro3\financeiro.UI.Web\Views\Perfis\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae56238c7c8bacaca3498a991095690b7e18373a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perfis_Index), @"mvc.1.0.view", @"/Views/Perfis/Index.cshtml")]
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
#line 1 "C:\Users\mauricio.souza\Documents\mine\financeiro3\financeiro.UI.Web\Views\_ViewImports.cshtml"
using financeiro.UI.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mauricio.souza\Documents\mine\financeiro3\financeiro.UI.Web\Views\_ViewImports.cshtml"
using financeiro.UI.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae56238c7c8bacaca3498a991095690b7e18373a", @"/Views/Perfis/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5476f86aa13cfccc93100aa8289ee39df44872a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mauricio.souza\Documents\mine\financeiro3\financeiro.UI.Web\Views\Perfis\Index.cshtml"
  


    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/v/bs4/dt-1.10.20/datatables.min.css"" />



<div class=""container"">

    <div class=""row m-4"">

        <div class=""col-12"">

            <div class=""card"">
                <div class=""card-body"">
                    This is some text within a card body.
                </div>
            </div>
        </div>



    </div>


    <div class=""row"">

        <div class=""col-12"">

            <div class=""card"">
                <div class=""card-body"">
                    <div class=""card"">
                        <div class=""card-body"">

                            <table id=""example"" class=""table table-striped table-bordered"" style=""width:100%"">
                                <thead>
                                    <tr>
                                        <th>Name</th>
                                        <th>Position</th>
                                        <th>Office</th>
            ");
            WriteLiteral(@"                            <th>Age</th>
                                        <th>Start date</th>
                                        <th>Salary</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Tiger Nixon</td>
                                        <td>System Architect</td>
                                        <td>Edinburgh</td>
                                        <td>61</td>
                                        <td>2011/04/25</td>
                                        <td>$320,800</td>
                                    </tr>
                                    <tr>
                                        <td>Garrett Winters</td>
                                        <td>Accountant</td>
                                        <td>Tokyo</td>
                                        <td>63</td>
             ");
            WriteLiteral(@"                           <td>2011/07/25</td>
                                        <td>$170,750</td>
                                    </tr>
                                    <tr>
                                        <td>Ashton Cox</td>
                                        <td>Junior Technical Author</td>
                                        <td>San Francisco</td>
                                        <td>66</td>
                                        <td>2009/01/12</td>
                                        <td>$86,000</td>
                                    </tr>
                                    <tr>
                                        <td>Cedric Kelly</td>
                                        <td>Senior Javascript Developer</td>
                                        <td>Edinburgh</td>
                                        <td>22</td>
                                        <td>2012/03/29</td>
                                        <td>$433,060</td>
  ");
            WriteLiteral(@"                                  </tr>
                                    <tr>
                                        <td>Airi Satou</td>
                                        <td>Accountant</td>
                                        <td>Tokyo</td>
                                        <td>33</td>
                                        <td>2008/11/28</td>
                                        <td>$162,700</td>
                                    </tr>

                                </tbody>
                                <tfoot>
                                    <tr>
                                        <th>Name</th>
                                        <th>Position</th>
                                        <th>Office</th>
                                        <th>Age</th>
                                        <th>Start date</th>
                                        <th>Salary</th>
                                    </tr>
                                </");
            WriteLiteral("tfoot>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n    <script type=\"text/javascript\" src=\"https://cdn.datatables.net/v/bs4/dt-1.10.20/datatables.min.js\"></script>\r\n\r\n    <script>\r\n\r\n        $(document).ready(function () {\r\n            $(\'#example\').DataTable();\r\n        });\r\n\r\n    </script>\r\n");
            }
            );
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
