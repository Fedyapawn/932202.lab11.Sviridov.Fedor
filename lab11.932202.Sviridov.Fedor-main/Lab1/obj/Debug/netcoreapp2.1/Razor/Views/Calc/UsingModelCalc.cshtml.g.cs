#pragma checksum "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "843b62076a1d762cd9d945e7bce42b580e58c11bfed1d66302759974c40a8d76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_UsingModelCalc), @"mvc.1.0.view", @"/Views/Calc/UsingModelCalc.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calc/UsingModelCalc.cshtml", typeof(AspNetCore.Views_Calc_UsingModelCalc))]
namespace AspNetCore
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\_ViewImports.cshtml"
using Lab1

    ;
#line 2 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\_ViewImports.cshtml"
using Lab1.Models

#line default
#line hidden
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"843b62076a1d762cd9d945e7bce42b580e58c11bfed1d66302759974c40a8d76", @"/Views/Calc/UsingModelCalc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d162c52a393ddcf7ae4b96a3c99d77e10e3b84f920488182504f464518e1d099", @"/Views/_ViewImports.cshtml")]
    public class Views_Calc_UsingModelCalc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#line 1 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml"
       mylist

#line default
#line hidden
    >
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml"
  
    ViewData["Title"] = "UsingModelCalc";

#line default
#line hidden

            BeginContext(61, 44, true);
            WriteLiteral("\n<h2>UsingModelCalc</h2>\n<div>Первое число: ");
            EndContext();
            BeginContext(106, 15, false);
            Write(
#line 7 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml"
                    Model.values[4]

#line default
#line hidden
            );
            EndContext();
            BeginContext(121, 26, true);
            WriteLiteral("</div>\n<div>Второе число: ");
            EndContext();
            BeginContext(148, 15, false);
            Write(
#line 8 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml"
                    Model.values[5]

#line default
#line hidden
            );
            EndContext();
            BeginContext(163, 19, true);
            WriteLiteral("</div>\n<div>Сумма: ");
            EndContext();
            BeginContext(183, 15, false);
            Write(
#line 9 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml"
             Model.values[4]

#line default
#line hidden
            );
            EndContext();
            BeginContext(198, 3, true);
            WriteLiteral(" + ");
            EndContext();
            BeginContext(202, 15, false);
            Write(
#line 9 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml"
                                Model.values[5]

#line default
#line hidden
            );
            EndContext();
            BeginContext(217, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(221, 15, false);
            Write(
#line 9 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml"
                                                   Model.values[0]

#line default
#line hidden
            );
            EndContext();
            BeginContext(236, 22, true);
            WriteLiteral("</div>\n<div>Разность: ");
            EndContext();
            BeginContext(259, 15, false);
            Write(
#line 10 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml"
                Model.values[4]

#line default
#line hidden
            );
            EndContext();
            BeginContext(274, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(278, 15, false);
            Write(
#line 10 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml"
                                   Model.values[5]

#line default
#line hidden
            );
            EndContext();
            BeginContext(293, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(297, 15, false);
            Write(
#line 10 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml"
                                                      Model.values[1]

#line default
#line hidden
            );
            EndContext();
            BeginContext(312, 23, true);
            WriteLiteral("</div>\n<div>Умножение: ");
            EndContext();
            BeginContext(336, 15, false);
            Write(
#line 11 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml"
                 Model.values[4]

#line default
#line hidden
            );
            EndContext();
            BeginContext(351, 3, true);
            WriteLiteral(" * ");
            EndContext();
            BeginContext(355, 15, false);
            Write(
#line 11 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml"
                                    Model.values[5]

#line default
#line hidden
            );
            EndContext();
            BeginContext(370, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(374, 15, false);
            Write(
#line 11 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml"
                                                       Model.values[2]

#line default
#line hidden
            );
            EndContext();
            BeginContext(389, 21, true);
            WriteLiteral("</div>\n<div>Деление: ");
            EndContext();
            BeginContext(411, 15, false);
            Write(
#line 12 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml"
               Model.values[4]

#line default
#line hidden
            );
            EndContext();
            BeginContext(426, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(430, 15, false);
            Write(
#line 12 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml"
                                  Model.values[5]

#line default
#line hidden
            );
            EndContext();
            BeginContext(445, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(449, 15, false);
            Write(
#line 12 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\UsingModelCalc.cshtml"
                                                     Model.values[3]

#line default
#line hidden
            );
            EndContext();
            BeginContext(464, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mylist> Html { get; private set; }
    }
}
#pragma warning restore 1591
