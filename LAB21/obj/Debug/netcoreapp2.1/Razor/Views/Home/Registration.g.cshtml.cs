#pragma checksum "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Home\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "214e28865ef6eaace00516f45c4a4a2d28ca3269"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registration), @"mvc.1.0.view", @"/Views/Home/Registration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Registration.cshtml", typeof(AspNetCore.Views_Home_Registration))]
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
#line 1 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\_ViewImports.cshtml"
using LAB21;

#line default
#line hidden
#line 2 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\_ViewImports.cshtml"
using LAB21.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"214e28865ef6eaace00516f45c4a4a2d28ca3269", @"/Views/Home/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dc4e46c305daca7c01bcb47467b331f3613ec2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Result"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 520, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed0ec7b5f8174453b6d1ca59759129d8", async() => {
                BeginContext(35, 478, true);
                WriteLiteral(@"
    <h4>Please fill the form to register!</h4>
    <p>First Name:</p>
    <input type=""text"" name=""FirstName"" />
    <p>Last Name:</p>
    <input type=""text"" name=""LastName"" />
    <p>Email:</p>
    <input type=""email"" name=""Email"" />
    <p>Phone Number:</p>
    <input type=""number"" name=""PhoneNumber"" />
    <p>Password:</p>
    <input type=""password"" name=""Password"" />
    <p>Age</p>
    <input type =""number""  name=""Age"" />


    <input type=""submit"" />
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
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
            BeginContext(520, 8, true);
            WriteLiteral("\r\n\r\n<p> ");
            EndContext();
            BeginContext(529, 17, false);
#line 20 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Home\Registration.cshtml"
Write(ViewBag.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(546, 10, true);
            WriteLiteral("</p>\r\n<p> ");
            EndContext();
            BeginContext(557, 16, false);
#line 21 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Home\Registration.cshtml"
Write(ViewBag.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(573, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(583, 13, false);
#line 22 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Home\Registration.cshtml"
Write(ViewBag.email);

#line default
#line hidden
            EndContext();
            BeginContext(596, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(606, 19, false);
#line 23 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Home\Registration.cshtml"
Write(ViewBag.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(625, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(635, 16, false);
#line 24 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Home\Registration.cshtml"
Write(ViewBag.Password);

#line default
#line hidden
            EndContext();
            BeginContext(651, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(661, 11, false);
#line 25 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Home\Registration.cshtml"
Write(ViewBag.Age);

#line default
#line hidden
            EndContext();
            BeginContext(672, 4, true);
            WriteLiteral("</p>");
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
