#pragma checksum "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3463c713675b4ffc5fbf680c7b7eb8260bc6cedc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\_ViewImports.cshtml"
using DemoDotNet5.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\_ViewImports.cshtml"
using DemoDotNet5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3463c713675b4ffc5fbf680c7b7eb8260bc6cedc", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b5654109d4820fdaaaf30cabe68258086956ce8", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DemoDotNet5.ViewModel.CategoryViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure ?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1 class=""m-0 text-dark"">Category</h1>
            </div><!-- /.col -->
            <div class=""col-sm-6"">
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.container-fluid -->
</div>
<!-- /.content-header -->
<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Total List: ");
#nullable restore
#line 22 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                                                      Write(ViewBag.totalItems);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                        <div class=\"card-tools\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3463c713675b4ffc5fbf680c7b7eb8260bc6cedc7135", async() => {
                WriteLiteral(@"
                                <div class=""input-group input-group-sm"" style=""width: 150px;"">
                                    <input type=""text"" name=""search"" class=""form-control float-right"" placeholder=""Search"">

                                    <div class=""input-group-append"">
                                        <button type=""submit"" class=""btn btn-default""><i class=""fas fa-search""></i></button>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                    <!-- /.card-header -->
                    <div class=""card-body table-responsive p-0"">
                        <table class=""table table-hover text-nowrap"">
                            <thead>
                                <tr>
                                    <th>Category Name</th>
                                    <th>Description</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 47 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                                 if (Model.Count() > 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                                     foreach (var obj in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 52 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                                           Write(obj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 53 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                                           Write(obj.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3463c713675b4ffc5fbf680c7b7eb8260bc6cedc11294", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                                                                               WriteLiteral(obj.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3463c713675b4ffc5fbf680c7b7eb8260bc6cedc13821", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                                                                                                                          WriteLiteral(obj.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 59 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
        </div>


        <div class=""row"">
            <div class=""col-2"">
                <div class=""form-group"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3463c713675b4ffc5fbf680c7b7eb8260bc6cedc17370", async() => {
                WriteLiteral("\r\n                        <div class=\"input-group\">\r\n                            <input type=\"number\" name=\"pageSize\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 3521, "\"", 3546, 1);
#nullable restore
#line 76 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 3529, ViewBag.pageSize, 3529, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1\">\r\n                            <input type=\"hidden\" name=\"search\"");
                BeginWriteAttribute("value", " value=\"", 3620, "\"", 3643, 1);
#nullable restore
#line 77 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 3628, ViewBag.search, 3628, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            <div class=""input-group-append"">
                                <button class=""btn btn-dark"" type=""submit"">
                                    OK
                                </button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col-9\">\r\n                <ul class=\"pagination justify-content-end\">\r\n");
#nullable restore
#line 90 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                      
                        int totalPages = ViewBag.totalPages;
                        int currentPage = ViewBag.currentPage;
                        string search = ViewBag.search;
                        int pageSize = ViewBag.pageSize;
                        int totalItems = ViewBag.totalItems;


                        // Hiển thị nút < nếu pageCurrent lớn hơn 1 và ngược lại thỳ sẽ gán thuộc tính disabled
                        if (currentPage > 1)
                        {
                            int previousPage = currentPage - 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link active\"");
            BeginWriteAttribute("href", " href=\"", 4767, "\"", 4834, 6);
            WriteAttributeValue("", 4774, "?currentPage=", 4774, 13, true);
#nullable restore
#line 102 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 4787, previousPage, 4787, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4800, "&search=", 4800, 8, true);
#nullable restore
#line 102 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 4808, search, 4808, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4815, "&pageSize=", 4815, 10, true);
#nullable restore
#line 102 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 4825, pageSize, 4825, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">❮</a></li>\r\n");
#nullable restore
#line 103 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link active\" disabled>❮</a></li>\r\n");
#nullable restore
#line 107 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                        }

                        // Hiển thị các page nếu page nào đang hiển thị sẽ để trạng thái active
                        int i;
                        for (i = 1; i <= totalPages; i++)
                        {
                            if (i == currentPage)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5438, "\"", 5494, 6);
            WriteAttributeValue("", 5445, "?currentPage=", 5445, 13, true);
#nullable restore
#line 115 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 5458, i, 5458, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5460, "&search=", 5460, 8, true);
#nullable restore
#line 115 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 5468, search, 5468, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5475, "&pageSize=", 5475, 10, true);
#nullable restore
#line 115 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 5485, pageSize, 5485, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 115 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                                                                                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 116 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\"><a");
            BeginWriteAttribute("id", " id=\"", 5661, "\"", 5666, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5685, "\"", 5741, 6);
            WriteAttributeValue("", 5692, "?currentPage=", 5692, 13, true);
#nullable restore
#line 119 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 5705, i, 5705, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5707, "&search=", 5707, 8, true);
#nullable restore
#line 119 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 5715, search, 5715, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5722, "&pageSize=", 5722, 10, true);
#nullable restore
#line 119 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 5732, pageSize, 5732, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 119 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                                                                                                                                     Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 120 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                            }
                        }

                        // Hiển thị nút > nếu pageCurrent lớn hơn 0 và pageCurrent < totalPages ngược lại thỳ sẽ gán thuộc tính disabled
                        if (currentPage > 0 && currentPage < totalPages)
                        {
                            int nextPage = currentPage + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link active\"");
            BeginWriteAttribute("href", " href=\"", 6193, "\"", 6256, 6);
            WriteAttributeValue("", 6200, "?currentPage=", 6200, 13, true);
#nullable restore
#line 127 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 6213, nextPage, 6213, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6222, "&search=", 6222, 8, true);
#nullable restore
#line 127 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 6230, search, 6230, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6237, "&pageSize=", 6237, 10, true);
#nullable restore
#line 127 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 6247, pageSize, 6247, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">❯</a></li>\r\n");
#nullable restore
#line 128 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link active\" disabled>❯</a></li>\r\n");
#nullable restore
#line 132 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Category\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div><!-- /.container-fluid -->\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DemoDotNet5.ViewModel.CategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
