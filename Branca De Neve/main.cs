using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branca_De_Neve
{
    public partial class Branca_Neve : Form
    {
        public Branca_Neve()
        {
            InitializeComponent();            
        }

        #region BOTÕES PEDIR E CARDÁPIO

        private void bt_pedido_Click(object sender, EventArgs e)
        {
            pedidos pe = new pedidos();
            pe.Show();
        }

        private void bt_cardapio_Click(object sender, EventArgs e)
        {
            cardapio ca = new cardapio();
            ca.Show();
        }

        private void bt_relatorio_Click(object sender, EventArgs e)
        {
            relatorio re = new relatorio();
            re.Show();
        }

        #endregion

        #region MENU DO APP

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pedidos pe = new pedidos();
            pe.Show();
        }

        private void cardápioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cardapio ca = new cardapio();
            ca.Show();
        }

        #endregion

        private void Branca_Neve_FormClosing(object sender, FormClosingEventArgs e)
        {
            // sair do programa
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
