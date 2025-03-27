

using System.Numerics;
using System;

namespace CalculodeSeguro.Dominio
{
    public class Automotor
    {
        public int Id { get; private set; }
        public string Placa { get; private set; }
        public string Modelo { get; private set; }
        public int Ano { get; private set; }
        public string Chassi { get; private set; }
        public decimal ValorDoBem { get; private set; }


        public Automotor(string placa, string modelo, int ano, string chassi, decimal valorDoBem)
        {
            Placa = placa;
            Modelo = modelo;
            Ano = ano;
            Chassi = chassi;
            ValorDoBem = valorDoBem;
        }

        public void AtualizarId(int id)
        {
            Id = id;
        }



    }

}