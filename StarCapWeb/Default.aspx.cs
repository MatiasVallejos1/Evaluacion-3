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
                this.medidorDdl.DataSource = medidor;
                this.medidorDdl.DataTextField = "Nombre";
                this.medidorDdl.DataValueField = "Serie";
                this.medidorDdl.DataBind();
            }

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1. obtener los datos del formulario
            Random rand = new Random();
            int num = rand.Next();
            DateTime fecha = this.fechaDdl.SelectedDate;
            int hora = int.Parse(this.horaTxt.Text.Trim());
            int minutos = int.Parse(this.minutosTxt.Text.Trim());
            int consumo = int.Parse(this.consumoTxt.Text.Trim());
            //esto obtine el valor del dropdown
            string medidortxt = this.medidorDdl.SelectedValue;
            //esto obtiene el texto
            //2. construir el objeto de tipo cliente
            List<Medidor> medidores = medidoresDAL.ObtenerMedidor();
            Medidor medidor = medidores.Find(b => b.Nombre.Equals(this.medidorDdl.SelectedItem.Value));

            Lectura lectura = new Lectura()
            {
                Id = num,
                SMedidor = medidor,
                Fecha = fecha,
                Hora = hora,
                Minutos = minutos,
                Consumo = consumo
            };

            //3. Llammar al DAL
            lecturasDAL.Agregar(lectura);
            //4. Mostrar mensaje de exito
            this.mensajeslbl.Text = "Lectura Ingresada";
            Response.Redirect("MostrarLecturas.aspx");

            

        }
    }
}