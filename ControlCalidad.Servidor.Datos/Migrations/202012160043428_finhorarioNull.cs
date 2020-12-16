namespace ControlCalidad.Servidor.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finhorarioNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Horario", "Fin", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Horario", "Fin", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
    }
}
