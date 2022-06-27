using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionModel

{
    public class Medidor
    {
        private string serie;
        private string nombre;

        public string Serie { get => serie; set => serie = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
