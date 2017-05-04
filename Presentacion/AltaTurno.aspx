<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaTurno.aspx.cs" Inherits="Presentacion.AltaTurno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <div class="container" id="container">
        <div class="panel panel-primary">
            <div class="panel-heading">Carga Clientes</div>
            <div class="panel-body">

                <div class="form-group">
                    <asp:Label ID="lblFechaturno" class="col-md-2 control-label" runat="server" Text="Fecha del Turno: "></asp:Label>
                    <div class="col-md-4">
                        <div id="datetimepicker" class="input-append date">

                            <input type="text" id="txtFechaTurno" runat="server" /> 
                            <span class="add-on">
                                <i data-time-icon="icon-time" data-date-icon="icon-calendar"></i>
                            </span>
                        </div>
                    </div>

                    <asp:Label ID="lblMotivoTurno" class="col-md-2 control-label" runat="server" Text="Motivo Turno: "></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtMotivoTurno" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="form-group">

                <asp:Label ID="lblDescripcion" class="col-md-2 control-label" runat="server" Text="Descripcion Turno: "></asp:Label>

                <div class="col-md-4">
                    <asp:TextBox ID="txtDescripcionTurno" runat="server"></asp:TextBox>
                </div>

                <asp:Label ID="lblCliente" class="col-md-2 control-label" runat="server" Text="Seleccione Cliente: "></asp:Label>

                <div class="col-md-4">
                </div>
                <asp:DropDownList ID="ddlCliente" runat="server" DataTextField="clienteNombre" DataValueField="clienteId">
                </asp:DropDownList>
            </div>
        </div>
        <div class="col-md-4">
            <asp:Button ID="btnGuardar" CssClass="btn btn-success" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>
    </div>
    <div class="container">
        <asp:GridView ID="gdvTurnos" runat="server" CssClass="table table-hover" AutoGenerateColumns="false" OnRowCommand="gdvTurnos_RowCommand">

            <Columns>
                <asp:BoundField HeaderText="Nombre " DataField="clienteNombre" />
                <asp:BoundField HeaderText="Apellido " DataField="clienteApellido" />
                <asp:BoundField HeaderText="Direccion " DataField="clienteDireccion" />
                <asp:BoundField HeaderText="Telefono " DataField="clienteTelefono" />
                <asp:BoundField HeaderText="Fecha Turno " DataField="turnoFecha" />
                <asp:BoundField HeaderText="Motivo " DataField="turnoMotivo" />
                <asp:BoundField HeaderText="Descripcion " DataField="turnoDescripcion" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton runat="server" ImageUrl="~/img/edit.png" CommandName="btnEditar" CommandArgument='<%#Eval("turnoId") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <script type="text/javascript" src="js/jquery.min.js"> </script>
    <script type="text/javascript" src="js/bootstrap.min.js"> </script>
    <script type="text/javascript" src="js/bootstrap-datetimepicker.min.js">  </script>
    <script type="text/javascript" src="js/bootstrap-datetimepicker.pt-AR.js"> </script>

    <script type="text/javascript">
        $('#datetimepicker').datetimepicker({
            format: 'dd/MM/yyyy hh:mm:ss',
            language: 'pt-AR'
        });
    </script>
</asp:Content>
