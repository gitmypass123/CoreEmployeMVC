#pragma checksum "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9abf659ed85d839c2dd17d0f17b842e1bda4005"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineering_ADD), @"mvc.1.0.view", @"/Views/Engineering/ADD.cshtml")]
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
#line 1 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\_ViewImports.cshtml"
using CoreEmployeMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\_ViewImports.cshtml"
using CoreEmployeMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9abf659ed85d839c2dd17d0f17b842e1bda4005", @"/Views/Engineering/ADD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05fbe9b5a57c305b85b8080bfc8350fb46f95de7", @"/Views/_ViewImports.cshtml")]
    public class Views_Engineering_ADD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreEmployeMVC.Models.ProjectClass>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
  
    ViewData["Title"] = "ADD";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h2>Engineering Department</h2>

<style>

    td {
        width: 50px;
        text-align: center;
    }

    label {
        width: 46px;
        text-align: center;
    }

    .drop1 {
        margin-left: 50px;
    }

    .drop2 {
        margin-left:30px;
    }

    .TextArea {
        margin-left: 80px;
    }

    .Month {
        margin-left: 640px;
    }

    .Text {
        margin-left: 590px;
    }

    .lbl_details {
        margin-left: 590px;
    }

    .activity {
        margin-left: 10px;
        width: 150px;
    }
</style>

<br>
<br>


