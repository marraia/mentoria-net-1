
bool sair = false;

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
        Console.WriteLine("Olá, ");
        Console.WriteLine("Digite seu CPF: ");
        var CPF = Console.ReadLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine("O que deseja fazr agora?");
        Console.WriteLine("\tl - Compras");
        Console.WriteLine("\tp - Métodos de pagamentos");
        Console.WriteLine("\ts- Sair");


    }
    else if (clientOrVendor == "v")
    {
        Console.WriteLine("Olá Vendedor, ");
        Console.WriteLine("Digite sua matrícula: ");
        var vendorReg = Console.ReadLine();
        Console.WriteLine("==============================");
        Console.WriteLine("O que deseja exibir? ");
        Console.WriteLine("\tr - Relatório de Vendas");
        Console.WriteLine("\ts - Sair");
    }
    var userOP = Console.ReadLine();
    switch (userOP)
    {
        case "l":
            Console.WriteLine("===========Loja===========");
            break;
        case "p":
            Console.WriteLine("=============Pagamentos=============");
            break;
        case "r":
            Console.WriteLine("=================Relátorios de Vendas===================");
            break;
        case "s":
            sair = true;
            break;


    }
} while (!sair);