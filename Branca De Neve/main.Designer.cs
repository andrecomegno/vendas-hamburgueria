
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardápioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rodape = new System.Windows.Forms.Panel();
            this.bt_cardapio = new System.Windows.Forms.Button();
            this.lb_novo_pedido = new System.Windows.Forms.Label();
            this.bt_relatorio = new System.Windows.Forms.Button();
            this.bt_caixa = new System.Windows.Forms.Button();
            this.im_cardapio = new System.Windows.Forms.PictureBox();
            this.im_novo_pedido = new System.Windows.Forms.PictureBox();
            this.im_ = new System.Windows.Forms.PictureBox();
            this.im_historico = new System.Windows.Forms.PictureBox();
            this.relatórioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.im_cardapio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.im_novo_pedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.im_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.im_historico)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_pedido
            // 
            this.bt_pedido.BackColor = System.Drawing.Color.YellowGreen;
            this.bt_pedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_pedido.FlatAppearance.BorderSize = 0;
            this.bt_pedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.bt_pedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.bt_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pedido.ForeColor = System.Drawing.Color.White;
            this.bt_pedido.Location = new System.Drawing.Point(45, 99);
            this.bt_pedido.Name = "bt_pedido";
            this.bt_pedido.Size = new System.Drawing.Size(193, 69);
            this.bt_pedido.TabIndex = 0;
            this.bt_pedido.Text = "   NOVO PEDIDO";
            this.bt_pedido.UseVisualStyleBackColor = false;
            this.bt_pedido.Click += new System.EventHandler(this.bt_pedido_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(499, 27);
            this.menuStrip1.TabIndex = 5;
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
            this.novoPedidoToolStripMenuItem.Click += new System.EventHandler(this.novoPedidoToolStripMenuItem_Click);
            // 
            // cardápioToolStripMenuItem
            // 
            this.cardápioToolStripMenuItem.Name = "cardápioToolStripMenuItem";
            this.cardápioToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.cardápioToolStripMenuItem.Text = "Cardápio";
            this.cardápioToolStripMenuItem.Click += new System.EventHandler(this.cardápioToolStripMenuItem_Click);
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
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // rodape
            // 
            this.rodape.BackColor = System.Drawing.Color.Gray;
            this.rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rodape.Location = new System.Drawing.Point(0, 485);
            this.rodape.Name = "rodape";
            this.rodape.Size = new System.Drawing.Size(499, 30);
            this.rodape.TabIndex = 14;
            // 
            // bt_cardapio
            // 
            this.bt_cardapio.BackColor = System.Drawing.Color.CadetBlue;
            this.bt_cardapio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cardapio.FlatAppearance.BorderSize = 0;
            this.bt_cardapio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.bt_cardapio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.bt_cardapio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cardapio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cardapio.ForeColor = System.Drawing.Color.White;
            this.bt_cardapio.Location = new System.Drawing.Point(258, 99);
            this.bt_cardapio.Name = "bt_cardapio";
            this.bt_cardapio.Size = new System.Drawing.Size(193, 69);
            this.bt_cardapio.TabIndex = 1;
            this.bt_cardapio.Text = "CARDÁPIO";
            this.bt_cardapio.UseVisualStyleBackColor = false;
            this.bt_cardapio.Click += new System.EventHandler(this.bt_cardapio_Click);
            // 
            // lb_novo_pedido
            // 
            this.lb_novo_pedido.BackColor = System.Drawing.Color.YellowGreen;
            this.lb_novo_pedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_novo_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_novo_pedido.ForeColor = System.Drawing.Color.White;
            this.lb_novo_pedido.Location = new System.Drawing.Point(216, 146);
            this.lb_novo_pedido.Name = "lb_novo_pedido";
            this.lb_novo_pedido.Size = new System.Drawing.Size(19, 20);
            this.lb_novo_pedido.TabIndex = 0;
            this.lb_novo_pedido.Text = "0";
            this.lb_novo_pedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_relatorio
            // 
            this.bt_relatorio.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_relatorio.FlatAppearance.BorderSize = 0;
            this.bt_relatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.bt_relatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.bt_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_relatorio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_relatorio.ForeColor = System.Drawing.Color.White;
            this.bt_relatorio.Location = new System.Drawing.Point(44, 190);
            this.bt_relatorio.Name = "bt_relatorio";
            this.bt_relatorio.Size = new System.Drawing.Size(193, 69);
            this.bt_relatorio.TabIndex = 2;
            this.bt_relatorio.Text = " RELATÓRIO \r\nDE\r\n VENDAS";
            this.bt_relatorio.UseVisualStyleBackColor = false;
            this.bt_relatorio.Click += new System.EventHandler(this.bt_relatorio_Click);
            // 
            // bt_caixa
            // 
            this.bt_caixa.BackColor = System.Drawing.Color.Orange;
            this.bt_caixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_caixa.FlatAppearance.BorderSize = 0;
            this.bt_caixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.bt_caixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.bt_caixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_caixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_caixa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_caixa.Location = new System.Drawing.Point(258, 190);
            this.bt_caixa.Name = "bt_caixa";
            this.bt_caixa.Size = new System.Drawing.Size(193, 69);
            this.bt_caixa.TabIndex = 3;
            this.bt_caixa.Text = "CAIXA";
            this.bt_caixa.UseVisualStyleBackColor = false;
            // 
            // im_cardapio
            // 
            this.im_cardapio.BackColor = System.Drawing.Color.CadetBlue;
            this.im_cardapio.BackgroundImage = global::Branca_De_Neve.Properties.Resources.cardapio;
            this.im_cardapio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.im_cardapio.Cursor = System.Windows.Forms.Cursors.Default;
            this.im_cardapio.Location = new System.Drawing.Point(263, 104);
            this.im_cardapio.Name = "im_cardapio";
            this.im_cardapio.Size = new System.Drawing.Size(30, 30);
            this.im_cardapio.TabIndex = 23;
            this.im_cardapio.TabStop = false;
            // 
            // im_novo_pedido
            // 
            this.im_novo_pedido.BackColor = System.Drawing.Color.YellowGreen;
            this.im_novo_pedido.BackgroundImage = global::Branca_De_Neve.Properties.Resources.pedido;
            this.im_novo_pedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.im_novo_pedido.Cursor = System.Windows.Forms.Cursors.Default;
            this.im_novo_pedido.Location = new System.Drawing.Point(49, 103);
            this.im_novo_pedido.Name = "im_novo_pedido";
            this.im_novo_pedido.Size = new System.Drawing.Size(30, 30);
            this.im_novo_pedido.TabIndex = 19;
            this.im_novo_pedido.TabStop = false;
            // 
            // im_
            // 
            this.im_.BackColor = System.Drawing.Color.Orange;
            this.im_.BackgroundImage = global::Branca_De_Neve.Properties.Resources.caixa;
            this.im_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.im_.Cursor = System.Windows.Forms.Cursors.Default;
            this.im_.Location = new System.Drawing.Point(261, 193);
            this.im_.Name = "im_";
            this.im_.Size = new System.Drawing.Size(30, 30);
            this.im_.TabIndex = 25;
            this.im_.TabStop = false;
            // 
            // im_historico
            // 
            this.im_historico.BackColor = System.Drawing.Color.SteelBlue;
            this.im_historico.BackgroundImage = global::Branca_De_Neve.Properties.Resources.historico;
            this.im_historico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.im_historico.Cursor = System.Windows.Forms.Cursors.Default;
            this.im_historico.Image = global::Branca_De_Neve.Properties.Resources.historico;
            this.im_historico.Location = new System.Drawing.Point(47, 193);
            this.im_historico.Name = "im_historico";
            this.im_historico.Size = new System.Drawing.Size(30, 30);
            this.im_historico.TabIndex = 24;
            this.im_historico.TabStop = false;
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            this.relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            this.relatórioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.relatórioDeVendasToolStripMenuItem.Text = "Relatório De Vendas";
            this.relatórioDeVendasToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeVendasToolStripMenuItem_Click);
            // 
            // Branca_Neve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(499, 515);
            this.Controls.Add(this.im_);
            this.Controls.Add(this.im_historico);
            this.Controls.Add(this.im_cardapio);
            this.Controls.Add(this.bt_caixa);
            this.Controls.Add(this.bt_relatorio);
            this.Controls.Add(this.lb_novo_pedido);
            this.Controls.Add(this.im_novo_pedido);
            this.Controls.Add(this.bt_cardapio);
            this.Controls.Add(this.bt_pedido);
            this.Controls.Add(this.rodape);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Branca_Neve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branca de Neve Hamburgueria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Branca_Neve_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.im_cardapio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.im_novo_pedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.im_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.im_historico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_pedido;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel rodape;
        private System.Windows.Forms.Button bt_cardapio;
        private System.Windows.Forms.ToolStripMenuItem novoPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardápioToolStripMenuItem;
        private System.Windows.Forms.PictureBox im_novo_pedido;
        private System.Windows.Forms.Label lb_novo_pedido;
        private System.Windows.Forms.Button bt_relatorio;
        private System.Windows.Forms.Button bt_caixa;
        private System.Windows.Forms.PictureBox im_cardapio;
        private System.Windows.Forms.PictureBox im_;
        private System.Windows.Forms.PictureBox im_historico;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
    }
}

