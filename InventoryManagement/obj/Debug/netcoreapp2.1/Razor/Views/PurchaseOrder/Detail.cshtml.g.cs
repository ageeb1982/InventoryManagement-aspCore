#pragma checksum "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c3ef6e24990c9ad847700c8ea96740bb9db5616"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseOrder_Detail), @"mvc.1.0.view", @"/Views/PurchaseOrder/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PurchaseOrder/Detail.cshtml", typeof(AspNetCore.Views_PurchaseOrder_Detail))]
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
#line 1 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/_ViewImports.cshtml"
using coderush;

#line default
#line hidden
#line 3 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/_ViewImports.cshtml"
using coderush.Models;

#line default
#line hidden
#line 4 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/_ViewImports.cshtml"
using coderush.Models.AccountViewModels;

#line default
#line hidden
#line 5 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/_ViewImports.cshtml"
using coderush.Models.ManageViewModels;

#line default
#line hidden
#line 6 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/_ViewImports.cshtml"
using coderush.Pages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c3ef6e24990c9ad847700c8ea96740bb9db5616", @"/Views/PurchaseOrder/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ac69d2a6197d05847cf2439b90d37e9c3db3e0", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseOrder_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<coderush.Models.PurchaseOrder>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
  
    ViewData["Title"] = "Purchase Order Detail";

