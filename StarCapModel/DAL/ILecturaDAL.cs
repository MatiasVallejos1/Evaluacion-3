using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionModel.DAL
{
    public interface ILecturaDAL
    {
        List<Lectura> Obtener();
        void Agregar(Lectura cliente);

        void Eliminar(string rut);

        List<Lectura> Filtrar(int nivel);

    }
}
