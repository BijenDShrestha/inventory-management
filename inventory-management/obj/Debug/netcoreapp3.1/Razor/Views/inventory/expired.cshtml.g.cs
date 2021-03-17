#pragma checksum "D:\Bijen\Inventory_Management\inventory-management\Views\inventory\expired.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1a58e75b13c1f919662c4ba4cce5bb34f6f7409"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_inventory_expired), @"mvc.1.0.view", @"/Views/inventory/expired.cshtml")]
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
#line 1 "D:\Bijen\Inventory_Management\inventory-management\Views\_ViewImports.cshtml"
using inventory_management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Bijen\Inventory_Management\inventory-management\Views\_ViewImports.cshtml"
using inventory_management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1a58e75b13c1f919662c4ba4cce5bb34f6f7409", @"/Views/inventory/expired.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d3f12e823c9db5857599e9f594cf308d52543b6", @"/Views/_ViewImports.cshtml")]
    public class Views_inventory_expired : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Bijen\Inventory_Management\inventory-management\Views\inventory\expired.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" List<Inventory>;\r\n");
#nullable restore
#line 2 "D:\Bijen\Inventory_Management\inventory-management\Views\inventory\expired.cshtml"
    
    Layout = "_Layout";
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Bijen\Inventory_Management\inventory-management\Views\inventory\expired.cshtml"
    
    ViewData["Title"] = "Inventory List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h1>List of Inventories</h1>
    <table class=""table table-striped"">
  <thead>
    <tr>
      <th scope=""col"">Id</th>
      <th scope=""col"">Name</th>
      <th scope=""col"">Supplier</th>
      <th scope=""col"">Expiry Date</th>
      <th scope=""col"">Price</th>
      <th scope=""col"">Quantity</th>
      <th scope=""col"">Action</th>
    </tr>
  </thead>

DateTime today = DateTime.Now; // 12/20/2015 11:48:09 AM  
DateTime newDate2 = today.AddDays(30); // Adding one month(as 30 days)  
Console.WriteLine(newDate2); // 1/19/2016 11:48:09 AM  

");
#nullable restore
#line 28 "D:\Bijen\Inventory_Management\inventory-management\Views\inventory\expired.cshtml"
 foreach (var inventory in Model)
{
    
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n            <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 34 "D:\Bijen\Inventory_Management\inventory-management\Views\inventory\expired.cshtml"
                       Write(inventory.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 826, "\"", 867, 2);
            WriteAttributeValue("", 833, "/inventory/detail?id=", 833, 21, true);
#nullable restore
#line 35 "D:\Bijen\Inventory_Management\inventory-management\Views\inventory\expired.cshtml"
WriteAttributeValue("", 854, inventory.Id, 854, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 36 "D:\Bijen\Inventory_Management\inventory-management\Views\inventory\expired.cshtml"
       Write(inventory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td>");
#nullable restore
#line 37 "D:\Bijen\Inventory_Management\inventory-management\Views\inventory\expired.cshtml"
           Write(inventory.Supplier);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "D:\Bijen\Inventory_Management\inventory-management\Views\inventory\expired.cshtml"
           Write(inventory.ExpDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "D:\Bijen\Inventory_Management\inventory-management\Views\inventory\expired.cshtml"
           Write(inventory.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "D:\Bijen\Inventory_Management\inventory-management\Views\inventory\expired.cshtml"
           Write(inventory.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1091, "\"", 1130, 2);
            WriteAttributeValue("", 1098, "/inventory/edit?id=", 1098, 19, true);
#nullable restore
#line 41 "D:\Bijen\Inventory_Management\inventory-management\Views\inventory\expired.cshtml"
WriteAttributeValue("", 1117, inventory.Id, 1117, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            Edit</a>/<a");
            BeginWriteAttribute("href", " href=\"", 1157, "\"", 1198, 2);
            WriteAttributeValue("", 1164, "/inventory/delete?id=", 1164, 21, true);
#nullable restore
#line 42 "D:\Bijen\Inventory_Management\inventory-management\Views\inventory\expired.cshtml"
WriteAttributeValue("", 1185, inventory.Id, 1185, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            Delete</a></td>\r\n            </tr>\r\n        </tbody>\r\n");
#nullable restore
#line 46 "D:\Bijen\Inventory_Management\inventory-management\Views\inventory\expired.cshtml"
    }

}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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