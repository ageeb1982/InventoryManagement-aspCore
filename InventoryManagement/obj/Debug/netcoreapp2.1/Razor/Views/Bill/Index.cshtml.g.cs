#pragma checksum "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/Bill/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e498c1c95b48641d96c62460dae5cc2529482bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bill_Index), @"mvc.1.0.view", @"/Views/Bill/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bill/Index.cshtml", typeof(AspNetCore.Views_Bill_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e498c1c95b48641d96c62460dae5cc2529482bc", @"/Views/Bill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ac69d2a6197d05847cf2439b90d37e9c3db3e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Bill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/Bill/Index.cshtml"
  
    ViewData["Title"] = "Bill";

#line default
#line hidden
            BeginContext(38, 324, true);
            WriteLiteral(@"<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">

    <!-- Main content -->
    <section class=""content"">
        <!-- Default box -->
        <div class=""box"">
            <div class=""box-header with-border"">
                <h3 class=""box-title text-primary""><i class=""fa fa-certificate""></i> ");
            EndContext();
            BeginContext(363, 17, false);
#line 13 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/Bill/Index.cshtml"
                                                                                Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(380, 885, true);
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
                BeginContext(1281, 2, true);
                WriteLiteral("\n\n");
                EndContext();
            }
            );
            BeginContext(1285, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1303, 4669, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(function () {

            var dataManager = ej.DataManager({
                url: ""/api/Bill"",
                adaptor: new ej.WebApiAdaptor(),
                offline: true
            });

            var dataManagerGoodsReceivedNote = ej.DataManager({
                url: ""/api/GoodsReceivedNote"",
                adaptor: new ej.WebApiAdaptor()
            });

            var dataManagerBillType = ej.DataManager({
                url: ""/api/BillType"",
                adaptor: new ej.WebApiAdaptor()
            });

            dataManager.ready.done(function (e) { 
                $(""#Grid"").ejGrid({
                    dataSource: ej.DataManager({
                        json: e.result,
                        adaptor: new ej.remoteSaveAdaptor(),
                        insertUrl: ""/api/Bill/Insert"",
                        updateUrl: ""/api/Bill/Update"",
                        removeUrl: ""/api/Bill/Remove"",
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
                        { field: ""BillId"", headerText: 'Bill', isPrimaryKey: true, isIdentity: true, visible: false },
                        { field: ""BillName"", headerText: 'Bill#', allowEditing: false },
                        { field: ""GoodsReceivedNoteId"", headerText: 'GRN', foreignKeyField: ""GoodsReceivedNoteId"", foreignKeyValue: ""GoodsReceivedNoteName"", dataSource: dataManagerGoodsReceivedNote, validationRules: { required: true } },
                        { field: ""VendorDONumber"", headerText: 'Vendor DO#' },
                        { field: ""VendorInvoiceNumber"", headerText: 'Vendor Invoice#' },
                        { field: ""BillDate"", headerText: 'Bill Date', editType: ""datepicker"", format: ""{0:MM/dd/yyyy}"", validationRules: { required: true }, validationRules: { required: true } },
                        { field: ""BillDueDate"", headerText: 'Bill Due Date', editType: ""datepicker"", format: ""{0:MM/dd/yyyy}"", validationRules: { required: true }, validationRules:");
                WriteLiteral(@" { required: true } },
                        { field: ""BillTypeId"", headerText: 'Bill Type', foreignKeyField: ""BillTypeId"", foreignKeyValue: ""BillTypeName"", dataSource: dataManagerBillType },
                    ],
                    actionComplete: ""complete"",
                });
            });

            
        });

        function complete(args) {
            if (args.requestType == 'beginedit') {
                $(""#"" + this._id + ""_dialogEdit"").ejDialog({ title: ""Edit Record"" });
            }
            if (args.requestType == 'beginedit' || args.requestType == 'add') {
                var selected = $('#GridGoodsReceivedNoteId').data('ejDropDownList');
                var selectedValue = parseInt(selected.option('value'));
                var selectedText = selected.option('text');
                $.ajax({
                    type: 'GET',
                    url: '/api/GoodsReceivedNote/GetNotBilledYet',
                    success: function (data) {
                        if (args.requestTy");
                WriteLiteral(@"pe == 'beginedit') {
                            data.push({ 'GoodsReceivedNoteId': selectedValue, 'GoodsReceivedNoteName': selectedText });
                        }

                        $(""#GridGoodsReceivedNoteId"").ejDropDownList({
                            dataSource: data,
                            fields: { id: 'GoodsReceivedNoteId', text: 'GoodsReceivedNoteName', value: 'GoodsReceivedNoteId' },
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
            BeginContext(5974, 1, true);
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
