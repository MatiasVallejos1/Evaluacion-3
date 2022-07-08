using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionModel.DAL
{
    public class MedidorDALObjetos : IMedidorDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();
        public void AgregarMedidor(Medidor medidor)
        {
            medidores.Add(medidor);
        }

        public void CargarLista()
        {
            medidores.Add(new Medidor
            {
                Nombre = "Medidor 01",
                Serie = "M01"
            });
            medidores.Add(new Medidor
            {
                Nombre = "Medidor 02",
                Serie = "M02"
            });
            medidores.Add(new Medidor
            {
                Nombre = "Medidor 03",
                Serie = "M03"
            });
        }

        public void Eliminar(string serie)
        {
            Medidor eliminado = medidores.Find(c => c.Serie.Equals(serie));
            medidores.Remove(eliminado);
        }

        public List<Medidor> Filtrar(Medidor smedidor)
        {
            return medidores.FindAll(c => c.Nombre.Equals(smedidor.Nombre));
        }

        public List<Medidor> ObtenerMedidor()
        {

            return medidores;
        }
    }
}
