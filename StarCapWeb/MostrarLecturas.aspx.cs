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
    public partial class MostrarLecturas : System.Web.UI.Page
    {
        private ILecturaDAL lecturaDAL = new LecturaDALObjetos();
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrilla();
                
                //aqui cargo la lista del dropdown
                List<Medidor> medidor = medidorDAL.ObtenerMedidor();
                this.lecturaDdl.DataSource = medidor;
                this.lecturaDdl.DataTextField = "Nombre";
                this.lecturaDdl.DataValueField = "Serie";
                this.lecturaDdl.DataBind();
            }
        }

        private void cargarGrilla()
        {
            List<Lectura> lecturas = lecturaDAL.Obtener();
            this.grillaLecturas.DataSource = lecturas;
            this.grillaLecturas.DataBind();
        }

        private void cargarGrilla(List<Lectura> filtrada)
        {
            List<Lectura> lecturas = lecturaDAL.Obtener();
            this.grillaLecturas.DataSource = filtrada;
            this.grillaLecturas.DataBind();
        }
        protected void grillaLectura_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "eliminar")
            {
                //signfica que el usuario apreto el boton eliminar
                //por ende, tengo que eliminar el cliente
                int serie = Convert.ToInt32(e.CommandArgument);
                lecturaDAL.Eliminar(serie);
                cargarGrilla();
            }
        }
        protected void lecturaDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lecturaDdl.SelectedItem != null)
            {
                List<Medidor> medidores = medidorDAL.ObtenerMedidor();
                Medidor medidor = medidores.Find(b => b.Nombre.Equals(this.lecturaDdl.SelectedItem.Value));
                //filtrar por nivel
                List<Lectura> filtrada = lecturaDAL.Filtrar(medidor);
                cargarGrilla(filtrada);
            }
        }
    }
}