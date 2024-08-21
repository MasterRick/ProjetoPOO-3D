



/*
double Soma(double numero1, double numero2)
{
    return numero1 + numero2;
}
double Subtracao(double numero1, double numero2)
{
    return numero1 - numero2;
}
double Multiplicacao(double numero1, double numero2)
{
    return numero1 * numero2;
}



double Divisao(double numero1, double numero2)
{
    return numero1 / numero2;
}



bool e_par(double num)
{
    if (num % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

double mult2(double num, double num2)
{
    double resultado = 0;
    for (int i = 0; i < num2; i++)
    {
        resultado += num;
    }
    return resultado;
}

int tamanhoDaFrase(string palavra1, string palavra2)
{
    return palavra1.Length + palavra2.Length;
}

double media(double[] notas)
{
    double somaDasNotas = 0;
    for (int i = 0; i < notas.Length; i++)
    {
        somaDasNotas += notas[i];
    }
    return somaDasNotas / notas.Length;
}

double[] resolveEquacao2Grau(double a, double b, double c)
{
    double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;
    double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;

    return [x1, x2];
}





Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(tamanhoDaFrase("ola", "mundo"));
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine(media([10, 5, 8, 7, 5]));




Console.WriteLine(mult2(2, 4));
Console.WriteLine(Divisao(10, 2));

















void Operacoes(double numero1, double numero2, char operacao)
{
    if (operacao == '+')
    {
        Soma(numero1, numero2);
    }
    else if (operacao == '-')
    {
        Subtracao(numero1, numero2);
    }
    else if (operacao == '*')
    {
        Multiplicacao(numero1, numero2);
    }
    else if (operacao == '/')
    {
        Divisao(numero1, numero2);
    }
    else
    {
        Console.WriteLine("Operação inválida");
    }
}

Operacoes(5, 9, '+');
Operacoes(5, 90, '-');
Operacoes(50, 9, '/');
Operacoes(5, 19, '*');


*/


class Program
{
    static void Main()
    {
        ConsoleKeyInfo opcao = new ConsoleKeyInfo();
        BancoDeDados banco = new BancoDeDados();

        while (opcao.Key != ConsoleKey.D3)
        {
            Console.Clear();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Bem vindo! A Concecionária de carros mais barata do Brasil!");
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Cadastrar um carro");
            Console.WriteLine("2 - Listar carros");
            Console.WriteLine("3 - Sair");

            opcao = Console.ReadKey();

            if (opcao.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine("Digite o nome do carro:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a placa do carro:");
                string placa = Console.ReadLine();
                Console.WriteLine("Digite a cor do carro:");
                string cor = Console.ReadLine();
                Console.WriteLine("Digite a quilometragem rodada do carro:");
                double kmrodados = double.Parse(Console.ReadLine());

                Carro carro = new Carro(nome, placa, cor, kmrodados);
                banco.SalvarCarro(carro);
            }
            else if (opcao.Key == ConsoleKey.D2)
            {
                banco.ListarCarros();
                System.Threading.Thread.Sleep(10000);
            }
        }
    }
}



