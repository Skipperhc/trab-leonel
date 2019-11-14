using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2Bim
{
    class NF
    {
        NF nf = new NF();
        public int numNf { get; set; }
        public string nomeProd { get; set; }
        public int qntVendida { get; set; }
        public double precoUnit { get; set; }
        public double totalItem { get; set; }
        public string vendedor { get; set; }
        public string cliente { get; set; }
        public string fornecedor { get; set; }
        public string regiao { get; set; }

        List<NF> listNf = new List<NF>();

        public List<NF> lista()
        {
            return listNf;
        }

        public void salvarlist()
        {
            listNf.Add(nf);
        }
    }
}
