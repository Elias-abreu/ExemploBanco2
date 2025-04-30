
try
{
	ContaBancaria c2 = new ContaBancaria();
	c2.Depositar(10);
	c2.Depositar();
	Console.WriteLine("Valor depositado!");
}
catch(Exception ex)
{
	Console.WriteLine(ex.Message);
}
finally
{
	Console.WriteLine("Vai passar aqui de qualquer forma!");
}




/*Segundo commit*/
List<ContaBancaria> lista = new List<ContaBancaria> ();
//tete
int cont = 1;
while (true)
{
	Console.WriteLine("Digite 1 para cadastrar um nova conta e 2 para listar todas");
	int ops = Convert.ToInt32(Console.ReadLine());

	if(ops == 1)
	{
		ContaBancaria c1 = new ContaBancaria(cont);
		cont++;
		Console.WriteLine("Digite o valor do ID");
		c1._id = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Digite a agência");
		c1.agencia = Console.ReadLine();
		Console.WriteLine("Digite o N da conta");
		c1.Nconta = Console.ReadLine();
		Console.WriteLine("Digite o proprietário");
		c1.nomePro = Console.ReadLine();
		c1.saldo = 0;
		lista.Add(c1); //Adicionar o elemento na lista
	}
	else if( ops == 2)
	{
		foreach(ContaBancaria c in lista)
		{
			Console.WriteLine("ID "+c._id+" agência "+c.agencia+ " Número "+c.Nconta+" Saldo"+c.saldo);
		}
	}
	else
	{
		break;
	}
}


/*
ContaBancaria c1 = new ContaBancaria();
Console.WriteLine("Digite o valor do ID");
c1.id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a agência");
c1.agencia = Console.ReadLine();
Console.WriteLine("Digite o N da conta");
c1.Nconta = Console.ReadLine();
Console.WriteLine("Digite o proprietário");
c1.nomePro = Console.ReadLine();
c1.saldo = 0;

List<ContaBancaria> lContas = new List<ContaBancaria>();
lContas.Add(c1);

foreach(ContaBancaria c in lContas)
{
	Console.WriteLine(c.id+" - "+c.nomePro+" - "+c.saldo);
}

bool teste = true;
while (teste)
{
	Console.WriteLine("Digite 1 para depositar, 2 para sacar e 3 para sair!");
	int opcao = Convert.ToInt32(Console.ReadLine());

	if (opcao == 1)
	{
		Console.WriteLine("Digite o valor a ser depositado");
		double v = Convert.ToDouble(Console.ReadLine());
		c1.Depositar(v);
	}
	else if (opcao == 2)
	{
		Console.WriteLine("Digite o valor a ser sacado");
		double valor = Convert.ToDouble(Console.ReadLine());
		c1.Sacar(valor);
	}
	else
	{
		teste = false;
	}
}
Console.WriteLine(c1.saldo);
*/
