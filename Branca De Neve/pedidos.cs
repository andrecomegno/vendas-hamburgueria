using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Branca_De_Neve.Script;
using MySql.Data.MySqlClient;

namespace Branca_De_Neve
{
    public partial class pedidos : Form
    {

        public pedidos()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            txt_valor_01.Text = Convert.ToDouble(txt_valor_01.Text).ToString("F");
            txt_valor_02.Text = Convert.ToDouble(txt_valor_02.Text).ToString("F");
            txt_valor_03.Text = Convert.ToDouble(txt_valor_03.Text).ToString("F");
            txt_valor_04.Text = Convert.ToDouble(txt_valor_04.Text).ToString("F");
            txt_valor_05.Text = Convert.ToDouble(txt_valor_05.Text).ToString("F");
            txt_valor_06.Text = Convert.ToDouble(txt_valor_06.Text).ToString("F");
            txt_valor_07.Text = Convert.ToDouble(txt_valor_07.Text).ToString("F");
            txt_valor_08.Text = Convert.ToDouble(txt_valor_08.Text).ToString("F");
            txt_valor_09.Text = Convert.ToDouble(txt_valor_09.Text).ToString("F");
            txt_valor_10.Text = Convert.ToDouble(txt_valor_10.Text).ToString("F");

            txt_total_01.Text = Convert.ToDouble(txt_total_01.Text).ToString("F");
            txt_total_02.Text = Convert.ToDouble(txt_total_02.Text).ToString("F");
            txt_total_03.Text = Convert.ToDouble(txt_total_03.Text).ToString("F");
            txt_total_04.Text = Convert.ToDouble(txt_total_04.Text).ToString("F");
            txt_total_05.Text = Convert.ToDouble(txt_total_05.Text).ToString("F");
            txt_total_06.Text = Convert.ToDouble(txt_total_06.Text).ToString("F");
            txt_total_07.Text = Convert.ToDouble(txt_total_07.Text).ToString("F");
            txt_total_08.Text = Convert.ToDouble(txt_total_08.Text).ToString("F");
            txt_total_09.Text = Convert.ToDouble(txt_total_09.Text).ToString("F");
            txt_total_10.Text = Convert.ToDouble(txt_total_10.Text).ToString("F");

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");

        }

        #region PEDIDO TABELA

        private void TotalPagar()
        {
            double res = Convert.ToDouble(txt_total_01.Text) + Convert.ToDouble(txt_total_02.Text) + Convert.ToDouble(txt_total_03.Text) +
                Convert.ToDouble(txt_total_04.Text) + Convert.ToDouble(txt_total_05.Text) + Convert.ToDouble(txt_total_06.Text) +
                Convert.ToDouble(txt_total_07.Text) + Convert.ToDouble(txt_total_08.Text) + Convert.ToDouble(txt_total_09.Text) +
                Convert.ToDouble(txt_total_10.Text);

            txt_total_venda.Text = res.ToString();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("C");
        }

        Int32 Calculador(Int32 a, Int32 b)
        {
            return a * b;
        }

        private void txt_valor_01_Leave(object sender, EventArgs e)
        {         
            if (txt_valor_01.Text == "")
            {
                txt_valor_01.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_01.Text);
            b = Convert.ToInt32(txt_valor_01.Text);

            txt_total_01.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_valor_01.Text = Convert.ToDouble(txt_valor_01.Text).ToString("F");
            txt_total_01.Text = Convert.ToDouble(txt_total_01.Text).ToString("F");
        }

        private void txt_valor_02_Leave(object sender, EventArgs e)
        {
            if (txt_valor_02.Text == "")
            {
                txt_valor_02.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_02.Text);
            b = Convert.ToInt32(txt_valor_02.Text);

            txt_total_02.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_valor_02.Text = Convert.ToDouble(txt_valor_02.Text).ToString("F");
            txt_total_02.Text = Convert.ToDouble(txt_total_02.Text).ToString("F");
        }

