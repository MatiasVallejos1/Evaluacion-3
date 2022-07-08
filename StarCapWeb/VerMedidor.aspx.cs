using EvaluacionModel;
using EvaluacionModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarCapWeb
{
    public partial class VerMedidor : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrilla();

                //aqui cargo la lista del dropdown
                List<Medidor> medidor = medidorDAL.ObtenerMedidor();
                this.medidorDdl.DataSource = medidor;
                this.medidorDdl.DataTextField = "Nombre";
                this.medidorDdl.DataValueField = "Serie";
                this.medidorDdl.DataBind();
            }
        }
        private void cargarGrilla()
        {
            List<Medidor> medidor = medidorDAL.ObtenerMedidor();
            this.grillaMedidor.DataSource = medidor;
            this.grillaMedidor.DataBind();
        }

        private void cargarGrilla(List<Medidor> filtrada)
        {
            List<Medidor> medidor = medidorDAL.ObtenerMedidor();
            this.grillaMedidor.DataSource = filtrada;
            this.grillaMedidor.DataBind();
        }
        protected void grillaMedidor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminarM")
            {
                //signfica que el usuario apreto el boton eliminar
                //por ende, tengo que eliminar el cliente
                string serie = Convert.ToString(e.CommandArgument);
                medidorDAL.Eliminar(serie);
                cargarGrilla();
            }
        }
        protected void medidorDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.medidorDdl.SelectedItem != null)
            {
                List<Medidor> medidores = medidorDAL.ObtenerMedidor();
                Medidor medidor = medidores.Find(b => b.Nombre.Equals(this.medidorDdl.SelectedItem.Value));
                //filtrar por nivel
                List<Medidor> filtrada = medidorDAL.Filtrar(medidor);
                cargarGrilla(filtrada);
            }
        }
    }
}