#pragma checksum "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7808167f4e6e79808785dfd11dd1d291b8aa114"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\Users\axels\source\repos\TodoList\TodoList\Views\_ViewImports.cshtml"
using TodoList;

#line default
#line hidden
#line 2 "C:\Users\axels\source\repos\TodoList\TodoList\Views\_ViewImports.cshtml"
using TodoList.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7808167f4e6e79808785dfd11dd1d291b8aa114", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11405023e71b4984b21d108cf68c11a8d007b906", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoList.Models.ContactModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("maxlength", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Skriv din åsikt här"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Kontakt";

#line default
#line hidden
            BeginContext(80, 46, true);
            WriteLiteral("<h2 style=\"text-align: center; color: black;\">");
            EndContext();
            BeginContext(127, 17, false);
#line 5 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
                                         Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(144, 159, true);
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <div class=\"contact\">\r\n        <div class=\"contact-area\">\r\n            <h2>Skicka ett mejl 📧</h2>\r\n            <br />\r\n            <div>\r\n");
            EndContext();
#line 13 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
                 foreach (var email in TodoList.Repositories.PeopleRepository.GetEmail())
                {

#line default
#line hidden
            BeginContext(413, 25, true);
            WriteLiteral("                    <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 438, "\"", 458, 2);
            WriteAttributeValue("", 445, "mailto:", 445, 7, true);
#line 15 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
WriteAttributeValue("", 452, email, 452, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(459, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(461, 5, false);
#line 15 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
                                          Write(email);

#line default
#line hidden
            EndContext();
            BeginContext(466, 10, true);
            WriteLiteral("</a></p>\r\n");
            EndContext();
#line 16 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
                }

#line default
#line hidden
            BeginContext(495, 145, true);
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"contact-area\">\r\n            <h2>Ring oss ☎️</h2>\r\n            <br />\r\n            <div>\r\n");
            EndContext();
#line 23 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
                 foreach (var number in TodoList.Repositories.PeopleRepository.GetPhonenumbers())
                {

#line default
#line hidden
            BeginContext(758, 25, true);
            WriteLiteral("                    <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 783, "\"", 801, 2);
            WriteAttributeValue("", 790, "tel:", 790, 4, true);
#line 25 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
WriteAttributeValue("", 794, number, 794, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(802, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(804, 6, false);
#line 25 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
                                        Write(number);

#line default
#line hidden
            EndContext();
            BeginContext(810, 10, true);
            WriteLiteral("</a></p>\r\n");
            EndContext();
#line 26 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
                }

#line default
#line hidden
            BeginContext(839, 146, true);
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"contact-area\">\r\n            <h2>Besök oss 🚶</h2>\r\n            <br />\r\n            <div>\r\n");
            EndContext();
#line 33 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
                 foreach (var address in TodoList.Repositories.PeopleRepository.GetAddresses())
                {

#line default
#line hidden
            BeginContext(1101, 23, true);
            WriteLiteral("                    <p>");
            EndContext();
            BeginContext(1125, 7, false);
#line 35 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
                  Write(address);

#line default
#line hidden
            EndContext();
            BeginContext(1132, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 36 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
                }

#line default
#line hidden
            BeginContext(1157, 83, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <br />\r\n\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(1240, 549, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff0f7c6ba9814788ba01de3213cbcde7", async() => {
                BeginContext(1324, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1338, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fbc623ea0dc4a4e9d932ec2b81b5fca", async() => {
                    BeginContext(1364, 8, true);
                    WriteLiteral("Kategori");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 45 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Category);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1380, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1394, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e3019b9a59d4af69e25d5bba9a65b97", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 46 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Category);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1449, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1464, 50, false);
#line 47 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
       Write(Html.ValidationMessageFor(model => model.Category));

#line default
#line hidden
                EndContext();
                BeginContext(1514, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1528, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a81ade61b094901b3433ace56236996", async() => {
                    BeginContext(1553, 10, true);
                    WriteLiteral("Din åsikt:");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 48 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Content);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1571, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1585, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d2abf6e42eb4d92ac8ec4adc720a3e8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 49 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Content);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1658, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1673, 49, false);
#line 50 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Contact.cshtml"
       Write(Html.ValidationMessageFor(model => model.Content));

#line default
#line hidden
                EndContext();
                BeginContext(1722, 60, true);
                WriteLiteral("\r\n            <button type=\"submit\">Klar!</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1789, 1324, true);
            WriteLiteral(@"
    </div>
</div>

<style>
    .contact-form * {
        color: black;
    }
    .contact, .contact-form {
        color: black;
    }
    .contact {
        display: flex;
        flex-direction: row;
        justify-content: space-between;
        flex-wrap: wrap;
    }
    .contact>.contact-area {
        display: flex;
        flex-direction: column;
        justify-content: flex-start;
        min-width: min(500px, 30%);
        max-width: min(500px, 100%);
        height: auto;
        padding: 5px;
        border-radius: 5px;
        background-color: lightgray;
    }
    .contact>.contact-area h2 {
        margin: 0;
    }
    .contact-form {
        width: min(100%, 450px);
        margin: 0 auto;
    }
    .contact-form>input,.contact-form>label,.contact-form>textarea {
        width: 100%;
        box-sizing: border-box;
    }
    .contact-form>textarea {
        min-height: 250px;
        resize: vertical;
    }
    div:has(.contact) {
        padding: ");
            WriteLiteral(@"5px;
        border-top-left-radius: 5px;
        border-top-right-radius: 5px;
        background-color: gray;
    }
    div:has(.contact) h1, div:has(.contact) h2, div:has(.contact) h3, div:has(.contact) h4, div:has(.contact) h5, div:has(.contact) h6 {
        margin: 0;
    }
</style>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoList.Models.ContactModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
