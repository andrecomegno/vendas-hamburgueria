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

        private void cardapio_Load(object sender, EventArgs e)
        {
            database database = new database();

            database.openConnection();
            // TODO: esta linha de código carrega dados na tabela 'brancadeneveDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtosTableAdapter.Fill(this.brancadeneveDataSet.produtos);
            database.closeConnection();
        }
    }
}
