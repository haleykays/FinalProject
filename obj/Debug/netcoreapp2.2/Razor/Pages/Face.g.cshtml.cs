#pragma checksum "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Face.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5673fe4462ef4594d5aa6c632f521a01e70fbba5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MakeupProject.Pages.Pages_Face), @"mvc.1.0.razor-page", @"/Pages/Face.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Face.cshtml", typeof(MakeupProject.Pages.Pages_Face), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5673fe4462ef4594d5aa6c632f521a01e70fbba5", @"/Pages/Face.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92c51f5a2eed0bedb23121d67122c1b47f42485e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Face : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Face.cshtml"
  
    ViewData["Title"] = "Face page";

#line default
#line hidden
            BeginContext(74, 97, true);
            WriteLiteral("\r\n<table class=\"table table-dark\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(172, 56, false);
#line 12 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Face.cshtml"
           Write(Html.DisplayNameFor(model => model.faceProduct[0].Brand));

#line default
#line hidden
            EndContext();
            BeginContext(228, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(284, 55, false);
#line 15 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Face.cshtml"
           Write(Html.DisplayNameFor(model => model.faceProduct[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(339, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(395, 56, false);
#line 18 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Face.cshtml"
           Write(Html.DisplayNameFor(model => model.faceProduct[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(451, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(507, 56, false);
#line 21 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Face.cshtml"
           Write(Html.DisplayNameFor(model => model.faceProduct[0].BuyAt));

#line default
#line hidden
            EndContext();
            BeginContext(563, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(619, 58, false);
#line 24 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Face.cshtml"
           Write(Html.DisplayNameFor(model => model.faceProduct[0].Reviews));

#line default
#line hidden
            EndContext();
            BeginContext(677, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Face.cshtml"
 foreach (var item in Model.faceProduct) 
{

#line default
#line hidden
            BeginContext(786, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(835, 40, false);
#line 33 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Face.cshtml"
           Write(Html.DisplayFor(modelItem => item.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(875, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(931, 39, false);
#line 36 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Face.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(970, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1026, 40, false);
#line 39 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Face.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1122, 40, false);
#line 42 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Face.cshtml"
           Write(Html.DisplayFor(modelItem => item.BuyAt));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1218, 42, false);
#line 45 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Face.cshtml"
           Write(Html.DisplayFor(modelItem => item.Reviews));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 90, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n               \r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\haley\Documents\SPRING2019\Advanced Business Programming\MakeupProject\Pages\Face.cshtml"
}

#line default
#line hidden
            BeginContext(1353, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FaceModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FaceModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FaceModel>)PageContext?.ViewData;
        public FaceModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591