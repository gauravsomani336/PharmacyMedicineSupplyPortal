#pragma checksum "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0af7947dbb07bab2ebb1e66b2ab7ddb79e4415b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetStockData), @"mvc.1.0.view", @"/Views/Home/GetStockData.cshtml")]
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
#line 1 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\_ViewImports.cshtml"
using WebProj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\_ViewImports.cshtml"
using WebProj.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0af7947dbb07bab2ebb1e66b2ab7ddb79e4415b8", @"/Views/Home/GetStockData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9a5bb697ea1ba3d4406c6dc6c01fc615dd7054f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetStockData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebProj.Models.Stock>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
      
        ViewData["Title"] = "GetStockData";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <link rel=\"stylesheet\" href=\"https://www.w3schools.com/w3css/4/w3.css\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0af7947dbb07bab2ebb1e66b2ab7ddb79e4415b83554", async() => {
                WriteLiteral("\r\n\r\n        <!-- Sidebar -->\r\n        <div class=\"w3-sidebar w3-bar-block w3-border-right\" style=\"display:none\" id=\"mySidebar\">\r\n            <button onclick=\"w3_close()\" class=\"w3-bar-item w3-large\">Close &times;</button>\r\n\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 510, "\"", 555, 1);
#nullable restore
#line 15 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
WriteAttributeValue("", 517, Url.ActionLink("GetStockData","Home"), 517, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"w3-bar-item w3-button\">Stock Data</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 617, "\"", 661, 1);
#nullable restore
#line 16 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
WriteAttributeValue("", 624, Url.ActionLink("GetSchedule","Home"), 624, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"w3-bar-item w3-button\">Schedule Appointment</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 733, "\"", 783, 1);
#nullable restore
#line 17 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
WriteAttributeValue("", 740, Url.ActionLink("GetPharmacySupply","Home"), 740, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""w3-bar-item w3-button""></a>
        </div>

        <!-- Page Content -->
        <div>
            <button class=""w3-button w3-bar-block w3-xlarge"" onclick=""w3_open()"">☰</button>

        </div>
        <script>
            function w3_open() {
                document.getElementById(""mySidebar"").style.display = ""block"";
            }

            function w3_close() {
                document.getElementById(""mySidebar"").style.display = ""none"";
            }
        </script>

    


<h1>GetStockData</h1>


<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 45 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
           Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
           Write(Html.DisplayNameFor(model => model.ChemicalComposition));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
           Write(Html.DisplayNameFor(model => model.TargetAilment));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 54 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
           Write(Html.DisplayNameFor(model => model.DateOfExpiry));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 57 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
           Write(Html.DisplayNameFor(model => model.NumberOfTabletsInStock));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 63 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
               Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
               Write(Html.DisplayFor(modelItem => item.ChemicalComposition));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
               Write(Html.DisplayFor(modelItem => item.TargetAilment));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateOfExpiry));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumberOfTabletsInStock));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 82 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 85 "D:\Cogni project\PharmacyMedicineSupplyPortal\WebProj\Views\Home\GetStockData.cshtml"
Write(Html.ActionLink("Back", "Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebProj.Models.Stock>> Html { get; private set; }
    }
}
#pragma warning restore 1591