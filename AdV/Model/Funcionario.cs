﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdV.Model
{
    class Funcionario
    {
        private static int codigoFun;
        private static string nomeFun;
        private static string emailFun;
        private static string senhaFun;

        public static int CodigoFun { get => codigoFun; set => codigoFun = value; }
        public static string NomeFun { get => nomeFun; set => nomeFun = value; }
        public static string EmailFun { get => emailFun; set => emailFun = value; }
        public static string SenhaFun { get => senhaFun; set => senhaFun = value; }
    }
}
