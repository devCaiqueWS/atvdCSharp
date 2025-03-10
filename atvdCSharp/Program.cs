using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu RM: ");
        string rm = Console.ReadLine();

        Console.Write("Digite seu e-mail FIAP: ");
        string email = Console.ReadLine();


        if (ValidarUsuario(email, rm))
        {
            Console.WriteLine("Usuário validado com sucesso!");

            Console.Write("Digite seu ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            Console.Write("Digite seu tempo de contribuição em anos: ");
            int tempoContribuicao = int.Parse(Console.ReadLine());

            CalcularTempoAposentadoria(anoNascimento, tempoContribuicao);
        }
        else
        {
            Console.WriteLine("Usuário ou senha inválidos. Tente novamente.");
        }
    }

        static bool ValidarUsuario(string email, string rm)
        {
            if (rm.Length == 6 && email == $"rm{rm}@fiap.com.br")
            {
                return true;
            }
            return false;
        }

        static void CalcularTempoAposentadoria(int anoNascimento, int tempoContribuicao)
        {
            int idadeAposentadoria = 65;
            int tempoMinimoContribuicao = 15;

            int anoAtual = DateTime.Now.Year;
            int idadeAtual = anoAtual - anoNascimento;
            int anosRestantes = idadeAposentadoria - idadeAtual;
            int tempoRestante = tempoMinimoContribuicao - tempoContribuicao;

            if (tempoContribuicao >= tempoMinimoContribuicao || idadeAtual >= idadeAposentadoria)
            {
            Console.WriteLine("Você já pode se aposentar!");
            }
            else
            {
            Console.WriteLine($"Você não tem tempo de contribuição ou idade o suficiente para se aposentar. Faltam {anosRestantes} anos ou {tempoRestante} anos de contribuição para se aposentar.");
            }
        }
    }
