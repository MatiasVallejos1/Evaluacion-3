using EvaluacionModel;
using EvaluacionModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvaluacionWeb
{
    public partial class Default : System.Web.UI.Page
    {
        private ILecturaDAL lecturasDAL = new LecturaDALObjetos();
        private IMedidorDAL medidoresDAL = new MedidorDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {
            //este metodo se ejecuta cuando se carga el form y puede ser:
            // Cuando es una peticion GET (!PostBack)
            // Cuando es una peticion POST (PostBack)
            if (!IsPostBack)
            {
                //aqui cargo la lista del dropdown
                List<Medidor> medidor = medidoresDAL.ObtenerMedidor();
                this.bebidaDdl.DataSource = medidor;
                this.bebidaDdl.DataTextField = "Nombre";
                this.bebidaDdl.DataValueField = "Serie";
                this.bebidaDdl.DataBind();
            }

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1. obtener los datos del formulario
            string nombre = this.nombreTxt.Text.Trim();
            string rut = this.rutTxt.Text.Trim();
            //esto obtine el valor del dropdown
            string bebidaValor = this.bebidaDdl.SelectedValue;
            //esto obtiene el texto
            string bebidaTexto = this.bebidaDdl.SelectedItem.Text;
            int nivel = Convert.ToInt32(this.nivelRbl.SelectedItem.Value);
            //2. construir el objeto de tipo cliente
            List<Medidor> medidores = medidoresDAL.ObtenerMedidor();
            Medidor medidor = medidores.Find(b => b.Serie == this.bebidaDdl.SelectedItem.Value);

            Lectura lectura = new Lectura()
            {
                Nombre = nombre,
                Medidor = nivel,
            };

            //3. Llammar al DAL
            lecturasDAL.Agregar(lectura);
            //4. Mostrar mensaje de exito
            this.mensajeslbl.Text = "Cliente Ingresado";
            Response.Redirect("VerCliente.aspx");

        }
    }
}