#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a0ad3c59f3a87877c36928472f0508bd40cdd8c"
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
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelper_cshtml : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("bar", " World", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0414
        private string __tagHelperStringValueBuffer = null;
        #pragma warning restore 0414
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext = null;
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
        private global::AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelper_cshtml.__Generated__TestViewComponentTagHelper __AspNetCore_TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelper_cshtml___Generated__TestViewComponentTagHelper = null;
        private global::AllTagHelper __AllTagHelper = null;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelper.cshtml"
  
    var foo = "Hello";

#line default
#line hidden
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(61, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:test", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
            }
            );
            __AspNetCore_TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelper_cshtml___Generated__TestViewComponentTagHelper = CreateTagHelper<global::AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelper_cshtml.__Generated__TestViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__AspNetCore_TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelper_cshtml___Generated__TestViewComponentTagHelper);
            __AllTagHelper = CreateTagHelper<global::AllTagHelper>();
            __tagHelperExecutionContext.Add(__AllTagHelper);
            BeginWriteTagHelperAttribute();
#line 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelper.cshtml"
         WriteLiteral(foo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __AspNetCore_TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelper_cshtml___Generated__TestViewComponentTagHelper.firstName = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("first-name", __AspNetCore_TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelper_cshtml___Generated__TestViewComponentTagHelper.firstName, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __AllTagHelper.Bar = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:test")]
public class __Generated__TestViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
{
    private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
    public __Generated__TestViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
    {
        _helper = helper;
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
    public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
    public System.String firstName { get; set; }
    public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
    {
        (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
        var content = await _helper.InvokeAsync("Test", new { firstName });
        output.TagName = null;
        output.Content.SetHtmlContent(content);
    }
}

    }
}