        private void txt_valor_03_Leave(object sender, EventArgs e)
        {
            if (txt_valor_03.Text == "")
            {
                txt_valor_03.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_03.Text);
            b = Convert.ToInt32(txt_valor_03.Text);

            txt_total_03.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
            txt_valor_03.Text = Convert.ToDouble(txt_valor_03.Text).ToString("F");
            txt_total_03.Text = Convert.ToDouble(txt_total_03.Text).ToString("F");
        }

        private void txt_valor_04_Leave(object sender, EventArgs e)
        {
            if (txt_valor_04.Text == "")
            {
                txt_valor_04.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_04.Text);
            b = Convert.ToInt32(txt_valor_04.Text);

            txt_total_04.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
            txt_valor_04.Text = Convert.ToDouble(txt_valor_04.Text).ToString("F");
            txt_total_04.Text = Convert.ToDouble(txt_total_04.Text).ToString("F");
        }

        private void txt_valor_05_Leave(object sender, EventArgs e)
        {
            if (txt_valor_05.Text == "")
            {
                txt_valor_05.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_05.Text);
            b = Convert.ToInt32(txt_valor_05.Text);

            txt_total_05.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
            txt_valor_05.Text = Convert.ToDouble(txt_valor_05.Text).ToString("F");
            txt_total_05.Text = Convert.ToDouble(txt_total_05.Text).ToString("F");
        }

        private void txt_valor_06_Leave(object sender, EventArgs e)
        {
            if (txt_valor_06.Text == "")
            {
                txt_valor_06.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_06.Text);
            b = Convert.ToInt32(txt_valor_06.Text);

            txt_total_06.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
            txt_valor_06.Text = Convert.ToDouble(txt_valor_06.Text).ToString("F");
            txt_total_06.Text = Convert.ToDouble(txt_total_06.Text).ToString("F");
        }

        private void txt_valor_07_Leave(object sender, EventArgs e)
        {
            if (txt_valor_07.Text == "")
            {
                txt_valor_07.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_07.Text);
            b = Convert.ToInt32(txt_valor_07.Text);

            txt_total_07.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
            txt_valor_07.Text = Convert.ToDouble(txt_valor_07.Text).ToString("F");
            txt_total_07.Text = Convert.ToDouble(txt_total_07.Text).ToString("F");
        }

        private void txt_valor_08_Leave(object sender, EventArgs e)
        {
            if (txt_valor_08.Text == "")
            {
                txt_valor_08.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_08.Text);
            b = Convert.ToInt32(txt_valor_08.Text);

            txt_total_08.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
            txt_valor_08.Text = Convert.ToDouble(txt_valor_08.Text).ToString("F");
            txt_total_08.Text = Convert.ToDouble(txt_total_08.Text).ToString("F");
        }

        private void txt_valor_09_Leave(object sender, EventArgs e)
        {
            if (txt_valor_09.Text == "")
            {
                txt_valor_09.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_09.Text);
            b = Convert.ToInt32(txt_valor_09.Text);

            txt_total_09.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
            txt_valor_09.Text = Convert.ToDouble(txt_valor_09.Text).ToString("F");
            txt_total_09.Text = Convert.ToDouble(txt_total_09.Text).ToString("F");

        }

        private void txt_valor_10_Leave(object sender, EventArgs e)
        {
            if (txt_valor_10.Text == "")
            {
                txt_valor_10.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_10.Text);
            b = Convert.ToInt32(txt_valor_10.Text);

            txt_total_10.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
            txt_valor_10.Text = Convert.ToDouble(txt_valor_10.Text).ToString("F");
            txt_total_10.Text = Convert.ToDouble(txt_total_10.Text).ToString("F");
        }

        private void txt_total_venda_Leave(object sender, EventArgs e)
        {
            if (txt_total_venda.Text == "")
            {
                txt_total_venda.Text = "0";
            }

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
        }

