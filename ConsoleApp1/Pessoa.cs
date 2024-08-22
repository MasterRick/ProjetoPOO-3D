class Pessoa
{
    public string nome;
    public int idade;
    private string cpf;

    public Pessoa(string nome, int idade, string cpf)
    {
        this.nome = nome;
        this.idade = idade;
        SetCpf(cpf);
    }

    public void SetCpf(string cpf)
    {
        if (cpf.Length == 14)
        {
            for (int i = 0; i < cpf.Length; i++)
            {
                try
                {
                    int numero;
                    if (cpf[i] != '.' && cpf[i] != '-')
                    {
                        numero = int.Parse(cpf[i].ToString());
                    }

                }
                catch (System.Exception)
                {
                    return;
                }
            }
            this.cpf = cpf;
        }
        else
        {
            return;
        }


    }

    public string GetCpf()
    {
        return cpf;
    }

    public bool isValid()
    {
        if (cpf == null || nome.Length < 5)
        {
            return false;
        }
        return true;
    }

}