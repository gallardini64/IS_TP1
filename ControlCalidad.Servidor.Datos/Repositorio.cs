using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ControlCalidad.Servidor.Dominio;

namespace ControlCalidad.Servidor.Datos
{
    public class Repositorio<T> : IDisposable
         where T : EntityBase
    {
        
        private readonly ControlCalidadContext _context;
        private Repositorio()
        {
            if (_context == null)
            {
                _context = ControlCalidadContext.GetInstancia();
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

        public void Update(T entity)
        {
            var DbSet = _context.Set<T>();
            DbSet.Attach(entity);
            var entry = _context.Entry(entity);
            entry.State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public int Next()
        {
            return GetAll() == null ? 1 : GetAll().Count() + 1;
        }

        public void Dispose()
        {
            _context.Dispose();
        }


    }
}
