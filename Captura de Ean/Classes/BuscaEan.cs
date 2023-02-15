using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captura_de_Ean.Classes
{
    internal class BuscaEan
    {
        public string ean { get; set; }
        public string nomeProduto {get; set; }
        public string url { get; set; }
        public string preco { get; set; }
        public string marketplace { get; set; }
    }
}
