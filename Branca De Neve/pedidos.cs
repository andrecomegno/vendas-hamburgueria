﻿using System;
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
        string pagamentos = string.Empty;

        public pedidos()
        {
            InitializeComponent();
        }

        #region MENU

        // NOVO PEDIDO
        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<pedidos>().Count() > 0)
            {
                MessageBox.Show("A Janela Novo Pedido já está aberta", "OPS !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.ShowDialog();
            }
        }

        // CARDÁPIO
        private void cardápioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<cardapio>().Count() > 0)
            {
                MessageBox.Show("A Janela Cardápido já está aberta", "OPS !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();

                cardapio ca = new cardapio();
                ca.ShowDialog();
            }
        }

        // RELATORIO
        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<relatorio>().Count() > 0)
            {
                MessageBox.Show("A Janela Relatório já está aberta", "OPS !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();

                relatorio re = new relatorio();
                re.ShowDialog();
            }
        }

        // AJUDA
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/andrecomegno");
        }

        // SAIR
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region CADASTRO

        //BUSCAR CEP
        private void bt_buscar_cep_Click(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(txt_cep.Text);

                    txt_cep.Text.Replace("-", "");
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

        #region PAGAMENTO
        //PAGAMENTOS
        private void rad_debito_CheckedChanged(object sender, EventArgs e)
        {
            pagamentos = "Debito";
        }

        private void rad_credito_CheckedChanged(object sender, EventArgs e)
        {
            pagamentos = "Credito";
        }

        private void rad_pix_CheckedChanged(object sender, EventArgs e)
        {
            pagamentos = "PIX";
        }

        private void rd_dinheiro_CheckedChanged(object sender, EventArgs e)
        {
            pagamentos = "Dinheiro";
        }
        #endregion

        #region PEDIDO TABELA

        // QUANTIDADE DE PRODUTO
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

        // VALOR DO PRODUTO
        private void txt_valor_01_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_qt_01.Text == "0")
                {
                    txt_qt_01.Text = "1";
                }

                double res = Convert.ToDouble(txt_qt_01.Text) * Convert.ToDouble(txt_valor_01.Text);

                txt_total_01.Text = res.ToString();

                TotalPagar();
            }
            catch
            {
                MessageBox.Show(" Código de erro interno ", "ERRO FATAL");
            }
            finally
            {                      
                txt_total_01.Text = Convert.ToDouble(txt_total_01.Text).ToString("N2");
            }   
        }

        private void txt_valor_02_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_qt_02.Text == "0")
                {
                    txt_qt_02.Text = "1";
                }

                double res = Convert.ToDouble(txt_qt_02.Text) * Convert.ToDouble(txt_valor_02.Text);

                txt_total_02.Text = res.ToString();

                TotalPagar();
            }
            catch
            {
                MessageBox.Show(" Código de erro interno ", "ERRO FATAL");
            }
            finally
            {
                txt_total_02.Text = Convert.ToDouble(txt_total_02.Text).ToString("N2");
            }
        }

        private void txt_valor_03_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_qt_03.Text == "0")
                {
                    txt_qt_03.Text = "1";
                }

                double res = Convert.ToDouble(txt_qt_03.Text) * Convert.ToDouble(txt_valor_03.Text);

                txt_total_03.Text = res.ToString();

                TotalPagar();
            }
            catch
            {
                MessageBox.Show(" Código de erro interno ", "ERRO FATAL");
            }
            finally
            {
                txt_total_03.Text = Convert.ToDouble(txt_total_03.Text).ToString("N2");
            }

        }

        private void txt_valor_04_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_qt_04.Text == "0")
                {
                    txt_qt_04.Text = "1";
                }

                double res = Convert.ToDouble(txt_qt_04.Text) * Convert.ToDouble(txt_valor_04.Text);

                txt_total_04.Text = res.ToString();

                TotalPagar();
            }
            catch
            {
                MessageBox.Show(" Código de erro interno ", "ERRO FATAL");
            }
            finally
            {
                txt_total_04.Text = Convert.ToDouble(txt_total_04.Text).ToString("N2");
            }

        }

        private void txt_valor_05_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_qt_05.Text == "0")
                {
                    txt_qt_05.Text = "1";
                }

                double res = Convert.ToDouble(txt_qt_05.Text) * Convert.ToDouble(txt_valor_05.Text);

                txt_total_05.Text = res.ToString();

                TotalPagar();
            }
            catch
            {
                MessageBox.Show(" Código de erro interno ", "ERRO FATAL");
            }
            finally
            {
                txt_total_05.Text = Convert.ToDouble(txt_total_05.Text).ToString("N2");
            }

        }

        private void txt_valor_06_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txt_qt_06.Text == "0")
                {
                    txt_qt_06.Text = "1";
                }

                double res = Convert.ToDouble(txt_qt_06.Text) * Convert.ToDouble(txt_valor_06.Text);

                txt_total_06.Text = res.ToString();

                TotalPagar();
            }
            catch
            {
                MessageBox.Show(" Código de erro interno ", "ERRO FATAL");
            }
            finally
            {
                txt_total_06.Text = Convert.ToDouble(txt_total_06.Text).ToString("N2");
            }

        }

        private void txt_valor_07_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_qt_07.Text == "0")
                {
                    txt_qt_07.Text = "1";
                }

                double res = Convert.ToDouble(txt_qt_07.Text) * Convert.ToDouble(txt_valor_07.Text);

                txt_total_07.Text = res.ToString();

                TotalPagar();
            }
            catch
            {
                MessageBox.Show(" Código de erro interno ", "ERRO FATAL");
            }
            finally
            {
                txt_total_07.Text = Convert.ToDouble(txt_total_07.Text).ToString("N2");
            }
        }

        private void txt_valor_08_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_qt_08.Text == "0")
                {
                    txt_qt_08.Text = "1";
                }

                double res = Convert.ToDouble(txt_qt_08.Text) * Convert.ToDouble(txt_valor_08.Text);

                txt_total_08.Text = res.ToString();

                TotalPagar();
            }
            catch
            {
                MessageBox.Show(" Código de erro interno ", "ERRO FATAL");
            }
            finally
            {
                txt_total_08.Text = Convert.ToDouble(txt_total_08.Text).ToString("N2");
            }

        }

        private void txt_valor_09_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_qt_09.Text == "0")
                {
                    txt_qt_09.Text = "1";
                }

                double res = Convert.ToDouble(txt_qt_09.Text) * Convert.ToDouble(txt_valor_09.Text);

                txt_total_09.Text = res.ToString();

                TotalPagar();
            }
            catch
            {
                MessageBox.Show(" Código de erro interno ", "ERRO FATAL");
            }
            finally
            {
                txt_total_09.Text = Convert.ToDouble(txt_total_09.Text).ToString("N2");
            }

        }

        private void txt_valor_10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_qt_10.Text == "0")
                {
                    txt_qt_10.Text = "1";
                }

                double res = Convert.ToDouble(txt_qt_10.Text) * Convert.ToDouble(txt_valor_10.Text);

                txt_total_10.Text = res.ToString();

                TotalPagar();
            }
            catch (Exception)
            {
                MessageBox.Show(" Código de erro interno ", "ERRO FATAL");
            }
            finally
            {
                txt_total_10.Text = Convert.ToDouble(txt_total_10.Text).ToString("N2");
            }

        }

        // SOMA DO VALOR TOTAL
        private void TotalPagar()
        {
            try
            {
                double res = Convert.ToDouble(txt_total_01.Text) + Convert.ToDouble(txt_total_02.Text) + Convert.ToDouble(txt_total_03.Text) +
                    Convert.ToDouble(txt_total_04.Text) + Convert.ToDouble(txt_total_05.Text) + Convert.ToDouble(txt_total_06.Text) +
                    Convert.ToDouble(txt_total_07.Text) + Convert.ToDouble(txt_total_08.Text) + Convert.ToDouble(txt_total_09.Text) +
                    Convert.ToDouble(txt_total_10.Text);

                txt_total_pagar.Text = res.ToString();
            }
            catch
            {
                MessageBox.Show(" Código de erro interno ", "ERRO FATAL");
            }
            finally
            {
                txt_total_pagar.Text = Convert.ToDouble(txt_total_pagar.Text).ToString("C");                
            }            
        }

        // SELECIONAR PRODUTOS
        private void txt_produto_01_SelectedIndexChanged(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select * from cardapio where nome ='" + txt_produto_01.Text + "'", database.getConnection());
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string preco = (string)rd["preco"].ToString();
                txt_valor_01.Text = preco;
            }

            database.closeConnection();
        }

        private void txt_produto_02_SelectedIndexChanged(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select * from cardapio where nome ='" + txt_produto_02.Text + "'", database.getConnection());
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string preco = (string)rd["preco"].ToString();
                txt_valor_02.Text = preco;
            }

            database.closeConnection();
        }

        private void txt_produto_03_SelectedIndexChanged(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select * from cardapio where nome ='" + txt_produto_03.Text + "'", database.getConnection());
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string preco = (string)rd["preco"].ToString();
                txt_valor_03.Text = preco;
            }

            database.closeConnection();
        }

        private void txt_produto_04_SelectedIndexChanged(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select * from cardapio where nome ='" + txt_produto_04.Text + "'", database.getConnection());
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string preco = (string)rd["preco"].ToString();
                txt_valor_04.Text = preco;
            }

            database.closeConnection();
        }

        private void txt_produto_05_SelectedIndexChanged(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select * from cardapio where nome ='" + txt_produto_05.Text + "'", database.getConnection());
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string preco = (string)rd["preco"].ToString();
                txt_valor_05.Text = preco;
            }

            database.closeConnection();
        }

        private void txt_produto_06_SelectedIndexChanged(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select * from cardapio where nome ='" + txt_produto_06.Text + "'", database.getConnection());
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string preco = (string)rd["preco"].ToString();
                txt_valor_06.Text = preco;
            }

            database.closeConnection();
        }

        private void txt_produto_07_SelectedIndexChanged(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select * from cardapio where nome ='" + txt_produto_07.Text + "'", database.getConnection());
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string preco = (string)rd["preco"].ToString();
                txt_valor_07.Text = preco;
            }

            database.closeConnection();
        }

        private void txt_produto_08_SelectedIndexChanged(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select * from cardapio where nome ='" + txt_produto_08.Text + "'", database.getConnection());
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string preco = (string)rd["preco"].ToString();
                txt_valor_08.Text = preco;
            }

            database.closeConnection();
        }

        private void txt_produto_09_SelectedIndexChanged(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select * from cardapio where nome ='" + txt_produto_09.Text + "'", database.getConnection());
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string preco = (string)rd["preco"].ToString();
                txt_valor_09.Text = preco;
            }

            database.closeConnection();
        }

        private void txt_produto_10_SelectedIndexChanged(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select * from cardapio where nome ='" + txt_produto_10.Text + "'", database.getConnection());
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string preco = (string)rd["preco"].ToString();
                txt_valor_10.Text = preco;
            }

            database.closeConnection();
        }

        // TABELA CARDAPIO
        private void Cardapio()
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select nome from cardapio", database.getConnection());
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                txt_produto_01.Items.Add(dr["nome"].ToString());
                txt_produto_02.Items.Add(dr["nome"].ToString());
                txt_produto_03.Items.Add(dr["nome"].ToString());
                txt_produto_04.Items.Add(dr["nome"].ToString());
                txt_produto_05.Items.Add(dr["nome"].ToString());
                txt_produto_06.Items.Add(dr["nome"].ToString());
                txt_produto_07.Items.Add(dr["nome"].ToString());
                txt_produto_08.Items.Add(dr["nome"].ToString());
                txt_produto_09.Items.Add(dr["nome"].ToString());
                txt_produto_10.Items.Add(dr["nome"].ToString());
            }

            database.closeConnection();
        }

        #endregion

        #region BOTAO

        // CONCLUIR PEDIDO

        private void VerificarConcluir()
        {
            // VERIFICA SE TODOS OS COMPOS ESTAO PREENCHIDOS
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
            else if (rad_credito.Checked == false && rad_debito.Checked == false &&
                rad_pix.Checked == false && rad_dinheiro.Checked == false)
            {
                MessageBox.Show("Selecione Um Pagamento ", "OPS !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Pedido();

                DialogResult dr = MessageBox.Show("Pedido Salvo Com Sucesso !", "Obrigado !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.OK:
                        LimparFormulario();
                        break;
                    default:
                        break;
                }
            }

        }

        // BANCO DE DADOS 
        private void Pedido()
        {
            database database = new database();

            database.openConnection();

            // INSERT TABELA ENDERECO
            MySqlCommand objCmdEndereco = new MySqlCommand("insert into endereco (id, endereco, numero, cep, bairro, cidade, estado) values (null, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdEndereco.Parameters.Add("@endereco", MySqlDbType.VarChar, 150).Value = txt_end.Text;
            objCmdEndereco.Parameters.Add("@numero", MySqlDbType.VarChar, 20).Value = txt_end_n.Text;
            objCmdEndereco.Parameters.Add("@cep", MySqlDbType.VarChar, 10).Value = txt_cep.Text;
            objCmdEndereco.Parameters.Add("@bairro", MySqlDbType.VarChar, 50).Value = txt_bairro.Text;
            objCmdEndereco.Parameters.Add("@cidade", MySqlDbType.VarChar, 50).Value = txt_cidade.Text;
            objCmdEndereco.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = txt_estado.Text;

            objCmdEndereco.ExecuteNonQuery();
            long idEndereco = objCmdEndereco.LastInsertedId;

            // INSERT TABELA CLIENTE
            MySqlCommand objCmdCliente = new MySqlCommand("insert into cliente (id, nome, telefone, endereco_id) values (null, ?, ?, ?)", database.getConnection());

            objCmdCliente.Parameters.Add("@nome", MySqlDbType.VarChar, 256).Value = txt_nome.Text;
            objCmdCliente.Parameters.Add("@telefone", MySqlDbType.VarChar, 256).Value = txt_tel.Text;
            objCmdCliente.Parameters.Add("@endereco_id", MySqlDbType.VarChar, 256).Value = idEndereco;

            objCmdCliente.ExecuteNonQuery();
            long idCliente = objCmdCliente.LastInsertedId;

            // INSERT TABELA PAGAMENTO
            MySqlCommand objCmdPagamento = new MySqlCommand("insert into pagamento (id, forma_pagamento) value(null, ?)", database.getConnection());

            objCmdPagamento.Parameters.Add("@forma_pagamento", MySqlDbType.VarChar, 256).Value = pagamentos;

            objCmdPagamento.ExecuteNonQuery();
            long idPagamento = objCmdPagamento.LastInsertedId;

            // INSERT TABELA VENDAS
            MySqlCommand objCmdVendas = new MySqlCommand("insert into vendas (id, total, data_venda, cliente_id, pagamento_id) value(null, ?, ?, ?, ?)", database.getConnection());

            objCmdVendas.Parameters.Add("@total", MySqlDbType.Decimal).Value = txt_total_pagar.Text.Replace("R$", "");
            objCmdVendas.Parameters.Add("@data_venda", MySqlDbType.Date).Value = DateTime.Now;
            objCmdVendas.Parameters.Add("@cliente_id", MySqlDbType.Int32).Value = idCliente;
            objCmdVendas.Parameters.Add("@pagamento_id", MySqlDbType.Int32).Value = idPagamento;

            objCmdVendas.ExecuteNonQuery();
            long idVendas = objCmdVendas.LastInsertedId;

            // INSERT TABELA PRODUTOS
            MySqlCommand objCmdProdutos = new MySqlCommand("insert into produtos (id, produto, preco_uni, quantidade, preco_total) value (null, ?, ?, ?, ?)", database.getConnection());

            objCmdProdutos.Parameters.Add("@produto", MySqlDbType.VarChar, 256).Value = txt_produto_01.Text;
            objCmdProdutos.Parameters.Add("@preco_uni", MySqlDbType.Decimal).Value = txt_valor_01.Text;
            objCmdProdutos.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = txt_qt_01.Text;
            objCmdProdutos.Parameters.Add("@preco_total", MySqlDbType.Decimal).Value = txt_total_01.Text;

            objCmdProdutos.ExecuteNonQuery();
            long idProdutos = objCmdProdutos.LastInsertedId;

            // INSERT TABELA VENDAS_PRODUTOS
            MySqlCommand objCmdVendasProdutos = new MySqlCommand("insert into vendas_produtos (id_vendas, id_produtos) value(?, ?)", database.getConnection());

            objCmdVendasProdutos.Parameters.Add("@id_vendas", MySqlDbType.Int32).Value = idVendas;
            objCmdVendasProdutos.Parameters.Add("@id_produtos", MySqlDbType.Int32).Value = idProdutos;

            objCmdVendasProdutos.ExecuteNonQuery();

            database.closeConnection();
        }

        private void bt_concluir_Click(object sender, EventArgs e)
        {
            VerificarConcluir();
        }

        // LIMPAR FORMULARIO        
        private void LimparFormulario()
        {
            LimparTextBox(gp_cad.Controls);
            LimparTextBox2(p_qt.Controls);
            LimparTextBox3(p_valores.Controls);
            LimparTextBox3(this.Controls);
            LimparTextBox4(gp_pedido.Controls);
            LimparTextBox5(gp_pag.Controls);
        }

        private void LimparTextBox(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if(c is TextBox)
                {
                    ((TextBox)(c)).Text = string.Empty;
                }

                if(c is MaskedTextBox)
                {
                    ((MaskedTextBox)(c)).Text = string.Empty;
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

        private void LimparTextBox4(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)(c)).SelectedIndex = -1;
                }
            }
        }

        private void LimparTextBox5(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)(c)).Checked = false;
                }
            }
        }

        // SAIR
        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        // JANELA PEDIDO
        private void pedidos_Load(object sender, EventArgs e)
        {
            Cardapio();
        }

        // VERIFICA SE SOMENTE NUMEROS ESTAO SENDO DIGITADOS
        private void valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.KeyChar = (Char)0;
            }
        }

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
    }
}
