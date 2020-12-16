using ControlCalidad.Servidor.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Datos
{
    public class ControlCalidadContext : DbContext
    {
        public ControlCalidadContext() : base("name=ControlCalidadConnection")
        {

        }

        private static ControlCalidadContext Instancia { get; set; } = null;

        public static ControlCalidadContext GetInstancia()
        {
            return Instancia ?? (Instancia = new ControlCalidadContext());
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
              .Conventions
              .Remove<PluralizingTableNameConvention>();

            modelBuilder
                .Conventions
                .Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder
                .Conventions
                .Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<DateTime>()
              .Configure(c => c.HasColumnType("datetime2"));


            base.OnModelCreating(modelBuilder);
        }

        DbSet<Op> OPs { get; set; }
        DbSet<Color> Colores { get; set; }
        DbSet<Defecto> Defectos { get; set; }
        DbSet<Empleado> Empleados { get; set; }
        DbSet<EspecificacionDeDefecto> EspecificacionDeDefectos { get; set; }
        DbSet<Horario> Horarios { get; set; }
        DbSet<Linea> Lineas { get; set; }
        DbSet<Modelo> Modelos { get; set; }
        DbSet<Par> Pares { get; set; }
        DbSet<Turno> Turnos { get; set; }





        

        
       
        
    }
}
