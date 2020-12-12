namespace ControlCalidad.Servidor.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Color",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Codigo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Defecto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hora = c.DateTime(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Pie = c.Int(nullable: false),
                        EspecificacionDeDefecto_Id = c.Int(),
                        Horario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EspecificacionDeDefecto", t => t.EspecificacionDeDefecto_Id)
                .ForeignKey("dbo.Horario", t => t.Horario_Id)
                .Index(t => t.EspecificacionDeDefecto_Id)
                .Index(t => t.Horario_Id);
            
            CreateTable(
                "dbo.EspecificacionDeDefecto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoDefecto = c.Int(nullable: false),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Documento = c.Int(nullable: false),
                        Nombre = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Horario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Inicio = c.DateTime(nullable: false),
                        Fin = c.DateTime(nullable: false),
                        Turno_Id = c.Int(),
                        Op_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Turno", t => t.Turno_Id)
                .ForeignKey("dbo.Op", t => t.Op_Id)
                .Index(t => t.Turno_Id)
                .Index(t => t.Op_Id);
            
            CreateTable(
                "dbo.Par",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Calidad = c.Int(nullable: false),
                        Hora = c.DateTime(nullable: false),
                        Horario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Horario", t => t.Horario_Id)
                .Index(t => t.Horario_Id);
            
            CreateTable(
                "dbo.Turno",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Inicio = c.DateTime(nullable: false),
                        Fin = c.DateTime(nullable: false),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Linea",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Op",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        Estado = c.Int(nullable: false),
                        Color_Id = c.Int(),
                        Linea_Id = c.Int(),
                        Modelo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Color", t => t.Color_Id)
                .ForeignKey("dbo.Linea", t => t.Linea_Id)
                .ForeignKey("dbo.Modelo", t => t.Modelo_Id)
                .Index(t => t.Color_Id)
                .Index(t => t.Linea_Id)
                .Index(t => t.Modelo_Id);
            
            CreateTable(
                "dbo.Modelo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sku = c.String(),
                        Denominacion = c.String(),
                        Objetivo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Op", "Modelo_Id", "dbo.Modelo");
            DropForeignKey("dbo.Op", "Linea_Id", "dbo.Linea");
            DropForeignKey("dbo.Horario", "Op_Id", "dbo.Op");
            DropForeignKey("dbo.Op", "Color_Id", "dbo.Color");
            DropForeignKey("dbo.Horario", "Turno_Id", "dbo.Turno");
            DropForeignKey("dbo.Par", "Horario_Id", "dbo.Horario");
            DropForeignKey("dbo.Defecto", "Horario_Id", "dbo.Horario");
            DropForeignKey("dbo.Defecto", "EspecificacionDeDefecto_Id", "dbo.EspecificacionDeDefecto");
            DropIndex("dbo.Op", new[] { "Modelo_Id" });
            DropIndex("dbo.Op", new[] { "Linea_Id" });
            DropIndex("dbo.Op", new[] { "Color_Id" });
            DropIndex("dbo.Par", new[] { "Horario_Id" });
            DropIndex("dbo.Horario", new[] { "Op_Id" });
            DropIndex("dbo.Horario", new[] { "Turno_Id" });
            DropIndex("dbo.Defecto", new[] { "Horario_Id" });
            DropIndex("dbo.Defecto", new[] { "EspecificacionDeDefecto_Id" });
            DropTable("dbo.Modelo");
            DropTable("dbo.Op");
            DropTable("dbo.Linea");
            DropTable("dbo.Turno");
            DropTable("dbo.Par");
            DropTable("dbo.Horario");
            DropTable("dbo.Empleado");
            DropTable("dbo.EspecificacionDeDefecto");
            DropTable("dbo.Defecto");
            DropTable("dbo.Color");
        }
    }
}
