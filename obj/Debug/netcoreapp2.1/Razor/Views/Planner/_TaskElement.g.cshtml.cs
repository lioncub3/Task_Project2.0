#pragma checksum "C:\Users\s28-vp\Desktop\Tasks\Views\Planner\_TaskElement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db82af0f6e6f12cd56630cefb8760e27b04fbb69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planner__TaskElement), @"mvc.1.0.view", @"/Views/Planner/_TaskElement.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Planner/_TaskElement.cshtml", typeof(AspNetCore.Views_Planner__TaskElement))]
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
#line 1 "C:\Users\s28-vp\Desktop\Tasks\Views\_ViewImports.cshtml"
using PlannerApp;

#line default
#line hidden
#line 2 "C:\Users\s28-vp\Desktop\Tasks\Views\_ViewImports.cshtml"
using PlannerApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db82af0f6e6f12cd56630cefb8760e27b04fbb69", @"/Views/Planner/_TaskElement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"636513d8fe1e47bc74941356e63a611206e63468", @"/Views/_ViewImports.cshtml")]
    public class Views_Planner__TaskElement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger delete-task"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(17, 6, true);
            WriteLiteral("\r\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 23, "\"", 62, 2);
            WriteAttributeValue("", 31, "task", 31, 4, true);
#line 3 "C:\Users\s28-vp\Desktop\Tasks\Views\Planner\_TaskElement.cshtml"
WriteAttributeValue(" ", 35, Model.Done ? "done": "", 36, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(63, 176, true);
            WriteLiteral(">\r\n\r\n    <div class=\"task-icon\">\r\n        <i class=\"fa fa-check-circle fa-2x\"></i>\r\n        <i class=\"fa fa-circle fa-2x\"></i>\r\n    </div>\r\n    <div class=\"task-name\" data-id=\"");
            EndContext();
            BeginContext(240, 8, false);
#line 9 "C:\Users\s28-vp\Desktop\Tasks\Views\Planner\_TaskElement.cshtml"
                               Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(248, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(251, 10, false);
#line 9 "C:\Users\s28-vp\Desktop\Tasks\Views\Planner\_TaskElement.cshtml"
                                          Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(261, 47, true);
            WriteLiteral("</div>\r\n    <div id=\"task-date\" class=\"hidden\">");
            EndContext();
            BeginContext(309, 10, false);
#line 10 "C:\Users\s28-vp\Desktop\Tasks\Views\Planner\_TaskElement.cshtml"
                                  Write(Model.Date);

#line default
#line hidden
            EndContext();
            BeginContext(319, 54, true);
            WriteLiteral("</div>\r\n    <div id=\"task-description\" class=\"hidden\">");
            EndContext();
            BeginContext(374, 17, false);
#line 11 "C:\Users\s28-vp\Desktop\Tasks\Views\Planner\_TaskElement.cshtml"
                                         Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(391, 126, true);
            WriteLiteral("</div>\r\n    <a id=\"task-info\" class=\"btn btn-info\" data-toggle=\"modal\" href=\"#task-modal\"><i class=\"fa fa-info\"></i></a>\r\n    ");
            EndContext();
            BeginContext(517, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1406a2fe5cd464f8c56e23444afd0d9", async() => {
                BeginContext(600, 29, true);
                WriteLiteral(" <i class=\"fa fa-trash\"></i> ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\s28-vp\Desktop\Tasks\Views\Planner\_TaskElement.cshtml"
                             WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(633, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
