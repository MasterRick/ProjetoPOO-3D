class Program
{

    static ConsoleKeyInfo opcao = new ConsoleKeyInfo();
    static BancoDeDados banco = new BancoDeDados();
    static void Main()
    {
        while (opcao.Key != ConsoleKey.Escape)
        {
            Console.Clear();
            Console.WriteLine("Bem vindo! A Concecionária de carros mais barata do Brasil!");
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Gerenciar carros");
            Console.WriteLine("2 - Gerenciar pessoas");
            Console.WriteLine("ESC - Sair");

            opcao = Console.ReadKey();

            if (opcao.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Adicionar carro");
                Console.WriteLine("2 - Remover carro");
                Console.WriteLine("3 - Listar Carros");
                Console.WriteLine("4 - Voltar");

                opcao = Console.ReadKey();

                switch (opcao.Key)
                {
                    case ConsoleKey.D1:
                        AdicionarCarroMenu();
                        break;
                    case ConsoleKey.D2:
                        RemoverCarroMenu();
                        break;
                    case ConsoleKey.D3:
                        banco.ListarCarros();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        break;
                }

            }
            else if (opcao.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Adicionar pessoa");
                Console.WriteLine("2 - Remover pessoa");
                Console.WriteLine("3 - Listar Pessoas");
                Console.WriteLine("4 - Voltar");

                opcao = Console.ReadKey();

                switch (opcao.Key)
                {
                    case ConsoleKey.D1:
                        //AdicionarPessoaMenu();
                        break;
                    case ConsoleKey.D2:
                        //RemoverPessoaMenu();
                        break;
                    case ConsoleKey.D3:
                        banco.ListarPessoas();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        break;
                }
            }
        }
    }

    static void AdicionarCarroMenu()
    {
        Console.Clear();
        Console.WriteLine("Digite o nome do carro:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a placa do carro:");
        string placa = Console.ReadLine();
        Console.WriteLine("Digite a cor do carro:");
        string cor = Console.ReadLine();
        Console.WriteLine("Digite a quilometragem do carro:");
        double km = double.Parse(Console.ReadLine());

        Carro carro = new Carro(nome, placa, cor, km);
        banco.SalvarCarro(carro);
    }

    static void RemoverCarroMenu()
    {
        Console.Clear();
        Console.WriteLine("Digite a placa do carro que deseja remover:");
        string placa = Console.ReadLine();
        Carro carro = banco.getCarros().Find(carro => carro.placa == placa);

        if (carro == null)
        {
            Console.WriteLine("Carro não encontrado");
            System.Threading.Thread.Sleep(1000);
        }
        else
        {
            banco.RemoverCarro(carro);
        }
    }
}



