namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Sexo = c.Boolean(nullable: false),
                        Contato_Id = c.Int(),
                        Matricula_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contatoes", t => t.Contato_Id)
                .ForeignKey("dbo.Matriculas", t => t.Matricula_Id)
                .Index(t => t.Contato_Id)
                .Index(t => t.Matricula_Id);
            
            CreateTable(
                "dbo.Contatoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Telefone1 = c.String(),
                        Telefone2 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Matriculas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataMatricula = c.DateTime(nullable: false),
                        DataVencimento = c.DateTime(nullable: false),
                        Adimplente = c.Boolean(nullable: false),
                        Mensalidades_Id = c.Int(),
                        Pagamento_Id = c.Int(),
                        PlanoDesconto_Id = c.Int(),
                        PlanoFrequencia_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mensalidades", t => t.Mensalidades_Id)
                .ForeignKey("dbo.Pagamentoes", t => t.Pagamento_Id)
                .ForeignKey("dbo.PlanoDescontoes", t => t.PlanoDesconto_Id)
                .ForeignKey("dbo.PlanoFrequencias", t => t.PlanoFrequencia_Id)
                .Index(t => t.Mensalidades_Id)
                .Index(t => t.Pagamento_Id)
                .Index(t => t.PlanoDesconto_Id)
                .Index(t => t.PlanoFrequencia_Id);
            
            CreateTable(
                "dbo.Mensalidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MesReferencia = c.String(),
                        Pagamento_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pagamentoes", t => t.Pagamento_Id)
                .Index(t => t.Pagamento_Id);
            
            CreateTable(
                "dbo.Pagamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Single(nullable: false),
                        Data = c.DateTime(nullable: false),
                        FormaDePagamento = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlanoDescontoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Desconto = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlanoFrequencias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cheques",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Banco = c.String(),
                        DataVencimento = c.DateTime(nullable: false),
                        Numero = c.String(),
                        Valor = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Visitantes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        DataVisita = c.DateTime(nullable: false),
                        ProximoContato = c.DateTime(nullable: false),
                        ContatoId = c.Int(nullable: false),
                        Informacoes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contatoes", t => t.ContatoId, cascadeDelete: true)
                .Index(t => t.ContatoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visitantes", "ContatoId", "dbo.Contatoes");
            DropForeignKey("dbo.Alunoes", "Matricula_Id", "dbo.Matriculas");
            DropForeignKey("dbo.Matriculas", "PlanoFrequencia_Id", "dbo.PlanoFrequencias");
            DropForeignKey("dbo.Matriculas", "PlanoDesconto_Id", "dbo.PlanoDescontoes");
            DropForeignKey("dbo.Matriculas", "Pagamento_Id", "dbo.Pagamentoes");
            DropForeignKey("dbo.Matriculas", "Mensalidades_Id", "dbo.Mensalidades");
            DropForeignKey("dbo.Mensalidades", "Pagamento_Id", "dbo.Pagamentoes");
            DropForeignKey("dbo.Alunoes", "Contato_Id", "dbo.Contatoes");
            DropIndex("dbo.Visitantes", new[] { "ContatoId" });
            DropIndex("dbo.Mensalidades", new[] { "Pagamento_Id" });
            DropIndex("dbo.Matriculas", new[] { "PlanoFrequencia_Id" });
            DropIndex("dbo.Matriculas", new[] { "PlanoDesconto_Id" });
            DropIndex("dbo.Matriculas", new[] { "Pagamento_Id" });
            DropIndex("dbo.Matriculas", new[] { "Mensalidades_Id" });
            DropIndex("dbo.Alunoes", new[] { "Matricula_Id" });
            DropIndex("dbo.Alunoes", new[] { "Contato_Id" });
            DropTable("dbo.Visitantes");
            DropTable("dbo.Cheques");
            DropTable("dbo.PlanoFrequencias");
            DropTable("dbo.PlanoDescontoes");
            DropTable("dbo.Pagamentoes");
            DropTable("dbo.Mensalidades");
            DropTable("dbo.Matriculas");
            DropTable("dbo.Contatoes");
            DropTable("dbo.Alunoes");
        }
    }
}
