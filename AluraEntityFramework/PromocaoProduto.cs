﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AluraEntityFramework
{
    public class PromocaoProduto
    {
        public int ProdutoId { get; set; }
        public int PromocaoId { get; set; }
        public Produto Produto { get; set; }
        public Promocao Promocao { get; set; }
    }
}