        private void txt_qt_01_Leave(object sender, EventArgs e)
        {
            if (txt_qt_01.Text == "")
            {
                txt_qt_01.Text = "0";
            }
        }

        private void txt_qt_02_Leave(object sender, EventArgs e)
        {
            if (txt_qt_02.Text == "")
            {
                txt_qt_02.Text = "0";
            }
        }

        private void txt_qt_03_Leave(object sender, EventArgs e)
        {
            if (txt_qt_03.Text == "")
            {
                txt_qt_03.Text = "0";
            }
        }

        private void txt_qt_04_Leave(object sender, EventArgs e)
        {
            if (txt_qt_04.Text == "")
            {
                txt_qt_04.Text = "0";
            }
        }

        private void txt_qt_05_Leave(object sender, EventArgs e)
        {
            if (txt_qt_05.Text == "")
            {
                txt_qt_05.Text = "0";
            }
        }

        private void txt_qt_06_Leave(object sender, EventArgs e)
        {
            if (txt_qt_06.Text == "")
            {
                txt_qt_06.Text = "0";
            }
        }

        private void txt_qt_07_Leave(object sender, EventArgs e)
        {
            if (txt_qt_07.Text == "")
            {
                txt_qt_07.Text = "0";
            }
        }

        private void txt_qt_08_Leave(object sender, EventArgs e)
        {
            if (txt_qt_08.Text == "")
            {
                txt_qt_08.Text = "0";
            }
        }

        private void txt_qt_09_Leave(object sender, EventArgs e)
        {
            if (txt_qt_09.Text == "")
            {
                txt_qt_09.Text = "0";
            }
        }

        private void txt_qt_10_Leave(object sender, EventArgs e)
        {
            if (txt_qt_10.Text == "")
            {
                txt_qt_10.Text = "0";
            }
        }

        #endregion

        #region MOUSE CLICK

        // CADASTRO
        private void txt_nome_MouseClick(object sender, MouseEventArgs e)
        {
            txt_nome.BackColor = Color.White;
        }

        private void txt_end_MouseClick(object sender, MouseEventArgs e)
        {
            txt_end.BackColor = Color.White;
        }

        private void txt_end_n_MouseClick(object sender, MouseEventArgs e)
        {
            txt_end_n.BackColor = Color.White;
        }

        // PAGAMENTO


        // QUANTIDADE
        private void txt_qt_01_MouseClick(object sender, MouseEventArgs e)
        {
            txt_qt_01.Text = "";
        }

        private void txt_qt_02_MouseClick(object sender, MouseEventArgs e)
        {
            txt_qt_02.Text = "";
        }

        private void txt_qt_03_MouseClick(object sender, MouseEventArgs e)
        {
            txt_qt_03.Text = "";
        }

        private void txt_qt_04_MouseClick(object sender, MouseEventArgs e)
        {
            txt_qt_04.Text = "";
        }

        private void txt_qt_05_MouseClick(object sender, MouseEventArgs e)
        {
            txt_qt_05.Text = "";
        }

        private void txt_qt_06_MouseClick(object sender, MouseEventArgs e)
        {
            txt_qt_06.Text = "";
        }

        private void txt_qt_07_MouseClick(object sender, MouseEventArgs e)
        {
            txt_qt_07.Text = "";
        }

        private void txt_qt_08_MouseClick(object sender, MouseEventArgs e)
        {
            txt_qt_08.Text = "";
        }

        private void txt_qt_09_MouseClick(object sender, MouseEventArgs e)
        {
            txt_qt_09.Text = "";
        }

        private void txt_qt_10_MouseClick(object sender, MouseEventArgs e)
        {
            txt_qt_10.Text = "";
        }

        // NOME DO PRODUTO
        private void txt_produto_01_MouseClick(object sender, MouseEventArgs e)
        {

        }

        // VALOR UNITARIO
        private void txt_valor_01_MouseClick(object sender, MouseEventArgs e)
        {
            txt_valor_01.Text = "";
        }

