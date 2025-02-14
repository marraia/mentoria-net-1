using SeguroMelApp.CalculoSeguro;
using SeguroMelApp.CalculoSeguro.Base;

Console.WriteLine("============Simule uma cotação!===============");
Console.WriteLine("\ta - Carros");
Console.WriteLine("\tb - Motos");
Console.WriteLine("\tc - Caminhões");
Console.WriteLine("\td - Nauticos");
Console.WriteLine("\te - Pessoa");
Console.WriteLine("\tf - Celulares");
Console.WriteLine("\tg - Joias");

var simulacaoCotacao = Console.ReadLine();
 CalculoApolice apolice = new CalculoApolice();
switch (simulacaoCotacao)
{
    case "a":
        apolice = AutoPerguntas();

        break;
    case "b":
        apolice = AutoPerguntas();
        break;
    case "c":
        apolice = CaminhaoPerguntas();
        break;
    case "d":
        apolice = NauticoPerguntas();
        break;
    case "e":
        apolice = PessoaPerguntas();
        break;
        case "f":
        apolice = CelularPerguntas();
        break;
    case "g":
        apolice = JoiasPerguntas();
        break;
}

Simular(apolice.Apolice, apolice.NomeSegurado, apolice.ValorDoBem, apolice.DataBasica);

 CalculoApolice AutoPerguntas()
{

    if(simulacaoCotacao == "a")
    {
        Console.WriteLine("Placa do Carro:");
        var placaCarro = Console.ReadLine();
        Console.WriteLine("Marca do Carro:");
        var marcaCarro = Console.ReadLine();
        Console.WriteLine("Modelo do carro:");
        var modeloCarro = Console.ReadLine();
        Console.WriteLine("Kilometros Rodados");
        var kmRodados = Convert.ToDecimal(Console.ReadLine());
        var carro = new Carro(modeloCarro, marcaCarro, placaCarro, kmRodados);

        Console.WriteLine("Nome:");
        var nomeSegurado = Console.ReadLine();
        Console.WriteLine("Valor do Carro:");
        var valorDoBem = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Data da compra do  Carro (00/00/0000):");
        var dataBásica = Convert.ToDateTime(Console.ReadLine());
        return new CalculoApolice()
        {
            Apolice = carro,
            NomeSegurado = nomeSegurado,
            ValorDoBem = valorDoBem,
            DataBasica = dataBásica
        };
    }
    else if (simulacaoCotacao == "b")
    {
        Console.WriteLine("Modelo: ");
        var modeloMoto = Console.ReadLine();
        Console.WriteLine("Placa : ");
        var PlacaMoto = Console.ReadLine();
        Console.WriteLine("Ano:");
        var anoMoto = Convert.ToInt32(Console.ReadLine());
        var moto = new Moto(modeloMoto, PlacaMoto, anoMoto);

        Console.WriteLine("Nome:");
        var nomeSegurado = Console.ReadLine();
        Console.WriteLine("Valor da Moto:");
        var valorDoBem = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Data da compra (00/00/0000):");
        var dataBásica = Convert.ToDateTime(Console.ReadLine());
        return new CalculoApolice()
        {
            Apolice = moto,
            NomeSegurado = nomeSegurado,
            ValorDoBem = valorDoBem,
            DataBasica = dataBásica
        };
    }
    return default;
}


CalculoApolice CaminhaoPerguntas()
{
    Console.WriteLine("Sexo do Motorista (F ou M):");
    var sexo = Console.ReadLine();
    Console.WriteLine("Itinerario :");
    var itinerario = Console.ReadLine();
    Console.WriteLine("Tipo de carga: ");
    var tipoDeCarga = Console.ReadLine();
    var caminhao = new Caminhao(sexo, itinerario, tipoDeCarga);

    Console.WriteLine("Nome:");
    var nomeSegurado = Console.ReadLine();
    Console.WriteLine("Valor total do Caminhão:");
    var valorDoBem = Convert.ToDecimal(Console.ReadLine());
    return new CalculoApolice()
    {
        Apolice = caminhao,
        NomeSegurado = nomeSegurado,
        ValorDoBem = valorDoBem,
        DataBasica = null
    };

}

