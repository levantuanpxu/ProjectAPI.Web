#pragma checksum "D:\Blog_DuLich\Blogdulich.Web\Blogdulich.Web\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c42b8097567a7fd3762bcb33a9a9f281026ab8f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "D:\Blog_DuLich\Blogdulich.Web\Blogdulich.Web\Views\_ViewImports.cshtml"
using Blogdulich.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Blog_DuLich\Blogdulich.Web\Blogdulich.Web\Views\_ViewImports.cshtml"
using Blogdulich.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blog_DuLich\Blogdulich.Web\Blogdulich.Web\Views\_ViewImports.cshtml"
using Blogdulich.Web.Models.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Blog_DuLich\Blogdulich.Web\Blogdulich.Web\Views\_ViewImports.cshtml"
using Blogdulich.Web.Models.Contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Blog_DuLich\Blogdulich.Web\Blogdulich.Web\Views\_ViewImports.cshtml"
using Blogdulich.Web.Models.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Blog_DuLich\Blogdulich.Web\Blogdulich.Web\Views\_ViewImports.cshtml"
using Blogdulich.Web.Models.Users;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c42b8097567a7fd3762bcb33a9a9f281026ab8f6", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484393afad347c6bf774a8eb0233a8fa30cb3010", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-contact contact_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("contact_process.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""mb-30px"">
    <div class=""container"">
        <div class=""hero-banner hero-banner--sm"">
            <div class=""hero-banner__content"">
                <h1>Contact Us</h1>
                <nav aria-label=""breadcrumb"" class=""banner-breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Contact Us</li>
                    </ol>
                </nav>
            </div>
        </div>
    </div>
</section>
  <!-- ================ contact section start ================= -->
<section class=""section-margin--small section-margin"">
    <div class=""container"">


        <div class=""row"">
            <div class=""col-md-4 col-lg-3 mb-4 mb-md-0"">
                <div class=""media contact-info"">
                    <span class=""contact-info__icon""><i class=""ti-home""></i></span>
                    <div class=""media-body"">
                        <h3>C");
            WriteLiteral(@"alifornia United States</h3>
                        <p>Santa monica bullevard</p>
                    </div>
                </div>
                <div class=""media contact-info"">
                    <span class=""contact-info__icon""><i class=""ti-headphone""></i></span>
                    <div class=""media-body"">
                        <h3><a href=""tel:454545654"">00 (440) 9865 562</a></h3>
                        <p>Mon to Fri 9am to 6pm</p>
                    </div>
                </div>
                <div class=""media contact-info"">
                    <span class=""contact-info__icon""><i class=""ti-email""></i></span>
                    <div class=""media-body"">
                        <h3><a href=""mailto:support@colorlib.com"">support@colorlib.com</a></h3>
                        <p>Send us your query anytime!</p>
                    </div>
                </div>
            </div>
            <div class=""col-md-8 col-lg-9"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c42b8097567a7fd3762bcb33a9a9f281026ab8f68094", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-lg-5"">
                            <div class=""form-group"">
                                <input class=""form-control"" name=""name"" id=""name"" type=""text"" placeholder=""Enter your name"">
                            </div>
                            <div class=""form-group"">
                                <input class=""form-control"" name=""email"" id=""email"" type=""email"" placeholder=""Enter email address"">
                            </div>
                            <div class=""form-group"">
                                <input class=""form-control"" name=""subject"" id=""subject"" type=""text"" placeholder=""Enter Subject"">
                            </div>
                        </div>
                        <div class=""col-lg-7"">
                            <div class=""form-group"">
                                <textarea class=""form-control different-control w-100"" name=""message"" id=""message"" cols=""30"" rows=""5"" placeholder=""Enter Mess");
                WriteLiteral(@"age""></textarea>
                            </div>
                        </div>
                    </div>
                    <div class=""form-group text-center text-md-right mt-3"">
                        <button type=""submit"" class=""button button--active button-contactForm"">Send Message</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591