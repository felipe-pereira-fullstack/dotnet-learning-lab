public class Emprestimo
{
	public int cd_emprestimo { get; private set; }
	public DateTime dt_emprestimo { get; private set; }
	public DateTime dt_prevista_devolucao { get; private set; }
	public DateTime ? dt_devolucao { get; private set; }

	public int cd_livro { get; private set; }
	public Livro livro { get; private set; }
	public int cd_pessoa { get; private set; }
	public Pessoa pessoa { get; private set; }

}