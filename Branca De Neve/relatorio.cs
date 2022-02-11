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
using Dapper;

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


        }

        private void bt_data_Click(object sender, EventArgs e)
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT c.ID, v.DATA_VENDA, c.NOME, c.TELEFONE, e.ENDERECO, e.NUMERO, p.PRODUTO, p.QUANTIDADE, p.PRECO, v.VALOR_TOTAL, pa.FORMA_PAGAMENTO FROM CLIENTE c JOIN ENDERECO e ON c.ENDERECO_ID = e.ID JOIN VENDAS v ON v.CLIENTE_ID = c.ID JOIN VENDAS_PRODUTOS vp ON vp.ID_VENDAS = v.ID JOIN PRODUTOS p ON p.ID = vp.ID_PRODUTOS JOIN PAGAMENTO pa ON pa.ID = v.PAGAMENTO_ID WHERE v.DATA_VENDA BETWEEN '"+ dataDe.Value.ToString("yyyy-MM-dd") +"' and '"+ dataPara.Value.ToString("yyyy-MM-dd") + "' ", database.getConnection());

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

            MySqlCommand cmd = new MySqlCommand("SELECT c.ID, v.DATA_VENDA, c.NOME, c.TELEFONE, e.ENDERECO, e.NUMERO, p.PRODUTO, p.QUANTIDADE, p.PRECO, v.VALOR_TOTAL, pa.FORMA_PAGAMENTO FROM CLIENTE c JOIN ENDERECO e ON c.ENDERECO_ID = e.ID JOIN VENDAS v ON v.CLIENTE_ID = c.ID JOIN VENDAS_PRODUTOS vp ON vp.ID_VENDAS = v.ID JOIN PRODUTOS p ON p.ID = vp.ID_PRODUTOS JOIN PAGAMENTO pa ON pa.ID = v.PAGAMENTO_ID WHERE NOME LIKE @nome '%'", database.getConnection());
            cmd.Parameters.AddWithValue("@nome", txt_pesquisa.Text);

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
