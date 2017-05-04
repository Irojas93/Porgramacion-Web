<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClienteAlta.aspx.cs" Inherits="Presentacion.ClienteAlta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                <asp:Button ID="btnGuardar" CssClass="btn btn-success" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            </div>
        </div>
        </div>
    </div>
    <br />
    <div class="container">
        <asp:GridView ID="gdvClientes" runat="server" CssClass="table table-hover" AutoGenerateColumns="false" OnRowCommand="gdvClientes_RowCommand">
            <Columns>
                <asp:BoundField HeaderText="Nombre " DataField="clienteNombre" />
                <asp:BoundField HeaderText="Apellido " DataField="clienteApellido" />
                <asp:BoundField HeaderText="Direccion " DataField="clienteDireccion" />
                <asp:BoundField HeaderText="Telefono " DataField="clienteTelefono" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton runat="server" ImageUrl="~/img/edit.png" CommandName="btnEditar" CommandArgument='<%#Eval("clienteId") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
