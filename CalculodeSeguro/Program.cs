using CalculodeSeguro.Dominio;
using CalculodeSeguro.Repositorio;
using CalculodeSeguro.Servicos;

var clienteId = 0;
Console.WriteLine("----------Seguros Resguardos----------");
Console.WriteLine("Peça um orçamento!");
Console.WriteLine("\t1 - Fazer um orçamento");
Console.WriteLine("\t2 - Já sou cliente!");
Console.WriteLine("\t3 - Sair");
Console.WriteLine("---------------------------------------");
Console.WriteLine("Digite a opção desejada:");
var opcao = Convert.ToInt32(Console.ReadLine());
 if(opcao == 1)
{
    Console.WriteLine("Otimo! Vamos começar! Abaixo nos diga suas informações:");
    Console.WriteLine("Nome Completo:");
    var NomeCompleto = Console.ReadLine();
    Console.WriteLine("Cpf:");
    var CPF = Console.ReadLine();
    Console.WriteLine("Email:");
    var Email = Console.ReadLine();
    Console.WriteLine("Telefone:");
    var Telefone = Console.ReadLine();
    Console.WriteLine("Endereço:");
    var Endereco = Console.ReadLine();
    Console.WriteLine("Deseja Confirmar suas informações? (S/N)");
    var confirmacao = Console.ReadLine().ToUpper();
    if (confirmacao != "S")
    {
        Console.WriteLine("Por favor, digite novamente suas informações:");
        Console.WriteLine("Nome Completo:");
        NomeCompleto = Console.ReadLine();
        Console.WriteLine("Cpf:");
        CPF = Console.ReadLine();
        Console.WriteLine("Email:");
        Email = Console.ReadLine();
        Console.WriteLine("Telefone:");
        Telefone = Console.ReadLine();
        Console.WriteLine("Endereço:");
        Endereco = Console.ReadLine();
    }
    
    else
    {
        Console.WriteLine("Obrigado! Agora vamos para a próxima etapa!");
        var cliente = new Cliente(NomeCompleto, CPF, Email, Telefone, Endereco);
        var clienteServico = new ClienteServico();
        clienteId = clienteServico.CriarCliente(cliente);
    }

}
else if (opcao == 2)
{
    Console.WriteLine("Otimo! Vamos começar! Abaixo nos diga suas informações:");
    Console.WriteLine("Cpf:");
    var CpfCadastrado = Console.ReadLine();
    // Update the instantiation of Cliente to match the constructor signature  
    var clienteCadastrado = new Cliente("",CpfCadastrado, "", "", "");
    var clienteServico = new ClienteServico();
    clienteServico.SelecionarClientePorCpf(clienteCadastrado);

}

else if (opcao == 3)
{
    Console.WriteLine("Obrigado por nos visitar!");
    Environment.Exit(0);
}
Console.WriteLine("Qual tipo de seguro deseja fazer?");
Console.WriteLine("\t1 - Seguro de Automoveis");
Console.WriteLine("\t2 - Seguro Nautico");
Console.WriteLine("\t3 - Seguro de Pessoas");
Console.WriteLine("\t4 - Seguro de bens móveis (eletronicos)");
Console.WriteLine("Digite a opção desejada:");
var tipoSeguro = Convert.ToInt32(Console.ReadLine());

