using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho2Bim {

    public partial class printVendedor : Form {
        public printVendedor() {
            InitializeComponent();
            preencher();
        }

        public void preencher() {
            double totalAmericanas = 0, totalColombo = 0, totalCasas_Bahias = 0, totalCondor = 0, totalCarrefour = 0, totalHavan = 0, totalExtra = 0, totalAliExpress = 0, totalAmazon = 0;
            NF nf = new NF();
            List<NF> listaNF = nf.lista();

            foreach (var vendedor in listaNF) {

                if (vendedor.vendedor == "Americanas") {
                    totalAmericanas = totalAmericanas + vendedor.totalItem;
                } else if (vendedor.vendedor == "Colombo") {
                    totalColombo = totalColombo + vendedor.totalItem;
                } else if (vendedor.vendedor == "Casas Bahias") {
                    totalCasas_Bahias = totalCasas_Bahias + vendedor.totalItem;
                } else if (vendedor.vendedor == "Condor") {
                    totalCondor = totalCondor + vendedor.totalItem;
                } else if (vendedor.vendedor == "Carrefour") {
                    totalCarrefour = totalCarrefour + vendedor.totalItem;
                } else if (vendedor.vendedor == "Havan") {
                    totalHavan = totalHavan + vendedor.totalItem;
                } else if (vendedor.vendedor == "Extra") {
                    totalExtra = totalExtra + vendedor.totalItem;
                } else if (vendedor.vendedor == "AliExpress") {
                    totalAliExpress = totalAliExpress + vendedor.totalItem;
                } else if (vendedor.vendedor == "Amazon") {
                    totalAmazon = totalAmazon + vendedor.totalItem;
                }
            }

            dgvVendedor.Rows[0].Cells[0].Value = "Americanas";
            dgvVendedor.Rows[0].Cells[1].Value = totalAmericanas;
            dgvVendedor.Rows[1].Cells[0].Value = "Colombo";
            dgvVendedor.Rows[1].Cells[1].Value = totalColombo;
            dgvVendedor.Rows[2].Cells[0].Value = "Casas Bahias";
            dgvVendedor.Rows[2].Cells[1].Value = totalCasas_Bahias;
            dgvVendedor.Rows[3].Cells[0].Value = "Condor";
            dgvVendedor.Rows[3].Cells[1].Value = totalCondor;
            dgvVendedor.Rows[4].Cells[0].Value = "Carrefour";
            dgvVendedor.Rows[4].Cells[1].Value = totalCarrefour;
            dgvVendedor.Rows[5].Cells[0].Value = "Havan";
            dgvVendedor.Rows[5].Cells[1].Value = totalHavan;
            dgvVendedor.Rows[6].Cells[0].Value = "Extra";
            dgvVendedor.Rows[6].Cells[1].Value = totalExtra;
            dgvVendedor.Rows[7].Cells[0].Value = "AliExpress";
            dgvVendedor.Rows[7].Cells[1].Value = totalAliExpress;
            dgvVendedor.Rows[8].Cells[0].Value = "Amazon";
            dgvVendedor.Rows[8].Cells[1].Value = totalAmazon;
        }
    }
}
