using SeguroMelApp.CalculoSeguro.Base;

var carro = new Carro("EJE2F34", "Ford", "Mustang", 90);
carro.InformarDadosDaApolice("Mel", 350000, DateTime.Parse("2024-01-01"));
carro.CalcularSeguro();
carro.Contratar();
carro.ExibirContrato();

var pessoa = new Pessoa("EJE2F34", "Ford");
pessoa.InformarDadosDaApolice("Mel", DateTime.Parse("1995-10-09"));
pessoa.CalcularSeguro();
pessoa.Contratar();
