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
using Branca_De_Neve.Tabela;
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
            var dt = gerarRelatorio();
            using (var im = new imprimir(dt))
            {
                im.ShowDialog();
            }     
        }

        private DataTable gerarRelatorio()
        {
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(Int32));
            dt.Columns.Add("DATA_VENDA", typeof(DateTime));
            dt.Columns.Add("NOME", typeof(string));
            dt.Columns.Add("TELEFONE", typeof(string));
            dt.Columns.Add("ENDERECO", typeof(string));
            dt.Columns.Add("NUMERO", typeof(Int32));
            dt.Columns.Add("PRODUTO", typeof(string));
            dt.Columns.Add("PRECO_UNI", typeof(decimal));
            dt.Columns.Add("QUANTIDADE", typeof(Int32));
            dt.Columns.Add("PRECO_TOTAL", typeof(decimal));
            dt.Columns.Add("TOTAL", typeof(decimal));
            dt.Columns.Add("FORMA_PAGAMENTO", typeof(string));

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                dt.Rows.Add
                (
                    item.Cells["ID"].Value.ToString(),
                    item.Cells["DATA_VENDA"].Value.ToString(),
                    item.Cells["NOME"].Value.ToString(),
                    item.Cells["TELEFONE"].Value.ToString(),
                    item.Cells["ENDERECO"].Value.ToString(),
                    item.Cells["NUMERO"].Value.ToString(),
                    item.Cells["PRODUTO"].Value.ToString(),
                    item.Cells["PRECO_UNI"].Value.ToString(),
                    item.Cells["QUANTIDADE"].Value.ToString(),
                    item.Cells["PRECO_TOTAL"].Value.ToString(),
                    item.Cells["TOTAL"].Value.ToString(),
                    item.Cells["FORMA_PAGAMENTO"].Value.ToString()
                );
            }
            return dt;

        }

        private void bt_data_Click(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT c.ID, v.DATA_VENDA, c.NOME, c.TELEFONE, e.ENDERECO, e.NUMERO, p.PRODUTO, p.QUANTIDADE, p.PRECO_UNI, p.PRECO_TOTAL, v.TOTAL, pa.FORMA_PAGAMENTO FROM CLIENTE c JOIN ENDERECO e ON c.ENDERECO_ID = e.ID JOIN VENDAS v ON v.CLIENTE_ID = c.ID JOIN VENDAS_PRODUTOS vp ON vp.ID_VENDAS = v.ID JOIN PRODUTOS p ON p.ID = vp.ID_PRODUTOS JOIN PAGAMENTO pa ON pa.ID = v.PAGAMENTO_ID WHERE v.DATA_VENDA BETWEEN '"+ dataDe.Value.ToString("yyyy-MM-dd") +"' and '"+ dataPara.Value.ToString("yyyy-MM-dd") + "' ", database.getConnection());

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            database.closeConnection();
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT c.ID, v.DATA_VENDA, c.NOME, c.TELEFONE, e.ENDERECO, e.NUMERO, p.PRODUTO, p.QUANTIDADE, p.PRECO_UNI, p.PRECO_TOTAL, v.TOTAL, pa.FORMA_PAGAMENTO FROM CLIENTE c JOIN ENDERECO e ON c.ENDERECO_ID = e.ID JOIN VENDAS v ON v.CLIENTE_ID = c.ID JOIN VENDAS_PRODUTOS vp ON vp.ID_VENDAS = v.ID JOIN PRODUTOS p ON p.ID = vp.ID_PRODUTOS JOIN PAGAMENTO pa ON pa.ID = v.PAGAMENTO_ID WHERE NOME LIKE @nome '%'", database.getConnection());
            cmd.Parameters.AddWithValue("@nome", txt_pesquisa.Text);

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            database.closeConnection();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            }
        }
    }
}
