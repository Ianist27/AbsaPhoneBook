#pragma checksum "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91834fceb7ee38ec57f4478369250cfcc34fcb14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\_ViewImports.cshtml"
using AbsaPhoneBook.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
using AbsaPhoneBook.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91834fceb7ee38ec57f4478369250cfcc34fcb14", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09c67a56dca3ae591fe18e70ba5b06e6e71d2f3f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntryViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Absa Phonebook";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""row"">
    <div class=""col"">
        <div class=""card"">
            <!-- Card header -->
            <div class=""row ml-0"">
                <div class=""card-header border-0"">
                    <span class=""text-muted"">
                        <b>
                            Phonebook
                        </b>
                    </span>
                    <span>
                        <button class=""btn btn-icon btn-primary btn-sm"" type=""button"" data-toggle=""modal"" data-target=""#addphoneBookModal"">
                            <span class=""btn-inner--text"">Add PhoneBook</span>
                        </button>
                    </span>
                </div>
            </div>
            <div class=""row ml-0"">
");
#nullable restore
#line 29 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
                 using (Html.BeginForm("GetPhonebook", "Home", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"input-group\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "91834fceb7ee38ec57f4478369250cfcc34fcb145669", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 32 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""input-group-btn"">
                            <button class=""btn btn-default"" type=""submit"">
                                <i class=""glyphicon glyphicon-search""></i>
                            </button>
                        </div>
                    </div>
");
#nullable restore
#line 39 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

            <!-- Modal -->
            <div class=""modal fade"" id=""addphoneBookModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addPhoneBookModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog modal-dialog-centered"" role=""main"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"" id=""exampleModalLabel"">Add Phonebook</h5>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
");
#nullable restore
#line 52 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
                         using (Html.BeginForm("Create", "Home", FormMethod.Post))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"modal-body\">\r\n                                <div class=\"form-group mb-3\">\r\n                                    <label class=\"form-control-label\" for=\"name\">Name</label>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "91834fceb7ee38ec57f4478369250cfcc34fcb149372", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 57 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n                                    <label class=\"form-control-label\" for=\"desc\">Phone Number</label>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "91834fceb7ee38ec57f4478369250cfcc34fcb1411669", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 61 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PhoneNumber);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""modal-footer"">
                                <button type=""submit"" class=""btn btn-primary"">Add</button>
                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                            </div>
");
#nullable restore
#line 68 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n\r\n");
#nullable restore
#line 73 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
             if (!string.IsNullOrWhiteSpace(TempData["StatusMessage"] as string))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- everything went ok -->\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-12\">\r\n                        <div role=\"alert\" class=\"alert alert-success alert-dismissible fade show\">\r\n                            ");
#nullable restore
#line 79 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
                       Write(TempData["StatusMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                <span aria-hidden=""true"">×</span>
                            </button>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 86 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
            }

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
             if (!ViewData.ModelState.IsValid && ViewData.ModelState[string.Empty] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- errors -->\r\n");
#nullable restore
#line 92 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
                 foreach (var error in @ViewData.ModelState[string.Empty]?.Errors)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n                        <div class=\"col-lg-12\">\r\n                            <div role=\"alert\" class=\"alert alert-warning alert-dismissible fade show\">\r\n                                <span>");
#nullable restore
#line 97 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
                                 Write(error.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                    <span aria-hidden=""true"">×</span>
                                </button>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 104 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 108 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
             if (ViewBag.PhoneBooks != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
           Write(await Html.PartialAsync("_PhonebookList", (List<PhoneBookViewModel>)ViewBag.PhoneBooks));

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\Index.cshtml"
                                                                                                        
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591