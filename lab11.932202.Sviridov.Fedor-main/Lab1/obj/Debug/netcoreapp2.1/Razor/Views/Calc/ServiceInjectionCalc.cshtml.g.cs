#pragma checksum "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9394f0dd26d28002449a673deb7dab7775cc3fa2ba9bdbd3bac42ea5724ee09d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_ServiceInjectionCalc), @"mvc.1.0.view", @"/Views/Calc/ServiceInjectionCalc.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calc/ServiceInjectionCalc.cshtml", typeof(AspNetCore.Views_Calc_ServiceInjectionCalc))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9394f0dd26d28002449a673deb7dab7775cc3fa2ba9bdbd3bac42ea5724ee09d", @"/Views/Calc/ServiceInjectionCalc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d162c52a393ddcf7ae4b96a3c99d77e10e3b84f920488182504f464518e1d099", @"/Views/_ViewImports.cshtml")]
    public class Views_Calc_ServiceInjectionCalc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
  

    ViewData["Title"] = "ServiceInjectionCalc";

#line default
#line hidden

            BeginContext(93, 50, true);
            WriteLiteral("\n<h2>ServiceInjectionCalc</h2>\n<div>Первое число: ");
            EndContext();
            BeginContext(144, 11, false);
            Write(
#line 9 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                    calc.Value1

#line default
#line hidden
            );
            EndContext();
            BeginContext(155, 26, true);
            WriteLiteral("</div>\n<div>Второе число: ");
            EndContext();
            BeginContext(182, 11, false);
            Write(
#line 10 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                    calc.Value2

#line default
#line hidden
            );
            EndContext();
            BeginContext(193, 19, true);
            WriteLiteral("</div>\n<div>Сумма: ");
            EndContext();
            BeginContext(213, 11, false);
            Write(
#line 11 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
             calc.Value1

#line default
#line hidden
            );
            EndContext();
            BeginContext(224, 3, true);
            WriteLiteral(" + ");
            EndContext();
            BeginContext(228, 11, false);
            Write(
#line 11 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                            calc.Value2

#line default
#line hidden
            );
            EndContext();
            BeginContext(239, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(243, 10, false);
            Write(
#line 11 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                                           calc.add()

#line default
#line hidden
            );
            EndContext();
            BeginContext(253, 22, true);
            WriteLiteral("</div>\n<div>Разность: ");
            EndContext();
            BeginContext(276, 11, false);
            Write(
#line 12 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                calc.Value1

#line default
#line hidden
            );
            EndContext();
            BeginContext(287, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(291, 11, false);
            Write(
#line 12 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                               calc.Value2

#line default
#line hidden
            );
            EndContext();
            BeginContext(302, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(306, 10, false);
            Write(
#line 12 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                                              calc.sub()

#line default
#line hidden
            );
            EndContext();
            BeginContext(316, 23, true);
            WriteLiteral("</div>\n<div>Умножение: ");
            EndContext();
            BeginContext(340, 11, false);
            Write(
#line 13 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                 calc.Value1

#line default
#line hidden
            );
            EndContext();
            BeginContext(351, 3, true);
            WriteLiteral(" * ");
            EndContext();
            BeginContext(355, 11, false);
            Write(
#line 13 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                                calc.Value2

#line default
#line hidden
            );
            EndContext();
            BeginContext(366, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(370, 11, false);
            Write(
#line 13 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                                               calc.mult()

#line default
#line hidden
            );
            EndContext();
            BeginContext(381, 22, true);
            WriteLiteral("</div>\n<div>\n    Div: ");
            EndContext();
            BeginContext(404, 11, false);
            Write(
#line 15 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
          calc.Value1

#line default
#line hidden
            );
            EndContext();
            BeginContext(415, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(419, 11, false);
            Write(
#line 15 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                         calc.Value2

#line default
#line hidden
            );
            EndContext();
            BeginContext(430, 3, true);
            WriteLiteral(" = ");
            EndContext();
#line 15 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                                        if (calc.div() == -1)
    {

#line default
#line hidden

            BeginContext(462, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(472, 7, true);
            WriteLiteral(" error\n");
            EndContext();
#line 18 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
    }
    else
    {
        

#line default
#line hidden

            BeginContext(509, 10, false);
            Write(
#line 21 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
         calc.div()

#line default
#line hidden
            );
            EndContext();
#line 21 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                   
    }

#line default
#line hidden

            BeginContext(526, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public 
#line 1 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
        Lab1.Services.HTMLSender

#line default
#line hidden
         
#line 1 "C:\Users\Федор\Desktop\web-лабы\lab11.932202.Sviridov.Fedor-main\Lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                                 calc

#line default
#line hidden
         { get; private set; }
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
