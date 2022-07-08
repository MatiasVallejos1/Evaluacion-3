using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionModel.DAL
{
    public interface IMedidorDAL
    {
        List<Medidor> ObtenerMedidor();

        void AgregarMedidor(Medidor medidor);

        void Eliminar(string serie);

        void CargarLista();
        List<Medidor> Filtrar(Medidor smedidor);
    }
}
