
class Carro
{
    public string nome;
    public string placa;
    public string cor;
    private double kmrodados;

    //MÉTODO CONSTRUTOR
    public Carro(string nome, string placa, string cor, double kmrodados)
    {
        this.nome = nome;
        this.placa = placa;


        this.kmrodados = kmrodados;
    }

    public double GetKmRodados()
    {
        return kmrodados;
    }
}
