
namespace Branca_De_Neve
{
    partial class Branca_Neve
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_pedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_cardapio = new System.Windows.Forms.Button();
            this.bt_clientes = new System.Windows.Forms.Button();
            this.bt_cadastro = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_pedido
            // 
            this.bt_pedido.BackColor = System.Drawing.Color.YellowGreen;
            this.bt_pedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_pedido.Location = new System.Drawing.Point(25, 110);
            this.bt_pedido.Name = "bt_pedido";
            this.bt_pedido.Size = new System.Drawing.Size(174, 56);
            this.bt_pedido.TabIndex = 0;
            this.bt_pedido.Text = "+ NOVO PEDIDO";
            this.bt_pedido.UseVisualStyleBackColor = false;
            this.bt_pedido.Click += new System.EventHandler(this.bt_pedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Branca de Neve Hamburgueria";
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
            this.menuStrip1.Size = new System.Drawing.Size(796, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 449);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 19);
            this.panel3.TabIndex = 14;
            // 
            // bt_cardapio
            // 
            this.bt_cardapio.BackColor = System.Drawing.Color.CadetBlue;
            this.bt_cardapio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cardapio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_cardapio.Location = new System.Drawing.Point(217, 110);
            this.bt_cardapio.Name = "bt_cardapio";
            this.bt_cardapio.Size = new System.Drawing.Size(174, 56);
            this.bt_cardapio.TabIndex = 15;
            this.bt_cardapio.Text = "CARDÁPIO";
            this.bt_cardapio.UseVisualStyleBackColor = false;
            // 
            // bt_clientes
            // 
            this.bt_clientes.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_clientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_clientes.Location = new System.Drawing.Point(407, 110);
            this.bt_clientes.Name = "bt_clientes";
            this.bt_clientes.Size = new System.Drawing.Size(174, 56);
            this.bt_clientes.TabIndex = 16;
            this.bt_clientes.Text = "CLIENTES";
            this.bt_clientes.UseVisualStyleBackColor = false;
            // 
            // bt_cadastro
            // 
            this.bt_cadastro.BackColor = System.Drawing.Color.Orange;
            this.bt_cadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_cadastro.Location = new System.Drawing.Point(600, 110);
            this.bt_cadastro.Name = "bt_cadastro";
            this.bt_cadastro.Size = new System.Drawing.Size(174, 56);
            this.bt_cadastro.TabIndex = 17;
            this.bt_cadastro.Text = "CADASTRO";
            this.bt_cadastro.UseVisualStyleBackColor = false;
            this.bt_cadastro.Click += new System.EventHandler(this.bt_cadastro_Click);
            // 
            // Branca_Neve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(796, 464);
            this.Controls.Add(this.bt_cadastro);
            this.Controls.Add(this.bt_clientes);
            this.Controls.Add(this.bt_cardapio);
            this.Controls.Add(this.bt_pedido);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Branca_Neve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branca de Neve Hamburgueria";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_pedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_cardapio;
        private System.Windows.Forms.Button bt_clientes;
        private System.Windows.Forms.Button bt_cadastro;
    }
}

