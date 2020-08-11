#pragma checksum "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/Invoice/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db4d248362cda471ede1fab8173e0da117d12864"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Index), @"mvc.1.0.view", @"/Views/Invoice/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/Index.cshtml", typeof(AspNetCore.Views_Invoice_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db4d248362cda471ede1fab8173e0da117d12864", @"/Views/Invoice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ac69d2a6197d05847cf2439b90d37e9c3db3e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/Invoice/Index.cshtml"
  
    ViewData["Title"] = "Invoice";

#line default
#line hidden
            BeginContext(41, 324, true);
            WriteLiteral(@"<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">

    <!-- Main content -->
    <section class=""content"">
        <!-- Default box -->
        <div class=""box"">
            <div class=""box-header with-border"">
                <h3 class=""box-title text-primary""><i class=""fa fa-certificate""></i> ");
            EndContext();
            BeginContext(366, 17, false);
#line 13 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/Invoice/Index.cshtml"
                                                                                Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(383, 887, true);
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
                <div id=""Grid""></div>
            </div>
            <!-- /.box-body -->
            <div class=""box-footer"">
               
            </div>
            <!-- /.box-footer-->
        </div>
        <!-- /.box -->
    </section>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->

");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(1286, 2, true);
                WriteLiteral("\n\n");
                EndContext();
            }
            );
            BeginContext(1290, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1308, 4370, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(function () {

            var dataManager = ej.DataManager({
                url: ""/api/Invoice"",
                adaptor: new ej.WebApiAdaptor(),
                offline: true
            });

            var dataManagerShipment = ej.DataManager({
                url: ""/api/Shipment"",
                adaptor: new ej.WebApiAdaptor()
            });

            var dataManagerInvoiceType = ej.DataManager({
                url: ""/api/InvoiceType"",
                adaptor: new ej.WebApiAdaptor()
            });

            dataManager.ready.done(function (e) { 
                $(""#Grid"").ejGrid({
                    dataSource: ej.DataManager({
                        json: e.result,
                        adaptor: new ej.remoteSaveAdaptor(),
                        insertUrl: ""/api/Invoice/Insert"",
                        updateUrl: ""/api/Invoice/Update"",
                        removeUrl: ""/api/Invoice/Remove"",
                    }),
                    tool");
                WriteLiteral(@"barSettings: {
                        showToolbar: true,
                        toolbarItems: [""add"", ""edit"", ""delete"", ""update"", ""cancel"", ""search"", ""printGrid""]
                    },
                    editSettings: {
                        allowEditing: true,
                        allowAdding: true,
                        allowDeleting: true,
                        showDeleteConfirmDialog: true,
                        editMode: ""dialog""
                    },
                    isResponsive: true,
                    enableResponsiveRow: true,
                    allowSorting: true,
                    allowSearching: true,
                    allowFiltering: true,
                    filterSettings: {
                        filterType: ""excel"",
                        maxFilterChoices: 100,
                        enableCaseSensitivity: false
                    },
                    allowPaging: true,
                    pageSettings: { pageSize: 10, printMode: ej.Grid.PrintMode.CurrentPage ");
                WriteLiteral(@"},
                    columns: [
                        { field: ""InvoiceId"", headerText: 'Invoice', isPrimaryKey: true, isIdentity: true, visible: false },
                        { field: ""InvoiceName"", headerText: 'Invoice#', allowEditing: false },
                        { field: ""ShipmentId"", headerText: 'Shipment / DO', foreignKeyField: ""ShipmentId"", foreignKeyValue: ""ShipmentName"", dataSource: dataManagerShipment, validationRules: { required: true } },
                        { field: ""InvoiceDate"", headerText: 'Invoice Date', editType: ""datepicker"", format: ""{0:MM/dd/yyyy}"", validationRules: { required: true } },
                        { field: ""InvoiceDueDate"", headerText: 'Invoice Due Date', editType: ""datepicker"", format: ""{0:MM/dd/yyyy}"", validationRules: { required: true } },
                        { field: ""InvoiceTypeId"", headerText: 'Invoice Type', foreignKeyField: ""InvoiceTypeId"", foreignKeyValue: ""InvoiceTypeName"", dataSource: dataManagerInvoiceType },
                    ],
            ");
                WriteLiteral(@"        actionComplete: ""complete"",
                });
            });

            
        });

        function complete(args) {
            if (args.requestType == 'beginedit') {
                $(""#"" + this._id + ""_dialogEdit"").ejDialog({ title: ""Edit Record"" });
            }
            if (args.requestType == 'beginedit' || args.requestType == 'add') {
                var selected = $('#GridShipmentId').data('ejDropDownList');
                var selectedValue = parseInt(selected.option('value'));
                var selectedText = selected.option('text');
                $.ajax({
                    type: 'GET',
                    url: '/api/Shipment/GetNotInvoicedYet',
                    success: function (data) {
                        if (args.requestType == 'beginedit') {
                            data.push({ 'ShipmentId': selectedValue, 'ShipmentName': selectedText });
                        }

                        $(""#GridShipmentId"").ejDropDownList({
                            dataS");
                WriteLiteral(@"ource: data,
                            fields: { id: 'ShipmentId', text: 'ShipmentName', value: 'ShipmentId' },
                            value: selectedValue
                        });
                    }
                });

            }
        }


    </script>
");
                EndContext();
            }
            );
            BeginContext(5680, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
