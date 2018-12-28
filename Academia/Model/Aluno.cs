using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Model
{
	class Aluno
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Cpf { get; set; }
		public Contato Contato { get; set; }
		public DateTime DataNascimento { get; set; }
		public Matricula Matricula { get; set; }
		public bool Sexo { get; set; }
		//public Avaliacao Avalicao { get; set; }
	}
}