#line default
#line hidden
            BeginContext(92, 309, true);
            WriteLiteral(@"
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">

    <!-- Main content -->
    <section class=""content"">
        <!-- Default box -->
        <div class=""box"">
            <div class=""box-header with-border"">
                <h3 class=""box-title""><i class=""fa fa-building""></i> ");
            EndContext();
            BeginContext(402, 17, false);
#line 15 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                                                                Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(419, 790, true);
            WriteLiteral(@"</h3>
                <div class=""box-tools pull-right"">
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"" data-toggle=""tooltip""
                            title=""Collapse"">
                        <i class=""fa fa-minus""></i>
                    </button>
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove"" data-toggle=""tooltip"" title=""Remove"">
                        <i class=""fa fa-times""></i>
                    </button>
                </div>
            </div>
            <div class=""box-body"">
                <div class=""content-container-fluid"">
                    <div class=""row"">
                        <dl class=""dl-horizontal"">
                            <dt>
                                ");
            EndContext();
            BeginContext(1210, 51, false);
#line 31 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayNameFor(model => model.PurchaseOrderId));

#line default
#line hidden
            EndContext();
            BeginContext(1261, 100, true);
            WriteLiteral("\n                            </dt>\n                            <dd>\n                                ");
            EndContext();
            BeginContext(1362, 47, false);
#line 34 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayFor(model => model.PurchaseOrderId));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 100, true);
            WriteLiteral("\n                            </dd>\n                            <dt>\n                                ");
            EndContext();
            BeginContext(1510, 53, false);
#line 37 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayNameFor(model => model.PurchaseOrderName));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 100, true);
            WriteLiteral("\n                            </dt>\n                            <dd>\n                                ");
            EndContext();
            BeginContext(1664, 49, false);
#line 40 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayFor(model => model.PurchaseOrderName));

#line default
#line hidden
            EndContext();
            BeginContext(1713, 100, true);
            WriteLiteral("\n                            </dd>\n                            <dt>\n                                ");
            EndContext();
            BeginContext(1814, 44, false);
#line 43 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayNameFor(model => model.BranchId));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 235, true);
            WriteLiteral("\n                            </dt>\n                            <dd>\n                                <input type=\"text\" id=\"BranchId\" />\n                            </dd>\n                            <dt>\n                                ");
            EndContext();
            BeginContext(2094, 44, false);
#line 49 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayNameFor(model => model.VendorId));

#line default
#line hidden
            EndContext();
            BeginContext(2138, 235, true);
            WriteLiteral("\n                            </dt>\n                            <dd>\n                                <input type=\"text\" id=\"VendorId\" />\n                            </dd>\n                            <dt>\n                                ");
            EndContext();
            BeginContext(2374, 45, false);
#line 55 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(2419, 100, true);
            WriteLiteral("\n                            </dt>\n                            <dd>\n                                ");
            EndContext();
            BeginContext(2520, 41, false);
#line 58 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(2561, 100, true);
            WriteLiteral("\n                            </dd>\n                            <dt>\n                                ");
            EndContext();
            BeginContext(2662, 48, false);
#line 61 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayNameFor(model => model.DeliveryDate));

#line default
#line hidden
            EndContext();
            BeginContext(2710, 100, true);
            WriteLiteral("\n                            </dt>\n                            <dd>\n                                ");
            EndContext();
            BeginContext(2811, 44, false);
#line 64 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayFor(model => model.DeliveryDate));

#line default
#line hidden
            EndContext();
            BeginContext(2855, 100, true);
            WriteLiteral("\n                            </dd>\n                            <dt>\n                                ");
            EndContext();
            BeginContext(2956, 46, false);
#line 67 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayNameFor(model => model.CurrencyId));

#line default
#line hidden
            EndContext();
            BeginContext(3002, 237, true);
            WriteLiteral("\n                            </dt>\n                            <dd>\n                                <input type=\"text\" id=\"CurrencyId\" />\n                            </dd>\n                            <dt>\n                                ");
            EndContext();
            BeginContext(3240, 50, false);
#line 73 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayNameFor(model => model.PurchaseTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(3290, 868, true);
            WriteLiteral(@"
                            </dt>
                            <dd>
                                <input type=""text"" id=""PurchaseTypeId"" />
                            </dd>


                        </dl>
                    </div>
                    

                </div>
            </div>
            <!-- /.box-body -->
        </div>
        <!-- /.box -->
        <div class=""box"">
            <div class=""box-body"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div id=""Grid""></div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-8"">

                    </div>
                    <div class=""col-lg-4"">
                        <dl class=""dl-horizontal"">
                            <dt>
                                ");
            EndContext();
            BeginContext(4159, 43, false);
#line 103 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayNameFor(model => model.Remarks));

#line default
#line hidden
            EndContext();
            BeginContext(4202, 100, true);
            WriteLiteral("\n                            </dt>\n                            <dd>\n                                ");
            EndContext();
            BeginContext(4303, 39, false);
#line 106 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayFor(model => model.Remarks));

#line default
#line hidden
            EndContext();
            BeginContext(4342, 100, true);
            WriteLiteral("\n                            </dd>\n                            <dt>\n                                ");
            EndContext();
            BeginContext(4443, 42, false);
#line 109 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(4485, 133, true);
            WriteLiteral("\n                            </dt>\n                            <dd>\n                                <label id=\"Amount\" name=\"Amount\">");
            EndContext();
            BeginContext(4619, 12, false);
#line 112 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                                                            Write(Model.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(4631, 108, true);
            WriteLiteral("</label>\n                            </dd>\n                            <dt>\n                                ");
            EndContext();
            BeginContext(4740, 44, false);
#line 115 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(4784, 137, true);
            WriteLiteral("\n                            </dt>\n                            <dd>\n                                <label id=\"Discount\" name=\"Discount\">");
            EndContext();
            BeginContext(4922, 14, false);
#line 118 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                                                                Write(Model.Discount);

#line default
#line hidden
            EndContext();
            BeginContext(4936, 108, true);
            WriteLiteral("</label>\n                            </dd>\n                            <dt>\n                                ");
            EndContext();
            BeginContext(5045, 44, false);
#line 121 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayNameFor(model => model.SubTotal));

#line default
#line hidden
            EndContext();
            BeginContext(5089, 137, true);
            WriteLiteral("\n                            </dt>\n                            <dd>\n                                <label id=\"SubTotal\" name=\"SubTotal\">");
            EndContext();
            BeginContext(5227, 14, false);
#line 124 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                                                                Write(Model.SubTotal);

#line default
#line hidden
            EndContext();
            BeginContext(5241, 108, true);
            WriteLiteral("</label>\n                            </dd>\n                            <dt>\n                                ");
            EndContext();
            BeginContext(5350, 39, false);
#line 127 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayNameFor(model => model.Tax));

#line default
#line hidden
            EndContext();
            BeginContext(5389, 127, true);
            WriteLiteral("\n                            </dt>\n                            <dd>\n                                <label id=\"Tax\" name=\"Tax\">");
            EndContext();
            BeginContext(5517, 9, false);
#line 130 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                                                      Write(Model.Tax);

#line default
#line hidden
            EndContext();
            BeginContext(5526, 108, true);
            WriteLiteral("</label>\n                            </dd>\n                            <dt>\n                                ");
            EndContext();
            BeginContext(5635, 43, false);
#line 133 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayNameFor(model => model.Freight));

#line default
#line hidden
            EndContext();
            BeginContext(5678, 135, true);
            WriteLiteral("\n                            </dt>\n                            <dd>\n                                <label id=\"Freight\" name=\"Freight\">");
            EndContext();
            BeginContext(5814, 13, false);
#line 136 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                                                              Write(Model.Freight);

#line default
#line hidden
            EndContext();
            BeginContext(5827, 108, true);
            WriteLiteral("</label>\n                            </dd>\n                            <dt>\n                                ");
            EndContext();
            BeginContext(5936, 41, false);
#line 139 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                           Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(5977, 131, true);
            WriteLiteral("\n                            </dt>\n                            <dd>\n                                <label id=\"Total\" name=\"Total\">");
            EndContext();
            BeginContext(6109, 11, false);
#line 142 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                                                          Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(6120, 233, true);
            WriteLiteral("</label>\n                            </dd>\n                        </dl>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </section>\n    <!-- /.content -->\n</div>\n<!-- /.content-wrapper -->\n\n\n\n\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(6369, 2, true);
                WriteLiteral("\n\n");
                EndContext();
            }
            );
            BeginContext(6373, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6391, 253, true);
                WriteLiteral("\n\n    <script type=\"text/javascript\">\n        $(function () {\n\n            var dataManager = ej.DataManager({\n                url: \"/api/PurchaseOrderLine\",\n                adaptor: new ej.WebApiAdaptor(),\n                headers: [{ \"PurchaseOrderId\": ");
                EndContext();
                BeginContext(6645, 21, false);
#line 169 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                                          Write(Model.PurchaseOrderId);

#line default
#line hidden
                EndContext();
                BeginContext(6666, 1205, true);
                WriteLiteral(@"}],
                offline: true,
            });

            var dataManagerProduct = ej.DataManager({
                url: ""/api/Product"",
                adaptor: new ej.WebApiAdaptor()
            });

            var dataManagerPurchaseOrder = ej.DataManager({
                url: ""/api/PurchaseOrder"",
                adaptor: new ej.WebApiAdaptor()
            });

            var dataManagerBranch = ej.DataManager({
                url: ""/api/Branch"",
                adaptor: new ej.WebApiAdaptor()
            });

            var dataManagerVendor = ej.DataManager({
                url: ""/api/Vendor"",
                adaptor: new ej.WebApiAdaptor()
            });

            var dataManagerCurrency = ej.DataManager({
                url: ""/api/Currency"",
                adaptor: new ej.WebApiAdaptor()
            });

            var dataManagerPurchaseType = ej.DataManager({
                url: ""/api/PurchaseType"",
                adaptor: new ej.WebApiAdaptor()
            });

            $('#");
                WriteLiteral("BranchId\').ejDropDownList({\n                dataSource: dataManagerBranch,\n                fields: { id: \'BranchId\', text: \'BranchName\', value: \'BranchId\' },\n                value: ");
                EndContext();
                BeginContext(7872, 14, false);
#line 206 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                  Write(Model.BranchId);

#line default
#line hidden
                EndContext();
                BeginContext(7886, 248, true);
                WriteLiteral(",\n                enabled: false,\n            });\n\n            $(\'#VendorId\').ejDropDownList({\n                dataSource: dataManagerVendor,\n                fields: { id: \'VendorId\', text: \'VendorName\', value: \'VendorId\' },\n                value: ");
                EndContext();
                BeginContext(8135, 14, false);
#line 213 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                  Write(Model.VendorId);

#line default
#line hidden
                EndContext();
                BeginContext(8149, 259, true);
                WriteLiteral(@",
                enabled: false,
            });

            $('#CurrencyId').ejDropDownList({
                dataSource: dataManagerCurrency,
                 fields: { id: 'CurrencyId', text: 'CurrencyName', value: 'CurrencyId' },
                value: ");
                EndContext();
                BeginContext(8409, 16, false);
#line 220 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                  Write(Model.CurrencyId);

#line default
#line hidden
                EndContext();
                BeginContext(8425, 278, true);
                WriteLiteral(@",
                enabled: false,
            });

            $('#PurchaseTypeId').ejDropDownList({
                dataSource: dataManagerPurchaseType,
                fields: { id: 'PurchaseTypeId', text: 'PurchaseTypeName', value: 'PurchaseTypeId' },
                value: ");
                EndContext();
                BeginContext(8704, 20, false);
#line 227 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                  Write(Model.PurchaseTypeId);

#line default
#line hidden
                EndContext();
                BeginContext(8724, 1154, true);
                WriteLiteral(@",
                enabled: false,
            });

            dataManager.ready.done(function (e) { 
            $(""#Grid"").ejGrid({
                dataSource: ej.DataManager({
                    json: e.result,
                    adaptor: new ej.remoteSaveAdaptor(),
                    insertUrl: ""/api/PurchaseOrderLine/Insert"",
                    updateUrl: ""/api/PurchaseOrderLine/Update"",
                    removeUrl: ""/api/PurchaseOrderLine/Remove"",
                }),
                toolbarSettings: {
                    showToolbar: true,
                    toolbarItems: [""add"", ""edit"", ""delete"", ""update"", ""cancel""]
                },
                editSettings: {
                    allowEditing: true,
                    allowAdding: true,
                    allowDeleting: true,
                    showDeleteConfirmDialog: true,

                },
                allowPaging: true,
                columns: [
                    { field: ""PurchaseOrderLineId"", headerText: 'Line Id', isPrima");
                WriteLiteral("ryKey: true, isIdentity: true, visible: false },\n                    { field: \"PurchaseOrderId\", headerText: \'PO#\', defaultValue: ");
                EndContext();
                BeginContext(9879, 21, false);
#line 254 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/PurchaseOrder/Detail.cshtml"
                                                                            Write(Model.PurchaseOrderId);

#line default
#line hidden
                EndContext();
                BeginContext(9900, 2642, true);
                WriteLiteral(@", foreignKeyField: ""PurchaseOrderId"", foreignKeyValue: ""PurchaseOrderName"", dataSource: dataManagerPurchaseOrder, visible: false },
                    { field: ""ProductId"", headerText: 'Product', foreignKeyField: ""ProductId"", foreignKeyValue: ""ProductName"", dataSource: dataManagerProduct },
                    { field: ""Description"", headerText: 'Description' },
                    { field: ""Quantity"", headerText: 'Qty', defaultValue: 1, editType: ""numericedit"", format: ""{0:n2}"" },
                    { field: ""Price"", headerText: 'Price', defaultValue: 0, editType: ""numericedit"", format: ""{0:n2}"" },
                    { field: ""Amount"", headerText: 'Amount', defaultValue: 0, allowEditing: false, editType: ""numericedit"", format: ""{0:n2}"" },
                    { field: ""DiscountPercentage"", headerText: 'Disc %', defaultValue: 0, editType: ""numericedit"", format: ""{0:n2}"" },
                    { field: ""DiscountAmount"", headerText: 'Disc Amt', defaultValue: 0, visible: false, editType: ""numericedit"", format:");
                WriteLiteral(@" ""{0:n2}"" },
                    { field: ""SubTotal"", headerText: 'SubTotal', defaultValue: 0, allowEditing: false, editType: ""numericedit"", format: ""{0:n2}"" },
                    { field: ""TaxPercentage"", headerText: 'Tax %', defaultValue: 0, editType: ""numericedit"", format: ""{0:n2}"" },
                    { field: ""TaxAmount"", headerText: 'Tax Amt', defaultValue: 0, visible: false, editType: ""numericedit"", format: ""{0:n2}"" },
                    { field: ""Total"", headerText: 'Total', defaultValue: 0, allowEditing: false, editType: ""numericedit"", format: ""{0:n2}"" },
                ],
                actionComplete: ""complete"",
            });
            });


        });

        function complete(args) {

            if (args.requestType == 'beginedit') {
                $(""#"" + this._id + ""_dialogEdit"").ejDialog({ title: ""Edit Record"" });
            }
            if (args.requestType == 'save' || args.requestType == 'delete') {
                RewriteTotal(args.data.PurchaseOrderId);
            }
    ");
                WriteLiteral(@"    }

        function RewriteTotal(purchaseOrderId) {
            $.ajax({
                type: 'GET',
                url: '/api/PurchaseOrder/GetById/' + purchaseOrderId,
                success: function (data) {
                    $('#Amount').text(data.Amount);
                    $('#SubTotal').text(data.SubTotal);
                    $('#Discount').text(data.Discount);
                    $('#Tax').text(data.Tax);
                    $('#Freight').text(data.Freight);
                    $('#Total').text(data.Total);
                }
            });
        }



    </script>
");
                EndContext();
            }
            );
            BeginContext(12544, 1, true);
            WriteLiteral("\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<coderush.Models.PurchaseOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591