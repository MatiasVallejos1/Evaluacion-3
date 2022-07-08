<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidor.aspx.cs" Inherits="StarCapWeb.VerMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="medidorDdl">Filtrar por Nivel:</label>
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="medidorDdl_SelectedIndexChanged" runat="server" ID="medidorDdl">
                            
                        </asp:DropDownList>
                    </div>
                    <asp:GridView CssClass="table table-hover table-bordered mt-5"
                        OnRowCommand="grillaMedidor_RowCommand"
                        AutoGenerateColumns="false"
                        EmptyDataText="No hay Medidores"
                        ShowHeader="true"
                        runat="server" ID="grillaMedidor">
                        <Columns>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre Medidor" />
                            <asp:BoundField DataField="Serie" HeaderText="Serie Medidor" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button
                                        CommandName="eliminarM"
                                        CommandArgument='<%# Eval("Serie") %>'
                                        runat="server" CssClass="btn btn-danger" Text="Eliminar" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
