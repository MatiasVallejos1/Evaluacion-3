using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionModel.DAL
{
    public class LecturaDALObjetos : ILecturaDAL
    {
        private static List<Lectura> lecturas = new List<Lectura>();
        public void Agregar(Lectura lectura)
        {
            lecturas.Add(lectura);
        }

        public void Eliminar(string nombre)
        {
            Lectura eliminado = lecturas.Find(c => c.Nombre == nombre);
            lecturas.Remove(eliminado);
        }

        public List<Lectura> Filtrar(int medidor)
        {
            return lecturas.FindAll(c => c.Medidor == medidor);
        }

        public List<Lectura> Obtener()
        {
            return lecturas;
        }
    }
}
