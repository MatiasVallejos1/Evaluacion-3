<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarMedidor.aspx.cs" Inherits="StarCapWeb.IngresarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeslbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Ingresar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="nombreTxt">Nombre medidor</label>
                        <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox>                      
                    </div>
                    <div class="form-group">
                        <label for="serieTxt">Numero de Serie</label>
                        <asp:TextBox ID="serieTxt" CssClass="form-control" runat="server"></asp:TextBox>                      
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarMBtn" OnClick="agregarMBtn_Click" 
                            Text="Agregar" CssClass="btn btn-primary " />
                    </div>
                </div>
            </div>
        </div>   
    </div>
</asp:Content>
