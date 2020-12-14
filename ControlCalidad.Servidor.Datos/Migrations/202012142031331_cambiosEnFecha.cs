namespace ControlCalidad.Servidor.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiosEnFecha : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Defecto", "Hora", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Horario", "Inicio", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Horario", "Fin", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Par", "Hora", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Turno", "Inicio", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Turno", "Fin", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Op", "FechaInicio", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Op", "FechaFin", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Op", "FechaFin", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Op", "FechaInicio", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Turno", "Fin", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Turno", "Inicio", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Par", "Hora", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Horario", "Fin", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Horario", "Inicio", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Defecto", "Hora", c => c.DateTime(nullable: false));
        }
    }
}
