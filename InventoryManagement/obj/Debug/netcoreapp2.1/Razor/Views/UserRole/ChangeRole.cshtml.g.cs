#pragma checksum "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/UserRole/ChangeRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ac510dde0c71bf5928cbbf1a2c1c4664ec21315"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserRole_ChangeRole), @"mvc.1.0.view", @"/Views/UserRole/ChangeRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserRole/ChangeRole.cshtml", typeof(AspNetCore.Views_UserRole_ChangeRole))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ac510dde0c71bf5928cbbf1a2c1c4664ec21315", @"/Views/UserRole/ChangeRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ac69d2a6197d05847cf2439b90d37e9c3db3e0", @"/Views/_ViewImports.cshtml")]
    public class Views_UserRole_ChangeRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/UserRole/ChangeRole.cshtml"
  
    ViewData["Title"] = "Change Role";

#line default
#line hidden
            BeginContext(45, 319, true);
            WriteLiteral(@"
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">

    <!-- Main content -->
    <section class=""content"">
        <!-- Default box -->
        <div class=""box"">
            <div class=""box-header with-border"">
                <h3 class=""box-title text-primary""><i class=""fa fa-users""></i> ");
            EndContext();
            BeginContext(365, 17, false);
#line 14 "/home/ageeb/Downloads/asp code/InventoryManagement-master/InventoryManagement/Views/UserRole/ChangeRole.cshtml"
                                                                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(382, 1903, true);
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

<script id=""templateForm"" type=""text/template"">
    <input hidden id=""UserProfileId"" name=""UserProfileId"" value=""{{:UserProfileId}}"" />
    <input hidde");
            WriteLiteral(@"n id=""ApplicationUserId"" name=""ApplicationUserId"" value=""{{:ApplicationUserId}}"" />
    <table cellspacing=""10"">
        <tr>
            <td>
                Email
            </td>
            <td colspan=""3"">
                <input id=""Email"" name=""Email"" value=""{{:Email}}"" />
            </td>
        </tr>
        <tr>
            <td>
                First Name
            </td>
            <td>
                <input id=""FirstName"" name=""FirstName"" value=""{{:FirstName}}"" />
            </td>
            <td>
                Last Name
            </td>
            <td>
                <input id=""LastName"" name=""LastName"" value=""{{:LastName}}"" />
            </td>
        </tr>
        <tr>
            <td colspan=""4"">
                <div id=""waitingPopup""></div>
                <div id=""GridRole""></div>
            </td>
        </tr>
    </table>
</script>


");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(2301, 2, true);
                WriteLiteral("\n\n");
                EndContext();
            }
            );
            BeginContext(2305, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2323, 5410, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(function () {

            var dataManager = ej.DataManager({
                url: ""/api/User"",
                adaptor: new ej.WebApiAdaptor(),
                offline: true
            });

            dataManager.ready.done(function (e) {
                $(""#Grid"").ejGrid({
                    dataSource: ej.DataManager({
                        json: e.result,
                        adaptor: new ej.remoteSaveAdaptor(),
                        updateUrl: ""/api/User/ChangeRole""
                    }),
                    toolbarSettings: {
                        showToolbar: true,
                        toolbarItems: [""edit"", ""update"", ""cancel"", ""search"", ""printGrid""]
                    },
                    editSettings: {
                        allowEditing: true,
                        allowAdding: false,
                        allowDeleting: false,
                        showDeleteConfirmDialog: true,
                        editMode: ""dialogtempl");
                WriteLiteral(@"ate"",
                        dialogEditorTemplateID: ""#templateForm"",
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
                        { field: ""UserProfileId"", headerText: 'Id', isPrimaryKey: true, isIdentity: true, visible: false },
                        { field: ""Email"", headerText: 'Email', validationRules: { required: true } },
                        { field: ""FirstName"", headerText: 'First Name', validationRules: { required: true } },
            ");
                WriteLiteral(@"            { field: ""LastName"", headerText: 'Last Name', validationRules: { required: false } },
                    ],
                    actionComplete: ""complete"",
                });
            });



        });

        function loadRoleByApplicationUserId() {
            renderWaiting();

            var applicationUserId = $(""#ApplicationUserId"").val();

            var dataManagerRole = ej.DataManager({
                url: ""/api/Role/GetRoleByApplicationUserId/"" + applicationUserId,
                adaptor: new ej.WebApiAdaptor(),
                offline: true
            });

            dataManagerRole.ready.done(function (e) { 
                $(""#GridRole"").ejGrid({
                    dataSource: ej.DataManager({
                        json: e.result,
                        adaptor: new ej.remoteSaveAdaptor(),
                        updateUrl: ""/api/Role/UpdateUserRole""
                    }),
                    toolbarSettings: {
                        showToolbar: true,
              ");
                WriteLiteral(@"          toolbarItems: [""edit"", ""update"", ""cancel"", ""search""]
                    },
                    editSettings: {
                        allowEditing: true,
                        allowAdding: false,
                        allowDeleting: false,
                    },
                    isResponsive: true,
                    enableResponsiveRow: true,
                    allowSorting: true,
                    allowSearching: true,
                    allowFiltering: false,
                    allowPaging: true,
                    pageSettings: { pageSize: 10 },
                    columns: [
                        { field: ""CounterId"", headerText: 'Id', isPrimaryKey: true, visible: false },
                        { field: ""ApplicationUserId"", headerText: 'Application UserId', visible: false },
                        { field: ""RoleName"", headerText: 'Role Name', allowEditing: false },
                        { field: ""IsHaveAccess"", headerText: 'Is Have Access', type: ""boolean"", editType: ""boo");
                WriteLiteral(@"leanedit"" },
                    ],
                    actionBegin: ""gridRoleBegin""
                });
            });
        }

        function gridRoleBegin(args) {
            hideWaiting();
        }


        function complete(args) {

            $(""#Email"").ejMaskEdit({
                inputMode: 'Text',
            });
            $(""#FirstName"").ejMaskEdit({
                inputMode: 'Text',
            });
            $(""#LastName"").ejMaskEdit({
                inputMode: 'Text',
            });

            if (args.requestType == 'beginedit') {
                $(""#"" + this._id + ""_dialogEdit"").ejDialog({ title: ""Edit Role"" });
                $(""#Email"").ejMaskEdit(""disable"");
                $(""#FirstName"").ejMaskEdit(""disable"");
                $(""#LastName"").ejMaskEdit(""disable"");

                loadRoleByApplicationUserId();
            }

            if (args.requestType == ""save"") {
                this.refreshContent();
            }

        }

        function renderWaiting() {
   ");
                WriteLiteral(@"         $(""#waitingPopup"").ejWaitingPopup({
                showOnInit: true,
                target: ""#GridRole""
            });
        }

        function hideWaiting() {
            var obj = $(""#waitingPopup"").data(""ejWaitingPopup"");
            obj.hide();
        }


    </script>
");
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
