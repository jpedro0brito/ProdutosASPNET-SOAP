using PRODUTO.ASP.NET.MVC.SOAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRODUTO.ASP.NET.MVC.SOAP.Service
{
    public static class ProdutoService
    {
        public static XmlProduto ToXmlProduto(this Produto produto) => new XmlProduto
        {
            Nome = produto.Nome,
            Valor = produto.Valor.ToString("n2"),
            XmlCategoria = new XmlCategoria
            {
                Descricao = produto.Categoria.Descricao,
            }
        };
    }
}