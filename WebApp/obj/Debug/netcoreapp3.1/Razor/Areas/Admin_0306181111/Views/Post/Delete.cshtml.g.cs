#pragma checksum "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\Post\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ade759e2a38506496f4b8130d5d880c7c67615f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_0306181111_Views_Post_Delete), @"mvc.1.0.view", @"/Areas/Admin_0306181111/Views/Post/Delete.cshtml")]
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
#line 1 "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\_ViewImports.cshtml"
using WebApp.Areas.Admin_0306181111.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ade759e2a38506496f4b8130d5d880c7c67615f", @"/Areas/Admin_0306181111/Views/Post/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"976f4cb5cf49e2342f88c7c5a1a43cb3151ffd37", @"/Areas/Admin_0306181111/Views/_ViewImports.cshtml")]
    public class Areas_Admin_0306181111_Views_Post_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Areas.Admin_0306181111.Models.PostModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/assets/images/avatar/avatar-s-1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("srcset", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\Post\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin_0306181111/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""main"">
    <nav class=""navbar navbar-header navbar-expand navbar-light"">
        <a class=""sidebar-toggler"" href=""#""><span class=""navbar-toggler-icon""></span></a>
        <button class=""btn navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
                aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
            <ul class=""navbar-nav d-flex align-items-center navbar-light ml-auto"">
                <li class=""dropdown nav-icon"">
                    <a href=""#"" data-toggle=""dropdown"" class=""nav-link  dropdown-toggle nav-link-lg nav-link-user"">
                        <div class=""d-lg-inline-block"">
                            <i data-feather=""bell""></i>
                        </div>
                    </a>
                    <div class=""dropdown-menu d");
            WriteLiteral(@"ropdown-menu-right dropdown-menu-large"">
                        <h6 class='py-2 px-4'>Notifications</h6>
                        <ul class=""list-group rounded-none"">
                            <li class=""list-group-item border-0 align-items-start"">
                                <div class=""avatar bg-success mr-3"">
                                    <span class=""avatar-content""><i data-feather=""shopping-cart""></i></span>
                                </div>
                                <div>
                                    <h6 class='text-bold'>New Order</h6>
                                    <p class='text-xs'>
                                        An order made by Ahmad Saugi for product Samsung Galaxy S69
                                    </p>
                                </div>
                            </li>
                        </ul>
                    </div>
                </li>
                <li class=""dropdown nav-icon mr-2"">
                    <a hre");
            WriteLiteral(@"f=""#"" data-toggle=""dropdown"" class=""nav-link  dropdown-toggle nav-link-lg nav-link-user"">
                        <div class=""d-lg-inline-block"">
                            <i data-feather=""mail""></i>
                        </div>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <a class=""dropdown-item"" href=""#""><i data-feather=""user""></i> Account</a>
                        <a class=""dropdown-item active"" href=""#""><i data-feather=""mail""></i> Messages</a>
                        <a class=""dropdown-item"" href=""#""><i data-feather=""settings""></i> Settings</a>
                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""#""><i data-feather=""log-out""></i> Logout</a>
                    </div>
                </li>
                <li class=""dropdown"">
                    <a href=""#"" data-toggle=""dropdown"" class=""nav-link dropdown-toggle nav-link-lg nav-link-user"">
             ");
            WriteLiteral("           <div class=\"avatar mr-1\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7ade759e2a38506496f4b8130d5d880c7c67615f9422", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""d-none d-md-block d-lg-inline-block"">Hi, Saugi</div>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <a class=""dropdown-item"" href=""#""><i data-feather=""user""></i> Account</a>
                        <a class=""dropdown-item active"" href=""#""><i data-feather=""mail""></i> Messages</a>
                        <a class=""dropdown-item"" href=""#""><i data-feather=""settings""></i> Settings</a>
                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""#""><i data-feather=""log-out""></i> Logout</a>
                    </div>
                </li>
            </ul>
        </div>
    </nav>

    <div class=""main-content container-fluid"">
        <div class=""page-title"">
            <div class=""row"">
                <div class=""col-12 col-md-6 order-md-1 order-last"">
                    <h3>Category</h3>
           ");
            WriteLiteral(@"         <p class=""text-subtitle text-muted"">We use 'simple-datatables' made by. You can check the full documentation <a href=""https://github.com/fiduswriter/Simple-DataTables/wiki"">here</a>.</p>
                </div>
                <div class=""col-12 col-md-6 order-md-2 order-first"">
                    <nav aria-label=""breadcrumb"" class='breadcrumb-header'>
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item""><a href=""index.html"">Dashboard</a></li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">Post</li>
                        </ol>
                    </nav>
                </div>
            </div>
        </div>
        <section class=""section"">
            <div class=""card"">
                <div class=""card-header"">
                    Post - Delete</a>
                </div>
                <div class=""card-body"">
                    <table class='table table-striped' id=""table1"">
              ");
            WriteLiteral(@"          <h2>Delete</h2>

                        <h3>Are you sure you want to delete this?</h3>
                        <div>
                            <hr />
                            <dl class=""dl-horizontal"">
                                <dt>
                                    ");
#nullable restore
#line 104 "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\Post\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Img));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd>\r\n                                    ");
#nullable restore
#line 107 "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\Post\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Img));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt>\r\n                                    ");
#nullable restore
#line 110 "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\Post\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd>\r\n                                    ");
#nullable restore
#line 113 "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\Post\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt>\r\n                                    ");
#nullable restore
#line 116 "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\Post\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd>\r\n                                    ");
#nullable restore
#line 119 "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\Post\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt>\r\n                                    ");
#nullable restore
#line 122 "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\Post\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd>\r\n                                    ");
#nullable restore
#line 125 "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\Post\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt>\r\n                                    ");
#nullable restore
#line 128 "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\Post\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd>\r\n                                    ");
#nullable restore
#line 131 "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\Post\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt>\r\n                                    ");
#nullable restore
#line 134 "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\Post\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.CategoryID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd>\r\n                                    ");
#nullable restore
#line 137 "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\Post\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.CategoryID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                            </dl>\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ade759e2a38506496f4b8130d5d880c7c67615f17887", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7ade759e2a38506496f4b8130d5d880c7c67615f18178", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 142 "C:\Users\SV\Desktop\TechBlog\WebApp\Areas\Admin_0306181111\Views\Post\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IDPost);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ade759e2a38506496f4b8130d5d880c7c67615f20023", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </table>\r\n                </div>\r\n            </div>\r\n\r\n        </section>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Areas.Admin_0306181111.Models.PostModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
