using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdV.Model
{
    class Pacote
    {
        private static int codigoPac;
        private static decimal valorPac;
        private static string origemPac;
        private static string destinoPac;
        private static DateTime dataPac;
        private static DateTime dataPacVolta;
        private static string descricaoPac;
        private static Array imagemPac;
        private static string retorno;

        public static int CodigoPac { get => codigoPac; set => codigoPac = value; }
        public static decimal ValorPac { get => valorPac; set => valorPac = value; }
        public static string OrigemPac { get => origemPac; set => origemPac = value; }
        public static string DestinoPac { get => destinoPac; set => destinoPac = value; }
        public static DateTime DataPac { get => dataPac; set => dataPac = value; }
        public static DateTime DataPacVolta { get => dataPacVolta; set => dataPacVolta = value; }
        public static string DescricaoPac { get => descricaoPac; set => descricaoPac = value; }
        public static Array ImagemPac { get => imagemPac; set => imagemPac = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
