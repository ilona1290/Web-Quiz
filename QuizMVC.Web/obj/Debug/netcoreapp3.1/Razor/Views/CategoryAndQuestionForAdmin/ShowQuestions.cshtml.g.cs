#pragma checksum "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3914c75a56a29b3e443eb51a5a05d7fbf53621f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CategoryAndQuestionForAdmin_ShowQuestions), @"mvc.1.0.view", @"/Views/CategoryAndQuestionForAdmin/ShowQuestions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3914c75a56a29b3e443eb51a5a05d7fbf53621f4", @"/Views/CategoryAndQuestionForAdmin/ShowQuestions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfb52783054c11335ff51e05239afb1af3af6c0", @"/Views/_ViewImports.cshtml")]
    public class Views_CategoryAndQuestionForAdmin_ShowQuestions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuizMVC.Application.CategoryAndQuestionForAdminVm.ListOfQuestionAdminVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-group-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddQuestion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "searchString", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("searchString"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowQuestions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CategoryAndQuestionForAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowMenuForAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
  
    ViewData["Title"] = "ShowQuestions";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center><h1 class=\"display-4 font-weight-bold\" style=\"color:darkorchid\">Pytania</h1></center>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3914c75a56a29b3e443eb51a5a05d7fbf53621f48671", async() => {
                WriteLiteral("Dodaj nowe pytanie");
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
            WriteLiteral(@"
</p>
<h6>
    Aby zobaczyć przypisane danemu pytania warianty odpowiedzi należy wejść stronę ze szczegółami pytania.
    Tak samo, akceptowanie pytania i wariantów odpowiedzi znajduje się na stronie ze szczegółami danego pytania.
    Link do edytowania pytania, przypisanej mu kategorii i wariantów odpowiedzi również znajduje się na stronie ze szczegółami.
</h6>
<p style=""color : red"">Uwaga! Jeśli usuniesz na tej stronie pytanie, usuniesz również przypisane do niego warianty odpowiedzi.</p>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3914c75a56a29b3e443eb51a5a05d7fbf53621f410426", async() => {
                WriteLiteral("    \r\n    <div class=\"form-group \">\r\n        <div>\r\n            <label class=\"font-weight-bolder\">Wyszukiwarka</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3914c75a56a29b3e443eb51a5a05d7fbf53621f410825", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 23 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchString);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div><br />\r\n        <div>\r\n            <label class=\"font-weight-bolder\"> Wybierz kategorie po której chcesz filtrować</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3914c75a56a29b3e443eb51a5a05d7fbf53621f413160", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 27 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(Model.Categories.Categories, "Id", "Name"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
        <div>
            <br />
            <input class=""btn btn-danger btn-group-sm"" type=""submit"" value=""Wyszukaj"" />
        </div>
    </div>
    <div class=""row"">
        <table class=""table"">
            <thead class=""table-primary"">
                <tr>
                    <th>
                        Pytanie
                    </th>
                    <th>
                        <center>
                            Kategoria
                        </center>
                    </th>
                    <th>
                        <center>
                            Akcje do wykonania na pytaniu
                        </center>
                    </th>
                    <th>
                        <center>
                            Czy zaakceptowano?
                        </center>
                    </th>
                </tr>
            </thead>
            <tbody class=""table-warning"">
");
#nullable restore
#line 59 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
                 foreach (var item in Model.Questions)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 63 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
                       Write(Html.DisplayFor(modelItem => item.QuestionText));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <center>\r\n                                ");
#nullable restore
#line 67 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CategoryText));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </center>\r\n                        </td>\r\n                        <td>\r\n                            <center>\r\n                                ");
#nullable restore
#line 72 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
                           Write(Html.ActionLink("Zobacz szczegóły pytania", "DetailsOfQuestion", new { id = item.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 73 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
                           Write(Html.ActionLink("Usuń", "DeleteQuestion", new { id = item.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </center>\r\n                        </td>\r\n                        <td>\r\n                            <center>\r\n");
#nullable restore
#line 78 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
                                 if (item.IsAccepted == true)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <p>&#10004;</p>\r\n");
#nullable restore
#line 81 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </center>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 85 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div>\r\n        <table class=\"float-right\">\r\n            <tr>\r\n");
#nullable restore
#line 92 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
                 for (int i = 1; i <= Math.Ceiling(Model.Count / (double)Model.PageSize); i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>\r\n");
#nullable restore
#line 95 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
                         if (i != Model.CurrentPage)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a class=\"page-link\" style=\"color:dodgerblue\"");
                BeginWriteAttribute("href", " href=\"", 4091, "\"", 4123, 3);
                WriteAttributeValue("", 4098, "javascript:PagerClick(", 4098, 22, true);
#nullable restore
#line 97 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
WriteAttributeValue("", 4120, i, 4120, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4122, ")", 4122, 1, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 97 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
                                                                                                      Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 98 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span class=\"page-link active btn-outline-success\" style=\"color:white\">");
#nullable restore
#line 101 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
                                                                                              Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 102 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </td>\r\n");
#nullable restore
#line 104 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n        </table>\r\n        <input type=\"hidden\" name=\"pageNo\" id=\"pageNo\" />\r\n        <input type=\"hidden\" name=\"pageSize\" id=\"pageSize\" value=\"7\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3914c75a56a29b3e443eb51a5a05d7fbf53621f425464", async() => {
                WriteLiteral("Powrót do menu głównego");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        function PagerClick(index) {\r\n            document.getElementById(\"pageNo\").value = index;\r\n            document.forms[1].submit();\r\n        }\r\n    </script>\r\n");
#nullable restore
#line 123 "C:\Users\HP\Desktop\Zostań programistą ASP.NET\Tydzień 9 - Obsługa użytkowników\Praca domowa\QuizMVC\QuizMVC.Web\Views\CategoryAndQuestionForAdmin\ShowQuestions.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuizMVC.Application.CategoryAndQuestionForAdminVm.ListOfQuestionAdminVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
