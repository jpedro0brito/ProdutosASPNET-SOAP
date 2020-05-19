using PRODUTO.ASP.NET.MVC.SOAP.Data;
using PRODUTO.ASP.NET.MVC.SOAP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PRODUTO.ASP.NET.MVC.SOAP.Dao
{
    public class ProdutosDao
    {
        private readonly ContextDbProduto context = new ContextDbProduto();

        public Produto Buscar(int produtoId) =>
           context.Produtos
                .AsNoTracking()
                .Include("Categoria")
                .FirstOrDefault(p => p.ProdutoID == produtoId);

        public List<Produto> Listar() =>
           context.Produtos
                .AsNoTracking()
                .Include("Categoria")
                .ToList();
    }
}