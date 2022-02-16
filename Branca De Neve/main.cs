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
                cardapio ca = new cardapio();
                ca.Show();
            }
        }

        // RELATORIO
        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<cardapio>().Count() > 0)
            {
                MessageBox.Show("A Janela Relatório já está aberta", "OPS !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
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

        private void bt_pedido_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<pedidos>().Count() > 0)
            {
                MessageBox.Show("A Janela Novo Pedido já está aberta", "OPS !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pedidos pe = new pedidos();
                pe.Show();
            }
        }

        private void bt_cardapio_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<cardapio>().Count() > 0)
            {
                MessageBox.Show("A Janela Cardápido já está aberta", "OPS !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cardapio ca = new cardapio();
                ca.Show();
            }
        }

        private void bt_relatorio_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<relatorio>().Count() > 0)
            {
                MessageBox.Show("A Janela Relatório já está aberta", "OPS !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                relatorio re = new relatorio();
                re.Show();
            }
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
