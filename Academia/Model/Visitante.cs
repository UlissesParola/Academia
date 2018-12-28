using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Model
{
	class Visitante
	{
		public int Id { get; set; }
		[Required]
		public string Nome { get; set; } = "";
		public DateTime DataVisita { get; set; }
		public DateTime ProximoContato { get; set; }
		public int ContatoId { get; set; }
		public Contato Contato { get; set; }
		public String Informacoes { get; set; } = "";
	}
}
