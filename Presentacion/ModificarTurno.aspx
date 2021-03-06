﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarTurno.aspx.cs" Inherits="Presentacion.ModificarTurno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <asp:HiddenField ID="hdfTurnoId" runat="server" />
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
            <asp:Label ID="lblDescripcion" class="col-md-2 control-label" runat="server" Text="Descripcion Turno: "></asp:Label>

            <div class="col-md-4">
                <asp:TextBox ID="txtDescripcionTurno" runat="server"></asp:TextBox>
            </div>

            <asp:Label ID="lblCliente" class="col-md-2 control-label" runat="server" Text="Seleccione Cliente: "></asp:Label>
            <asp:DropDownList ID="ddlCliente" runat="server" DataTextField="clienteNombre" DataValueField="clienteId">
            </asp:DropDownList>
        </div>
        <div class="col-md-4">
            <asp:Button ID="btnModificar" CssClass="btn btn-success" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
        </div>
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
