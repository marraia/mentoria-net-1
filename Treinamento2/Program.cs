
/*1- Escrever um algoritmo gerenciamento de usuários! 
Especificações:
Classe de usuários: CPF - Nome - Email - Data Nascimento -  DataCadastro

Funcionalidades:
    - Cadastrar um novo usuários na lista v
    - Visualizar todos os usuários cadastrados v
        - Mostrar a idade do usuários v 
        - Quais anos do nascimento são números pares v
    - Editar os dados do usuários v
        - Pesquisar o usuários pelo CPF v
        - Alterar os dados do usuários ************* (Remove) (Add)v

        - Qual time os usuarios torçem. propriedade nova
        - a quantidade total de cada time
        - criar uma nova opção no menu dizendo a quantidade de times cadastrados.
        - pegar uma lista, agrupar essa lista e somar a quantidade times cadastrados.

- Laços
- Condicionais
- Lista


- Um algoritmo sempre é um passo a passo (receita de bolo)...

*/


using System.Collections.Immutable;
using System.Threading.Tasks.Sources;
using Treinamento2;
var usuario = new Usuario();
var futebol = new Futebol();

bool sair = false;
Console.WriteLine("=====================Bem vindo ao sistema de Cadastramento!=====================");
Console.WriteLine("Vamos começar? ");
Console.WriteLine("\tn - Fazer Cadastro");
Console.WriteLine("\te - Sair");
var novoUsuario = Console.ReadLine();

if (novoUsuario == "n")
{
        CadastroOP();
        OpçoesVoltar();
        
    do
    {
        OpcoesCadastro();
    } while (!sair);


}else if (novoUsuario != "n")
{
    do
    {
        Console.WriteLine("Tente novamente :");
        novoUsuario = Console.ReadLine();
    } while (novoUsuario != "n");
    

}

void CadastroOP()
{
    //Nome
    var nomeCompleto = string.Empty;
    do
    {
        Console.WriteLine("Vamos fazer seu cadastro: ");
        Console.WriteLine("Nos diga seu nome completo: ");
        nomeCompleto = Console.ReadLine();

        if (nomeCompleto.Length > 100)
        {
            Console.WriteLine("Para o nome é permitido até 100 caracteres");
        }

    } while (nomeCompleto.Length > 100);

    //Cpf
    var cpf = string.Empty;
    do
    {

        Console.WriteLine($"Muito bem, {nomeCompleto}, agora nos diga seu CPF (sem hífen): ");
        cpf = Console.ReadLine();
        if (cpf.Length > 11)
        {
            Console.WriteLine("Cpf Inválido, tente novamente:");
        }

    } while (cpf.Length > 11);


    //Email
    var email = string.Empty;
    var validateEmail = 1;
    do
    {
        Console.WriteLine("Email: ");
        email = Console.ReadLine();
        validateEmail = email.IndexOf('@');

        if (validateEmail < 0)
        {
            Console.WriteLine("Email inválido! Tente novamente");
        }

    } while (validateEmail <= 0);

    //data de nascimento
    Console.WriteLine("Diga sua data de Nascimento (utilize o formato 00/00/0000): ");
    DateTime datanasc = Convert.ToDateTime(Console.ReadLine());




    usuario.AdicionarUsuario(cpf, nomeCompleto, email, datanasc);
    Console.WriteLine("Cadastro realizado com sucesso!");
}

void OpcoesCadastro()
{
    var userOP = Console.ReadLine();
    switch (userOP)
    {
        case "u":
            var exibir = usuario.ExibirUsuarios();

            Console.WriteLine("===============Usuarios Cadastrados=============\n");
            Console.WriteLine(exibir);
            OpçoesVoltar();
            break;
        case "a":
            CadastroOP();
            OpçoesVoltar();
            break;

        case "c":
            Console.WriteLine("Digite o cpf que deseja editar:");
            var cpf = Console.ReadLine();
            var clienteEdicao = usuario.LoginClient(cpf);
            Console.WriteLine(clienteEdicao);
            EditarCadastro(cpf);
            var clienteEditado = usuario.LoginClient(cpf);
            Console.WriteLine(clienteEditado);
            OpçoesVoltar();
            break;

        case "e":
            sair = true;
            break;
        case "f":
            
            TimeEscolhido();
            OpçoesVoltar();
            break;
        

    }
}

void TimeEscolhido()
{
    Console.WriteLine("+++++++++++++ TIMES DE FUTEBOL +++++++++++");
    Console.WriteLine("Nos diga qual é o seu time de futebol do Rio:");
    Console.WriteLine("escolhe e digite entre as opções: Vasco, Flamengo, Botafogo , Fluminense ou nenhum.");
    Console.WriteLine("Escolha um time: v (Vasco), f (Flamengo), b (Botafogo), t (Fluminense):");
    var timeEscolhido = Console.ReadLine();
    futebol.AdicionarVoto(timeEscolhido);
    futebol.ExibirResultados();
}

        


void EditarCadastro(string cpf)
{

    //Nome
    var nomeCompleto = String.Empty;
    do
    {
        Console.WriteLine("Vamos refazer seu cadastro: ");
        Console.WriteLine("Nos diga um nome completo: ");
         nomeCompleto = Console.ReadLine();

        if (nomeCompleto.Length > 100)
        {
            Console.WriteLine("Para o nome é permitido até 100 caracteres");
        }

    } while (nomeCompleto.Length > 100);
   
    //Email
    var email = string.Empty;
    var validateEmail = 1;
    do
    {
        Console.WriteLine("Email: ");
        email = Console.ReadLine();
        validateEmail = email.IndexOf('@');

        if (validateEmail < 0)
        {
            Console.WriteLine("Email inválido! Tente novamente");
        }

    } while (validateEmail <= 0);
    
    //data de nascimento
    Console.WriteLine("E por ultimo, sua data de nascimento (utilize o formato 00/00/00): ");
    var datanasc = Convert.ToDateTime(Console.ReadLine());

    usuario.EditarUsuario(cpf, nomeCompleto, email, datanasc);
    Console.WriteLine("Cadastro realizado com sucesso!");
}
void OpçoesVoltar()
{
    Console.WriteLine(" A seguir suas opções: ");
    Console.WriteLine("\tu - Visualizar usuarios cadastrados");
    Console.WriteLine("\tc - Editar Dados");
    Console.WriteLine("\ta - Cadastrar novamente");
    Console.WriteLine("\tf - Seguir para os times de futebol");
    Console.WriteLine("\te - Sair");
}



/*-Qual time os usuarios torçem. propriedade nova
        - a quantidade total de cada time
        - criar uma nova opção no menu dizendo a quantidade de times cadastrados.
        - pega ruma lista, agrupar essa lista e somar a quantidade times cadastrados.*/