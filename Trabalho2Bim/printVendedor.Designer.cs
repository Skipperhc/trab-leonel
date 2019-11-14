namespace Trabalho2Bim
{
    partial class printVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvVendedor = new System.Windows.Forms.DataGridView();
            this.colunVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendedor
            // 
            this.dgvVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunVendedor,
            this.ColumTotal});
            this.dgvVendedor.Location = new System.Drawing.Point(16, 15);
            this.dgvVendedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVendedor.Name = "dgvVendedor";
            this.dgvVendedor.RowHeadersWidth = 51;
            this.dgvVendedor.Size = new System.Drawing.Size(392, 524);
            this.dgvVendedor.TabIndex = 0;
            // 
            // colunVendedor
            // 
            this.colunVendedor.HeaderText = "Vendedores";
            this.colunVendedor.MinimumWidth = 6;
            this.colunVendedor.Name = "colunVendedor";
            this.colunVendedor.Width = 125;
            // 
            // ColumTotal
            // 
            this.ColumTotal.HeaderText = "Total de Vendas";
            this.ColumTotal.MinimumWidth = 6;
            this.ColumTotal.Name = "ColumTotal";
            this.ColumTotal.Width = 125;
            // 
            // printVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 554);
            this.Controls.Add(this.dgvVendedor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "printVendedor";
            this.Text = "printVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTotal;
    }
}