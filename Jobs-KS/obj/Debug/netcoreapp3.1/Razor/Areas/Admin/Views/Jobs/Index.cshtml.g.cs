#pragma checksum "C:\Users\getoa\OneDrive\Desktop\Getoar Arifaj\JobsProject\Jobs-KS\Jobs-KS\Areas\Admin\Views\Jobs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d78ace40b7635639e5c81c002b05f635b6d4681"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Jobs_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Jobs/Index.cshtml")]
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
#line 1 "C:\Users\getoa\OneDrive\Desktop\Getoar Arifaj\JobsProject\Jobs-KS\Jobs-KS\Areas\Admin\Views\_ViewImports.cshtml"
using Jobs_KS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\getoa\OneDrive\Desktop\Getoar Arifaj\JobsProject\Jobs-KS\Jobs-KS\Areas\Admin\Views\Jobs\Index.cshtml"
using Jobs_KS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d78ace40b7635639e5c81c002b05f635b6d4681", @"/Areas/Admin/Views/Jobs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e9794bdf35e129156c174e2f00f0e2eec7b546", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Jobs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Job>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\getoa\OneDrive\Desktop\Getoar Arifaj\JobsProject\Jobs-KS\Jobs-KS\Areas\Admin\Views\Jobs\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n<br />\n<div class=\"row\">\n    <div class=\"col-6\">\n        <h2 class=\"text-info\">Job List</h2>\n    </div>\n    <div class=\"col-6 text-right\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d78ace40b7635639e5c81c002b05f635b6d46814699", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; Add New Job");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n    <div class=\"col-3\"></div>\n</div>\n\n<br />\n<div>\n    <table class=\"table table-striped border\" id=\"myTable\">\n        <thead>\n            <tr class=\"table-info\">\n                <th>\n                    ");
#nullable restore
#line 23 "C:\Users\getoa\OneDrive\Desktop\Getoar Arifaj\JobsProject\Jobs-KS\Jobs-KS\Areas\Admin\Views\Jobs\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 26 "C:\Users\getoa\OneDrive\Desktop\Getoar Arifaj\JobsProject\Jobs-KS\Jobs-KS\Areas\Admin\Views\Jobs\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 29 "C:\Users\getoa\OneDrive\Desktop\Getoar Arifaj\JobsProject\Jobs-KS\Jobs-KS\Areas\Admin\Views\Jobs\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.JobTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th></th>\n                <th></th>\n            </tr>\n        </thead>\n\n        <tbody>\n");
#nullable restore
#line 37 "C:\Users\getoa\OneDrive\Desktop\Getoar Arifaj\JobsProject\Jobs-KS\Jobs-KS\Areas\Admin\Views\Jobs\Index.cshtml"
             foreach (var item in Model )
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 40 "C:\Users\getoa\OneDrive\Desktop\Getoar Arifaj\JobsProject\Jobs-KS\Jobs-KS\Areas\Admin\Views\Jobs\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 41 "C:\Users\getoa\OneDrive\Desktop\Getoar Arifaj\JobsProject\Jobs-KS\Jobs-KS\Areas\Admin\Views\Jobs\Index.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 42 "C:\Users\getoa\OneDrive\Desktop\Getoar Arifaj\JobsProject\Jobs-KS\Jobs-KS\Areas\Admin\Views\Jobs\Index.cshtml"
               Write(item.JobTypes.JobType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4d78ace40b7635639e5c81c002b05f635b6d46818535", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 44 "C:\Users\getoa\OneDrive\Desktop\Getoar Arifaj\JobsProject\Jobs-KS\Jobs-KS\Areas\Admin\Views\Jobs\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.ID;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 47 "C:\Users\getoa\OneDrive\Desktop\Getoar Arifaj\JobsProject\Jobs-KS\Jobs-KS\Areas\Admin\Views\Jobs\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n\n\n    </table>\n</div>\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""//cdn.jsdelivr.net/npm/alertifyjs@1.11.2/build/alertify.min.js""></script>

    <script type=""text/javascript"">
        $(document).ready( function () {
            $('#myTable').DataTable({
                dom: 'Bfrtip',
                buttons: [
                    'pageLength'
                ]
            });
        } );
        $(function(){
            var save = '");
#nullable restore
#line 67 "C:\Users\getoa\OneDrive\Desktop\Getoar Arifaj\JobsProject\Jobs-KS\Jobs-KS\Areas\Admin\Views\Jobs\Index.cshtml"
                   Write(TempData["save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\n            if(save!=\'\') {\n                alertify.success(save);\n            }\n            var edit = \'");
#nullable restore
#line 71 "C:\Users\getoa\OneDrive\Desktop\Getoar Arifaj\JobsProject\Jobs-KS\Jobs-KS\Areas\Admin\Views\Jobs\Index.cshtml"
                   Write(TempData["edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\n            if(edit!=\'\') {\n                alertify.success(edit);\n            }\n            var del = \'");
#nullable restore
#line 75 "C:\Users\getoa\OneDrive\Desktop\Getoar Arifaj\JobsProject\Jobs-KS\Jobs-KS\Areas\Admin\Views\Jobs\Index.cshtml"
                  Write(TempData["delete"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\n            if (del!=\'\') {\n                alertify.error(del);\n            }\n        })\n    </script>\n");
            }
            );
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Job>> Html { get; private set; }
    }
}
#pragma warning restore 1591
