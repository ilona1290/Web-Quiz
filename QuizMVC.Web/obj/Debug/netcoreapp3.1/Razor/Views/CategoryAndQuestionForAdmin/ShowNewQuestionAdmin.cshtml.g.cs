#pragma checksum "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowNewQuestionAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "041f5cd1edbe27d011bf2b2d7dbb7a1c1c8c00ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CategoryAndQuestionForAdmin_ShowNewQuestionAdmin), @"mvc.1.0.view", @"/Views/CategoryAndQuestionForAdmin/ShowNewQuestionAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"041f5cd1edbe27d011bf2b2d7dbb7a1c1c8c00ae", @"/Views/CategoryAndQuestionForAdmin/ShowNewQuestionAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfb52783054c11335ff51e05239afb1af3af6c0", @"/Views/_ViewImports.cshtml")]
    public class Views_CategoryAndQuestionForAdmin_ShowNewQuestionAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuizMVC.Application.CategoryAndQuestionForAdminVm.DetailsOfQuestionAdminVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowNewQuestionAdmin.cshtml"
  
    ViewData["Title"] = "ShowNewQuestionAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center><h1 class=\"font-weight-bolder\" style=\"color:blue\">Wybieranie poprawnego wariantu odpowiedzi</h1></center>\r\n\r\n\r\n<p><h3 class=\"font-weight-bolder\">Treść pytania:</h3><h4 style=\"color:darkmagenta\">");
#nullable restore
#line 10 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowNewQuestionAdmin.cshtml"
                                                                              Write(Html.DisplayFor(model => model.QuestionText));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></p>\r\n<br />\r\n<p><h3 class=\"font-weight-bolder\" style=\"color:firebrick\">Kategoria: ");
#nullable restore
#line 12 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowNewQuestionAdmin.cshtml"
                                                                Write(Html.DisplayFor(model => model.CategoryText));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></p>\r\n<br />\r\n<h3 style=\"color:indigo\">Kliknij na wariant, który jest poprawną odpowiedzią na nowo dodane przez Ciebie pytanie.</h3>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowNewQuestionAdmin.cshtml"
 foreach (var item in Model.Answers)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <center>\r\n        <h3>");
#nullable restore
#line 19 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowNewQuestionAdmin.cshtml"
       Write(Html.ActionLink(item.AnswerText, "ChooseGoodAnswerAndAcceptAnswersAdmin", new { id = item.Id }, new { @class = "btn btn-success btn-lg" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n    </center>\r\n");
#nullable restore
#line 21 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowNewQuestionAdmin.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuizMVC.Application.CategoryAndQuestionForAdminVm.DetailsOfQuestionAdminVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
