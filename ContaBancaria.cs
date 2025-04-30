
public class ContaBancaria
{
	public int _id;
	public string agencia;
	public string Nconta;
	public string nomePro;
	public double saldo;

	public ContaBancaria()
	{
		
	}
	public ContaBancaria(int id)
	{
		this._id = id;
	}

	public void Depositar(double valor)
	{
		if (valor >= 0) {
			saldo += valor;
		}
		else
		{
			throw new Exception("Valor inválido!"); // Lançando uma exceção
		}
	}

	public void Depositar()
	{

	}
	public void Sacar(double valor)
	{
		if (valor > 0 && valor <= saldo)
		{
			saldo -= valor;
		}
		else
		{
			throw new Exception("Valor inválido!");
		}
	}
}

 