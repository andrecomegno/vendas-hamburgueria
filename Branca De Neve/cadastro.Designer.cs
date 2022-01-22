
namespace Branca_De_Neve
{
    partial class cadastro_novo
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
            this.bt_sair = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_estado = new System.Windows.Forms.Label();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.lb_bairro = new System.Windows.Forms.Label();
            this.lb_end = new System.Windows.Forms.Label();
            this.lb_cep = new System.Windows.Forms.Label();
            this.bt_buscar_cep = new System.Windows.Forms.Button();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lb_tel = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.Red;
            this.bt_sair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.Color.White;
            this.bt_sair.Location = new System.Drawing.Point(418, 311);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(110, 35);
            this.bt_sair.TabIndex = 9;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = false;
            // 
            // bt_salvar
            // 
            this.bt_salvar.BackColor = System.Drawing.Color.YellowGreen;
            this.bt_salvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar.ForeColor = System.Drawing.Color.White;
            this.bt_salvar.Location = new System.Drawing.Point(534, 311);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(110, 35);
            this.bt_salvar.TabIndex = 10;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 370);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 24);
            this.panel3.TabIndex = 13;
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
            this.menuStrip1.Size = new System.Drawing.Size(656, 27);
            this.menuStrip1.TabIndex = 14;
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
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Location = new System.Drawing.Point(541, 178);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(40, 13);
            this.lb_estado.TabIndex = 25;
            this.lb_estado.Text = "Estado";
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Location = new System.Drawing.Point(320, 178);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(40, 13);
            this.lb_cidade.TabIndex = 24;
            this.lb_cidade.Text = "Cidade";
            // 
            // lb_bairro
            // 
            this.lb_bairro.AutoSize = true;
            this.lb_bairro.Location = new System.Drawing.Point(19, 178);
            this.lb_bairro.Name = "lb_bairro";
            this.lb_bairro.Size = new System.Drawing.Size(34, 13);
            this.lb_bairro.TabIndex = 23;
            this.lb_bairro.Text = "Bairro";
            // 
            // lb_end
            // 
            this.lb_end.AutoSize = true;
            this.lb_end.Location = new System.Drawing.Point(19, 128);
            this.lb_end.Name = "lb_end";
            this.lb_end.Size = new System.Drawing.Size(53, 13);
            this.lb_end.TabIndex = 22;
            this.lb_end.Text = "Endereço";
            // 
            // lb_cep
            // 
            this.lb_cep.AutoSize = true;
            this.lb_cep.Location = new System.Drawing.Point(153, 79);
            this.lb_cep.Name = "lb_cep";
            this.lb_cep.Size = new System.Drawing.Size(28, 13);
            this.lb_cep.TabIndex = 18;
            this.lb_cep.Text = "CEP";
            // 
            // bt_buscar_cep
            // 
            this.bt_buscar_cep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_buscar_cep.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar_cep.ForeColor = System.Drawing.Color.White;
            this.bt_buscar_cep.Location = new System.Drawing.Point(281, 87);
            this.bt_buscar_cep.Name = "bt_buscar_cep";
            this.bt_buscar_cep.Size = new System.Drawing.Size(85, 34);
            this.bt_buscar_cep.TabIndex = 16;
            this.bt_buscar_cep.Text = "Buscar";
            this.bt_buscar_cep.UseVisualStyleBackColor = false;
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(22, 144);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(589, 20);
            this.txt_end.TabIndex = 17;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(22, 194);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(295, 20);
            this.txt_bairro.TabIndex = 19;
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(156, 95);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(110, 20);
            this.txt_cep.TabIndex = 15;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(544, 194);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(67, 20);
            this.txt_estado.TabIndex = 21;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(323, 194);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(213, 20);
            this.txt_cidade.TabIndex = 20;
            // 
            // lb_tel
            // 
            this.lb_tel.AutoSize = true;
            this.lb_tel.Location = new System.Drawing.Point(19, 79);
            this.lb_tel.Name = "lb_tel";
            this.lb_tel.Size = new System.Drawing.Size(49, 13);
            this.lb_tel.TabIndex = 31;
            this.lb_tel.Text = "Telefone";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(19, 32);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(82, 13);
            this.lb_nome.TabIndex = 29;
            this.lb_nome.Text = "Nome Completo";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(22, 48);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(589, 20);
            this.txt_nome.TabIndex = 26;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(22, 95);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(110, 20);
            this.txt_tel.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_nome);
            this.groupBox1.Controls.Add(this.lb_tel);
            this.groupBox1.Controls.Add(this.txt_cidade);
            this.groupBox1.Controls.Add(this.txt_estado);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.txt_cep);
            this.groupBox1.Controls.Add(this.txt_tel);
            this.groupBox1.Controls.Add(this.txt_bairro);
            this.groupBox1.Controls.Add(this.lb_estado);
            this.groupBox1.Controls.Add(this.txt_end);
            this.groupBox1.Controls.Add(this.lb_cidade);
            this.groupBox1.Controls.Add(this.bt_buscar_cep);
            this.groupBox1.Controls.Add(this.lb_bairro);
            this.groupBox1.Controls.Add(this.lb_cep);
            this.groupBox1.Controls.Add(this.lb_end);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 229);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo Cliente";
            // 
            // cadastro_novo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(656, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "cadastro_novo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Novo Cliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.Label lb_cidade;
        private System.Windows.Forms.Label lb_bairro;
        private System.Windows.Forms.Label lb_end;
        private System.Windows.Forms.Label lb_cep;
        private System.Windows.Forms.Button bt_buscar_cep;
        private System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lb_tel;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}