using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Datos_BD
{
    public abstract class RepositorioBase<T> : IRepositorio<T> where T : class
    {
        IstitutoTich2Entities _intitutoRepos;

        public RepositorioBase()
        {
            _intitutoRepos = new IstitutoTich2Entities();
        }
        public void Actualizar(T enitidad)
        {
            _intitutoRepos.Entry(enitidad).State = EntityState.Modified;
            _intitutoRepos.SaveChanges();
        }

        public T Consultar(Expression<Func<T, bool>> predicado, bool propLoading=true)
        {
            _intitutoRepos.Configuration.ProxyCreationEnabled = propLoading;
            _intitutoRepos.Configuration.LazyLoadingEnabled = propLoading;
            return _intitutoRepos.Set<T>().FirstOrDefault<T>(predicado);
            
        }

        public T Consultar(Expression<Func<T, bool>> predicado, List<Expression<Func<T, bool>>> includes)
        {
            throw new NotImplementedException();
        }


        public List<T> Consultar(bool propLoading=true)
        {
            _intitutoRepos.Configuration.ProxyCreationEnabled = propLoading;
            _intitutoRepos.Configuration.LazyLoadingEnabled = propLoading;
            return (List<T>)_intitutoRepos.Set<T>().ToList();
        }

        public void Crear(T entidad)
        {
            _intitutoRepos.Set<T>().Add(entidad);
            _intitutoRepos.SaveChanges();

        }

        public void Elimiar(Expression<Func<T, bool>> predicado)
        {
            _intitutoRepos.Entry(predicado).State = EntityState.Deleted;
            _intitutoRepos.SaveChanges();
        }

        public void Eliminar(T entidad)
        {
            throw new NotImplementedException();
        }
    }
}
