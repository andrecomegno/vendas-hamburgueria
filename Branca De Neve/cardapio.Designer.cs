
namespace Branca_De_Neve
{
    partial class cardapio
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
            this.gp_menu = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardapioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brancadeneveDataSet = new Branca_De_Neve.brancadeneveDataSet();
            this.bt_sair = new System.Windows.Forms.Button();
            this.rodape = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardápioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.gp_pesquisar = new System.Windows.Forms.GroupBox();
            this.gp_visualizar = new System.Windows.Forms.GroupBox();
            this.lb_tipo = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.lb_preco = new System.Windows.Forms.Label();
            this.lb_produto = new System.Windows.Forms.Label();
            this.cardapioTableAdapter = new Branca_De_Neve.brancadeneveDataSetTableAdapters.cardapioTableAdapter();
            this.txt_tipo = new System.Windows.Forms.ComboBox();
            this.gp_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardapioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brancadeneveDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gp_pesquisar.SuspendLayout();
            this.gp_visualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_menu
            // 
            this.gp_menu.BackColor = System.Drawing.SystemColors.Control;
            this.gp_menu.Controls.Add(this.dataGridView1);
            this.gp_menu.Location = new System.Drawing.Point(17, 278);
            this.gp_menu.Name = "gp_menu";
            this.gp_menu.Size = new System.Drawing.Size(740, 522);
            this.gp_menu.TabIndex = 0;
            this.gp_menu.TabStop = false;
            this.gp_menu.Text = "Menu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMEDataGridViewTextBoxColumn,
            this.pRECODataGridViewTextBoxColumn,
            this.tIPODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cardapioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(702, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.Width = 310;
            // 
            // pRECODataGridViewTextBoxColumn
            // 
            this.pRECODataGridViewTextBoxColumn.DataPropertyName = "PRECO";
            this.pRECODataGridViewTextBoxColumn.HeaderText = "PRECO";
            this.pRECODataGridViewTextBoxColumn.Name = "pRECODataGridViewTextBoxColumn";
            this.pRECODataGridViewTextBoxColumn.Width = 150;
            // 
            // tIPODataGridViewTextBoxColumn
            // 
            this.tIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO";
            this.tIPODataGridViewTextBoxColumn.HeaderText = "TIPO";
            this.tIPODataGridViewTextBoxColumn.Name = "tIPODataGridViewTextBoxColumn";
            this.tIPODataGridViewTextBoxColumn.Width = 200;
            // 
            // cardapioBindingSource
            // 
            this.cardapioBindingSource.DataMember = "cardapio";
            this.cardapioBindingSource.DataSource = this.brancadeneveDataSet;
            // 
            // brancadeneveDataSet
            // 
            this.brancadeneveDataSet.DataSetName = "brancadeneveDataSet";
            this.brancadeneveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.Red;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_sair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.Color.White;
            this.bt_sair.Location = new System.Drawing.Point(647, 832);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(110, 35);
            this.bt_sair.TabIndex = 18;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // rodape
            // 
            this.rodape.BackColor = System.Drawing.Color.Gray;
            this.rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rodape.Location = new System.Drawing.Point(0, 911);
            this.rodape.Name = "rodape";
            this.rodape.Size = new System.Drawing.Size(767, 30);
            this.rodape.TabIndex = 21;
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
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoPedidoToolStripMenuItem,
            this.cardápioToolStripMenuItem,
            this.relatórioDeVendasToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoPedidoToolStripMenuItem
            // 
            this.novoPedidoToolStripMenuItem.Name = "novoPedidoToolStripMenuItem";
            this.novoPedidoToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.novoPedidoToolStripMenuItem.Text = "Novo Pedido";
            // 
            // cardápioToolStripMenuItem
            // 
            this.cardápioToolStripMenuItem.Name = "cardápioToolStripMenuItem";
            this.cardápioToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.cardápioToolStripMenuItem.Text = "Cardápio";
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            this.relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            this.relatórioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.relatórioDeVendasToolStripMenuItem.Text = "Relatório De Vendas";
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
            // txt_pesquisar
            // 
            this.txt_pesquisar.Location = new System.Drawing.Point(56, 25);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(535, 20);
            this.txt_pesquisar.TabIndex = 24;
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_pesquisar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisar.ForeColor = System.Drawing.Color.White;
            this.bt_pesquisar.Location = new System.Drawing.Point(597, 17);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(87, 28);
            this.bt_pesquisar.TabIndex = 25;
            this.bt_pesquisar.Text = "Pesquisar";
            this.bt_pesquisar.UseVisualStyleBackColor = false;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // gp_pesquisar
            // 
            this.gp_pesquisar.Controls.Add(this.bt_pesquisar);
            this.gp_pesquisar.Controls.Add(this.txt_pesquisar);
            this.gp_pesquisar.Location = new System.Drawing.Point(20, 215);
            this.gp_pesquisar.Name = "gp_pesquisar";
            this.gp_pesquisar.Size = new System.Drawing.Size(737, 57);
            this.gp_pesquisar.TabIndex = 26;
            this.gp_pesquisar.TabStop = false;
            this.gp_pesquisar.Text = "Pesquisar";
            // 
            // gp_visualizar
            // 
            this.gp_visualizar.Controls.Add(this.txt_tipo);
            this.gp_visualizar.Controls.Add(this.lb_tipo);
            this.gp_visualizar.Controls.Add(this.txt_produto);
            this.gp_visualizar.Controls.Add(this.bt_add);
            this.gp_visualizar.Controls.Add(this.bt_excluir);
            this.gp_visualizar.Controls.Add(this.bt_editar);
            this.gp_visualizar.Controls.Add(this.txt_preco);
            this.gp_visualizar.Controls.Add(this.lb_preco);
            this.gp_visualizar.Controls.Add(this.lb_produto);
            this.gp_visualizar.Location = new System.Drawing.Point(17, 45);
            this.gp_visualizar.Name = "gp_visualizar";
            this.gp_visualizar.Size = new System.Drawing.Size(740, 164);
            this.gp_visualizar.TabIndex = 27;
            this.gp_visualizar.TabStop = false;
            this.gp_visualizar.Text = "Cardápio";
            // 
            // lb_tipo
            // 
            this.lb_tipo.AutoSize = true;
            this.lb_tipo.Location = new System.Drawing.Point(604, 64);
            this.lb_tipo.Name = "lb_tipo";
            this.lb_tipo.Size = new System.Drawing.Size(28, 13);
            this.lb_tipo.TabIndex = 123;
            this.lb_tipo.Text = "Tipo";
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(59, 80);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(348, 20);
            this.txt_produto.TabIndex = 121;
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_add.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.White;
            this.bt_add.Location = new System.Drawing.Point(59, 118);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(87, 28);
            this.bt_add.TabIndex = 119;
            this.bt_add.Text = "Adcionar";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.BackColor = System.Drawing.Color.Red;
            this.bt_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_excluir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.ForeColor = System.Drawing.Color.White;
            this.bt_excluir.Location = new System.Drawing.Point(657, 19);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(68, 28);
            this.bt_excluir.TabIndex = 118;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = false;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_editar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editar.ForeColor = System.Drawing.Color.White;
            this.bt_editar.Location = new System.Drawing.Point(152, 118);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(87, 28);
            this.bt_editar.TabIndex = 26;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // txt_preco
            // 
            this.txt_preco.BackColor = System.Drawing.Color.White;
            this.txt_preco.Location = new System.Drawing.Point(413, 80);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(139, 20);
            this.txt_preco.TabIndex = 44;
            this.txt_preco.TabStop = false;
            this.txt_preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_preco
            // 
            this.lb_preco.AutoSize = true;
            this.lb_preco.Location = new System.Drawing.Point(462, 64);
            this.lb_preco.Name = "lb_preco";
            this.lb_preco.Size = new System.Drawing.Size(35, 13);
            this.lb_preco.TabIndex = 117;
            this.lb_preco.Text = "Preço";
            // 
            // lb_produto
            // 
            this.lb_produto.AutoSize = true;
            this.lb_produto.Location = new System.Drawing.Point(175, 64);
            this.lb_produto.Name = "lb_produto";
            this.lb_produto.Size = new System.Drawing.Size(44, 13);
            this.lb_produto.TabIndex = 115;
            this.lb_produto.Text = "Produto";
            // 
            // cardapioTableAdapter
            // 
            this.cardapioTableAdapter.ClearBeforeFill = true;
            // 
            // txt_tipo
            // 
            this.txt_tipo.FormattingEnabled = true;
            this.txt_tipo.Items.AddRange(new object[] {
            "LANCHES",
            "BEBEDAS",
            "PORÇÂO",
            "OUTROS"});
            this.txt_tipo.Location = new System.Drawing.Point(558, 80);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(129, 21);
            this.txt_tipo.TabIndex = 124;
            // 
            // cardapio
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(767, 941);
            this.Controls.Add(this.gp_visualizar);
            this.Controls.Add(this.gp_pesquisar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.rodape);
            this.Controls.Add(this.gp_menu);
            this.Controls.Add(this.bt_sair);
            this.MaximizeBox = false;
            this.Name = "cardapio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cardápio - Branca de Neve Hamburgueria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cardapio_FormClosing);
            this.Load += new System.EventHandler(this.cardapio_Load);
            this.gp_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardapioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brancadeneveDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gp_pesquisar.ResumeLayout(false);
            this.gp_pesquisar.PerformLayout();
            this.gp_visualizar.ResumeLayout(false);
            this.gp_visualizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gp_menu;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Panel rodape;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardápioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.GroupBox gp_pesquisar;
        private System.Windows.Forms.GroupBox gp_visualizar;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label lb_preco;
        private System.Windows.Forms.Label lb_produto;
        private brancadeneveDataSet brancadeneveDataSet;
        private System.Windows.Forms.BindingSource cardapioBindingSource;
        private brancadeneveDataSetTableAdapters.cardapioTableAdapter cardapioTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lb_tipo;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.ComboBox txt_tipo;
    }
}