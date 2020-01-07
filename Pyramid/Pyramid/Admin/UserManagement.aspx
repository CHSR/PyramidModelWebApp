﻿<%@ Page Title="User Management" Language="C#" MasterPageFile="~/MasterPages/LoggedIn.Master" AutoEventWireup="true" CodeBehind="UserManagement.aspx.cs" Inherits="Pyramid.Admin.UserManagement" %>
<%@ Register Assembly="DevExpress.Web.v19.1, Version=19.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Data.Linq" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.Bootstrap.v19.1, Version=19.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register TagPrefix="uc" TagName="Messaging" Src="~/User_Controls/MessagingSystem.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ContentPlaceHolderID="ScriptContent" runat="server">
    <script>
        $(document).ready(function () {
            //Run the initial page init
            initializePage();

            //Run the page init after every AJAX load
            var requestManager = Sys.WebForms.PageRequestManager.getInstance();
            requestManager.add_endRequest(initializePage);
        });

        //This function initializes the page
        function initializePage() {
            //When the user goes to disable a user, set the hidden field pk
            $('.disable-user, .enable-user, .send-confirm-email').off('click').on('click', function () {
                $('[ID$="hfUserPK"]').val($(this).data('pk'));
            });

            //Hide the modal after a user is disabled
            $('[ID$="lbConfirmDisable"]').off('click').on('click', function () {
                $('#divDisableModal').modal('hide');
            });
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="upUserManagement" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true">
        <ContentTemplate>
            <uc:Messaging ID="msgSys" runat="server" />
            <asp:HiddenField ID="hfUserPK" runat="server" ClientIDMode="Static" />
            <div class="card bg-light">
                <div class="card-header">
                    Users
                    <a class="btn btn-loader btn-primary float-right" href="/Admin/CreateNewUser.aspx"><i class="fas fa-plus"></i> Add New User</a>
                </div>
                <div class="card-body">
                    <div>
                        <label>All Users</label>
                        <dx:BootstrapGridView ID="bsGRUsers" runat="server" EnableCallBacks="false" KeyFieldName="Id" AutoGenerateColumns="false" 
                            DataSourceID="efUserDataSource" OnHtmlRowCreated="bsGRUsers_HtmlRowCreated">
                            <SettingsPager PageSize="15" />
                            <SettingsBootstrap Striped="true" />
                            <SettingsBehavior EnableRowHotTrack="true" />
                            <SettingsSearchPanel Visible="true" ShowApplyButton="true" />
                            <Settings ShowGroupPanel="false" />
                            <CssClasses IconHeaderSortUp="fas fa-long-arrow-alt-up" IconHeaderSortDown="fas fa-long-arrow-alt-down" IconShowAdaptiveDetailButton="fas fa-plus-circle" />
                            <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true" AdaptiveColumnPosition="Left"></SettingsAdaptivity>
                            <Columns>
                                <dx:BootstrapGridViewDataColumn FieldName="Name" Caption="Name" SortIndex="0" SortOrder="Ascending" AdaptivePriority="0" />
                                <dx:BootstrapGridViewDataColumn FieldName="UserName" Caption="Username" AdaptivePriority="1" />
                                <dx:BootstrapGridViewDataColumn FieldName="Email" Caption="Email" AdaptivePriority="1">
                                    <DataItemTemplate>
                                        <asp:Label ID="lblEmail" runat="server" Text='<%# Eval("Email") %>' data-toggle="popover" data-trigger="hover"></asp:Label>
                                    </DataItemTemplate>
                                </dx:BootstrapGridViewDataColumn>
                                <dx:BootstrapGridViewDataColumn FieldName="PhoneNumber" Caption="Phone" AdaptivePriority="1">
                                    <DataItemTemplate>
                                        <asp:Label ID="lblPhone" runat="server" Text='<%# (Eval("PhoneNumber") != null && !String.IsNullOrWhiteSpace(Eval("PhoneNumber").ToString()) ? Convert.ToInt64(Eval("PhoneNumber")).ToString("+1 (###) ###-####") : "") %>' data-toggle="popover" data-trigger="hover"></asp:Label>
                                    </DataItemTemplate>
                                </dx:BootstrapGridViewDataColumn>
                                <dx:BootstrapGridViewDateColumn FieldName="LockoutEndDateUtc" Caption="Lockout End Date" PropertiesDateEdit-DisplayFormatString="MM/dd/yyyy" AdaptivePriority="2" />
                                <dx:BootstrapGridViewDataColumn FieldName="TwoFactorEnabled" Caption="Two Factor?" AdaptivePriority="3">
                                    <DataItemTemplate>
                                        <%# (Convert.ToBoolean(Eval("TwoFactorEnabled")) ? "Yes" : "No") %>
                                    </DataItemTemplate>
                                </dx:BootstrapGridViewDataColumn>
                                <dx:BootstrapGridViewButtonEditColumn Settings-AllowDragDrop="False" AdaptivePriority="0" CssClasses-DataCell="text-center">
                                    <DataItemTemplate>
                                        <div class="btn-group">
                                            <button id="btnActions" type="button" class="btn btn-secondary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                                Actions
                                            </button>
                                            <div class="dropdown-menu dropdown-menu-right" aria-labelledby="btnActions">
                                                <a class="dropdown-item" href="/Admin/EditUser?Id=<%# Eval("Id") %>"><i class="fas fa-edit"></i> Edit</a>
                                                <asp:LinkButton ID="lbDisableUser" runat="server" CssClass="dropdown-item disable-user" data-toggle="modal" data-target="#divDisableModal" data-pk='<%#Eval("Id") %>'><i class="fas fa-toggle-on"></i> Disable</asp:LinkButton>
                                                <asp:LinkButton ID="lbEnableUser" runat="server" 
                                                    CssClass="dropdown-item enable-user" OnClick="lbEnableUser_Click" data-pk='<%#Eval("Id") %>'><i class="fas fa-toggle-off"></i> Enable</asp:LinkButton>
                                                <asp:LinkButton ID="lbSendConfirmEmail" runat="server" 
                                                    CssClass="dropdown-item send-confirm-email" OnClick="lbSendConfirmEmail_Click" data-pk='<%#Eval("Id") %>'><i class="fas fa-paper-plane"></i> Send Confirmation Email</asp:LinkButton>
                                            </div>
                                        </div>
                                    </DataItemTemplate>
                                </dx:BootstrapGridViewButtonEditColumn>
                            </Columns>
                        </dx:BootstrapGridView>
                        <dx:EntityServerModeDataSource ID="efUserDataSource" runat="server"
                            OnSelecting="efUserDataSource_Selecting" />
                    </div>
                </div>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="lbConfirmDisable" />
        </Triggers>
    </asp:UpdatePanel>

    <div class="modal fade" id="divDisableModal" tabindex="-1" role="dialog" aria-labelledby="disableModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="disableModalLabel">Disable Confirmation</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <p>Are you sure you want to disable this user?</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal"><i class="fas fa-times"></i> Close</button>
                    <asp:LinkButton ID="lbConfirmDisable" runat="server" CssClass="btn btn-loader btn-warning" OnClick="lbConfirmDisable_Click"><i class="fas fa-check"></i> Yes</asp:LinkButton>
                </div>
            </div>
        </div>
    </div>
</asp:Content>