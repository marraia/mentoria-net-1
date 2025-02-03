using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosApp.Models
{
    internal class Nautico: SeguroBase
    {
        public string RegistroNaval {  get; set; }
        public string TipoEmbarcacao { get; set; }
        public int AnoConstrucao { get; set; }
    }
}
