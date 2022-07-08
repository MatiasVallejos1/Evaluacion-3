<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarLecturas.aspx.cs" Inherits="EvaluacionWeb.MostrarLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
      <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="lecturaDdl">Filtrar por Nivel:</label>
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="lecturaDdl_SelectedIndexChanged" runat="server" ID="lecturaDdl">
                            
                        </asp:DropDownList>
                    </div>
                    <asp:GridView CssClass="table table-hover table-bordered mt-5"
                        OnRowCommand="grillaLectura_RowCommand"
                        AutoGenerateColumns="false"
                        EmptyDataText="No hay Lecturas"
                        ShowHeader="true"
                        runat="server" ID="grillaLecturas">
                        <Columns>
                            <asp:BoundField DataField="SMedidor.Nombre" HeaderText="Medidor" />
                            <asp:BoundField DataField="Fecha" HeaderText="Rut Cliente" />
                            <asp:BoundField DataField="Hora" HeaderText="Nombre Cliente" />
                            <asp:BoundField DataField="Minutos" HeaderText="Nivel Rewards" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button
                                        CommandName="eliminar"
                                        CommandArgument='<%# Eval("Id") %>'
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
