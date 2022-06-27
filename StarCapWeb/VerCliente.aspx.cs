using EvaluacionModel;
using EvaluacionModel.DAL;
using EvaluacionWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvaluacionWeb
{
    public partial class VerCliente : System.Web.UI.Page
    {
        private ILecturaDAL lecturaDAL = new LecturaDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrilla();
            }
        }

        private void cargarGrilla()
        {
            List<Lectura> lecturas = lecturaDAL.Obtener();
            this.grillaClientes.DataSource = lecturas;
            this.grillaClientes.DataBind();
        }

        private void cargarGrilla(List<Lectura> filtrada)
        {
            List<Lectura> lecturas = lecturaDAL.Obtener();
            this.grillaClientes.DataSource = filtrada;
            this.grillaClientes.DataBind();
        }
        protected void grillaClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "eliminar")
            {
                //signfica que el usuario apreto el boton eliminar
                //por ende, tengo que eliminar el cliente
                string rut = Convert.ToString(e.CommandArgument);
                lecturaDAL.Eliminar(rut);
                cargarGrilla();
            }
        }

        protected void nivelDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.nivelDdl.SelectedItem != null)
            {
                int nivel = Convert.ToInt32(this.nivelDdl.SelectedItem.Value);
                //filtrar por nivel
                List<Lectura> filtrada = lecturaDAL.Filtrar(nivel);
                cargarGrilla(filtrada);
            }
        }
    }
}