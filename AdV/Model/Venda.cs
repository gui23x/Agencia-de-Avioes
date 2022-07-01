using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdV.Model
{
    class Venda
    {
        private static int codigoVenda;
        private static int codigoCliFK;
        private static int codigoFunFK;
        private static int codigoPacoteFK;
        private static string pagoVenda;
        private static string retorno;

        public static int CodigoVenda { get => codigoVenda; set => codigoVenda = value; }
        public static int CodigoCliFK { get => codigoCliFK; set => codigoCliFK = value; }
        public static int CodigoFunFK { get => codigoFunFK; set => codigoFunFK = value; }
        public static int CodigoPacoteFK { get => codigoPacoteFK; set => codigoPacoteFK = value; }
        public static string PagoVenda { get => pagoVenda; set => pagoVenda = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