        private void txt_valor_02_MouseClick(object sender, MouseEventArgs e)
        {
            txt_valor_02.Text = "";
        }

        private void txt_valor_03_MouseClick(object sender, MouseEventArgs e)
        {
            txt_valor_03.Text = "";
        }

        private void txt_valor_04_MouseClick(object sender, MouseEventArgs e)
        {
            txt_valor_04.Text = "";
        }

        private void txt_valor_05_MouseClick(object sender, MouseEventArgs e)
        {
            txt_valor_05.Text = "";
        }

        private void txt_valor_06_MouseClick(object sender, MouseEventArgs e)
        {
            txt_valor_06.Text = "";
        }

        private void txt_valor_07_MouseClick(object sender, MouseEventArgs e)
        {
            txt_valor_07.Text = "";
        }

        private void txt_valor_08_MouseClick(object sender, MouseEventArgs e)
        {
            txt_valor_08.Text = "";
        }

        private void txt_valor_09_MouseClick(object sender, MouseEventArgs e)
        {
            txt_valor_09.Text = "";
        }

        private void txt_valor_10_MouseClick(object sender, MouseEventArgs e)
        {
            txt_valor_10.Text = "";
        }

        #endregion

        #region CADASTRO TABELA
        private void bt_buscar_cep_Click(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(txt_cep.Text);
                    txt_end.Text = resultado.end;
                    txt_cidade.Text = resultado.cidade;
                    txt_bairro.Text = resultado.bairro;
                    txt_estado.Text = resultado.uf;
                }
                catch
                {
                    if (String.IsNullOrEmpty(txt_cep.Text))
                    {
                        MessageBox.Show("Você Esqueceu o CEP", "OPS !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_cep.Focus();
                        txt_cep.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("CEP Não Existe", "OPS !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_cep.Focus();
                        txt_cep.Text = "";
                    }                    
                }
            }
        }
        #endregion

        #region BOTÕES CONCLUIR E SAIR
        private void bt_concluir_Click(object sender, EventArgs e)
        {
            CampoVazio();
            // banco de dados

            database database = new database();

            database.openConnection();

            MySqlCommand objCmdCliente = new MySqlCommand("insert into cliente (id, nome, telefone, endereco, numero, cep, bairro, cidade, estado) values (null, ?, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCliente.Parameters.Add("@nome", MySqlDbType.VarChar, 256).Value = txt_nome.Text;
            objCmdCliente.Parameters.Add("@telefone", MySqlDbType.Int32).Value = txt_tel.Text;
            objCmdCliente.Parameters.Add("@endereco", MySqlDbType.VarChar, 256).Value = txt_end.Text;
            objCmdCliente.Parameters.Add("@numero", MySqlDbType.Int32).Value = txt_end_n.Text;
            objCmdCliente.Parameters.Add("@cep", MySqlDbType.Int32).Value = txt_end_n.Text;
            objCmdCliente.Parameters.Add("@bairro", MySqlDbType.VarChar, 256).Value = txt_bairro.Text;
            objCmdCliente.Parameters.Add("@cidade", MySqlDbType.VarChar, 256).Value = txt_cidade.Text;
            objCmdCliente.Parameters.Add("@estado", MySqlDbType.VarChar, 256).Value = txt_estado.Text;

            objCmdCliente.ExecuteNonQuery();
            long idCliente = objCmdCliente.LastInsertedId;

            MySqlCommand objCmdPagamento = new MySqlCommand("insert into pagamento (id, forma_pagamento) value(null, ?)", database.getConnection());

            //objCmdPagamento.Parameters.Add("@forma_pagamento", rad_credito.Checked);

            objCmdPagamento.ExecuteNonQuery();
            long idPagamento = objCmdPagamento.LastInsertedId;

            MySqlCommand objCmdVendas = new MySqlCommand("insert into vendas (id, valor_total, data, cliente_id, pagamento_id) value(null, ?, ?, ?, ?)", database.getConnection());

            objCmdVendas.Parameters.Add("@valor_total", MySqlDbType.VarChar, 256).Value = txt_nome.Text;
            objCmdVendas.Parameters.Add("@data", MySqlDbType.DateTime).Value = txt_tel.Text;
            objCmdVendas.Parameters.Add("@cliente_id", MySqlDbType.Int32).Value = idCliente;
            objCmdVendas.Parameters.Add("@pagamento_id", MySqlDbType.Int32).Value = idPagamento;

            objCmdVendas.ExecuteNonQuery();
            long idVendas = objCmdVendas.LastInsertedId;

            MySqlCommand objCmdProdutos = new MySqlCommand("insert into produtos (id, nome, preco, quantidade ) value(null, ?, ?, ?)", database.getConnection());
            objCmdProdutos.Parameters.Add("@nome", MySqlDbType.VarChar, 256).Value = txt_produto_01.Text;
            objCmdProdutos.Parameters.Add("@preco", MySqlDbType.VarChar, 256).Value = txt_valor_01.Text;
            objCmdProdutos.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = txt_qt_01.Text;

            objCmdProdutos.ExecuteNonQuery();
            long idProdutos = objCmdProdutos.LastInsertedId;

            MySqlCommand objCmdVendasProdutos = new MySqlCommand("insert into vendas_produtos (id_vendas, id_produtos) value(?, ?)", database.getConnection());
            objCmdVendasProdutos.Parameters.Add("@id_pessoa", MySqlDbType.Int32).Value = idVendas;
            objCmdVendasProdutos.Parameters.Add("@id_telefone", MySqlDbType.Int32).Value = idProdutos;

            objCmdVendasProdutos.ExecuteNonQuery();

            database.closeConnection();

        }

        private void LimparTextBox(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if(c is TextBox)
                {
                    ((TextBox)(c)).Text = string.Empty;
                }
            }
        }

