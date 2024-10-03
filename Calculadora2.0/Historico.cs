namespace Calculadora2._0;
    //Classe criada para mostrar o historico das operações
    public class Historico
    {
        //propriedades da classe Historico
        public DateTime Data { get; set; }
        public string Operacao { get; set; }
        public string Valores { get; set; }
        public float Resultado { get; set; }

        public override string ToString()
        {
            return $"{Data.ToString("yy-MM-dd")}, {Operacao} = {Resultado}, {Valores}";
        }
        //Data.ToString("yy-MM-dd") é para retornar a data do dia atual em formato de texto (string)
    }
