#pragma checksum "C:\Users\Rohan\Downloads\aspnet-core-fundamentals\04\demos\demos\after1\OdeToFood\Pages\Restaurants\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1a5f35e2d01c84c1a8e23adce2c3e67197a80f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_Detail), @"mvc.1.0.razor-page", @"/Pages/Restaurants/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/Detail.cshtml", typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_Detail), @"{studentId:int}")]
namespace OdeToFood.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Rohan\Downloads\aspnet-core-fundamentals\04\demos\demos\after1\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{studentId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1a5f35e2d01c84c1a8e23adce2c3e67197a80f0", @"/Pages/Restaurants/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81fe10e6c90f307728f15587f1d83247c98c9355", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Rohan\Downloads\aspnet-core-fundamentals\04\demos\demos\after1\OdeToFood\Pages\Restaurants\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(117, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(124, 18, false);
#line 8 "C:\Users\Rohan\Downloads\aspnet-core-fundamentals\04\demos\demos\after1\OdeToFood\Pages\Restaurants\Detail.cshtml"
Write(Model.Student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(142, 22, true);
            WriteLiteral("</h2>\r\n<div>\r\n    Id: ");
            EndContext();
            BeginContext(165, 16, false);
#line 10 "C:\Users\Rohan\Downloads\aspnet-core-fundamentals\04\demos\demos\after1\OdeToFood\Pages\Restaurants\Detail.cshtml"
   Write(Model.Student.Id);

#line default
#line hidden
            EndContext();
            BeginContext(181, 26, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Age: ");
            EndContext();
            BeginContext(208, 17, false);
#line 13 "C:\Users\Rohan\Downloads\aspnet-core-fundamentals\04\demos\demos\after1\OdeToFood\Pages\Restaurants\Detail.cshtml"
    Write(Model.Student.Age);

#line default
#line hidden
            EndContext();
            BeginContext(225, 30, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Gender : ");
            EndContext();
            BeginContext(256, 20, false);
#line 16 "C:\Users\Rohan\Downloads\aspnet-core-fundamentals\04\demos\demos\after1\OdeToFood\Pages\Restaurants\Detail.cshtml"
        Write(Model.Student.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(276, 28, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Fees : ");
            EndContext();
            BeginContext(305, 18, false);
#line 19 "C:\Users\Rohan\Downloads\aspnet-core-fundamentals\04\demos\demos\after1\OdeToFood\Pages\Restaurants\Detail.cshtml"
      Write(Model.Student.Fees);

#line default
#line hidden
            EndContext();
            BeginContext(323, 33, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Department: ");
            EndContext();
            BeginContext(357, 24, false);
#line 22 "C:\Users\Rohan\Downloads\aspnet-core-fundamentals\04\demos\demos\after1\OdeToFood\Pages\Restaurants\Detail.cshtml"
           Write(Model.Student.department);

#line default
#line hidden
            EndContext();
            BeginContext(381, 28, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Quota: ");
            EndContext();
            BeginContext(410, 19, false);
#line 25 "C:\Users\Rohan\Downloads\aspnet-core-fundamentals\04\demos\demos\after1\OdeToFood\Pages\Restaurants\Detail.cshtml"
      Write(Model.Student.quota);

#line default
#line hidden
            EndContext();
            BeginContext(429, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
#line 28 "C:\Users\Rohan\Downloads\aspnet-core-fundamentals\04\demos\demos\after1\OdeToFood\Pages\Restaurants\Detail.cshtml"
 if(Model.Message != null)
{

#line default
#line hidden
            BeginContext(472, 34, true);
            WriteLiteral("    <div class=\"alert alert-info\">");
            EndContext();
            BeginContext(507, 13, false);
#line 30 "C:\Users\Rohan\Downloads\aspnet-core-fundamentals\04\demos\demos\after1\OdeToFood\Pages\Restaurants\Detail.cshtml"
                             Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(520, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 31 "C:\Users\Rohan\Downloads\aspnet-core-fundamentals\04\demos\demos\after1\OdeToFood\Pages\Restaurants\Detail.cshtml"
}

#line default
#line hidden
            BeginContext(531, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(533, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e09057414434499c94a39a3e64e8c6d4", async() => {
                BeginContext(578, 12, true);
                WriteLiteral("All Students");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
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
            BeginContext(594, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Pages.Restaurants.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.DetailModel>)PageContext?.ViewData;
        public OdeToFood.Pages.Restaurants.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
