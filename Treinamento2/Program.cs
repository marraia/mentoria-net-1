
/*1- Escrever um algoritmo gerenciamento de usuários! 
Especificações:
Classe de usuários: CPF - Nome - Email - Data Nascimento -  DataCadastro

Funcionalidades:
    - Cadastrar um novo usuários na lista v
    - Visualizar todos os usuários cadastrados v
        - Mostrar a idade do usuários v 
        - Quais anos do nascimento são números pares v
    - Editar os dados do usuários
        - Pesquisar o usuários pelo CPF
        - Alterar os dados do usuários ************* (Remove) (Add)

        - Qual time os usuarios torçem. propriedade nova
        - a quantidade total de cada time
        - criar uma nova opção no menu dizendo a quantidade de times cadastrados.
        - pega ruma lista, agrupar essa lista e somar a quantidade times cadastrados.

- Laços
- Condicionais
- Lista


- Um algoritmo sempre é um passo a passo (receita de bolo)...

*/

using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using Treinamento2;
var usuario = new Usuario();


bool sair = false;
Console.WriteLine("=====================Bem vindo ao sistema de Cadastramento!=====================");
Console.WriteLine("Nos diga se é sua 1º vez aqui:");
Console.WriteLine("\tn - Primeira vez");
Console.WriteLine("\tc - Já possuo cadastro");
var novoUsuario = Console.ReadLine();

if (novoUsuario == "n")
{
   
        CadastroOP();
        OpçoesVoltar();


    do
    {
        OpcoesCadastro();
    } while (!sair);
        
   
}/*else if( novoUsuario == "c")
{
    if(cpf == null)
    {
        Console.WriteLine("Desclpe,seu cpf não foi encontrado, tente novamente!");
        Console.WriteLine("Digite seu cpf: ");
        var cpf = Console.ReadLine();
    }

    //if()
    {
        Console.WriteLine("Digite seu cpf: ");
        var cpf = Console.ReadLine();
        Console.WriteLine($"Bem vindo de volta {cpf}, ");
        Console.WriteLine("Suas opções: ");
        Console.WriteLine("\tu - Visualizar usuarios cadastrados");
        Console.WriteLine("\tc - Editar meu cadastro");
        Console.WriteLine("\te - Sair");
    }

   
}*/

void CadastroOP()
{
    //Nome
    var nomeCompleto = String.Empty;
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
        
    }while (cpf.Length > 11);
    

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

    usuario.AdicionarUsuario(cpf, nomeCompleto, email, datanasc);
    Console.WriteLine("Cadastro realizado com sucesso!");

    

}
void OpçoesVoltar()
{
    Console.WriteLine(" A seguir suas opções: ");
    Console.WriteLine("\tu - Visualizar usuarios cadastrados");
    
    Console.WriteLine("\ta - Cadastrar novamente");
    Console.WriteLine("\te - Sair");
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
        case "e":
            sair = true;
            break;
        
    }
}

 