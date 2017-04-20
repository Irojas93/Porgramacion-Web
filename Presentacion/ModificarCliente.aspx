<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarCliente.aspx.cs" Inherits="Presentacion.ModificarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField ID="hdfClienteId" runat="server" />
      <br />
    <div class="container" id="container">
        <div class="panel panel-primary">
            <div class="panel-heading">Carga Clientes</div>
            <div class="panel-body">

                <div class="form-group">
                    <asp:Label ID="lblClienteNombre" class="col-md-2 control-label" runat="server" Text="Nombre Cliente: "></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtClienteNombre" runat="server"></asp:TextBox>
                    </div>

                    <asp:Label ID="lblClienteApellido" class="col-md-2 control-label" runat="server" Text="Apellido Cliente: "></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtClienteApellido" runat="server"></asp:TextBox>
                    </div>

                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblClienteDireccion" class="col-md-2 control-label" runat="server" Text="Dirección Cliente: "></asp:Label>

                <div class="col-md-4">
                    <asp:TextBox ID="txtCleinteDireccion" runat="server"></asp:TextBox>
                </div>

                <asp:Label ID="lblClienteTelefono" class="col-md-2 control-label" runat="server" Text="Telefono Cliente: "></asp:Label>

                <div class="col-md-4">
                    <asp:TextBox ID="txtClienteTelefono" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-2">
                    <asp:Button ID="btnModificar" CssClass="btn btn-success" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                </div>
            </div>
        </div>

    </div>
</asp:Content>
