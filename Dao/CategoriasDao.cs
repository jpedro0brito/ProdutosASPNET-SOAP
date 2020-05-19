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
    public class CategoriasDao
    {
        private readonly ContextDbProduto context = new ContextDbProduto();

        public Categoria Buscar(int categoriaId) =>
            context.Categorias
                .AsNoTracking()
                .Include("Produtos")
                .FirstOrDefault(p => p.CategoriaID == categoriaId);

        public List<Categoria> Listar() =>
            context.Categorias
                .AsNoTracking()
                .Include("Produtos")
                .ToList();
    }
}