using System;

namespace Academia.Model

{
	public class Cheque
	{
		public int Id { get; set; }
		public string Banco { get; set; }
		public DateTime DataVencimento { get; set; }
		public string Numero { get; set; }
		public float Valor { get; set; }
	}
}