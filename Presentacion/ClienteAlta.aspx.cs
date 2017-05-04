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
    public partial class ClienteAlta : System.Web.UI.Page
    {
        ClienteNego clienteNego = new ClienteNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            CargarGrilla();
        }

        private void CargarGrilla()
        {
            gdvClientes.DataSource = clienteNego.ListaClientes();
            gdvClientes.DataBind();
        }

        public void GuardarCliente()
        {
            ClienteDom clienteDom = new ClienteDom();

            clienteDom.Nombre = txtClienteNombre.Text;
            clienteDom.Apellido = txtClienteApellido.Text;
            clienteDom.Direccion = txtCleinteDireccion.Text;
            clienteDom.Telefono = txtClienteTelefono.Text;

            clienteNego.GuardarCliente(clienteDom);

            LimpiaControles();
            CargarGrilla();
        }

        private void LimpiaControles()
        {
            txtClienteNombre.Text = String.Empty;
            txtClienteApellido.Text = String.Empty;
            txtCleinteDireccion.Text = String.Empty;
            txtClienteTelefono.Text = String.Empty;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCliente();
        }

        protected void gdvClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btnEditar")
            {
                int clienteId = int.Parse(e.CommandArgument.ToString());
                String pagina = "ModificarCliente.aspx?clienteId=" + clienteId ;
                Response.Redirect(pagina);
            }
        }
    }
}