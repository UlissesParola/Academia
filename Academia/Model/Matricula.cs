using System;

namespace Academia.Model
{
	public class Matricula
	{
		public int Id { get; set; }
		public DateTime DataMatricula { get; set; }
		public DateTime DataVencimento { get; set; }
		public bool Adimplente { get; set; }
		public PlanoDesconto PlanoDesconto { get; set; }
		public PlanoFrequencia PlanoFrequencia { get; set; }
		public Pagamento Pagamento { get; set; }
		public Mensalidade Mensalidades { get; set; }
	}
}
