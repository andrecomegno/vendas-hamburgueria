
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardápioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rodape = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.im_historico = new System.Windows.Forms.PictureBox();
            this.im_cardapio = new System.Windows.Forms.PictureBox();
            this.im_novo_pedido = new System.Windows.Forms.PictureBox();
            this.bt_pedido = new System.Windows.Forms.Button();
            this.bt_cardapio = new System.Windows.Forms.Button();
            this.bt_relatorio = new System.Windows.Forms.Button();
            this.desenvolvido = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.rodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.im_historico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.im_cardapio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.im_novo_pedido)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(700, 27);
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
            // relatórioDeVendasToolStripMenuItem
            // 
            this.relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            this.relatórioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.relatórioDeVendasToolStripMenuItem.Text = "Relatório De Vendas";
            this.relatórioDeVendasToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeVendasToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.helpToolStripMenuItem.Text = "Ajuda";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
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
            this.rodape.Controls.Add(this.desenvolvido);
            this.rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rodape.Location = new System.Drawing.Point(0, 616);
            this.rodape.Name = "rodape";
            this.rodape.Size = new System.Drawing.Size(700, 30);
            this.rodape.TabIndex = 14;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Gainsboro;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Enabled = false;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Location = new System.Drawing.Point(467, 406);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(193, 69);
            this.button10.TabIndex = 57;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Gainsboro;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Enabled = false;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button11.Location = new System.Drawing.Point(255, 406);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(193, 69);
            this.button11.TabIndex = 56;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Gainsboro;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Enabled = false;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button12.Location = new System.Drawing.Point(42, 406);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(193, 69);
            this.button12.TabIndex = 55;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gainsboro;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Enabled = false;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(467, 313);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(193, 69);
            this.button6.TabIndex = 53;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Enabled = false;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(255, 313);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(193, 69);
            this.button7.TabIndex = 52;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gainsboro;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Enabled = false;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(42, 313);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(193, 69);
            this.button8.TabIndex = 51;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(467, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 69);
            this.button3.TabIndex = 49;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(255, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 69);
            this.button2.TabIndex = 48;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(42, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 69);
            this.button1.TabIndex = 47;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // im_historico
            // 
            this.im_historico.BackColor = System.Drawing.Color.SteelBlue;
            this.im_historico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.im_historico.Cursor = System.Windows.Forms.Cursors.Default;
            this.im_historico.Image = global::Branca_De_Neve.Properties.Resources.historico;
            this.im_historico.Location = new System.Drawing.Point(470, 127);
            this.im_historico.Name = "im_historico";
            this.im_historico.Size = new System.Drawing.Size(30, 30);
            this.im_historico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.im_historico.TabIndex = 45;
            this.im_historico.TabStop = false;
            // 
            // im_cardapio
            // 
            this.im_cardapio.BackColor = System.Drawing.Color.CadetBlue;
            this.im_cardapio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.im_cardapio.Cursor = System.Windows.Forms.Cursors.Default;
            this.im_cardapio.Image = global::Branca_De_Neve.Properties.Resources.cardapio;
            this.im_cardapio.Location = new System.Drawing.Point(260, 129);
            this.im_cardapio.Name = "im_cardapio";
            this.im_cardapio.Size = new System.Drawing.Size(30, 30);
            this.im_cardapio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.im_cardapio.TabIndex = 44;
            this.im_cardapio.TabStop = false;
            // 
            // im_novo_pedido
            // 
            this.im_novo_pedido.BackColor = System.Drawing.Color.YellowGreen;
            this.im_novo_pedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.im_novo_pedido.Cursor = System.Windows.Forms.Cursors.Default;
            this.im_novo_pedido.Image = global::Branca_De_Neve.Properties.Resources.pedido;
            this.im_novo_pedido.Location = new System.Drawing.Point(46, 128);
            this.im_novo_pedido.Name = "im_novo_pedido";
            this.im_novo_pedido.Size = new System.Drawing.Size(30, 30);
            this.im_novo_pedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.im_novo_pedido.TabIndex = 43;
            this.im_novo_pedido.TabStop = false;
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
            this.bt_pedido.Location = new System.Drawing.Point(42, 124);
            this.bt_pedido.Name = "bt_pedido";
            this.bt_pedido.Size = new System.Drawing.Size(193, 69);
            this.bt_pedido.TabIndex = 38;
            this.bt_pedido.Text = "   NOVO PEDIDO";
            this.bt_pedido.UseVisualStyleBackColor = false;
            this.bt_pedido.Click += new System.EventHandler(this.bt_pedido_Click);
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
            this.bt_cardapio.Location = new System.Drawing.Point(255, 124);
            this.bt_cardapio.Name = "bt_cardapio";
            this.bt_cardapio.Size = new System.Drawing.Size(193, 69);
            this.bt_cardapio.TabIndex = 40;
            this.bt_cardapio.Text = "CARDÁPIO";
            this.bt_cardapio.UseVisualStyleBackColor = false;
            this.bt_cardapio.Click += new System.EventHandler(this.bt_cardapio_Click);
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
            this.bt_relatorio.Location = new System.Drawing.Point(467, 124);
            this.bt_relatorio.Name = "bt_relatorio";
            this.bt_relatorio.Size = new System.Drawing.Size(193, 69);
            this.bt_relatorio.TabIndex = 41;
            this.bt_relatorio.Text = " RELATÓRIO \r\nDE\r\n VENDAS";
            this.bt_relatorio.UseVisualStyleBackColor = false;
            this.bt_relatorio.Click += new System.EventHandler(this.bt_relatorio_Click);
            // 
            // desenvolvido
            // 
            this.desenvolvido.AutoSize = true;
            this.desenvolvido.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.desenvolvido.Location = new System.Drawing.Point(12, 8);
            this.desenvolvido.Name = "desenvolvido";
            this.desenvolvido.Size = new System.Drawing.Size(169, 13);
            this.desenvolvido.TabIndex = 74;
            this.desenvolvido.Text = "Desenvolvido por André Comegno";
            // 
            // Branca_Neve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(700, 646);
            this.Controls.Add(this.im_historico);
            this.Controls.Add(this.im_cardapio);
            this.Controls.Add(this.im_novo_pedido);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rodape);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bt_pedido);
            this.Controls.Add(this.bt_cardapio);
            this.Controls.Add(this.bt_relatorio);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Branca_Neve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branca de Neve Hamburgueria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Branca_Neve_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.rodape.ResumeLayout(false);
            this.rodape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.im_historico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.im_cardapio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.im_novo_pedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel rodape;
        private System.Windows.Forms.ToolStripMenuItem novoPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardápioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox im_historico;
        private System.Windows.Forms.PictureBox im_cardapio;
        private System.Windows.Forms.PictureBox im_novo_pedido;
        private System.Windows.Forms.Button bt_pedido;
        private System.Windows.Forms.Button bt_cardapio;
        private System.Windows.Forms.Button bt_relatorio;
        private System.Windows.Forms.Label desenvolvido;
    }
}

