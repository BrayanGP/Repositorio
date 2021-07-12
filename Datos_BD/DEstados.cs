using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_BD
{
    public class DEstados: RepositorioBase<Estados>
    {
        public List<Estados> consultar()
        {
            return base.Consultar();
        }
    }
}
