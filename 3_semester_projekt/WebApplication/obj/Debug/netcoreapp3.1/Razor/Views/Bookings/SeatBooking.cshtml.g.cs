#pragma checksum "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee6359fbf03c30a819fe4339e1f6fef3ac6bcfcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_SeatBooking), @"mvc.1.0.view", @"/Views/Bookings/SeatBooking.cshtml")]
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
#line 1 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee6359fbf03c30a819fe4339e1f6fef3ac6bcfcd", @"/Views/Bookings/SeatBooking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_SeatBooking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebClientMVC.Models.Showing>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Book seats", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/MovieDynamics.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
  
    ViewBag.Title = "SeatBooking";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Seat Booking</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 13 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 17 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 21 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
       Write(Html.DisplayNameFor(model => model.Room));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 25 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
       Write(Html.DisplayFor(model => model.Room));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 29 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
       Write(Html.DisplayNameFor(model => model.ShowTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 33 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
       Write(Html.DisplayFor(model => model.ShowTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 37 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
       Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n\r\n<ol class=\"allSeats\">\r\n\r\n");
#nullable restore
#line 45 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
     if (Model != null) {
        List<WebClientMVC.Models.SeatBooking> currenSeats;
        foreach (int roomRow in Model.GetRoomRows()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"row\">\r\n                <ol class=\"seats\" type=\"A\">\r\n");
#nullable restore
#line 50 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
                       currenSeats = Model.GetSeatRow(roomRow);
                        int tempResVal;
                        int tempSeatNo;
                        int tempId;
                        foreach (WebClientMVC.Models.SeatBooking sr in currenSeats) {
                            tempResVal = sr.GetReservedValue();
                            tempSeatNo = sr.SeatNo;
                            tempId = (roomRow * 1000) + tempSeatNo;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"seat\">\r\n");
#nullable restore
#line 63 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
                                 if (tempResVal > 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 1907, "\"", 1919, 1);
#nullable restore
#line 64 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
WriteAttributeValue("", 1912, tempId, 1912, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1920, "\"", 1939, 1);
#nullable restore
#line 64 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
WriteAttributeValue("", 1928, tempResVal, 1928, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"seat\" checked=\"checked\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1970, "\"", 1999, 3);
            WriteAttributeValue("", 1980, "seatchange(", 1980, 11, true);
#nullable restore
#line 64 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
WriteAttributeValue("", 1991, tempId, 1991, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1998, ")", 1998, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    <label");
            BeginWriteAttribute("for", " for=\"", 2047, "\"", 2060, 1);
#nullable restore
#line 65 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
WriteAttributeValue("", 2053, tempId, 2053, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 65 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
                                                    Write(tempSeatNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 66 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
                                }
                                else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 2216, "\"", 2228, 1);
#nullable restore
#line 68 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
WriteAttributeValue("", 2221, tempId, 2221, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2229, "\"", 2248, 1);
#nullable restore
#line 68 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
WriteAttributeValue("", 2237, tempResVal, 2237, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"seat\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2261, "\"", 2290, 3);
            WriteAttributeValue("", 2271, "seatchange(", 2271, 11, true);
#nullable restore
#line 68 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
WriteAttributeValue("", 2282, tempId, 2282, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2289, ")", 2289, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    <label");
            BeginWriteAttribute("for", " for=\"", 2338, "\"", 2351, 1);
#nullable restore
#line 69 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
WriteAttributeValue("", 2344, tempId, 2344, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 69 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
                                                    Write(tempSeatNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 70 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </li>\r\n");
#nullable restore
#line 72 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ol>\r\n            </li>\r\n");
#nullable restore
#line 76 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>\r\n");
#nullable restore
#line 79 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
 using (Html.BeginForm()) {
    if (Model != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"hidden\" id=\"showId\" name=\"showId\"");
            BeginWriteAttribute("value", " value=\"", 2670, "\"", 2687, 1);
#nullable restore
#line 81 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
WriteAttributeValue("", 2678, Model.ID, 2678, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee6359fbf03c30a819fe4339e1f6fef3ac6bcfcd16301", async() => {
                WriteLiteral("\r\n            <div class=\"col-md-4\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee6359fbf03c30a819fe4339e1f6fef3ac6bcfcd16616", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 84 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee6359fbf03c30a819fe4339e1f6fef3ac6bcfcd18386", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 86 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PhoneNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee6359fbf03c30a819fe4339e1f6fef3ac6bcfcd20026", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 87 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PhoneNumber);

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
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee6359fbf03c30a819fe4339e1f6fef3ac6bcfcd21660", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 88 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PhoneNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n                <input type=\"hidden\" id=\"reservedSeats\" name=\"reservedSeats\"");
                BeginWriteAttribute("value", " value=\"", 3256, "\"", 3264, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <div class=\"form-group\">\r\n                    <div>");
#nullable restore
#line 93 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
                    Write(ViewBag.PrevResult);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                    <div class=""col-md-offset-2 col-md-10"">
                        <input type=""submit"" value=""Book seats"" class=""btn btn-outline-primary"" />
                    </div>
                </div>
                <span>Currently selected:</span>
                <div id=""seatSelection"" name=""seatSelection"">None</div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 101 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
            }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee6359fbf03c30a819fe4339e1f6fef3ac6bcfcd25803", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 106 "C:\Users\PC\Documents\GitHub\3_semester_projekt\3_semester_projekt\WebApplication\Views\Bookings\SeatBooking.cshtml"
                  await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebClientMVC.Models.Showing> Html { get; private set; }
    }
}
#pragma warning restore 1591
