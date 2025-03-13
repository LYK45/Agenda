using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

bool continuarCadastro = true;

while (continuarCadastro)
{
    // Cria os modelos de hóspedes e cadastra na lista de hóspedes
    List<Pessoa> hospedes = new List<Pessoa>();

    Console.WriteLine("Quantos hóspedes você deseja cadastrar?");
    int quantidadeHospedes = int.Parse(Console.ReadLine());

    for (int i = 1; i <= quantidadeHospedes; i++)
    {
        Console.WriteLine($"Digite o nome do hóspede {i}:");
        string nomeHospede = Console.ReadLine();
        Pessoa hospede = new Pessoa(nome: nomeHospede);
        hospedes.Add(hospede);
    }

    // Cria a suíte
    Console.WriteLine("Digite o tipo da suíte:");
    string tipoSuite = Console.ReadLine();
    Console.WriteLine("Digite a capacidade da suíte:");
    int capacidadeSuite = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor da diária da suíte:");
    decimal valorDiariaSuite = decimal.Parse(Console.ReadLine());

    Suite suite = new Suite(tipoSuite: tipoSuite, capacidade: capacidadeSuite, valorDiaria: valorDiariaSuite);

    // Cria uma nova reserva, passando a suíte e os hóspedes
    Console.WriteLine("Digite a quantidade de dias reservados:");
    int diasReservados = int.Parse(Console.ReadLine());

    Reserva reserva = new Reserva(diasReservados: diasReservados);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

    // Exibe a quantidade de hóspedes e o valor da diária
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

    // Pergunta se deseja fazer um novo cadastro
    Console.WriteLine("Deseja fazer um novo cadastro? (s/n)");
    string resposta = Console.ReadLine().ToLower();
    continuarCadastro = resposta == "s";
}
