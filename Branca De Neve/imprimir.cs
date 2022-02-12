using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branca_De_Neve.Tabela;
using System.Windows.Forms;
using Branca_De_Neve.Script;
using MySql.Data.MySqlClient;

namespace Branca_De_Neve
{
    public partial class imprimir : Form
    {
        DataTable dt = new DataTable();

        public imprimir(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void imprimir_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetRelatorio", dt);            
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);

            this.reportViewer1.RefreshReport();
        }
    }
}
