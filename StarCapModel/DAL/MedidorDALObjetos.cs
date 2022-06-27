using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionModel.DAL
{
    public class MedidorDALObjetos : IMedidorDAL
    {
        public List<Medidor> ObtenerMedidor()
        {
            return new List<Medidor>()
            {
                new Medidor()
                {
                    Nombre = "Medidor 1",
                    Serie = "M01"
                },
                new Medidor()
                {
                    Nombre = "Medidor 2",
                    Serie = "M02"
                },
                new Medidor()
                {
                    Nombre = "Medidor 3",
                    Serie = "M03"
                },
                new Medidor()
                {
                    Nombre = "Medidor 4",
                    Serie = "M04"
                }
            };
        }
    }
}
