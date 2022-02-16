using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branca_De_Neve.Script;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Branca_De_Neve
{
    public partial class cardapio : Form
    {
        string id = "";

        public cardapio()
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
                this.Close();

                pedidos pe = new pedidos();
                pe.Show();
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
                this.Show();
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
                re.Show();
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

        #region BOTAO

        // NOVO PEDIDO
        private void bt_novo_Click(object sender, EventArgs e)
        {
            bt_excluir.Enabled = false;
            bt_excluir.BackColor = Color.DarkGray;

            bt_editar.Enabled = false;
            bt_editar.BackColor = Color.DarkGray;

            bt_add.Enabled = true;
            bt_add.BackColor = Color.MediumSeaGreen;

            bt_cancelar.Enabled = true;
            bt_cancelar.BackColor = Color.Red;

            dataGridView1.Enabled = false;
            p_novo.Enabled = true;
            LimparTextBox(p_novo.Controls);
        }

        // CANCELAR
        private void bt_cancelar_Click(object sender, EventArgs e)
        {

            txt_produto.BackColor = Color.White;
            txt_preco.BackColor = Color.White;
            txt_tipo.BackColor = Color.White;

            bt_cancelar.Enabled = false;
            bt_cancelar.BackColor = Color.DarkGray;

            bt_excluir.Enabled = false;
            bt_excluir.BackColor = Color.DarkGray;

            bt_editar.Enabled = false;
            bt_editar.BackColor = Color.DarkGray;

            bt_salvar.Enabled = false;
            bt_salvar.BackColor = Color.DarkGray;

            bt_add.Enabled = false;
            bt_add.BackColor = Color.DarkGray;

            dataGridView1.Enabled = true;
            p_novo.Enabled = false;
            LimparTextBox(p_novo.Controls);

        }

        // EXCLUIR
        private void bt_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Tem Certeza Que Deseja Excluir ?", "AVISO !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        Excluir();
                        break;
                    case DialogResult.No:
                        
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Código de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                dataGridView();
            }
        }

        private void Excluir()
        {
            try
            {
                database database = new database();
                database.openConnection();

                MySqlCommand cmd = new MySqlCommand("delete from cardapio where ID=@id", database.getConnection());
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                database.closeConnection();
            }
            catch
            {
                MessageBox.Show("Código de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                BTexcluir();
            }            
        }

        private void BTexcluir()
        {
            bt_add.Enabled = false;
            bt_add.BackColor = Color.DarkGray;

            bt_editar.Enabled = false;
            bt_editar.BackColor = Color.DarkGray;

            bt_excluir.Enabled = false;
            bt_excluir.BackColor = Color.DarkGray;

            p_novo.Enabled = false;
            LimparTextBox(p_novo.Controls);
        }

        // ADICIONAR

        private void bt_add_Click(object sender, EventArgs e)
        {
            verificarNovoProduto();
        }

        // VERIFICA SE TODOS OS COMPOS ESTAO PREENCHIDOS
        private void verificarNovoProduto()
        {            
            if (String.IsNullOrEmpty(txt_produto.Text))
            {
                txt_produto.BackColor = Color.FromArgb(255, 139, 139);
            }
            else if (String.IsNullOrEmpty(txt_preco.Text))
            {
                txt_preco.BackColor = Color.FromArgb(255, 139, 139);
            }
            else if (String.IsNullOrEmpty(txt_tipo.Text))
            {
                txt_tipo.BackColor = Color.FromArgb(255, 139, 139);
            }
            else
            {
                try
                {
                    addNovoProduto();

                    DialogResult dr = MessageBox.Show("Novo Produto Salvo Com Sucesso !", "Novo Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    LimparTextBox(p_novo.Controls);
                    dataGridView();
                    BTadd();
                }
            }
        }

        // BOTAO ADD, EDITAR, EXCLUIR, DESABILITAR
        private void BTadd()
        {
            bt_add.Enabled = false;
            bt_add.BackColor = Color.DarkGray;

            bt_editar.Enabled = false;
            bt_editar.BackColor = Color.DarkGray;

            bt_excluir.Enabled = false;
            bt_excluir.BackColor = Color.DarkGray;

            bt_cancelar.Enabled = false;
            bt_cancelar.BackColor = Color.DarkGray;

            p_novo.Enabled = false;
            dataGridView1.Enabled = true;
        }

        // INSERT ADCIONAR NOVO PRODUTO
        private void addNovoProduto()
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("insert into cardapio (id, nome, preco, tipo) values (null, ?, ?, ?)", database.getConnection());

            cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 256).Value = txt_produto.Text;
            cmd.Parameters.Add("@preco", MySqlDbType.Decimal).Value = txt_preco.Text;
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar, 256).Value = txt_tipo.Text;

            cmd.ExecuteNonQuery();

            database.closeConnection();
        }

        private void txt_produto_MouseClick(object sender, MouseEventArgs e)
        {
            txt_produto.BackColor = Color.White;
        }

        private void txt_preco_MouseClick(object sender, MouseEventArgs e)
        {
            txt_preco.BackColor = Color.White;
        }

        private void txt_tipo_MouseClick(object sender, MouseEventArgs e)
        {
            txt_tipo.BackColor = Color.White;
        }

        // SALVAR E EDITAR
        private void bt_salvar_Click(object sender, EventArgs e)
        {
            verificarSalvar();
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            bt_salvar.Enabled = true;
            bt_salvar.BackColor = Color.Orange;

            bt_editar.Enabled = false;
            bt_editar.BackColor = Color.DarkGray;

            bt_excluir.Enabled = false;
            bt_excluir.BackColor = Color.DarkGray;

            bt_cancelar.Enabled = true;
            bt_cancelar.BackColor = Color.Red;

            p_novo.Enabled = true;
            dataGridView1.Enabled = false;
        }

        private void EditarSalvar()
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("update cardapio set nome=@nome, preco=@preco, tipo=@tipo WHERE (id=@id)", database.getConnection());

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 256).Value = txt_produto.Text;
            cmd.Parameters.Add("@preco", MySqlDbType.Decimal).Value = txt_preco.Text;
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar, 256).Value = txt_tipo.Text;

            cmd.ExecuteNonQuery();
            database.closeConnection();
        }

        private void BTSalvar()
        {
            p_novo.Enabled = false;

            bt_salvar.Enabled = false;
            bt_salvar.BackColor = Color.DarkGray;

            bt_excluir.Enabled = false;
            bt_excluir.BackColor = Color.DarkGray;

            bt_cancelar.Enabled = false;
            bt_cancelar.BackColor = Color.DarkGray;

            dataGridView1.Enabled = true;
            p_novo.Enabled = true;
            LimparTextBox(p_novo.Controls);
        }

        private void verificarSalvar()
        {
            if (String.IsNullOrEmpty(txt_produto.Text))
            {
                txt_produto.BackColor = Color.FromArgb(255, 139, 139);
            }
            else if (String.IsNullOrEmpty(txt_preco.Text))
            {
                txt_preco.BackColor = Color.FromArgb(255, 139, 139);
            }
            else if (String.IsNullOrEmpty(txt_tipo.Text))
            {
                txt_tipo.BackColor = Color.FromArgb(255, 139, 139);
            }
            else
            {
                try
                {
                    EditarSalvar();
                    DialogResult dr = MessageBox.Show("Salvo Com Sucesso !", "Editar Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    LimparTextBox(p_novo.Controls);
                    BTSalvar();
                    dataGridView();
                }
            }
        }

        // PESQUISAR
        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select id, nome, preco, tipo from cardapio where nome like @nome '%'", database.getConnection());
            cmd.Parameters.AddWithValue("@nome", txt_pesquisar.Text);

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            database.closeConnection();

        }        

        // SAIR
        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        // TABELA CARDAPIO
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;

                id = dr["ID"].ToString();
                txt_produto.Text = dr["NOME"].ToString();
                txt_preco.Text = dr["PRECO"].ToString();
                txt_tipo.Text = dr["TIPO"].ToString();

                bt_add.Enabled = false;
                bt_add.BackColor = Color.DarkGray;

                bt_excluir.Enabled = true;
                bt_excluir.BackColor = Color.LightCoral;

                bt_editar.Enabled = true;
                bt_editar.BackColor = Color.MediumSlateBlue;

                bt_cancelar.Enabled = true;
                bt_cancelar.BackColor = Color.Red;
            }
        }

        private void cardapio_Load(object sender, EventArgs e)
        {
            dataGridView();

            bt_excluir.Enabled = false;
            bt_excluir.BackColor = Color.DarkGray;

            bt_add.Enabled = false;
            bt_add.BackColor = Color.DarkGray;

            bt_editar.Enabled = false;
            bt_editar.BackColor = Color.DarkGray;

            bt_salvar.Enabled = false;
            bt_salvar.BackColor = Color.DarkGray;

            bt_cancelar.Enabled = false;
            bt_cancelar.BackColor = Color.DarkGray;
        }

        // DATA BASE
        private void dataGridView()
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select * from cardapio", database.getConnection());

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }

            database.closeConnection();
        }

        // LIMPAR FORMULARIO
        private void LimparTextBox(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is TextBox)
                {
                    ((TextBox)(c)).Text = string.Empty;
                }
            }

            foreach (Control c in control)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)(c)).SelectedIndex = -1;
                }
            }
        }
    }
}
