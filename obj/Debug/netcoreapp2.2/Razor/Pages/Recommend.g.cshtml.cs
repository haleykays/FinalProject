#pragma checksum "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57ab75ac76cd43a23259c3f70d5badbe0e1eeac9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MakeupProject.Pages.Pages_Recommend), @"mvc.1.0.razor-page", @"/Pages/Recommend.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Recommend.cshtml", typeof(MakeupProject.Pages.Pages_Recommend), null)]
namespace MakeupProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\_ViewImports.cshtml"
using MakeupProject;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ab75ac76cd43a23259c3f70d5badbe0e1eeac9", @"/Pages/Recommend.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92c51f5a2eed0bedb23121d67122c1b47f42485e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Recommend : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
  
    ViewData["Title"] = "Tell us what you want to see!";

#line default
#line hidden
            BeginContext(95, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(100, 17, false);
#line 6 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(117, 470, true);
            WriteLiteral(@"</h1>

<table class=""table table-borderless table-dark"">
  <thead>
    <tr>
      <th scope=""col-3"">Face</th>
      <th scope=""col-3"">Eyes</th>
      <th scope=""col-3"">Lips</th>
      <th scope=""col-3""></th>
    </tr>
  </thead>
  <tbody>
      <tr><img src=""/img/Foundation.jpg"" width=""250"" height=""200""></tr>
      <tr><img src=""/img/Eyes.jpg"" width=""300"" height=""200""></tr>
      <tr><img src=""/img/Lips.jpg"" width=""250"" height=""200""></tr>

    <tr>
");
            EndContext();
            BeginContext(587, 375, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57ab75ac76cd43a23259c3f70d5badbe0e1eeac94600", async() => {
                BeginContext(607, 348, true);
                WriteLiteral(@"
    <td><input type=""checkbox"" name=""selectedProductTypes"" value=""1""/> Most Popular</td>
    <td><input type=""checkbox"" name=""selectedProductTypes"" value=""2""/> Most Popular</td>
    <td><input type=""checkbox"" name=""selectedProductTypes"" value=""3""/> Most Popular</td>
    <td><input type=""submit"" value=""Submit"" class=""btn btn-primary""/></td>
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(962, 45, true);
            WriteLiteral("\r\n    </tr>\r\n  </tbody>\r\n</table>\r\n\r\n<hr />\r\n");
            EndContext();
#line 34 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
 if (Model.Product != null)
{
    

#line default
#line hidden
#line 36 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
     foreach(var item in Model.Product)
    {

#line default
#line hidden
            BeginContext(1087, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(1099, 10, false);
#line 38 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
      Write(item.Brand);

#line default
#line hidden
            EndContext();
            BeginContext(1109, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1111, 9, false);
#line 38 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
                  Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1120, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1122, 10, false);
#line 38 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
                             Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1132, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1134, 10, false);
#line 38 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
                                         Write(item.BuyAt);

#line default
#line hidden
            EndContext();
            BeginContext(1144, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 39 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
    }

#line default
#line hidden
#line 39 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
     
}

#line default
#line hidden
            BeginContext(1160, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecommendModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecommendModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecommendModel>)PageContext?.ViewData;
        public RecommendModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591