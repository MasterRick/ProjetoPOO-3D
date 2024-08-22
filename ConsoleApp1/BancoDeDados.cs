class BancoDeDados
{
    List<Carro> carros = new List<Carro>();
    List<Pessoa> pessoas = new List<Pessoa>();

    public BancoDeDados()
    {
        Carro carro = new Carro("Fusca", "ABC-1234", "Azul", 1000);
        SalvarCarro(carro);
        carro = new Carro("Gol", "DEF-5678", "Preto", 2000);
        SalvarCarro(carro);
        carro = new Carro("Uno", "GHI-9101", "Branco", 3000);
        SalvarCarro(carro);
        Pessoa pessoa = new Pessoa("Richardson", 27, "00.999.888-00");
        SalvarPessoa(pessoa);
        pessoa = new Pessoa("Maria", 25, "111.999.888-000");
        SalvarPessoa(pessoa);
        pessoa = new Pessoa("Maria", 55, "988.999.888-00");
        SalvarPessoa(pessoa);
    }
    public void SalvarCarro(Carro carro)
    {
        carros.Add(carro);
    }

    public void SalvarPessoa(Pessoa pessoa)
    {
        if (pessoa.isValid() == true)
        {
            pessoas.Add(pessoa);
        }
    }

    public void RemoverCarro(Carro carro)
    {
        carros.Remove(carro);
    }

    public void ListarCarros()
    {
        Console.Clear();
        for (int i = 0; i < carros.Count; i++)
        {
            Console.WriteLine("Carro " + (i + 1));
            Console.WriteLine("Nome: " + carros[i].nome);
            Console.WriteLine("Placa: " + carros[i].placa);
            Console.WriteLine("Cor: " + carros[i].cor);
            Console.WriteLine("Km rodados: " + carros[i].GetKmRodados());
            Console.WriteLine();
        }
    }

    public void ListarPessoas()
    {
        Console.Clear();
        for (int i = 0; i < pessoas.Count; i++)
        {
            Console.WriteLine("Pessoa " + (i + 1));
            Console.WriteLine("Nome: " + pessoas[i].nome);
            Console.WriteLine("Idade: " + pessoas[i].idade);
            Console.WriteLine("CPF: " + pessoas[i].GetCpf());
            Console.WriteLine();
        }
    }
    public List<Carro> getCarros()
    {
        return carros;
    }
}