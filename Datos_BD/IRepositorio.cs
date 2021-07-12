using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Datos_BD
{
    interface IRepositorio<T> where T : class
    {
        List<T> Consultar(bool propLoading);
        T Consultar(Expression<Func<T, bool>> predicado, bool propLoading);
        T Consultar(Expression<Func<T, bool>> predicado, List<Expression<Func<T, bool>>> includes);
        void Crear(T entidad);
        void Actualizar(T enitidad);
        void Eliminar(T entidad);
        void Elimiar(Expression<Func<T, bool>> predicado);
    
    }
}
