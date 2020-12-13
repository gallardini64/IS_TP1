namespace ControlCalidad.Servidor.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class horarioActual : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Op", "HorarioActual_Id", c => c.Int());
            CreateIndex("dbo.Op", "HorarioActual_Id");
            AddForeignKey("dbo.Op", "HorarioActual_Id", "dbo.Horario", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Op", "HorarioActual_Id", "dbo.Horario");
            DropIndex("dbo.Op", new[] { "HorarioActual_Id" });
            DropColumn("dbo.Op", "HorarioActual_Id");
        }
    }
}
