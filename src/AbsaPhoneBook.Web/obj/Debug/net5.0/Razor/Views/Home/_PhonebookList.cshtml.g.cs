#pragma checksum "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\_PhonebookList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9e96d5dad1a16ac0748253011a43552c030602a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__PhonebookList), @"mvc.1.0.view", @"/Views/Home/_PhonebookList.cshtml")]
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
#line 2 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\_ViewImports.cshtml"
using AbsaPhoneBook.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9e96d5dad1a16ac0748253011a43552c030602a", @"/Views/Home/_PhonebookList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09c67a56dca3ae591fe18e70ba5b06e6e71d2f3f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home__PhonebookList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AbsaPhoneBook.Web.Models.PhoneBookViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col"">
        <div class=""card"">
            <!-- Card header -->
            <div class=""card-header"">
                <div class=""row align-items-center"">
                    <div class=""col-12"">
                        <h4 class=""heading-small text-muted"">Phonebook List</h4>
                    </div>
                </div>
            </div>
            <div class=""table-responsive"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th scope=""col"">Name</th>
                            <th scope=""col"">PhoneNumber</th>
                            <th scope=""col"">Created By</th>
                            <th scope=""col"">Created Date</th>
                        </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 25 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\_PhonebookList.cshtml"
                         foreach (var phoneBook in Model.OrderBy(x => x.Name))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\_PhonebookList.cshtml"
                             foreach (var entry in phoneBook.Entries.OrderBy(x => x.Name))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 30 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\_PhonebookList.cshtml"
                                   Write(entry.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 31 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\_PhonebookList.cshtml"
                                   Write(entry.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 32 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\_PhonebookList.cshtml"
                                   Write(entry.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 33 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\_PhonebookList.cshtml"
                                   Write(entry.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 35 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\_PhonebookList.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Dev Base\Assessments\AbsaPhoneBook\AbsaPhoneBook\src\AbsaPhoneBook.Web\Views\Home\_PhonebookList.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AbsaPhoneBook.Web.Models.PhoneBookViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
