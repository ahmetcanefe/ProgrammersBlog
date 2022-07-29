#pragma checksum "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "611b23e3050f9a26687d14faed0c62c7c24e53de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Detail), @"mvc.1.0.view", @"/Views/Article/Detail.cshtml")]
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
#line 1 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
using ProgrammersBlog.Entities.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611b23e3050f9a26687d14faed0c62c7c24e53de", @"/Views/Article/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Article_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProgrammersBlog.Mvc.Models.ArticleDetailViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Comment/_CommentAddPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ArticleDetailRightSideBarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/BlogHome/js/articleDetail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/ecmascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
  
    Layout = "_ArticleLayout";
    ViewBag.Title = Model.ArticleDto.Article.Title;
    ViewBag.Description = Model.ArticleDto.Article.SeoDescription;
    ViewBag.Author = Model.ArticleDto.Article.SeoAuthor;
    ViewBag.Tags = Model.ArticleDto.Article.SeoTags;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Post Content Column -->\n<div class=\"col-lg-8\">\n\n    <!-- Title -->\n    <h1 class=\"mt-4\">");
#nullable restore
#line 14 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                Write(Model.ArticleDto.Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n    <!-- Author -->\n    <p class=\"lead\">\n        ");
#nullable restore
#line 18 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
   Write(Model.ArticleDto.Article.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" tarafından ");
#nullable restore
#line 18 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                                                      Write(Model.ArticleDto.Article.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" tarihinde paylaşılmıştır.\n    </p>\n\n    <hr>\n\n    <!-- Preview Image -->\n    <div class=\"text-center\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "611b23e3050f9a26687d14faed0c62c7c24e53de6390", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 788, "~/img/", 788, 6, true);
#nullable restore
#line 25 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
AddHtmlAttributeValue("", 794, Model.ArticleDto.Article.Thumbnail, 794, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
AddHtmlAttributeValue("", 836, Model.ArticleDto.Article.Title, 836, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n    <hr>\n\n    <!-- Post Content -->\n    ");
#nullable restore
#line 30 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
Write(Html.Raw(Model.ArticleDto.Article.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <hr>\n    \n    <p class=\"text-center\">Okunma Sayısı: <span class=\"badge badge-info\">");
#nullable restore
#line 34 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                                                                    Write(Model.ArticleDto.Article.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> Yorum Sayısı: <span class=\"badge badge-warning\">");
#nullable restore
#line 34 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                                                                                                                                                               Write(Model.ArticleDto.Article.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\n\n    <!-- Comments Form -->\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "611b23e3050f9a26687d14faed0c62c7c24e53de9637", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 37 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new CommentAddDto{ArticleId = Model.ArticleDto.Article.Id};

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
            WriteLiteral("\n    \n    <div id=\"comments\">\n");
#nullable restore
#line 40 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
         foreach (var comment in Model.ArticleDto.Article.Comments)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Single Comment -->\n            <div class=\"media mb-4\">\n                <img class=\"d-flex mr-3 rounded-circle\" src=\"https://randomuser.me/api/portraits/men/34.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1629, "\"", 1635, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"media-body\">\n                    <h5 class=\"mt-0\">");
#nullable restore
#line 45 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                                Write(comment.CreatedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    ");
#nullable restore
#line 46 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
               Write(comment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>");
#nullable restore
#line 48 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "611b23e3050f9a26687d14faed0c62c7c24e53de12737", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 51 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.ArticleDetailRightSideBarViewModel;

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
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "611b23e3050f9a26687d14faed0c62c7c24e53de14433", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProgrammersBlog.Mvc.Models.ArticleDetailViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591