
namespace Branca_De_Neve
{
    partial class relatorio
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardápioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rodape = new System.Windows.Forms.Panel();
            this.gp_relatorio = new System.Windows.Forms.GroupBox();
            this.bt_data = new System.Windows.Forms.Button();
            this.dataPara = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataDe = new System.Windows.Forms.DateTimePicker();
            this.bt_imprimir = new System.Windows.Forms.Button();
            this.lb_para = new System.Windows.Forms.Label();
            this.lb_de = new System.Windows.Forms.Label();
            this.bt_sair = new System.Windows.Forms.Button();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.gp_buscar = new System.Windows.Forms.GroupBox();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.clienteRelatorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.gp_relatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gp_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteRelatorioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 27);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoPedidoToolStripMenuItem,
            this.cardápioToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoPedidoToolStripMenuItem
            // 
            this.novoPedidoToolStripMenuItem.Name = "novoPedidoToolStripMenuItem";
            this.novoPedidoToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.novoPedidoToolStripMenuItem.Text = "Novo Pedido";
            // 
            // cardápioToolStripMenuItem
            // 
            this.cardápioToolStripMenuItem.Name = "cardápioToolStripMenuItem";
            this.cardápioToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.cardápioToolStripMenuItem.Text = "Cardápio";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.helpToolStripMenuItem.Text = "Ajuda";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // rodape
            // 
            this.rodape.BackColor = System.Drawing.Color.Gray;
            this.rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rodape.Location = new System.Drawing.Point(0, 989);
            this.rodape.Name = "rodape";
            this.rodape.Size = new System.Drawing.Size(767, 30);
            this.rodape.TabIndex = 68;
            // 
            // gp_relatorio
            // 
            this.gp_relatorio.Controls.Add(this.bt_data);
            this.gp_relatorio.Controls.Add(this.dataPara);
            this.gp_relatorio.Controls.Add(this.dataGridView1);
            this.gp_relatorio.Controls.Add(this.dataDe);
            this.gp_relatorio.Controls.Add(this.bt_imprimir);
            this.gp_relatorio.Controls.Add(this.lb_para);
            this.gp_relatorio.Controls.Add(this.lb_de);
            this.gp_relatorio.Location = new System.Drawing.Point(12, 144);
            this.gp_relatorio.Name = "gp_relatorio";
            this.gp_relatorio.Size = new System.Drawing.Size(743, 753);
            this.gp_relatorio.TabIndex = 69;
            this.gp_relatorio.TabStop = false;
            this.gp_relatorio.Text = "Relatório";
            // 
            // bt_data
            // 
            this.bt_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_data.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_data.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_data.ForeColor = System.Drawing.Color.White;
            this.bt_data.Location = new System.Drawing.Point(307, 43);
            this.bt_data.Name = "bt_data";
            this.bt_data.Size = new System.Drawing.Size(79, 28);
            this.bt_data.TabIndex = 7;
            this.bt_data.Text = "Buscar";
            this.bt_data.UseVisualStyleBackColor = false;
            this.bt_data.Click += new System.EventHandler(this.bt_data_Click);
            // 
            // dataPara
            // 
            this.dataPara.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPara.Location = new System.Drawing.Point(192, 51);
            this.dataPara.Name = "dataPara";
            this.dataPara.Size = new System.Drawing.Size(98, 20);
            this.dataPara.TabIndex = 2003;
            this.dataPara.Value = new System.DateTime(2022, 2, 9, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.dataGridView1.DataSource = this.clienteRelatorioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 96);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(716, 615);
            this.dataGridView1.TabIndex = 2001;
            this.dataGridView1.TabStop = false;
            // 
            // dataDe
            // 
            this.dataDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDe.Location = new System.Drawing.Point(47, 51);
            this.dataDe.Name = "dataDe";
            this.dataDe.Size = new System.Drawing.Size(98, 20);
            this.dataDe.TabIndex = 2002;
            this.dataDe.Value = new System.DateTime(2022, 2, 9, 0, 0, 0, 0);
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.BackColor = System.Drawing.Color.YellowGreen;
            this.bt_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_imprimir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_imprimir.ForeColor = System.Drawing.Color.White;
            this.bt_imprimir.Location = new System.Drawing.Point(621, 14);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(110, 35);
            this.bt_imprimir.TabIndex = 71;
            this.bt_imprimir.Text = "Imprimir";
            this.bt_imprimir.UseVisualStyleBackColor = false;
            this.bt_imprimir.Click += new System.EventHandler(this.bt_imprimir_Click);
            // 
            // lb_para
            // 
            this.lb_para.AutoSize = true;
            this.lb_para.Location = new System.Drawing.Point(157, 55);
            this.lb_para.Name = "lb_para";
            this.lb_para.Size = new System.Drawing.Size(29, 13);
            this.lb_para.TabIndex = 6;
            this.lb_para.Text = "Para";
            // 
            // lb_de
            // 
            this.lb_de.AutoSize = true;
            this.lb_de.Location = new System.Drawing.Point(20, 57);
            this.lb_de.Name = "lb_de";
            this.lb_de.Size = new System.Drawing.Size(21, 13);
            this.lb_de.TabIndex = 5;
            this.lb_de.Text = "De";
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.Red;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_sair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.Color.White;
            this.bt_sair.Location = new System.Drawing.Point(643, 922);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(110, 35);
            this.bt_sair.TabIndex = 70;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = false;
            // 
            // bt_buscar
            // 
            this.bt_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_buscar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar.ForeColor = System.Drawing.Color.White;
            this.bt_buscar.Location = new System.Drawing.Point(652, 31);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(79, 28);
            this.bt_buscar.TabIndex = 4;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = false;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // gp_buscar
            // 
            this.gp_buscar.Controls.Add(this.txt_pesquisa);
            this.gp_buscar.Controls.Add(this.bt_buscar);
            this.gp_buscar.Location = new System.Drawing.Point(12, 54);
            this.gp_buscar.Name = "gp_buscar";
            this.gp_buscar.Size = new System.Drawing.Size(743, 84);
            this.gp_buscar.TabIndex = 71;
            this.gp_buscar.TabStop = false;
            this.gp_buscar.Text = "Buscar";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(14, 39);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(632, 20);
            this.txt_pesquisa.TabIndex = 6;
            // 
            // clienteRelatorioBindingSource
            // 
            this.clienteRelatorioBindingSource.DataSource = typeof(Branca_De_Neve.Tabela.clienteRelatorio);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DATA_VENDA";
            this.dataGridViewTextBoxColumn5.HeaderText = "DATA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NOME";
            this.dataGridViewTextBoxColumn6.HeaderText = "NOME";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TELEFONE";
            this.dataGridViewTextBoxColumn7.HeaderText = "TELEFONE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ENDERECO";
            this.dataGridViewTextBoxColumn8.HeaderText = "ENDERECO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NUMERO";
            this.dataGridViewTextBoxColumn10.HeaderText = "NUMERO";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PRODUTO";
            this.dataGridViewTextBoxColumn11.HeaderText = "PRODUTO";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "QUANTIDADE";
            this.dataGridViewTextBoxColumn13.HeaderText = "QUANTIDADE";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "PRECO";
            this.dataGridViewTextBoxColumn16.HeaderText = "PRECO";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "VALOR_TOTAL";
            this.dataGridViewTextBoxColumn17.HeaderText = "TOTAL";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "FORMA_PAGAMENTO";
            this.dataGridViewTextBoxColumn18.HeaderText = "PAGAMENTO";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(767, 1019);
            this.Controls.Add(this.gp_buscar);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.gp_relatorio);
            this.Controls.Add(this.rodape);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas - Branca de Neve Hamburgueria";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gp_relatorio.ResumeLayout(false);
            this.gp_relatorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gp_buscar.ResumeLayout(false);
            this.gp_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteRelatorioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardápioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel rodape;
        private System.Windows.Forms.GroupBox gp_relatorio;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_imprimir;
        private System.Windows.Forms.GroupBox gp_buscar;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Button bt_data;
        private System.Windows.Forms.DateTimePicker dataPara;
        private System.Windows.Forms.DateTimePicker dataDe;
        private System.Windows.Forms.Label lb_para;
        private System.Windows.Forms.Label lb_de;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDERECODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAGAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clienteRelatorioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}