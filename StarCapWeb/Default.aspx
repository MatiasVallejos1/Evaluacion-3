<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EvaluacionWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeslbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Ingresar Lectura</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="medidorDdl">Medidor</label>
                        <asp:DropDownList runat="server" ID="medidorDdl" CssClass="form-select">

                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="fechaDbl">Fecha de Lectura</label>
                        <asp:Calendar runat="server" ID="fechaDdl"></asp:Calendar>
                    </div>
                    <div class="form-group">
                        <label for="nombreTxt">Hora de Lectura</label>
                        <div class="row justify-content-start">
                            <div class="col-4"><p class="text-center text-primary">Hora</p></div>
                            <div class="col-4"><p class="text-center text-primary">Minutos</p></div>
                        </div>
                        <div class="row justify-content-start">
                            <div class="col-4"><asp:TextBox type="number" min="1" max="24" ID="horaTxt" CssClass="form-control" runat="server"></asp:TextBox></div>
                            <div class="col-4"><asp:TextBox type="number" min="0" max="59" ID="minutosTxt" CssClass="form-control" runat="server"></asp:TextBox></div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="nivelRbl">Consumo</label>
                        <asp:TextBox type="number" min="0" max="600" ID="consumoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" OnClick="agregarBtn_Click"
                            Text="Agregar" CssClass="btn btn-primary " />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
