
using SMP.Entidades;
using SMP.Servico;

bool sair = false;
List<Pedido> listaPedidos = new List<Pedido>();

do
{
    Console.WriteLine("\n++++++++++++++++++ SMP +++++++++++++++++++++");
    Console.WriteLine("Bem vindo ao SMP");
    Console.WriteLine("Escolha entre as opções a seguir: ");
    Console.WriteLine("\tc - Cliente");
    Console.WriteLine("\tv - Vendedor");


    var clientOrVendor = Console.ReadLine();
    if (clientOrVendor == "c")
    {
        var clienteServico = new ClienteServico();

        Console.WriteLine("Olá, ");
        Console.WriteLine("Digite seu CPF: ");
        var CPF = Console.ReadLine();

        var logado = clienteServico.LoginCliente(CPF);
        do
        {
            if (logado == null)
            {

                Console.WriteLine("Seu CPF não foi encontrado, por favor tente novamente!"); //TODO: Resolvido!
                Console.WriteLine("Digite seu CPF: ");
                CPF = Console.ReadLine();
                logado = clienteServico.LoginCliente(CPF);
            }


            if (logado is not null)
            {
                Console.WriteLine($"============== Olá {logado.Nome} !! ================");
                Console.WriteLine("O que deseja fazer agora?");
                Console.WriteLine("\tb - Compras");
                Console.WriteLine("\tp - Minhas compras");
                Console.WriteLine("\te- Sair");
            }

        } while (logado == null);
    }
    else if (clientOrVendor == "v")
    {
        Console.WriteLine("Olá Vendedor, ");
        Console.WriteLine("Digite sua matrícula: ");
        var vendorReg = Console.ReadLine();
        Console.WriteLine("==============================");
        Console.WriteLine("O que deseja exibir? ");
        Console.WriteLine("\tr - Relatório de Vendas");
        Console.WriteLine("\te - Sair");
    }
    var userOP = Console.ReadLine();
    switch (userOP)
    {
        case "b":
            MostrarPrateleiraVirtual();
            InteracaoCompra();
            break;
        case "p":
            Console.WriteLine("=============Pagamentos=============");
            break;
        case "r":
            Console.WriteLine("=================Relátorios de Vendas===================");
            break;
        case "e":
            sair = true;
            break;


    }
} while (!sair);


void MostrarPrateleiraVirtual()
{
    var venda = new VendaServico();
    var itens = venda.ObterItensPrateleira();

    Console.WriteLine("=========== Prateleira Virtual ===========");

    foreach (var item in itens)
    {
        Console.WriteLine($"=> {item.Id} - {item.Descricao} - {item.Valor.ToString("c")}");
    }
}

void InteracaoCompra()
{
    var sair = false;
    var venda = new VendaServico();
    do
    {
        Console.WriteLine("Deseja realizar qual operação?");
        Console.WriteLine("\tb - Comprar Item");

        if (venda.CarrinhoCompra.Count > 0)
        {
            Console.WriteLine("\tf - Fechar Compra");
            Console.WriteLine("\tv - Visualizar Carrinho de Compra");
        }

        Console.WriteLine("\te - Voltar Menu Anterior");
        var opacao = Console.ReadLine();

        switch (opacao)
        {
            case "b":
                Console.WriteLine("Digite o Id do Item");
                var opcaoItem = Console.ReadLine();
                var item = venda.ObterItemPorId(Guid.Parse(opcaoItem));

                if (item is null)
                {
                    Console.WriteLine("Item não encontrado!! Favor tentar novamnte!"); //TODO: Resolvido?
                    Console.WriteLine("Digite o Id do Item");
                    opcaoItem = Console.ReadLine();
                    item = venda.ObterItemPorId(Guid.Parse(opcaoItem));
                }
                else
                {
                    venda.AdicionarCarrinhoCompra(item);
                }
                break;
            case "v":
                Console.WriteLine($"==== ITENS CARRINHO DE COMPRA ({venda.CarrinhoCompra.Count})=======");
                foreach(var itemCompra in venda.CarrinhoCompra)
                {
                    Console.WriteLine($"=> {itemCompra.Id} - {itemCompra.Descricao} - {itemCompra.Valor.ToString("c")}");
                }
                break;
            case "f":
                Console.WriteLine("FECHAMENTO DE PEDIDO");
                var pedido = venda.FecharPedido();
                Console.WriteLine($"PEDIDO ID {pedido.Id} | Data: {pedido.Data} | Valor : {pedido.Valor}");
                listaPedidos.Add(pedido);

                //TODO: FLUCO DE PAGAMENTO
                break;
            default:
                sair = true;
                break;
        }
    }
    while (!sair);
}
