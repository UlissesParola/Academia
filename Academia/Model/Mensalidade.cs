namespace Academia.Model
{
	public class Mensalidade
	{
		public int Id { get; set; }
		public string MesReferencia { get; set; }
		public Pagamento Pagamento { get; set; }
	}
}