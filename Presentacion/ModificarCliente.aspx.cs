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
    public partial class ModificarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           int clienteId = int.Parse(Request["clienteId"].ToString());
            LlenarCampos(clienteId);
        }

        private void LlenarCampos(int clienteId)
        {
            ClienteNego clienteNego = new ClienteNego();
            DataTable dt = new DataTable();
            dt = clienteNego.LlenarGrilla(clienteId);
            foreach (DataRow data in dt.Rows)
            {
                txtClienteNombre.Text = data["clienteNombre"].ToString();
                txtClienteApellido.Text = data["clienteApellido"].ToString();
                txtCleinteDireccion.Text = data["clienteDireccion"].ToString();
                txtClienteTelefono.Text = data["clienteTelefono"].ToString();
                hdfClienteId.Value = clienteId.ToString();
            }
        }

        public void Modificar()
        {
            ClienteNego clienteNego = new ClienteNego();
            ClienteDom clienteDom = new ClienteDom();
            clienteDom.Nombre = txtClienteNombre.Text;
            clienteDom.Apellido = txtClienteApellido.Text;
            clienteDom.Direccion = txtCleinteDireccion.Text;
            clienteDom.Telefono = txtClienteTelefono.Text;


        }
        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }
    }
}