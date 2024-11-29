using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento2
{
    public class Relatorio
    {
        private List<Times> Times { get; set; } = new List<Times>();



        public void AdicionarTime(string time)
        {
            var times = new Times()
            {
                 Nome = time,
            };

            Times.Add(times);
        }

        public int QtdTotal()
        {
            return Times.Count;
        }

       public IEnumerable<dynamic> ObterQtdPorTimes()
        {
            var timesAgrupados = Times.GroupBy(time => time.Nome ).Select(x => new 
            {
                Time = x.Key,
                Qtd = x.Count()
            });

            return timesAgrupados.ToList();
        }
    }

}
/*-Qual time os usuarios torçem. propriedade nova
        - a quantidade total de cada time
        - criar uma nova opção no menu dizendo a quantidade de times cadastrados.
        - pegar uma lista, agrupar essa lista e somar a quantidade times cadastrados.*/