#pragma checksum "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_ExercisesPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57144f3b8f6b0471a34850e269a3443faa6422a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TrainingAppAspCore.Pages.Shared.Pages_Shared__ExercisesPartial), @"mvc.1.0.view", @"/Pages/Shared/_ExercisesPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_ExercisesPartial.cshtml", typeof(TrainingAppAspCore.Pages.Shared.Pages_Shared__ExercisesPartial))]
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
#line 1 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_ExercisesPartial.cshtml"
using TrainingAppAspCore.Dto;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57144f3b8f6b0471a34850e269a3443faa6422a1", @"/Pages/Shared/_ExercisesPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b57369da85e88f0ca020fcd7bc1f3dbd9a980067", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__ExercisesPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExerciseDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 73, true);
            WriteLiteral("\r\n<div id=\"exerciseGrid\" class=\"col-sm-6 col-lg-6 col-md-6\">\r\n    <iframe");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 124, "\"", 158, 1);
#line 5 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_ExercisesPartial.cshtml"
WriteAttributeValue("", 130, Model.VideoLibrary.VideoUrl, 130, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(159, 94, true);
            WriteLiteral(" width=\"560\" height=\"315\" allowfullscreen></iframe>\r\n    <div id=\"ExerciseText\">\r\n        <h4>");
            EndContext();
            BeginContext(254, 10, false);
#line 7 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_ExercisesPartial.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(264, 31, true);
            WriteLiteral("</h4>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExerciseDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