CalculoApolice NauticoPerguntas()
{
    Console.WriteLine("Numero de Registro Naval:");
    var registroNaval = Console.ReadLine();
    Console.WriteLine("Tipo de embarcação:");
    var tipoEmbarcacao = Console.ReadLine();
    Console.WriteLine("Ano de Fabricação: ");
    var anoConstrucao = Convert.ToInt32(Console.ReadLine());
    var nautico = new Nautico(registroNaval,tipoEmbarcacao,anoConstrucao);

    Console.WriteLine("Nome:");
    var nomeSegurado = Console.ReadLine();
    Console.WriteLine("Valor total do Bem:");
    var valorDoBem = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Data da compra (00/00/0000):");
    var dataBásica = Convert.ToDateTime(Console.ReadLine());
    return new CalculoApolice()
    {
        Apolice = nautico,
        NomeSegurado = nomeSegurado,
        ValorDoBem = valorDoBem,
        DataBasica = dataBásica
    };
}

CalculoApolice PessoaPerguntas()
{
    Console.WriteLine("Gênero:");
    var sexo = Console.ReadLine();
    Console.WriteLine("Profissão::");
    var profissao = Console.ReadLine();
    var pessoa = new Pessoa(sexo,profissao);

    Console.WriteLine("Nome:");
    var nomeSegurado = Console.ReadLine();
    Console.WriteLine("Valor padrão do Bem: 100.000,00");
    var valorDoBem = 100000;
    Console.WriteLine("Data de Nascimento (00/00/0000):");
    var dataBásica = Convert.ToDateTime(Console.ReadLine());
    return new CalculoApolice()
    {
        Apolice = pessoa,
        NomeSegurado = nomeSegurado,
        ValorDoBem = valorDoBem,
        DataBasica = dataBásica
    };

}

CalculoApolice CelularPerguntas()
{
    Console.WriteLine("Marca do Celular:");
    var marcaCelular = Console.ReadLine();
    Console.WriteLine("Modelo:");
    var modeloCelular = Console.ReadLine();
    Console.WriteLine("Ano do Celular");
    var anoCel = Convert.ToInt32(Console.ReadLine());
    var celular = new Celular(marcaCelular,modeloCelular,anoCel);

    Console.WriteLine("Nome:");
    var nomeSegurado = Console.ReadLine();
    Console.WriteLine("Valor do bem:");
    var valorDoBem = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Data de Nascimento (00/00/0000):");
    var dataBásica = Convert.ToDateTime(Console.ReadLine());
    celular.ExibirSeguro();
    return new CalculoApolice()
    {
        Apolice = celular,
        NomeSegurado = nomeSegurado,
        ValorDoBem = valorDoBem,
        DataBasica = dataBásica
    };
    
}

CalculoApolice JoiasPerguntas()
{
    Console.WriteLine("Certificado de autenticidade");
    var autenticidade = Console.ReadLine();
   
    
    var joias = new Joias(autenticidade);

    Console.WriteLine("Nome:");
    var nomeSegurado = Console.ReadLine();
    Console.WriteLine("Valor do bem:");
    var valorDoBem = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Data de Nascimento (00/00/0000):");
    var dataBásica = Convert.ToDateTime(Console.ReadLine());
    joias.ExibirSeguro();
    return new CalculoApolice()
    {
        Apolice = joias,
        NomeSegurado = nomeSegurado,
        ValorDoBem = valorDoBem,
        DataBasica = dataBásica
    };
}

void Simular(ApoliceBase apolice, string NomeSegurado, decimal valorDoBem, DateTime? dataBásica = null)
{
    apolice.InformarDadosDaApolice(NomeSegurado, valorDoBem, dataBásica);
    apolice.CalcularSeguro();
    apolice.ExibirValor();
    apolice.Contratar();
}

public class CalculoApolice
{
    public ApoliceBase Apolice { get; set; }
    public string NomeSegurado { get; set; }
    public decimal ValorDoBem { get; set; }
    public DateTime? DataBasica { get; set; }
}

