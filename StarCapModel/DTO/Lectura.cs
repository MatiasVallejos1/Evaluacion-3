using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionModel
{
    public class Lectura
    {
        private int id;
        private DateTime fecha;

        private int consumo, hora, minutos;

        private Medidor sMedidor;

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Consumo { get => consumo; set => consumo = value; }
        public int Hora { get => hora; set => hora = value; }
        public int Minutos { get => minutos; set => minutos = value; }
        public Medidor SMedidor { get => sMedidor; set => sMedidor = value; }
    }
}
