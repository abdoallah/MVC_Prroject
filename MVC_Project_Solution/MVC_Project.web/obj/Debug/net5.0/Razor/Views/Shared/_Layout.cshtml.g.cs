#pragma checksum "C:\Users\Infotech\Documents\GitHub\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "791b7aa28594fa8c9b457e697c7db11a22551727"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Infotech\Documents\GitHub\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\_ViewImports.cshtml"
using MVC_Project.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Infotech\Documents\GitHub\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\_ViewImports.cshtml"
using MVC_Project.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"791b7aa28594fa8c9b457e697c7db11a22551727", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e95156fa3f6744c29da7903e5960b96d603b6103", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "791b7aa28594fa8c9b457e697c7db11a225517275337", async() => {
                WriteLiteral(@"
    <!-- Basic -->
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <!-- Mobile Metas -->
    <meta
      name=""viewport""
      content=""width=device-width, initial-scale=1, shrink-to-fit=no""
    />
    <!-- Site Metas -->
    <meta name=""keywords""");
                BeginWriteAttribute("content", " content=\"", 336, "\"", 346, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 380, "\"", 390, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 419, "\"", 429, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <link rel=\"shortcut icon\" href=\"images/favicon.png\"");
                BeginWriteAttribute("type", " type=\"", 490, "\"", 497, 0);
                EndWriteAttribute();
                WriteLiteral(@" />

    <title>Feane</title>

    <!-- bootstrap core css -->
    <link rel=""stylesheet"" type=""text/css"" href=""css/bootstrap.css"" />

    <!--owl slider stylesheet -->
    <link
      rel=""stylesheet""
      type=""text/css""
      href=""https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/assets/owl.carousel.min.css""
    />
    <!-- nice select  -->
    <link
      rel=""stylesheet""
      href=""https://cdnjs.cloudflare.com/ajax/libs/jquery-nice-select/1.1.0/css/nice-select.min.css""
      integrity=""sha512-CruCP+TD3yXzlvvijET8wV5WxxEh5H8P4cmz0RFbKK6FlZ2sYl3AEsKlLPHbniXKSrDdFewhbmBK5skbdsASbQ==""
      crossorigin=""anonymous""
    />
    <!-- font awesome style -->
    <link href=""css/font-awesome.min.css"" rel=""stylesheet"" />

    <!-- Custom styles for this template -->
    <link href=""css/style.css"" rel=""stylesheet"" />
    <!-- responsive style -->
    <link href=""css/responsive.css"" rel=""stylesheet"" />
  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "791b7aa28594fa8c9b457e697c7db11a225517278351", async() => {
                WriteLiteral(@"
      <!-- header section strats -->
      <header class=""header_section"">
        <div class=""container"">
          <nav class=""navbar navbar-expand-lg custom_nav-container"">
            <a class=""navbar-brand"" href=""index.html"">
              <span> Feane </span>
            </a>

            <button
              class=""navbar-toggler""
              type=""button""
              data-toggle=""collapse""
              data-target=""#navbarSupportedContent""
              aria-controls=""navbarSupportedContent""
              aria-expanded=""false""
              aria-label=""Toggle navigation""
            >
              <span");
                BeginWriteAttribute("class", " class=\"", 2107, "\"", 2115, 0);
                EndWriteAttribute();
                WriteLiteral(@"> </span>
            </button>

            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
              <ul class=""navbar-nav mx-auto"">
                <li class=""nav-item active"">
                  <a class=""nav-link"" href=""index.html""
                    >Home <span class=""sr-only"">(current)</span></a
                  >
                </li>
                <li class=""nav-item"">
                  <a class=""nav-link"" href=""menu.html"">Menu</a>
                </li>
                <li class=""nav-item"">
                  <a class=""nav-link"" href=""about.html"">About</a>
                </li>
                <li class=""nav-item"">
                  <a class=""nav-link"" href=""book.html"">Book Table</a>
                </li>
              </ul>
              <div class=""user_option"">
                <a");
                BeginWriteAttribute("href", " href=\"", 2964, "\"", 2971, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""user_link"">
                  <i class=""fa fa-user"" aria-hidden=""true""></i>
                </a>
                <a class=""cart_link"" href=""#"">
                  <svg
                    version=""1.1""
                    id=""Capa_1""
                    xmlns=""http://www.w3.org/2000/svg""
                    xmlns:xlink=""http://www.w3.org/1999/xlink""
                    x=""0px""
                    y=""0px""
                    viewBox=""0 0 456.029 456.029""
                    style=""enable-background: new 0 0 456.029 456.029""
                    xml:space=""preserve""
                  >
                    <g>
                      <g>
                        <path
                          d=""M345.6,338.862c-29.184,0-53.248,23.552-53.248,53.248c0,29.184,23.552,53.248,53.248,53.248
                   c29.184,0,53.248-23.552,53.248-53.248C398.336,362.926,374.784,338.862,345.6,338.862z""
                        />
                      </g>
                    </g>
                    <");
                WriteLiteral(@"g>
                      <g>
                        <path
                          d=""M439.296,84.91c-1.024,0-2.56-0.512-4.096-0.512H112.64l-5.12-34.304C104.448,27.566,84.992,10.67,61.952,10.67H20.48
                   C9.216,10.67,0,19.886,0,31.15c0,11.264,9.216,20.48,20.48,20.48h41.472c2.56,0,4.608,2.048,5.12,4.608l31.744,216.064
                   c4.096,27.136,27.648,47.616,55.296,47.616h212.992c26.624,0,49.664-18.944,55.296-45.056l33.28-166.4
                   C457.728,97.71,450.56,86.958,439.296,84.91z""
                        />
                      </g>
                    </g>
                    <g>
                      <g>
                        <path
                          d=""M215.04,389.55c-1.024-28.16-24.576-50.688-52.736-50.688c-29.696,1.536-52.224,26.112-51.2,55.296
                   c1.024,28.16,24.064,50.688,52.224,50.688h1.024C193.536,443.31,216.576,418.734,215.04,389.55z""
                        />
                      </g>
                    </g>
            ");
                WriteLiteral("      </svg>\r\n                </a>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "791b7aa28594fa8c9b457e697c7db11a2255172712673", async() => {
                    WriteLiteral("\r\n                  <button class=\"btn my-2 my-sm-0 nav_search-btn\" type=\"submit\">\r\n                    <i class=\"fa fa-search\" aria-hidden=\"true\"></i>\r\n                  </button>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 5323, "\"", 5330, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"order_online\"> Order Online </a>\r\n              </div>\r\n            </div>\r\n          </nav>\r\n        </div>\r\n      </header>\r\n      <!-- end header section -->\r\n     \r\n      <main>\r\n            ");
#nullable restore
#line 140 "C:\Users\Infotech\Documents\GitHub\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </main>

    <!-- footer section -->
    <footer class=""footer_section"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-md-4 footer-col"">
            <div class=""footer_contact"">
              <h4>Contact Us</h4>
              <div class=""contact_link_box"">
                <a");
                BeginWriteAttribute("href", " href=\"", 5874, "\"", 5881, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                  <i class=\"fa fa-map-marker\" aria-hidden=\"true\"></i>\r\n                  <span> Location </span>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 6039, "\"", 6046, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                  <i class=\"fa fa-phone\" aria-hidden=\"true\"></i>\r\n                  <span> Call +01 1234567890 </span>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 6210, "\"", 6217, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                  <i class=""fa fa-envelope"" aria-hidden=""true""></i>
                  <span> demo@gmail.com </span>
                </a>
              </div>
            </div>
          </div>
          <div class=""col-md-4 footer-col"">
            <div class=""footer_detail"">
              <a");
                BeginWriteAttribute("href", " href=\"", 6523, "\"", 6530, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer-logo""> Feane </a>
              <p>
                Necessary, making this the first true generator on the Internet.
                It uses a dictionary of over 200 Latin words, combined with
              </p>
              <div class=""footer_social"">
                <a");
                BeginWriteAttribute("href", " href=\"", 6824, "\"", 6831, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                  <i class=\"fa fa-facebook\" aria-hidden=\"true\"></i>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 6944, "\"", 6951, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                  <i class=\"fa fa-twitter\" aria-hidden=\"true\"></i>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 7063, "\"", 7070, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                  <i class=\"fa fa-linkedin\" aria-hidden=\"true\"></i>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 7183, "\"", 7190, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                  <i class=\"fa fa-instagram\" aria-hidden=\"true\"></i>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 7304, "\"", 7311, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                  <i class=""fa fa-pinterest"" aria-hidden=""true""></i>
                </a>
              </div>
            </div>
          </div>
          <div class=""col-md-4 footer-col"">
            <h4>Opening Hours</h4>
            <p>Everyday</p>
            <p>10.00 Am -10.00 Pm</p>
          </div>
        </div>
        <div class=""footer-info"">
          <p>
            &copy; <span id=""displayYear""></span> All Rights Reserved By
            <a href=""https://html.design/"">Free Html Templates</a>
          </p>
        </div>
      </div>
    </footer>
    <!-- footer section -->
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
       <!-- jQery -->
    <script src=""js/jquery-3.4.1.min.js""></script>
    <!-- popper js -->
    <script
      src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js""
      integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo""
      crossorigin=""anonymous""
    ></script>
    <!-- bootstrap js -->
    <script src=""js/bootstrap.js""></script>
    <!-- owl slider -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/owl.carousel.min.js""></script>
    <!-- isotope js -->
    <script src=""https://unpkg.com/isotope-layout@3.0.4/dist/isotope.pkgd.min.js""></script>
    <!-- nice select -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-nice-select/1.1.0/js/jquery.nice-select.min.js""></script>
    <!-- custom js -->
    <script src=""js/custom.js""></script>
    <!-- Google Map -->
    <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyCh39n5U-4IoWpsVGUHWdqB6puEkhRLdmI&callback=myMap""></script>
 ");
            WriteLiteral("   <!-- End Google Map -->\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "791b7aa28594fa8c9b457e697c7db11a2255172720521", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "791b7aa28594fa8c9b457e697c7db11a2255172721565", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "791b7aa28594fa8c9b457e697c7db11a2255172722609", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 231 "C:\Users\Infotech\Documents\GitHub\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
#nullable restore
#line 232 "C:\Users\Infotech\Documents\GitHub\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</html>");
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