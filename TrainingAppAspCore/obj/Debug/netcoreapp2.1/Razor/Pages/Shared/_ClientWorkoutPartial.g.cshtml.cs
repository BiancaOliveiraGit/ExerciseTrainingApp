#pragma checksum "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_ClientWorkoutPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e13e6d3da20bfe6eb596bf4a66fd84caa222954e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TrainingAppAspCore.Pages.Shared.Pages_Shared__ClientWorkoutPartial), @"mvc.1.0.view", @"/Pages/Shared/_ClientWorkoutPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_ClientWorkoutPartial.cshtml", typeof(TrainingAppAspCore.Pages.Shared.Pages_Shared__ClientWorkoutPartial))]
namespace TrainingAppAspCore.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\_ViewImports.cshtml"
using TrainingAppAspCore;

#line default
#line hidden
#line 1 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_ClientWorkoutPartial.cshtml"
using TrainingAppAspCore.Dto;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e13e6d3da20bfe6eb596bf4a66fd84caa222954e", @"/Pages/Shared/_ClientWorkoutPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b57369da85e88f0ca020fcd7bc1f3dbd9a980067", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__ClientWorkoutPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClientWorkoutDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "StartExercises", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(56, 141, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\" id=\"clientworkout\">\r\n        <div  class=\"col-sm-12 col-lg-12 col-md-12\">\r\n            ");
            EndContext();
            BeginContext(197, 304, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ea88a8ada0649bfbc0964d326d7c0b1", async() => {
                BeginContext(262, 26, true);
                WriteLiteral("\r\n                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 288, "\"", 321, 1);
#line 8 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_ClientWorkoutPartial.cshtml"
WriteAttributeValue("", 294, Model.WorkoutPlan.ImageUrl, 294, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(322, 23, true);
                WriteLiteral(" class=\"img-responsive\"");
                EndContext();
                BeginWriteAttribute("alt", " alt=\"", 345, "\"", 374, 1);
#line 8 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_ClientWorkoutPartial.cshtml"
WriteAttributeValue("", 351, Model.WorkoutPlan.Name, 351, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(375, 70, true);
                WriteLiteral(" />\r\n                    <div id=\"indexText\" class=\"centered\"><strong>");
                EndContext();
                BeginContext(446, 22, false);
#line 9 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_ClientWorkoutPartial.cshtml"
                                                            Write(Model.WorkoutPlan.Name);

#line default
#line hidden
                EndContext();
                BeginContext(468, 29, true);
                WriteLiteral("</strong></div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 7 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_ClientWorkoutPartial.cshtml"
                                           WriteLiteral(Model.WorkoutPlanId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(501, 44, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClientWorkoutDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
