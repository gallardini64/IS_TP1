using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ControlCalidad.Servidor.Dominio;

namespace ControlCalidad.Servidor.Datos
{
    public class Repositorio<T> : IDisposable
         where T : EntityBase
    {
        private readonly ControlCalidadContext _context;
        protected Repositorio()
        {
            if (_context == null)
            {
                _context = new ControlCalidadContext();
            }
        }

        private static Repositorio<T> Instancia { get; set; } = null;

        public static Repositorio<T> GetInstancia()
        {
            return Instancia ?? (Instancia = new Repositorio<T>());
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }
        public IEnumerable<T> GetFiltered(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter);
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public int Next()
        {
            if (GetAll() == null) return 0;
            else return GetAll().Count();
        }

        public void Dispose()
        {
            _context.Dispose();
        }





    }
}
