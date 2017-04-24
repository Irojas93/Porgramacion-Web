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
            int turnoId = int.Parse(Request["turnoId"].ToString());
            RecuperarTurno(turnoId);
        }

        private void RecuperarTurno(int turnoId)
        {
            TurnoNego turnoNego = new TurnoNego();
            DataTable dt = new DataTable();
            turnoNego.RecuperarTurno(turnoId);
            foreach (DataRow data in dt.Rows)
            {
             txtDescripcionTurno.Text = data["turnoDescripcion"].ToString();
             
            }
        }
    }
}