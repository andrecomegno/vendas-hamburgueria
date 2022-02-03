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

        #region BOTÕES PEDIDO E SAIR

        private void bt_pedido_Click(object sender, EventArgs e)
        {
            this.Close();

            pedidos pe = new pedidos();
            pe.Show();            
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region MENU APP

        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<pedidos>().Count() > 0)
            {
               MessageBox.Show("A Janela Novo Pedido já está aberto", "OPS !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();

                pedidos pe = new pedidos();
                pe.Show();
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
                this.Show();
            }                
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void cardapio_FormClosing(object sender, FormClosingEventArgs e)
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

        private void bt_add_Click(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            // ADICIONAR NOVO PRODUTO NO CATALOGO 

            database.closeConnection();
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            // ADICIONAR EDITAR O PRODUTO 

            database.closeConnection();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            // EXCLUIR NOVO PRODUTO 

            database.closeConnection();
        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select * from cardapio where nome like @nome '%' ", database.getConnection());
            cmd.Parameters.AddWithValue("@nome", txt_produto.Text);

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            database.closeConnection();
        }

        private void cardapio_Load(object sender, EventArgs e)
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
    }
}
