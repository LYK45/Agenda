using Funcoes.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;


string nome = "";
string sobrenome = "";
string telefone = "";
List<Contatos> agenda = new List<Contatos>();

Console.WriteLine("Seja bem vindo à agenda de contatos!\n" + "Digite o que gostaria de fazer:");

// Criando um objeto Contato
Contatos contato1 = new Contatos("João", "da Silva", "(11) 91234-5678");


// Realiza o loop do menu
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar contato");
    Console.WriteLine("2 - Editar contato");
    Console.WriteLine("3 - Listar contatos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Por favor insira o primeiro nome do contato:");
            nome = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Por favor insira o sobrenome do contato:");
            sobrenome = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Por favor insira o sobrenome do contato:");
            telefone = Console.ReadLine() ?? string.Empty;

            // Criando um objeto Contato
            Contatos contato2 = new Contatos(nome, sobrenome, telefone);
            agenda.Add(contato2);
            break;

        case "2":
            contato1.Nome = "Maria";
            Console.WriteLine(contato1.Telefone);
            break;

        case "3":
            // Chamando o método
            contato1.ExibirInformacoes();
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

Console.WriteLine("O programa se encerrou");
