#pragma checksum "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da1b05d4168520f3eca96591d173e3282d0d27f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CategoryAndQuestionForAdmin_DetailsOfQuestion), @"mvc.1.0.view", @"/Views/CategoryAndQuestionForAdmin/DetailsOfQuestion.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da1b05d4168520f3eca96591d173e3282d0d27f6", @"/Views/CategoryAndQuestionForAdmin/DetailsOfQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfb52783054c11335ff51e05239afb1af3af6c0", @"/Views/_ViewImports.cshtml")]
    public class Views_CategoryAndQuestionForAdmin_DetailsOfQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuizMVC.Application.CategoryAndQuestionForAdminVm.DetailsOfQuestionAdminVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowQuestions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
  
    ViewData["Title"] = "DetailsOfQuestion";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center><h1 style=\"color:lightcoral\">Szczegóły wybranego pytania</h1></center>\r\n");
#nullable restore
#line 8 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
Write(Html.ActionLink("Edytuj to pytanie", "EditQuestion", new { id = Model.Id}, new { @class = "btn btn-info btn-group-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<p><h5>Treść pytania:</h5>");
#nullable restore
#line 10 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
                     Write(Html.DisplayFor(model => model.QuestionText));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><h5>Kategoria:</h5>");
#nullable restore
#line 11 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
                 Write(Html.DisplayFor(model => model.CategoryText));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<div>\r\n    <p><h5>Czy zaakceptowano?</h5></p>\r\n");
#nullable restore
#line 14 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
     if (Model.IsAccepted == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>&#10004;</p>\r\n");
#nullable restore
#line 17 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
   Write(Html.ActionLink("Akceptuj", "AcceptQuestion", new { id = Model.Id }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
                                                                                                                 
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><br />\r\n\r\n<div>\r\n    ");
#nullable restore
#line 25 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
Write(Html.ActionLink("Dodaj dodatkowy wariant odpowiedzi do tego pytania", "AddExtraAnswersToExistingQuestion", new { idQuestion = Model.Id }, new { @class = "btn btn-primary btn-lg" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
<table class=""table"">
    <tr class=""table-success"">
        <th>
            Treść wariantu odpowiedzi
        </th>
        <th>
            <center>
                Czy wariant jest poprawną odpowiedzią na pytanie?
            </center>
        </th>
        <th>
            <center>
                Czy wariant odpowiedzi został zaakceptowany?
            </center>
        </th>
        <th>
            <center>Usunąć ten wariant?</center>
        </th>
    </tr>
");
#nullable restore
#line 46 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
     foreach (var item in Model.Answers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"table-warning\">\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
           Write(Html.DisplayFor(modelItem => item.AnswerText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <center>\r\n");
#nullable restore
#line 54 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
                     if (item.IsCorrect == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>&#10004;</p>\r\n");
#nullable restore
#line 57 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"font-weight-bolder\" style=\"color:red\">X</p>\r\n");
#nullable restore
#line 61 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </center>\r\n            </td>\r\n            <td>\r\n                <center>\r\n");
#nullable restore
#line 66 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
                     if (item.IsAccepted == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>&#10004;</p>\r\n");
#nullable restore
#line 69 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
                   Write(Html.ActionLink("Akceptuj", "AcceptAnswer", new { id = item.Id }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
                                                                                                                              
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </center>\r\n            </td>\r\n            <td>\r\n                <center>\r\n                    ");
#nullable restore
#line 78 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
               Write(Html.ActionLink("Usuń", "DeleteAnswer", new { id = item.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </center>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 82 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\DetailsOfQuestion.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da1b05d4168520f3eca96591d173e3282d0d27f612802", async() => {
                WriteLiteral("Powrót do listy z pytaniami");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuizMVC.Application.CategoryAndQuestionForAdminVm.DetailsOfQuestionAdminVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
