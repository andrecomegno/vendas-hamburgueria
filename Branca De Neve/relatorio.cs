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
    public partial class relatorio : Form
    {
        public relatorio()
        {
            InitializeComponent();
        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            imprimir im = new imprimir();
            im.ShowDialog();
        }

        private void relatorio_Load(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT v.DATA_VENDA, c.NOME, c.TELEFONE, e.ENDERECO, e.NUMERO, p.PRODUTO, p.QUANTIDADE, p.PRECO, v.VALOR_TOTAL, pa.FORMA_PAGAMENTO FROM CLIENTE c JOIN ENDERECO e ON c.ENDERECO_ID = e.ID JOIN VENDAS v ON v.CLIENTE_ID = c.ID JOIN VENDAS_PRODUTOS vp ON vp.ID_VENDAS = v.ID JOIN PRODUTOS p ON p.ID = vp.ID_PRODUTOS JOIN PAGAMENTO pa ON pa.ID = v.PAGAMENTO_ID", database.getConnection());

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }
            database.closeConnection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_data_Click(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT v.DATA_VENDA, c.NOME, c.TELEFONE, e.ENDERECO, e.NUMERO, p.PRODUTO, p.QUANTIDADE, p.PRECO, v.VALOR_TOTAL, pa.FORMA_PAGAMENTO FROM CLIENTE c JOIN ENDERECO e ON c.ENDERECO_ID = e.ID JOIN VENDAS v ON v.CLIENTE_ID = c.ID JOIN VENDAS_PRODUTOS vp ON vp.ID_VENDAS = v.ID JOIN PRODUTOS p ON p.ID = vp.ID_PRODUTOS JOIN PAGAMENTO pa ON pa.ID = v.PAGAMENTO_ID WHERE v.DATA_VENDA BETWEEN '2022-02-01' and '2022-02-01' ", database.getConnection());

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
