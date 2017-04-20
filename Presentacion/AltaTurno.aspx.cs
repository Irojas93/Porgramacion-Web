using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class AltaTurno : System.Web.UI.Page
    {
        ClienteNego clienteNego = new ClienteNego();
        
        TurnoNego turnoNego = new TurnoNego();

        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            CargarCombos();
            CargarGrilla();
        }

        private void CargarCombos()
        {
            ddlCliente.DataSource = clienteNego.ListaClientes();
            ddlCliente.DataBind();
        }

        private void CargarGrilla()
        {
            gdvTurnos.DataSource = turnoNego.ListaTurnos();
            gdvTurnos.DataBind();
        }

        public void GuardarTurno()
        {
            TurnoDom turnoDom = new TurnoDom();

            turnoDom.TurnoFecha = Convert.ToDateTime(txtFechaTurno.Value);
            turnoDom.TurnoFechaDeRegistro = DateTime.Now;
            turnoDom.Motivo = txtMotivoTurno.Text;
            turnoDom.Descripcion = txtDescripcionTurno.Text;
            turnoDom.ClienteId = int.Parse(ddlCliente.SelectedValue);

            turnoNego.GuardarTurno(turnoDom);

            CargarGrilla();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarTurno();
        }


    }
}