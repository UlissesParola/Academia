using System;

namespace Academia.Model
{
	public class Pagamento
	{
		public int Id { get; set; }
		public float Valor { get; set; }
		public DateTime Data { get; set; }
		public string FormaDePagamento { get; set; }
	}
}
