<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="manage-enquiry.aspx.cs" Inherits="admin_manage_department" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   
    <style>
        .table td, .table th {
            padding: 0.3rem !important;
            vertical-align: top;
            border-top: 1px solid #dee2e6;
            font-size: 13px !important;
        }

        .pagination-ys {
            /*display: inline-block;*/
            padding-left: 0;
            margin: 20px 0;
            border-radius: 4px;
        }

            .pagination-ys table > tbody > tr > td {
                display: inline;
            }

                .pagination-ys table > tbody > tr > td > a,
                .pagination-ys table > tbody > tr > td > span {
                    position: relative;
                    float: left;
                    padding: 8px 12px;
                    line-height: 1.42857143;
                    text-decoration: none;
                    color: #dd4814;
                    background-color: #ffffff;
                    border: 1px solid #dddddd;
                    margin-left: -1px;
                }

                .pagination-ys table > tbody > tr > td > span {
                    position: relative;
                    float: left;
                    padding: 8px 12px;
                    line-height: 1.42857143;
                    text-decoration: none;
                    margin-left: -1px;
                    z-index: 2;
                    color: #aea79f;
                    background-color: #f5f5f5;
                    border-color: #dddddd;
                    cursor: default;
                }

                .pagination-ys table > tbody > tr > td:first-child > a,
                .pagination-ys table > tbody > tr > td:first-child > span {
                    margin-left: 0;
                    border-bottom-left-radius: 4px;
                    border-top-left-radius: 4px;
                }

                .pagination-ys table > tbody > tr > td:last-child > a,
                .pagination-ys table > tbody > tr > td:last-child > span {
                    border-bottom-right-radius: 4px;
                    border-top-right-radius: 4px;
                }

                .pagination-ys table > tbody > tr > td > a:hover,
                .pagination-ys table > tbody > tr > td > span:hover,
                .pagination-ys table > tbody > tr > td > a:focus,
                .pagination-ys table > tbody > tr > td > span:focus {
                    color: #97310e;
                    background-color: #eeeeee;
                    border-color: #dddddd;
                }
    </style>

    <div class="alert" id="alert_container"></div>

    <asp:Label ID="lblquery" hidden runat="server" Text=""></asp:Label>

    <section class="content">
        <div class="container-fluid">

            <div class="card card-danger">
                <div class="card-header">
                    <h3 class="card-title">Manage Enquiry</h3>
                    
                </div>

                <div class="card-body">

                    <div class="row">

                        <div class="col-md-12">

                            <div class="table-responsive">

                                <asp:GridView ID="grdproducts" AutoGenerateColumns="false" ShowHeader="true" ShowFooter="False" class="table table-bordered table-striped gvv" runat="server" CellPadding="15" AllowPaging="True" OnPageIndexChanging="grdproducts_PageIndexChanging" PageSize="30" AllowSorting="True" PagerSettings-Position="Bottom" OnRowDataBound="grdproducts_RowDataBound">
                                    <Columns>

                                        <asp:TemplateField HeaderText="Name">
                                            <ItemTemplate>

                                                <asp:Label ID="txt_name" runat="server" Text='<%# Eval("name") %>'></asp:Label>

                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Mobile No">
                                            <ItemTemplate>

                                                <asp:Label ID="txt_mobileno" runat="server" Text='<%# Eval("mobileno") %>'></asp:Label>

                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Email ID">
                                            <ItemTemplate>

                                                <asp:Label ID="txtano" runat="server" Text='<%# Eval("email") %>'></asp:Label>

                                            </ItemTemplate>
                                        </asp:TemplateField>

                                       


                                        
                                        <asp:TemplateField HeaderText="Message">
                                            <ItemTemplate>

                                                <asp:Label ID="txt_address" runat="server" Text='<%# Eval("message") %>'></asp:Label>

                                            </ItemTemplate>
                                        </asp:TemplateField>



                                        <asp:TemplateField HeaderText="Action">
                                            <ItemTemplate>

                                                <asp:LinkButton runat="server" class="link-danger" ID="lnkdel" title="Delete" CommandArgument='<%# Eval("id") %>' OnClick="lnkdel_Click"><i class="fa fa-trash"></i></asp:LinkButton>

                                            </ItemTemplate>
                                        </asp:TemplateField>

                                    </Columns>
                                    <PagerStyle CssClass="pagination-ys" />
                                </asp:GridView>

                                <%-- Delete Modal--%>

                                <div class="modal fade" id="Del" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">

                                    <div class="modal-dialog">
                                        <div class="modal-content">
                                            <div class="modal-header">
                                                <h5 class="modal-title" id="myModalLabel2">Confirm Delete</h5>

                                                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                            </div>

                                            <div class="panel-body">

                                                <asp:Label ID="lbldeleteRowId" hidden runat="server"></asp:Label>
                                                <div class="col-md-12">
                                                    <div class="form-group">
                                                        <center>
                                                            <label style="font-size: 25px;">Are you sure you want to delete?</label>
                                                        </center>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="modal-footer">
                                                <button type="button" class="btn btn-default" data-dismiss="modal">No</button>
                                                <button id="lnkdelete" runat="server" class="btn btn-danger" onserverclick="lnkdelete_ServerClick">Yes</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>

                        </div>
                    </div>


                </div>
            </div>
        </div>
    </section>


    <br />


</asp:Content>