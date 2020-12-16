namespace ControlCalidad.Servidor.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncioDeSesion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Defecto", "Empleado_Id", c => c.Int());
            AddColumn("dbo.Empleado", "Usuario", c => c.String());
            AddColumn("dbo.Empleado", "Contrasenia", c => c.String());
            AddColumn("dbo.Empleado", "Rol", c => c.Int(nullable: false));
            AddColumn("dbo.Op", "Empleado_Id", c => c.Int());
            AddColumn("dbo.Par", "Empleado_Id", c => c.Int());
            CreateIndex("dbo.Defecto", "Empleado_Id");
            CreateIndex("dbo.Op", "Empleado_Id");
            CreateIndex("dbo.Par", "Empleado_Id");
            AddForeignKey("dbo.Defecto", "Empleado_Id", "dbo.Empleado", "Id");
            AddForeignKey("dbo.Op", "Empleado_Id", "dbo.Empleado", "Id");
            AddForeignKey("dbo.Par", "Empleado_Id", "dbo.Empleado", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Par", "Empleado_Id", "dbo.Empleado");
            DropForeignKey("dbo.Op", "Empleado_Id", "dbo.Empleado");
            DropForeignKey("dbo.Defecto", "Empleado_Id", "dbo.Empleado");
            DropIndex("dbo.Par", new[] { "Empleado_Id" });
            DropIndex("dbo.Op", new[] { "Empleado_Id" });
            DropIndex("dbo.Defecto", new[] { "Empleado_Id" });
            DropColumn("dbo.Par", "Empleado_Id");
            DropColumn("dbo.Op", "Empleado_Id");
            DropColumn("dbo.Empleado", "Rol");
            DropColumn("dbo.Empleado", "Contrasenia");
            DropColumn("dbo.Empleado", "Usuario");
            DropColumn("dbo.Defecto", "Empleado_Id");
        }
    }
}
