﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_RestFull.Models
{
    public class Produto
    {

        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public double ValorProduto { get; set; }
        public string Descricao { get; set; }

    }
}