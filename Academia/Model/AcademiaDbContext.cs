using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Model
{
	class AcademiaDbContext : DbContext
	{
		public DbSet<Aluno> Alunos { get; set; }
		public DbSet<Cheque> Cheques { get; set; }
		public DbSet<Matricula> Matriculas { get; set; }
		public DbSet<Mensalidade> Mensalidades { get; set; }
		public DbSet<Pagamento> Pagamentos { get; set; }
		public DbSet<PlanoDesconto> PlanosDesconto { get; set; }
		public DbSet<PlanoFrequencia> PlanosFrequencia { get; set; }
		public DbSet<Visitante> Visitantes { get; set; }
		public DbSet<Contato> Contatos { get; set; }


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{

		}
	}
}
