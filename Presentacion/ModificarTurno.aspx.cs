using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
using System.Data;

namespace Presentacion
{
    public partial class ModificarTurno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            CargarCombos();
            int turnoId = int.Parse(Request["turnoId"].ToString());
            RecuperarTurno(turnoId);
           
        }

        private void CargarCombos()
        {
            ClienteNego clienteNego = new ClienteNego();

            ddlCliente.DataSource = clienteNego.LlenarCombo();
            ddlCliente.DataTextField = "datos";
            ddlCliente.DataValueField = "clienteId";
            ddlCliente.DataBind();
        }

        private void RecuperarTurno(int turnoId)
        {
            TurnoNego turnoNego = new TurnoNego();
            DataTable dt = new DataTable();

            dt = turnoNego.RecuperarTurno(turnoId);

            foreach (DataRow data in dt.Rows)
            {
                txtDescripcionTurno.Text = data["turnoDescripcion"].ToString();
                txtFechaTurno.Value = data["turnoFecha"].ToString();
                txtMotivoTurno.Text = data["turnoMotivo"].ToString();
                ddlCliente.SelectedValue = data["clienteId"].ToString();
                hdfTurnoId.Value = turnoId.ToString();
            }
        }

        public void Modificar()
        {
            TurnoDom turnoDom = new TurnoDom();
            TurnoNego turnoNego = new TurnoNego();

            turnoDom.Descripcion = txtDescripcionTurno.Text;
            turnoDom.Motivo = txtMotivoTurno.Text;
            turnoDom.TurnoFecha = Convert.ToDateTime(txtFechaTurno.Value);
            turnoDom.ClienteId = int.Parse(ddlCliente.SelectedValue);

            turnoNego.ModificarTurno(int.Parse(hdfTurnoId.Value), turnoDom);

            String pagina = "AltaTurno.aspx";
            Response.Redirect(pagina);
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }
    }
}