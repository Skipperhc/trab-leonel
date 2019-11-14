using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho2Bim
{
    
    public partial class printVendedor : Form
    {
        public printVendedor()
        {
            InitializeComponent();
            preencher();
        }
        List<NF> listNf = new List<NF>();

        public void preencher()
        {
            dgvVendedor.DataSource = null;
            dgvVendedor.DataSource = listNf;
        }
    }
}
