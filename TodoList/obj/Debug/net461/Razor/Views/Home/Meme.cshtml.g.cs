#pragma checksum "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Meme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8e0a61a5603a2cf854b9614670f30c88e39c085"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Meme), @"mvc.1.0.view", @"/Views/Home/Meme.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Meme.cshtml", typeof(AspNetCore.Views_Home_Meme))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8e0a61a5603a2cf854b9614670f30c88e39c085", @"/Views/Home/Meme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11405023e71b4984b21d108cf68c11a8d007b906", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Meme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoList.Models.MemeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Meme.cshtml"
  
    ViewData["Title"] = "Dagens meme";

#line default
#line hidden
            BeginContext(81, 207, true);
            WriteLiteral("\r\n\r\n<div style=\"max-width: 700px; width: fit-content; margin: 0 auto; border-top-left-radius: 5px; border-top-right-radius: 5px; background-color: lightgray; color: black;\">\r\n    <h2 style=\"padding: 0 5px;\">");
            EndContext();
            BeginContext(289, 11, false);
#line 8 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Meme.cshtml"
                           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(300, 50, true);
            WriteLiteral("</h2>\r\n    <p style=\"padding: 0 5px;\">Skapad av <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 350, "\"", 395, 2);
            WriteAttributeValue("", 357, "https://www.reddit.com/u/", 357, 25, true);
#line 9 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Meme.cshtml"
WriteAttributeValue("", 382, Model.Author, 382, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(396, 41, true);
            WriteLiteral(" target=\"_blank\" style=\"color: black;\">u/");
            EndContext();
            BeginContext(438, 12, false);
#line 9 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Meme.cshtml"
                                                                                                                             Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(450, 43, true);
            WriteLiteral("</a></p>\r\n    <p style=\"padding: 0 5px;\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 493, "\"", 515, 1);
#line 10 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Meme.cshtml"
WriteAttributeValue("", 500, Model.PostLink, 500, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(516, 156, true);
            WriteLiteral(" target=\"_blank\" style=\"color: black; font-style: italic;\">Du kan se posten här</a></p>\r\n    <div style=\"width: fit-content; margin: 0 auto;\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 672, "\"", 718, 1);
#line 12 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Meme.cshtml"
WriteAttributeValue("", 678, Model.Preview[Model.Preview.Length - 1], 678, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 719, "\"", 737, 1);
#line 12 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Meme.cshtml"
WriteAttributeValue("", 725, Model.Title, 725, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(738, 129, true);
            WriteLiteral(" width=\"700\" height=\"700\" style=\"max-width: 700px; width: auto; max-height: 600px; height: auto;\" />\r\n    </div>\r\n</div>\r\n\r\n<!-- ");
            EndContext();
            BeginContext(868, 71, false);
#line 16 "C:\Users\axels\source\repos\TodoList\TodoList\Views\Home\Meme.cshtml"
Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model).ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(939, 8, true);
            WriteLiteral(" -->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoList.Models.MemeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
