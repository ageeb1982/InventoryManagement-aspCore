#pragma checksum "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/UnitOfMeasure/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a90da64977685ed87d17d0b88a9858d4ceebca6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UnitOfMeasure_Index), @"mvc.1.0.view", @"/Views/UnitOfMeasure/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UnitOfMeasure/Index.cshtml", typeof(AspNetCore.Views_UnitOfMeasure_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a90da64977685ed87d17d0b88a9858d4ceebca6", @"/Views/UnitOfMeasure/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ac69d2a6197d05847cf2439b90d37e9c3db3e0", @"/Views/_ViewImports.cshtml")]
    public class Views_UnitOfMeasure_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/UnitOfMeasure/Index.cshtml"
  
    ViewData["Title"] = "Unit of Measure";

#line default
#line hidden
            BeginContext(49, 317, true);
            WriteLiteral(@"<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">

    <!-- Main content -->
    <section class=""content"">
        <!-- Default box -->
        <div class=""box"">
            <div class=""box-header with-border"">
                <h3 class=""box-title text-primary""><i class=""fa fa-gear""></i> ");
            EndContext();
            BeginContext(367, 17, false);
#line 13 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/UnitOfMeasure/Index.cshtml"
                                                                         Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(384, 887, true);
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
                BeginContext(1287, 2, true);
                WriteLiteral("\n\n");
                EndContext();
            }
            );
            BeginContext(1291, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1309, 2258, true);
                WriteLiteral(@"

<script type=""text/javascript"">
    $(function () {

        var dataManager = ej.DataManager({
            url: ""/api/UnitOfMeasure"",
            adaptor: new ej.WebApiAdaptor(),
            offline: true
        });

        dataManager.ready.done(function (e) { 
            $(""#Grid"").ejGrid({
                dataSource: ej.DataManager({
                    json: e.result,
                    adaptor: new ej.remoteSaveAdaptor(),
                    insertUrl: ""/api/UnitOfMeasure/Insert"",
                    updateUrl: ""/api/UnitOfMeasure/Update"",
                    removeUrl: ""/api/UnitOfMeasure/Remove"",
                }),
                toolbarSettings: {
                    showToolbar: true,
                    toolbarItems: [""add"", ""edit"", ""delete"", ""update"", ""cancel"", ""search"", ""printGrid""]
                },
                editSettings: {
                    allowEditing: true,
                    allowAdding: true,
                    allowDeleting: true,
                    showDeleteConfirmD");
                WriteLiteral(@"ialog: true,
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
                pageSettings: { pageSize: 10, printMode: ej.Grid.PrintMode.CurrentPage },
                columns: [
                    { field: ""UnitOfMeasureId"", headerText: 'Unit of Measure Id', isPrimaryKey: true, isIdentity: true, visible: false },
                    { field: ""UnitOfMeasureName"", headerText: 'Unit of Measure Name', validationRules: { required: true } },
                    { field: ""Description"", headerText: 'Description', },
                ],
                actionComplete: ""complete"",
            });
        ");
                WriteLiteral("});\n\n        \n    });\n\n    function complete(args) {\n        if (args.requestType == \'beginedit\') {\n            $(\"#\" + this._id + \"_dialogEdit\").ejDialog({ title: \"Edit Record\" });\n        }\n    }\n\n\n</script>\n");
                EndContext();
            }
            );
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