");
#nullable restore
#line 59 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
 using (Html.BeginForm("ADD", "Engineering", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
Write(Html.DropDownListFor(item => Model.DepartmentName, ViewBag.departmetName as SelectList, "-- Select  Depatment --", new { @class = "drop2" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
Write(Html.ValidationMessageFor(model => model.DepartmentName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
Write(Html.DropDownListFor(item => Model.ProjectName, ViewBag.CategoriesList as SelectList, "-- Select Project --", new { @class = "drop1" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
Write(Html.ValidationMessageFor(model => model.ProjectName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
Write(Html.TextAreaFor(x => x.Activity, new { @class = "TextArea" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br>\r\n    <br>\r\n");
            WriteLiteral(@"    <Label ID=""lbl_details"" runat=""server"" Text=""Details"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Select_Month</Label>
");
#nullable restore
#line 93 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
   Write(Html.DropDownList("Month", new List<SelectListItem>
    {
            new SelectListItem{ Text="Jun", Value = "1" },
       new SelectListItem{ Text="Feb", Value = "2" },
       new SelectListItem{ Text="Mar", Value = "3" },
       new SelectListItem{ Text="Apr", Value = "4" },
       new SelectListItem{ Text="May", Value = "5" },
       new SelectListItem{ Text="Jun", Value = "6" },
       new SelectListItem{ Text="Jul", Value = "7" },
       new SelectListItem{ Text="Aug", Value = "8" },
       new SelectListItem{ Text="Sep", Value = "9" },
       new SelectListItem{ Text="Oct", Value = "10" },
       new SelectListItem{ Text="Nov", Value = "11" },
       new SelectListItem{ Text="Dec", Value = "12" },


    },

    new { @class = "Month", id = "myId", @onchange = "getVal()" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
                                                                  ;











#line default
#line hidden
#nullable disable
            WriteLiteral("        <table>\r\n\r\n\r\n");
#nullable restore
#line 125 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
             if (ViewData["WeekDay"] != null)
            {
                // your code

                foreach (string WeekDay in (string[])ViewData["WeekDay"])
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 132 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
                   Write(WeekDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 134 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
            WriteLiteral(@"        <script type=""text/javascript"">
            function getVal() {
                var selectedVal = document.getElementById(""myId"");
                var selectedText = selectedVal.options[selectedVal.selectedIndex].text;
                document.getElementById('lbl1').innerHTML = selectedText;
                document.getElementById('lbl2').innerHTML = selectedText;
                document.getElementById('lbl3').innerHTML = selectedText;
                document.getElementById('lbl4').innerHTML = selectedText;
                document.getElementById('lbl5').innerHTML = selectedText;
                document.getElementById('lbl6').innerHTML = selectedText;
                document.getElementById('lbl7').innerHTML = selectedText;
                document.getElementById('lbl8').innerHTML = selectedText;
                document.getElementById('lbl9').innerHTML = selectedText;
                document.getElementById('lbl10').innerHTML = selectedText;
                document.getElementById('l");
            WriteLiteral(@"bl11').innerHTML = selectedText;
                document.getElementById('lbl12').innerHTML = selectedText;
                document.getElementById('lbl13').innerHTML = selectedText;
                document.getElementById('lbl14').innerHTML = selectedText;
                document.getElementById('lbl15').innerHTML = selectedText;
                document.getElementById('lbl16').innerHTML = selectedText;
                document.getElementById('lbl17').innerHTML = selectedText;
                document.getElementById('lbl18').innerHTML = selectedText;
                document.getElementById('lbl19').innerHTML = selectedText;
                document.getElementById('lbl20').innerHTML = selectedText;
                document.getElementById('lbl21').innerHTML = selectedText;
                document.getElementById('lbl22').innerHTML = selectedText;
                document.getElementById('lbl23').innerHTML = selectedText;
                document.getElementById('lbl24').innerHTML = selectedText;
  ");
            WriteLiteral(@"              document.getElementById('lbl25').innerHTML = selectedText;
                document.getElementById('lbl26').innerHTML = selectedText;
                document.getElementById('lbl27').innerHTML = selectedText;
                document.getElementById('lbl28').innerHTML = selectedText;
                document.getElementById('lbl29').innerHTML = selectedText;
                document.getElementById('lbl30').innerHTML = selectedText;
                document.getElementById('lbl31').innerHTML = selectedText;


            };
        </script>
");
            WriteLiteral(@"        <label id=""lbl1""></label>
        <label id=""lbl2""></label>
        <label id=""lbl3""></label>
        <label id=""lbl4""></label>
        <label id=""lbl5""></label>
        <label id=""lbl6""></label>
        <label id=""lbl7""></label>
        <label id=""lbl8""></label>
        <label id=""lbl9""></label>
        <label id=""lbl10""></label>
        <label id=""lbl11""></label>
        <label id=""lbl12""></label>
        <label id=""lbl13""></label>
        <label id=""lbl14""></label>
        <label id=""lbl15""></label>
");
            WriteLiteral("        <table>\r\n\r\n\r\n");
#nullable restore
#line 202 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
             if (ViewData["Month"] != null)
            {
                // your code

                foreach (string month in (string[])ViewData["Month"])
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n\r\n                        ");
#nullable restore
#line 211 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
                   Write(month);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 213 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"



                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </table>\r\n");
            WriteLiteral("        <table>\r\n\r\n\r\n            <div class=\"container\">\r\n\r\n            <td>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 235 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.work1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 236 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.ot1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n\r\n            <td>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 243 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.work2, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 244 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.ot2, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n\r\n            <td>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 251 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.work3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 252 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.ot3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n\r\n\r\n            <td>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 260 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.work4, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 261 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.ot4, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n\r\n\r\n\r\n            <td>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 270 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.work5, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 271 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.ot5, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n\r\n\r\n            <td>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 279 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.work6, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 280 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.ot6, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n\r\n            <td>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 287 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.work7, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 288 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.ot7, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n\r\n\r\n            <td>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 296 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.work8, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 297 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.ot8, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n\r\n\r\n            <td>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 305 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.work9, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 306 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.ot9, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n\r\n\r\n\r\n            <td>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 315 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.work10, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 316 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.ot10, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n\r\n\r\n\r\n            <td>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 325 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.work11, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 326 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.ot11, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n\r\n\r\n\r\n            <td>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 335 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.work12, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 336 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.ot12, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n\r\n\r\n            <td>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 344 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.work13, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 345 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.ot13, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n\r\n\r\n\r\n            <td>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 354 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.work14, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 355 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.ot14, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n\r\n\r\n\r\n            <td>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 364 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.work15, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 365 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(Html.TextBoxFor(x => x.ot15, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n\r\n\r\n\r\n\r\n    </div>\r\n    </table>\r\n");
            WriteLiteral("    <br>\r\n    <br />\r\n    <table>\r\n\r\n\r\n");
#nullable restore
#line 381 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
         if (ViewData["WeekDay2List"] != null)
        {
            // your code

            foreach (string WeekDay2 in (string[])ViewData["WeekDay2List"])
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 388 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(WeekDay2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 390 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
            WriteLiteral(@"    <label id=""lbl16""></label>
    <label id=""lbl17""></label>
    <label id=""lbl18""></label>
    <label id=""lbl19""></label>
    <label id=""lbl20""></label>
    <label id=""lbl21""></label>
    <label id=""lbl22""></label>
    <label id=""lbl23""></label>
    <label id=""lbl24""></label>
    <label id=""lbl25""></label>
    <label id=""lbl26""></label>
    <label id=""lbl27""></label>
    <label id=""lbl28""></label>
    <label id=""lbl29""></label>
    <label id=""lbl30""></label>
    <label id=""lbl31""></label>
");
            WriteLiteral("    <table>\r\n\r\n\r\n");
#nullable restore
#line 417 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
         if (ViewData["Month2"] != null)
        {
            // your code

            foreach (string month2 in (string[])ViewData["Month2"])
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 424 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
               Write(month2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 426 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n");
            WriteLiteral("    <table>\r\n\r\n\r\n        <div class=\"container\">\r\n\r\n        <td>\r\n            <div class=\"form-group\">\r\n\r\n                ");
#nullable restore
#line 441 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.work16, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 442 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.ot16, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n        <td>\r\n            <div class=\"form-group\">\r\n\r\n                ");
#nullable restore
#line 449 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.work17, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 450 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.ot17, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n        <td>\r\n            <div class=\"form-group\">\r\n\r\n                ");
#nullable restore
#line 457 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.work18, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 458 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.ot18, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n\r\n        <td>\r\n            <div class=\"form-group\">\r\n\r\n                ");
#nullable restore
#line 466 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.work19, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 467 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.ot19, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n\r\n\r\n        <td>\r\n            <div class=\"form-group\">\r\n\r\n                ");
#nullable restore
#line 476 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.work20, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 477 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.ot20, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n\r\n        <td>\r\n            <div class=\"form-group\">\r\n\r\n                ");
#nullable restore
#line 485 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.work21, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 486 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.ot21, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n        <td>\r\n            <div class=\"form-group\">\r\n\r\n                ");
#nullable restore
#line 493 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.work22, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 494 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.ot22, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n\r\n        <td>\r\n            <div class=\"form-group\">\r\n\r\n                ");
#nullable restore
#line 502 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.work23, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 503 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.ot23, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n\r\n        <td>\r\n            <div class=\"form-group\">\r\n\r\n                ");
#nullable restore
#line 511 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.work24, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 512 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.ot24, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n\r\n\r\n        <td>\r\n            <div class=\"form-group\">\r\n\r\n                ");
#nullable restore
#line 521 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.work25, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 522 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.ot25, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n\r\n\r\n        <td>\r\n            <div class=\"form-group\">\r\n\r\n                ");
#nullable restore
#line 531 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.work26, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 532 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.ot26, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n\r\n\r\n        <td>\r\n            <div class=\"form-group\">\r\n\r\n                ");
#nullable restore
#line 541 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.work27, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 542 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.ot27, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n\r\n        <td>\r\n            <div class=\"form-group\">\r\n\r\n                ");
#nullable restore
#line 550 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.work28, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 551 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.ot28, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n\r\n\r\n        <td>\r\n            <div class=\"form-group\">\r\n\r\n                ");
#nullable restore
#line 560 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.work29, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 561 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.ot29, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n\r\n\r\n        <td>\r\n            <div class=\"form-group\">\r\n\r\n                ");
#nullable restore
#line 570 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.work30, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 571 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.ot30, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n        <td>\r\n            <div class=\"form-group\">\r\n\r\n                ");
#nullable restore
#line 578 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.work31, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 579 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
           Write(Html.TextBoxFor(x => x.ot31, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n\r\n        </div>\r\n    </table>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <button type=\"submit\" class=\"btn btn-primary\">ADD</button>\r\n    </div>\r\n");
#nullable restore
#line 591 "D:\C#\DotNetCore\Git\CoreEmployeMVC\CoreEmployeMVC\CoreEmployeMVC\Views\Engineering\ADD.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreEmployeMVC.Models.ProjectClass> Html { get; private set; }
    }
}
#pragma warning restore 1591
