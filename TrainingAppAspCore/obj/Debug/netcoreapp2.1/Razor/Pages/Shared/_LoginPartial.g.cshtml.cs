#pragma checksum "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce111233d2bd7f83b5046c187a009519e097e13b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TrainingAppAspCore.Pages.Shared.Pages_Shared__LoginPartial), @"mvc.1.0.view", @"/Pages/Shared/_LoginPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_LoginPartial.cshtml", typeof(TrainingAppAspCore.Pages.Shared.Pages_Shared__LoginPartial))]
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
#line 1 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_LoginPartial.cshtml"
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;

#line default
#line hidden
#line 2 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_LoginPartial.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce111233d2bd7f83b5046c187a009519e097e13b", @"/Pages/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b57369da85e88f0ca020fcd7bc1f3dbd9a980067", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "AzureADB2C", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SignOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SignIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(157, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_LoginPartial.cshtml"
  
    var options = AzureADB2COptions.Get(AzureADB2CDefaults.AuthenticationScheme);

#line default
#line hidden
            BeginContext(249, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 10 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_LoginPartial.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(293, 46, true);
            WriteLiteral("    <ul class=\"nav navbar-nav navbar-right\">\r\n");
            EndContext();
#line 13 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_LoginPartial.cshtml"
         if (!string.IsNullOrEmpty(options.EditProfilePolicyId))
        {

#line default
#line hidden
            BeginContext(416, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(432, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ca0cc5bb2124d86bae2e08acc6d4c29", async() => {
                BeginContext(507, 6, true);
                WriteLiteral("Hello ");
                EndContext();
                BeginContext(514, 18, false);
#line 15 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_LoginPartial.cshtml"
                                                                                            Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(532, 1, true);
                WriteLiteral("!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            BeginContext(537, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 16 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_LoginPartial.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(580, 42, true);
            WriteLiteral("            <li class=\"navbar-text\">Hello ");
            EndContext();
            BeginContext(623, 18, false);
#line 19 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_LoginPartial.cshtml"
                                     Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(641, 8, true);
            WriteLiteral("!</li>\r\n");
            EndContext();
#line 20 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_LoginPartial.cshtml"
        }

#line default
#line hidden
            BeginContext(660, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(672, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c45b939fe3e4688a82290263650a87a", async() => {
                BeginContext(743, 8, true);
                WriteLiteral("Sign out");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            BeginContext(755, 18, true);
            WriteLiteral("</li>\r\n    </ul>\r\n");
            EndContext();
#line 23 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_LoginPartial.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(785, 58, true);
            WriteLiteral("    <ul class=\"nav navbar-nav navbar-right\">\r\n        <li>");
            EndContext();
            BeginContext(843, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4ede3b8f950419fb9ad83040ce836c2", async() => {
                BeginContext(913, 7, true);
                WriteLiteral("Sign in");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            BeginContext(924, 18, true);
            WriteLiteral("</li>\r\n    </ul>\r\n");
            EndContext();
#line 29 "C:\Projects\AspCoreTestProjects\ExerciseTrainingApp\TrainingAppAspCore\Pages\Shared\_LoginPartial.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptionsMonitor<AzureADB2COptions> AzureADB2COptions { get; private set; }
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