switch(tipoSeguro)
{
    case 1:
        Console.WriteLine("Seguro de Automoveis");
        Console.WriteLine("Digite a placa do veiculo:");
        var placa = Console.ReadLine();
        Console.WriteLine("Digite o modelo do veiculo:");
        var modelo = Console.ReadLine();
        Console.WriteLine("Digite o ano do veiculo:");
        var ano = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o chassi do veiculo:");
        var chassi = Console.ReadLine();
        Console.WriteLine("Digite o valor do veiculo:");
        var valor = Convert.ToDecimal(Console.ReadLine());

        var automovel = new Automotor( placa, modelo, ano, chassi, valor);
        var services = new AutomotorServicos();

        services.CriarAutomotor(automovel,clienteId,tipoSeguro);
        
        break;
    case 2:
        Console.WriteLine("Seguro Nautico");
        Console.WriteLine("Digite o numero de registro naval:");
        var registroNaval = Console.ReadLine();
        Console.WriteLine("Digite o tipo de embarcação:");
        var tipoEmbarcacao = Console.ReadLine();
        Console.WriteLine("Digite o ano de fabricação:");
        var anoFabricacao = Convert.ToInt32(Console.ReadLine());
        break;
    case 3:
        Console.WriteLine("Seguro de Pessoas");
        Console.WriteLine("Digite o genero:");
        var genero = Console.ReadLine();
        Console.WriteLine("Digite a profissão:");
        var profissao = Console.ReadLine();
        break;
    case 4:
        Console.WriteLine("Seguro de bens móveis");
        Console.WriteLine("Digite o tipo de bem:");
        var tipoBem = Console.ReadLine();
        Console.WriteLine("Digite o valor do bem:");
        var valorBem = Convert.ToDecimal(Console.ReadLine());
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
        /*asdasdasdasdasd*/
}
Console.WriteLine("Sue orçamento ficou em xx,xx!");
Console.WriteLine("Deseja contratar o seguro? (S/N)");
var contratar = Console.ReadLine();
if (contratar == "S")
{
    var apolice = new Apolice(clienteId);
    Console.WriteLine("Parabéns! Seu seguro foi contratado com sucesso!");
    Console.WriteLine($"Sua apolice de seguro de numero: {apolice.NumeroApolice}, funciona a partir do dia {apolice.DataInicio} até o dia {apolice.DataFim} no valor de xx,xx");
}
else
{
    Console.WriteLine("Obrigado por nos visitar!");
    Environment.Exit(0);
}
Console.WriteLine("Deseja fazer mais um orçamento? (S/N)");
var novoOrcamento = Console.ReadLine();

if (novoOrcamento == "S")
{
    Console.WriteLine("Qual tipo de seguro deseja fazer?");
    Console.WriteLine("\t1 - Seguro de Automoveis");
    Console.WriteLine("\t2 - Seguro Nautico");
    Console.WriteLine("\t3 - Seguro de Pessoas");
    Console.WriteLine("\t4 - Seguro de bens móveis (eletronicos)");
    Console.WriteLine("Digite a opção desejada:");
    var NovoSeguro = Convert.ToInt32(Console.ReadLine());

    switch (NovoSeguro)
    {
        case 1:
            Console.WriteLine("Seguro de Automoveis");
            Console.WriteLine("Digite a marca do veiculo:");
            var marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo do veiculo:");
            var modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano do veiculo:");
            var ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a placa do veiculo:");
            var placa = Console.ReadLine();
            Console.WriteLine("Digite o chassi do veiculo:");
            var chassi = Console.ReadLine();
            Console.WriteLine("Digite o valor do veiculo:");
            var valor = Convert.ToDecimal(Console.ReadLine());
            break;
        case 2:
            Console.WriteLine("Seguro Nautico");
            Console.WriteLine("Digite o numero de registro naval:");
            var registroNaval = Console.ReadLine();
            Console.WriteLine("Digite o tipo de embarcação:");
            var tipoEmbarcacao = Console.ReadLine();
            Console.WriteLine("Digite o ano de fabricação:");
            var anoFabricacao = Convert.ToInt32(Console.ReadLine());
            break;
        case 3:
            Console.WriteLine("Seguro de Pessoas");
            Console.WriteLine("Digite o genero:");
            var genero = Console.ReadLine();
            Console.WriteLine("Digite a profissão:");
            var profissao = Console.ReadLine();
            break;
        case 4:
            Console.WriteLine("Seguro de bens móveis");
            Console.WriteLine("Digite o tipo de bem:");
            var tipoBem = Console.ReadLine();
            Console.WriteLine("Digite o valor do bem:");
            var valorBem = Convert.ToDecimal(Console.ReadLine());
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;

    }
}
else
{
    Console.WriteLine("Obrigado por nos visitar!");
    Environment.Exit(0);
}
