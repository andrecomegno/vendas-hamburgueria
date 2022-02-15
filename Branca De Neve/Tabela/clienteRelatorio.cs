using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branca_De_Neve.Tabela
{
    public class clienteRelatorio
    {
        public Int32 ID { get; set; }
        public DateTime DATA_VENDA { get; set; }
        public string NOME { get; set; }
        public string TELEFONE { get; set; }
        public string ENDERECO { get; set; }
        public Int32 NUMERO { get; set; }
        public string PRODUTO { get; set; }
        public decimal QUANTIDADE { get; set; }
        public decimal PRECO_UNI { get; set; }
        public decimal PRECO_TOTAL { get; set; }
        public string FORMA_PAGAMENTO { get; set; }
        public decimal TOTAL
        {
            get
            {
                return QUANTIDADE * PRECO_UNI;
            }
        }


    }
}
