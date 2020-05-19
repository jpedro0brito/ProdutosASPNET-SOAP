using PRODUTO.ASP.NET.MVC.SOAP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PRODUTO.ASP.NET.MVC.SOAP.Data
{
    public class ContextDbProduto : DbContext
    {
        public ContextDbProduto()
            : base("ProdutosConnection")
        {}

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}