#pragma checksum "C:\Users\axels\source\repos\TodoList\TodoList\Views\Shared\_FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fe9eaafab94c0564ccb8807e8cf8ffb58b9650e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterPartial), @"mvc.1.0.view", @"/Views/Shared/_FooterPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_FooterPartial.cshtml", typeof(AspNetCore.Views_Shared__FooterPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fe9eaafab94c0564ccb8807e8cf8ffb58b9650e", @"/Views/Shared/_FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11405023e71b4984b21d108cf68c11a8d007b906", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewTodoItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 172, true);
            WriteLiteral("<footer>\r\n    <div>\r\n        <div>\r\n            <h2>Axels Attgöra-lista</h2>\r\n            <br />\r\n            <p>Interna länkar:</p>\r\n            <ul>\r\n                <li>");
            EndContext();
            BeginContext(172, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e13146db0c9045118f9d24322f8cd953", async() => {
                BeginContext(216, 3, true);
                WriteLiteral("Hem");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(223, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(250, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86eba6ab4f59441daf57babb684e0dd1", async() => {
                BeginContext(294, 6, true);
                WriteLiteral("Om oss");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(304, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(331, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94ff5668451546ce8e58cf6af651e450", async() => {
                BeginContext(377, 7, true);
                WriteLiteral("Kontakt");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(388, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(415, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6f31d3dc2ec4f66a15cb6d39a33cb16", async() => {
                BeginContext(465, 13, true);
                WriteLiteral("Lägg till sak");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(482, 138, true);
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n        <div id=\"joke\">\r\n            <h2>Dagens Skämt:</h2>\r\n            <br />\r\n            <p>");
            EndContext();
            BeginContext(621, 52, false);
#line 17 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Shared\_FooterPartial.cshtml"
          Write(TodoList.Repositories.CodeRepository.GetJoke().Setup);

#line default
#line hidden
            EndContext();
            BeginContext(673, 58, true);
            WriteLiteral("<br /><span class=\"joke\" onmouseover=\"makeJokeVisible();\">");
            EndContext();
            BeginContext(732, 55, false);
#line 17 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Shared\_FooterPartial.cshtml"
                                                                                                                         Write(TodoList.Repositories.CodeRepository.GetJoke().Delivery);

#line default
#line hidden
            EndContext();
            BeginContext(787, 375, true);
            WriteLiteral(@"</span></p>
        </div>
        <div>
            <img src=""https://styles.redditmedia.com/t5_2qjpg/styles/communityIcon_uzvo7sibvc3a1.jpg"" alt=""logo"" />
        </div>
        <div>
            <h2>&copy; 2023 Axel Sjögemark</h2>
            <br />
            <p>Kontakta oss: </p>
            <div style=""width: auto; display: flex; flex-direction: column;"">
");
            EndContext();
#line 27 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Shared\_FooterPartial.cshtml"
                 foreach (var email in TodoList.Repositories.PeopleRepository.GetEmail())
                {

#line default
#line hidden
            BeginContext(1272, 28, true);
            WriteLiteral("                    <span><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1300, "\"", 1320, 2);
            WriteAttributeValue("", 1307, "mailto:", 1307, 7, true);
#line 29 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Shared\_FooterPartial.cshtml"
WriteAttributeValue("", 1314, email, 1314, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1321, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1323, 5, false);
#line 29 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Shared\_FooterPartial.cshtml"
                                             Write(email);

#line default
#line hidden
            EndContext();
            BeginContext(1328, 13, true);
            WriteLiteral("</a></span>\r\n");
            EndContext();
#line 30 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Shared\_FooterPartial.cshtml"
                }

#line default
#line hidden
            BeginContext(1360, 1315, true);
            WriteLiteral(@"            </div>
        </div>
    </div>
</footer>

<script>
    var joke = $("".joke"")[0];
    if (joke.innerHTML == """") {
        var jokeContainer = $(""#joke"")[0];
        jokeContainer.remove();
    }
</script>

<style>
    footer {
        width: auto;
        padding-top: 10px;
        padding-bottom: 10px;
        background-color: black;
    }
    footer > div {
        display: flex;
        flex-direction: row;
        justify-content: space-between;
        width: min(1250px, 100%);
        margin: 0 auto;
    }
    footer > div > div {
        max-width: 25%;
    }
    footer > div > div > * {
        max-width: 100%;
    }
    footer h2 {
        margin: 0;
    }
    .joke:not(:hover) {
        color: black;
        transition: color 1s;
    }
</style>


<script defer>
    setTimeout(() => {
        var nav = document.getElementsByTagName(""nav"")[0];
        var footer = document.getElementsByTagName(""footer"")[0];
        var containter = ($(""#cont");
            WriteLiteral(@"ainer"")[0]);
        containter.style.minHeight = ""calc(100vh - 15px - "" + nav.offsetHeight + ""px - "" + footer.offsetHeight + ""px + 1px)"";
    }, 1);

    function makeJokeVisible() {
        setTimeout(() => { $(""span.joke"").css({ ""color"": ""lightgray"" }); }, 1000);
    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
