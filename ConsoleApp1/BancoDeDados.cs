class BancoDeDados
{
    List<Carro> carros = new List<Carro>();
    public void SalvarCarro(Carro carro)
    {
        carros.Add(carro);
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
}