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

        protected void gdvTurnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btnEditar")
            {
                int turnoId = int.Parse(e.CommandArgument.ToString());
                String pagina = "ModificarTurno.aspx?turnoId=" + turnoId;
                Response.Redirect(pagina);
            }
        }
    }
}