#pragma checksum "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f774f30be1b910ca978d4ba512b557d02b574d9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f774f30be1b910ca978d4ba512b557d02b574d9", @"/Pages/Recommend.cshtml")]
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
            BeginContext(117, 544, true);
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
      <tr><img src=""/img/Foundation.jpg"" width=""260"" height=""220""></tr>
      <tr><img src=""/img/Eyes.jpg"" width=""300"" height=""220""></tr>
      <tr><img src=""/img/Lips.jpg"" width=""270"" height=""220""></tr>
      <tr><img src=""/img/Recommend.jpg"" width=""278"" height=""220""></tr>


    <tr>
");
            EndContext();
            BeginContext(661, 375, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f774f30be1b910ca978d4ba512b557d02b574d94680", async() => {
                BeginContext(681, 348, true);
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
            BeginContext(1036, 45, true);
            WriteLiteral("\r\n    </tr>\r\n  </tbody>\r\n</table>\r\n\r\n<hr />\r\n");
            EndContext();
#line 36 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
 if (Model.Product != null)
{
    
    

#line default
#line hidden
#line 39 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
     foreach(var item in Model.Product)
    {

#line default
#line hidden
            BeginContext(1167, 458, true);
            WriteLiteral(@"  <table class=""table table-dark"">
    <thead>
        <tr>
            <th>
                Brand
            </th>
            <th>
                Name
            </th>
            <th>
                Price
            </th>
            <th>
                Purchase at
            </th>
            <th>
                Stars
            </th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                ");
            EndContext();
            BeginContext(1626, 40, false);
#line 64 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
           Write(Html.DisplayFor(modelItem => item.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(1666, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1722, 39, false);
#line 67 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1761, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1817, 40, false);
#line 70 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1857, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1913, 40, false);
#line 73 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
           Write(Html.DisplayFor(modelItem => item.BuyAt));

#line default
#line hidden
            EndContext();
            BeginContext(1953, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 76 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
                  
                  if(item.Reviews.Count > 0)
                  {
                    double avg = item.Reviews.Average(r => r.Stars);
                    

#line default
#line hidden
            BeginContext(2170, 33, false);
#line 80 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
               Write(Html.DisplayFor(modelItem => avg));

#line default
#line hidden
            EndContext();
#line 80 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
                                                      
                  }
                  else
                  {

#line default
#line hidden
            BeginContext(2271, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2293, 16, true);
            WriteLiteral("No Reviews Yet\r\n");
            EndContext();
#line 85 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
                  }
                

#line default
#line hidden
            BeginContext(2349, 66, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n<hr />\r\n");
            EndContext();
#line 92 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
        //<p>Brand : @item.Brand Name: @item.Name Price: @item.Price Purchase at: @item.BuyAt</p>
    }

#line default
#line hidden
#line 93 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Recommend.cshtml"
     
}

#line default
#line hidden
            BeginContext(2524, 2, true);
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
