#pragma checksum "C:\Users\Анжела\Desktop\Text-analyse-project\AbrProject\Views\HelloWorld\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "377148dd79c803466e8c34cbfc6034531e44cf2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Index), @"mvc.1.0.view", @"/Views/HelloWorld/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HelloWorld/Index.cshtml", typeof(AspNetCore.Views_HelloWorld_Index))]
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
#line 1 "C:\Users\Анжела\Desktop\Text-analyse-project\AbrProject\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#line 2 "C:\Users\Анжела\Desktop\Text-analyse-project\AbrProject\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#line 2 "C:\Users\Анжела\Desktop\Text-analyse-project\AbrProject\Views\HelloWorld\Index.cshtml"
using System.Text;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"377148dd79c803466e8c34cbfc6034531e44cf2c", @"/Views/HelloWorld/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcMovie.Views.HelloWorld.IndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 17, true);
            WriteLiteral("<!DOCTYPE html>\r\n");
            EndContext();
            BeginContext(38, 12, true);
            WriteLiteral("<html>\r\n    ");
            EndContext();
            BeginContext(50, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377148dd79c803466e8c34cbfc6034531e44cf2c5763", async() => {
                BeginContext(56, 79, true);
                WriteLiteral("\r\n        <meta charset=\"utf-8\">\r\n        <title>TextAnalyzer</title>\r\n        ");
                EndContext();
                BeginContext(135, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "377148dd79c803466e8c34cbfc6034531e44cf2c6227", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(182, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(195, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(201, 1417, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377148dd79c803466e8c34cbfc6034531e44cf2c8365", async() => {
                BeginContext(207, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(262, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 11 "C:\Users\Анжела\Desktop\Text-analyse-project\AbrProject\Views\HelloWorld\Index.cshtml"
          
            ViewData["Title"] = "Index";
        

#line default
#line hidden
                BeginContext(327, 53, true);
                WriteLiteral("\r\n        <p>Type your text right here!</p>\r\n        ");
                EndContext();
                BeginContext(380, 415, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377148dd79c803466e8c34cbfc6034531e44cf2c9228", async() => {
                    BeginContext(449, 339, true);
                    WriteLiteral(@"

            <div class=""form-group"">
                <label class=""control-label"">Text</label>
                <input id=""answerid"" name=""answerid"" class=""form-control"" />
                <span class=""text-danger""></span>
            </div>

            <input type=""submit"" value=""Analyze"" class=""btn btn-default"" />

        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(795, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 27 "C:\Users\Анжела\Desktop\Text-analyse-project\AbrProject\Views\HelloWorld\Index.cshtml"
         if (Model.Answer != null)
        {
            int o = 1;

#line default
#line hidden
                BeginContext(868, 30, true);
                WriteLiteral("            <p>Your keywords: ");
                EndContext();
                BeginContext(899, 12, false);
#line 30 "C:\Users\Анжела\Desktop\Text-analyse-project\AbrProject\Views\HelloWorld\Index.cshtml"
                         Write(Model.Answer);

#line default
#line hidden
                EndContext();
                BeginContext(911, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 31 "C:\Users\Анжела\Desktop\Text-analyse-project\AbrProject\Views\HelloWorld\Index.cshtml"
             foreach (var e in Model.Answer.Split().Where(x => x != string.Empty))
            {

#line default
#line hidden
                BeginContext(1016, 56, true);
                WriteLiteral("                <input style=\"color:black\" type=\"submit\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1072, "\"", 1086, 3);
#line 33 "C:\Users\Анжела\Desktop\Text-analyse-project\AbrProject\Views\HelloWorld\Index.cshtml"
WriteAttributeValue("", 1080, o, 1080, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 1082, ")", 1082, 1, true);
#line 33 "C:\Users\Анжела\Desktop\Text-analyse-project\AbrProject\Views\HelloWorld\Index.cshtml"
WriteAttributeValue(" ", 1083, e, 1084, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1087, 29, true);
                WriteLiteral(" class=\"btn btn-default\" />\r\n");
                EndContext();
#line 34 "C:\Users\Анжела\Desktop\Text-analyse-project\AbrProject\Views\HelloWorld\Index.cshtml"
                o++;

#line default
#line hidden
                BeginContext(1138, 24, true);
                WriteLiteral("                <br />\r\n");
                EndContext();
#line 36 "C:\Users\Анжела\Desktop\Text-analyse-project\AbrProject\Views\HelloWorld\Index.cshtml"
                var c = new StringBuilder();
                foreach(var t in Model.Stroka.Split('.').Where(x=>x.ToLower().Contains(e)))
                {
                    c.Append(t);
                    // <output style="color: black" class="btn btn-outline-dark">@t</output>
                }

#line default
#line hidden
                BeginContext(1467, 77, true);
                WriteLiteral("                <output style=\"color: black\" class=\"btn btn-outline-success\">");
                EndContext();
                BeginContext(1545, 1, false);
#line 42 "C:\Users\Анжела\Desktop\Text-analyse-project\AbrProject\Views\HelloWorld\Index.cshtml"
                                                                        Write(c);

#line default
#line hidden
                EndContext();
                BeginContext(1546, 35, true);
                WriteLiteral("</output>\r\n                <br />\r\n");
                EndContext();
#line 44 "C:\Users\Анжела\Desktop\Text-analyse-project\AbrProject\Views\HelloWorld\Index.cshtml"
            }

#line default
#line hidden
#line 44 "C:\Users\Анжела\Desktop\Text-analyse-project\AbrProject\Views\HelloWorld\Index.cshtml"
             
        }

#line default
#line hidden
                BeginContext(1607, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1618, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcMovie.Views.HelloWorld.IndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
