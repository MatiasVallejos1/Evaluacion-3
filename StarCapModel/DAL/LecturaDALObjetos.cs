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

        public void Eliminar(int id)
        {
            Lectura eliminado = lecturas.Find(c => c.Id.Equals(id));
            lecturas.Remove(eliminado);
        }

        public List<Lectura> Filtrar(Medidor medidor)
        {
            return lecturas.FindAll(c => c.SMedidor.Nombre.Equals(medidor.Nombre));
        }

        public List<Lectura> Obtener()
        {
            return lecturas;
        }
    }
}
