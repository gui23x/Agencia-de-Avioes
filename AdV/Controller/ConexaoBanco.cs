﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdV.Controller
{
    class ConexaoBanco
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\guilherme.gsilva53\source\repos\AdV\AdV\banco\bdagenciaviagens.mdf;Integrated Security=True";
        }
    }
}