        private void LimparTextBox2(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is TextBox)
                {
                    ((TextBox)(c)).Text = "0";
                }
            }
        }

        private void LimparTextBox3(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is TextBox)
                {
                    ((TextBox)(c)).Text = "0,00";
                }
            }
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CampoVazio()
        {

            if (String.IsNullOrEmpty(txt_nome.Text))
            {
                txt_nome.BackColor = Color.FromArgb(255, 139, 139);
            }
            else if (String.IsNullOrEmpty(txt_end.Text))
            {
                txt_end.BackColor = Color.FromArgb(255, 139, 139);
            }
            else if (String.IsNullOrEmpty(txt_end_n.Text))
            {
                txt_end_n.BackColor = Color.FromArgb(255, 139, 139);
            }
            else if(rad_credito.Checked == false && rad_debito.Checked == false && rad_pix.Checked == false)
            {
                MessageBox.Show("Selecione Um Pagamento ", "OPS !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pedido Salvo Com Sucesso ", "Tudo Certo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparTextBox(gp_cad.Controls);
                LimparTextBox2(p_qt.Controls);
                LimparTextBox3(p_valores.Controls);
                LimparTextBox3(this.Controls);
            }

        }

        #endregion

        #region MENU TOP

        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<pedidos>().Count() > 0)
            {
                MessageBox.Show("A Janela Novo Pedido já está aberto", "OPS !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Show();
            }
        }

        private void cardápioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<cardapio>().Count() > 0)
            {
                MessageBox.Show("A Janela Cardápido já está aberto", "OPS !", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                this.Close();

                cardapio ca = new cardapio();
                ca.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region SAIR DO APLICATIVO
        private void pedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja Mesmo Sair ?", "AVISO !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            switch (dr)
            {
                case DialogResult.Yes:
                    e.Cancel = false;
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }


        #endregion

        // VERIFICA SE SOMENTE NUMEROS ESTAO SENDO DIGITADOS
        private void valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.KeyChar = (Char)0;
            }
        }
    }
}
