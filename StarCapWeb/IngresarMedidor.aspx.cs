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
    public partial class IngresarMedidor : System.Web.UI.Page
    {
        private IMedidorDAL medidoresDAL = new MedidorDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarMBtn_Click(object sender, EventArgs e)
        {
            //1. Obtener los datos del formulario

            string name = this.nombreTxt.Text.Trim();
            string serie = this.serieTxt.Text.Trim();
            

            Medidor medidor = new Medidor()
            {
                Nombre = name,
                Serie = serie
            };

            //3. Llammar al DAL
            medidoresDAL.AgregarMedidor(medidor);
            
            //4. Mostrar mensaje de exito
            this.mensajeslbl.Text = "Lectura Ingresada";
            Response.Redirect("VerMedidor.aspx");

        }
    }
}