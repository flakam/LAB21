#pragma checksum "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Validation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38df7eab4c3c635077a6f5b04c67514be8d01851"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Validation_Index), @"mvc.1.0.view", @"/Views/Validation/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Validation/Index.cshtml", typeof(AspNetCore.Views_Validation_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38df7eab4c3c635077a6f5b04c67514be8d01851", @"/Views/Validation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dc4e46c305daca7c01bcb47467b331f3613ec2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Validation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LAB21.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Validation\Index.cshtml"
  
    ViewData["Title"] = "User";

#line default
#line hidden
            BeginContext(68, 115, true);
            WriteLiteral("\r\n<h2>User</h2>\r\n\r\n<div>\r\n    <h4>User</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(184, 45, false);
#line 14 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Validation\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(229, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(273, 41, false);
#line 17 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Validation\Index.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(314, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(358, 44, false);
#line 20 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Validation\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(402, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(446, 40, false);
#line 23 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Validation\Index.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(486, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(532, 44, false);
#line 27 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Validation\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(576, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(620, 40, false);
#line 30 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Validation\Index.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(660, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(704, 41, false);
#line 33 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Validation\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(745, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(789, 37, false);
#line 36 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Validation\Index.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(826, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(870, 47, false);
#line 39 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Validation\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(917, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(961, 43, false);
#line 42 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Validation\Index.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1004, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1048, 39, false);
#line 45 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Validation\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(1087, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1131, 35, false);
#line 48 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Validation\Index.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1214, 68, false);
#line 53 "C:\Users\Flaka\Desktop\lab221\LAB21\Views\Validation\Index.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1290, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98e9ff6c1c21424cb7624df2f02117c8", async() => {
                BeginContext(1312, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1328, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LAB21.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
