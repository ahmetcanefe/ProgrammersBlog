#pragma checksum "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Comment\_CommentDetailPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de295d2473fa87adb20ff885f4f3d80547e6e5e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment__CommentDetailPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/_CommentDetailPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de295d2473fa87adb20ff885f4f3d80547e6e5e0", @"/Areas/Admin/Views/Comment/_CommentDetailPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Comment__CommentDetailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProgrammersBlog.Entities.Dtos.CommentDto>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""><span class=""fas fa-newspaper""></span> ");
#nullable restore
#line 6 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Comment\_CommentDetailPartial.cshtml"
                                                                          Write(Model.Comment.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Numaralı Yorum Görüntüleniyor...</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""İptal"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
#nullable restore
#line 12 "C:\MyProjects\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Comment\_CommentDetailPartial.cshtml"
           Write(Model.Comment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger btn-block"" data-dismiss=""modal""><span class=""fas fa-times""></span> Kapat</button>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProgrammersBlog.Entities.Dtos.CommentDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
