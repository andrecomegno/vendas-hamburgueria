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
    public partial class pedidos : Form
    {
        public pedidos()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            txt_valor_01.Text = Convert.ToDouble(txt_valor_01.Text).ToString("F");
            txt_valor_02.Text = Convert.ToDouble(txt_valor_02.Text).ToString("F");
            txt_valor_03.Text = Convert.ToDouble(txt_valor_03.Text).ToString("F");
            txt_valor_04.Text = Convert.ToDouble(txt_valor_04.Text).ToString("F");
            txt_valor_05.Text = Convert.ToDouble(txt_valor_05.Text).ToString("F");
            txt_valor_06.Text = Convert.ToDouble(txt_valor_06.Text).ToString("F");
            txt_valor_07.Text = Convert.ToDouble(txt_valor_07.Text).ToString("F");
            txt_valor_08.Text = Convert.ToDouble(txt_valor_08.Text).ToString("F");
            txt_valor_09.Text = Convert.ToDouble(txt_valor_09.Text).ToString("F");
            txt_valor_10.Text = Convert.ToDouble(txt_valor_10.Text).ToString("F");

            txt_total_01.Text = Convert.ToDouble(txt_total_01.Text).ToString("F");
            txt_total_02.Text = Convert.ToDouble(txt_total_02.Text).ToString("F");
            txt_total_03.Text = Convert.ToDouble(txt_total_03.Text).ToString("F");
            txt_total_04.Text = Convert.ToDouble(txt_total_04.Text).ToString("F");
            txt_total_05.Text = Convert.ToDouble(txt_total_05.Text).ToString("F");
            txt_total_06.Text = Convert.ToDouble(txt_total_06.Text).ToString("F");
            txt_total_07.Text = Convert.ToDouble(txt_total_07.Text).ToString("F");
            txt_total_08.Text = Convert.ToDouble(txt_total_08.Text).ToString("F");
            txt_total_09.Text = Convert.ToDouble(txt_total_09.Text).ToString("F");
            txt_total_10.Text = Convert.ToDouble(txt_total_10.Text).ToString("F");

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");

        }

        private void TotalPagar()
        {
            double res = Convert.ToDouble(txt_total_01.Text) + Convert.ToDouble(txt_total_02.Text) + Convert.ToDouble(txt_total_03.Text) +
                Convert.ToDouble(txt_total_04.Text) + Convert.ToDouble(txt_total_05.Text) + Convert.ToDouble(txt_total_06.Text) +
                Convert.ToDouble(txt_total_07.Text) + Convert.ToDouble(txt_total_08.Text) + Convert.ToDouble(txt_total_09.Text) +
                Convert.ToDouble(txt_total_10.Text);

            txt_total_venda.Text = res.ToString();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("C");
        }

        Int32 Calculador(Int32 a, Int32 b)
        {
            return a * b;
        }

        private void txt_valor_01_Leave(object sender, EventArgs e)
        {         
            if (txt_valor_01.Text == "")
            {
                txt_valor_01.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_01.Text);
            b = Convert.ToInt32(txt_valor_01.Text);

            txt_total_01.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_valor_01.Text = Convert.ToDouble(txt_valor_01.Text).ToString("F");
            txt_total_01.Text = Convert.ToDouble(txt_total_01.Text).ToString("F");
        }

        private void txt_valor_02_Leave(object sender, EventArgs e)
        {
            if (txt_valor_02.Text == "")
            {
                txt_valor_02.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_02.Text);
            b = Convert.ToInt32(txt_valor_02.Text);

            txt_total_02.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_valor_02.Text = Convert.ToDouble(txt_valor_02.Text).ToString("F");
            txt_total_02.Text = Convert.ToDouble(txt_total_02.Text).ToString("F");
        }

        private void txt_valor_03_Leave(object sender, EventArgs e)
        {
            if (txt_valor_03.Text == "")
            {
                txt_valor_03.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_03.Text);
            b = Convert.ToInt32(txt_valor_03.Text);

            txt_total_03.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
            txt_valor_03.Text = Convert.ToDouble(txt_valor_03.Text).ToString("F");
            txt_total_03.Text = Convert.ToDouble(txt_total_03.Text).ToString("F");
        }

        private void txt_valor_04_Leave(object sender, EventArgs e)
        {
            if (txt_valor_04.Text == "")
            {
                txt_valor_04.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_04.Text);
            b = Convert.ToInt32(txt_valor_04.Text);

            txt_total_04.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
            txt_valor_04.Text = Convert.ToDouble(txt_valor_04.Text).ToString("F");
            txt_total_04.Text = Convert.ToDouble(txt_total_04.Text).ToString("F");
        }

        private void txt_valor_05_Leave(object sender, EventArgs e)
        {
            if (txt_valor_05.Text == "")
            {
                txt_valor_05.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_05.Text);
            b = Convert.ToInt32(txt_valor_05.Text);

            txt_total_05.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
            txt_valor_05.Text = Convert.ToDouble(txt_valor_05.Text).ToString("F");
            txt_total_05.Text = Convert.ToDouble(txt_total_05.Text).ToString("F");
        }

        private void txt_valor_06_Leave(object sender, EventArgs e)
        {
            if (txt_valor_06.Text == "")
            {
                txt_valor_06.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_06.Text);
            b = Convert.ToInt32(txt_valor_06.Text);

            txt_total_06.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
            txt_valor_06.Text = Convert.ToDouble(txt_valor_06.Text).ToString("F");
            txt_total_06.Text = Convert.ToDouble(txt_total_06.Text).ToString("F");
        }

        private void txt_valor_07_Leave(object sender, EventArgs e)
        {
            if (txt_valor_07.Text == "")
            {
                txt_valor_07.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_07.Text);
            b = Convert.ToInt32(txt_valor_07.Text);

            txt_total_07.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
            txt_valor_07.Text = Convert.ToDouble(txt_valor_07.Text).ToString("F");
            txt_total_07.Text = Convert.ToDouble(txt_total_07.Text).ToString("F");
        }

        private void txt_valor_08_Leave(object sender, EventArgs e)
        {
            if (txt_valor_08.Text == "")
            {
                txt_valor_08.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_08.Text);
            b = Convert.ToInt32(txt_valor_08.Text);

            txt_total_08.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
            txt_valor_08.Text = Convert.ToDouble(txt_valor_08.Text).ToString("F");
            txt_total_08.Text = Convert.ToDouble(txt_total_08.Text).ToString("F");
        }

        private void txt_valor_09_Leave(object sender, EventArgs e)
        {
            if (txt_valor_09.Text == "")
            {
                txt_valor_09.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_09.Text);
            b = Convert.ToInt32(txt_valor_09.Text);

            txt_total_09.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
            txt_valor_09.Text = Convert.ToDouble(txt_valor_09.Text).ToString("F");
            txt_total_09.Text = Convert.ToDouble(txt_total_09.Text).ToString("F");

        }

        private void txt_valor_10_Leave(object sender, EventArgs e)
        {
            if (txt_valor_10.Text == "")
            {
                txt_valor_10.Text = "0";
            }

            Int32 a, b;

            a = Convert.ToInt32(txt_qt_10.Text);
            b = Convert.ToInt32(txt_valor_10.Text);

            txt_total_10.Text = Calculador(a, b).ToString();

            TotalPagar();

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
            txt_valor_10.Text = Convert.ToDouble(txt_valor_10.Text).ToString("F");
            txt_total_10.Text = Convert.ToDouble(txt_total_10.Text).ToString("F");
        }

        // VERIFICA SE SOMENTE NUMEROS ESTAO SENDO DIGITADOS
        private void valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt_nome_02.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        #region MouseClick

        // Valor
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


        // Quantidade
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

        #endregion

        private void txt_total_venda_Leave(object sender, EventArgs e)
        {
            if (txt_total_venda.Text == "")
            {
                txt_total_venda.Text = "0";
            }

            txt_total_venda.Text = Convert.ToDouble(txt_total_venda.Text).ToString("F");
        }

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

    }
}
