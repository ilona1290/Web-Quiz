#pragma checksum "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestion\ShowQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d55ad8e5b7440e80f16bba9b2d4ed9a46b34b85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CategoryAndQuestion_ShowQuestion), @"mvc.1.0.view", @"/Views/CategoryAndQuestion/ShowQuestion.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\_ViewImports.cshtml"
using QuizMVC.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\_ViewImports.cshtml"
using QuizMVC.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d55ad8e5b7440e80f16bba9b2d4ed9a46b34b85", @"/Views/CategoryAndQuestion/ShowQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfb52783054c11335ff51e05239afb1af3af6c0", @"/Views/_ViewImports.cshtml")]
    public class Views_CategoryAndQuestion_ShowQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuizMVC.Application.CategoryAndQuestionVm.QuestionVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UsersRolesAndScores", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAllScores", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowMenuForUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestion\ShowQuestion.cshtml"
  
    ViewData["Title"] = "ShowQuestion";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestion\ShowQuestion.cshtml"
 if (Model.Category != "empty")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <center><h1 style=\"color:blueviolet\">Odpowiedz na pytanie z kategorii ");
#nullable restore
#line 9 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestion\ShowQuestion.cshtml"
                                                                     Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1></center>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d55ad8e5b7440e80f16bba9b2d4ed9a46b34b856756", async() => {
                WriteLiteral("\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th class=\"font-weight-bolder\" style=\"color:crimson\">\r\n                        <h3>");
#nullable restore
#line 16 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestion\ShowQuestion.cshtml"
                       Write(Html.DisplayFor(model => model.QuestionText));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n                <tr>\r\n                    <td class=\"col-md-7\">\r\n");
#nullable restore
#line 24 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestion\ShowQuestion.cshtml"
                         foreach (var item in Model.Answers)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestion\ShowQuestion.cshtml"
                       Write(Html.ActionLink(item.AnswerText, "CheckAnswer", new { IdOfSelectedAnswer = item.Id }, new { @class = "btn btn-outline-primary btn-lg" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br /><br />\r\n");
#nullable restore
#line 27 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestion\ShowQuestion.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestion\ShowQuestion.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <center><h1 style=\"color:blueviolet\">Gratulacje!!! Odpowiedziałeś/aś poprawnie na wszystkie dostępne pytania. Poczekaj na nowy zestaw pytań.</h1></center><br />\r\n    <center>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d55ad8e5b7440e80f16bba9b2d4ed9a46b34b8510432", async() => {
                WriteLiteral("Pokaż tabele najlepszych wyników");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</center><br />\r\n    <center>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d55ad8e5b7440e80f16bba9b2d4ed9a46b34b8511930", async() => {
                WriteLiteral("Menu główne");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</center>\r\n");
#nullable restore
#line 39 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestion\ShowQuestion.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuizMVC.Application.CategoryAndQuestionVm.QuestionVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
