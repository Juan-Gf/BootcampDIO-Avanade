using EstacionamentoClasses.Common.Models;

List<Carro> estacionamento = new List<Carro>();
MenuEstacionamento newMenu = new MenuEstacionamento();
int valorFixo;
int valorPorHora;
Boolean exibeMenu = true;

Console.WriteLine($"Bem vindo ao sistema de estacionamento!");
Console.Write("Informe o valor fixo para estacionar: R$");
valorFixo = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor por hora adcionais: R$");
valorPorHora = Convert.ToInt32(Console.ReadLine());

while (exibeMenu)
{
    Console.Clear();
    Console.WriteLine("Menu de opçôes");
    Console.WriteLine("1 - Cadastrar veiculo");
    Console.WriteLine("2 - Listar veiculos e vagas");
    Console.WriteLine("3 - Remover veiculo");
    Console.WriteLine("4 - Encerrar");

    Console.Write("Digite a opção desejada: ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            Console.Clear();
            Console.WriteLine("Cadastro de Veiculo");
            newMenu.CadastroDeCarro(estacionamento);
            break;

        case "2":

            Console.Clear();
            Console.WriteLine("Lista de Veiculos");
            newMenu.ListaDeCarro(estacionamento);
            Console.WriteLine($"Temos {estacionamento.Count} carro no estacionamento");
            break;

        case "3":
            Console.Clear();
            Console.WriteLine("Remover de Veiculo");
            break;

        default:
            exibeMenu = false;
            break;

    }
    
    Console.Write("Pressione ENTER para continuar");
    Console.ReadLine();

    //newMenu.ListaDeCarro(estacionamento, cont);
    // Console.Write("Digite o modelo do carro: ");
    // carro1.modeloCarro = Console.ReadLine();

    // Console.Write("Digite o placa do carro: ");
    // carro1.placaCarro = Console.ReadLine();

    // estacionamento[0] = carro1;

    //estacionamento[0].Apresentar();

}
//carro1.Apresentar();


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

