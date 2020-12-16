namespace ControlCalidad.Servidor.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fechaFinNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Op", "FechaFin", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Op", "FechaFin", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
    }
}
