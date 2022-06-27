using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionModel
{
    public class Lectura
    {
        private string nombre, consumo;
        private DateTime fecha;

        private int medidor;
        private Medidor bebidaFavorita;

        public string NivelTxt
        {
            get
            {
                string nivelTxt = "";
                switch (medidor)
                {
                    case 1: nivelTxt = "M01";
                        break;
                    case 2: nivelTxt = "M02";
                        break;
                    case 3: nivelTxt = "M03";
                        break;
                }
                return nivelTxt;
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Medidor { get => medidor; set => medidor = value; }
    }
}
