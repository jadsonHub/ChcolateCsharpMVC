#pragma checksum "/home/pingulino/Downloads/ProjetoChocolate (3)/Views/Chocolate/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "046d5238101b5b11f83cf1ff4bac57c2c1c474cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chocolate_Details), @"mvc.1.0.view", @"/Views/Chocolate/Details.cshtml")]
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
#nullable restore
#line 1 "/home/pingulino/Downloads/ProjetoChocolate (3)/Views/_ViewImports.cshtml"
using ProjetoChocolate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/pingulino/Downloads/ProjetoChocolate (3)/Views/_ViewImports.cshtml"
using ProjetoChocolate.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"046d5238101b5b11f83cf1ff4bac57c2c1c474cc", @"/Views/Chocolate/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b9408b61dc5f9d8adc78f8d72eaed77e5634942", @"/Views/_ViewImports.cshtml")]
    public class Views_Chocolate_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoChocolate.Models.Chocolate>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/home/pingulino/Downloads/ProjetoChocolate (3)/Views/Chocolate/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""card"">
        <div class=""card-body"">
            <h1 class=""text-center"">Detalhes do Chocolate</h1><br />
            <div class=""row justify-content-md-center"">
                <div class=""col-md-12 col-lg-12"">
                    <hr />
                    <dl class=""row"">
                        <dt class=""col-sm-2"">
                            Marca
                        </dt>
                        <dd class=""col-sm-10"">
                            ");
#nullable restore
#line 19 "/home/pingulino/Downloads/ProjetoChocolate (3)/Views/Chocolate/Details.cshtml"
                       Write(Html.DisplayFor(model => model.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            Porcentagem de Cacau\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 25 "/home/pingulino/Downloads/ProjetoChocolate (3)/Views/Chocolate/Details.cshtml"
                       Write(Html.DisplayFor(model => model.Porcent_Cacau));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            Tipo\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 31 "/home/pingulino/Downloads/ProjetoChocolate (3)/Views/Chocolate/Details.cshtml"
                       Write(Html.DisplayFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            Data de Validade\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 37 "/home/pingulino/Downloads/ProjetoChocolate (3)/Views/Chocolate/Details.cshtml"
                       Write(Html.DisplayFor(model => model.Data_Validade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 40 "/home/pingulino/Downloads/ProjetoChocolate (3)/Views/Chocolate/Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 43 "/home/pingulino/Downloads/ProjetoChocolate (3)/Views/Chocolate/Details.cshtml"
                       Write(Html.DisplayFor(model => model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            Porcentagem de Desconto\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 49 "/home/pingulino/Downloads/ProjetoChocolate (3)/Views/Chocolate/Details.cshtml"
                       Write(Html.DisplayFor(model => model.Porcent_Desconto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n                </div>\r\n                <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "046d5238101b5b11f83cf1ff4bac57c2c1c474cc8164", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 54 "/home/pingulino/Downloads/ProjetoChocolate (3)/Views/Chocolate/Details.cshtml"
                                           WriteLiteral(Model.Id_Chocolate);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "046d5238101b5b11f83cf1ff4bac57c2c1c474cc10315", async() => {
                WriteLiteral("Voltar para o inicio ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</div>\r\n<div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoChocolate.Models.Chocolate> Html { get; private set; }
    }
}
#pragma warning restore 1591
