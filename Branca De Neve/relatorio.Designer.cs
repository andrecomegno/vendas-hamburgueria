
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardápioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rodape = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_sair = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_buscar_cep = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bt_concluir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(617, 27);
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
            this.rodape.Location = new System.Drawing.Point(0, 672);
            this.rodape.Name = "rodape";
            this.rodape.Size = new System.Drawing.Size(617, 30);
            this.rodape.TabIndex = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 424);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatório";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.Red;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_sair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.Color.White;
            this.bt_sair.Location = new System.Drawing.Point(29, 605);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(110, 35);
            this.bt_sair.TabIndex = 70;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bt_buscar_cep);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 84);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data";
            // 
            // bt_buscar_cep
            // 
            this.bt_buscar_cep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_buscar_cep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_buscar_cep.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar_cep.ForeColor = System.Drawing.Color.White;
            this.bt_buscar_cep.Location = new System.Drawing.Point(265, 42);
            this.bt_buscar_cep.Name = "bt_buscar_cep";
            this.bt_buscar_cep.Size = new System.Drawing.Size(79, 28);
            this.bt_buscar_cep.TabIndex = 4;
            this.bt_buscar_cep.Text = "Buscar";
            this.bt_buscar_cep.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // bt_concluir
            // 
            this.bt_concluir.BackColor = System.Drawing.Color.YellowGreen;
            this.bt_concluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_concluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_concluir.ForeColor = System.Drawing.Color.White;
            this.bt_concluir.Location = new System.Drawing.Point(474, 605);
            this.bt_concluir.Name = "bt_concluir";
            this.bt_concluir.Size = new System.Drawing.Size(110, 35);
            this.bt_concluir.TabIndex = 71;
            this.bt_concluir.Text = "Imprimir";
            this.bt_concluir.UseVisualStyleBackColor = false;
            // 
            // relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(617, 702);
            this.Controls.Add(this.bt_concluir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rodape);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas - Branca de Neve Hamburgueria";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bt_buscar_cep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_concluir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}