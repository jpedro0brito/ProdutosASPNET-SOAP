using PRODUTO.ASP.NET.MVC.SOAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRODUTO.ASP.NET.MVC.SOAP.Service
{
    public static class CategoriaService
    {
        public static XmlCategoria ToXmlCategoria(this Categoria categoria) => new XmlCategoria
        {
            Descricao = categoria.Descricao,
            XmlProdutos = categoria.Produtos.Select(p => new XmlProduto
            {
                Nome = p.Nome,
                Valor = p.Valor.ToString("n2"),
                XmlCategoria = new XmlCategoria
                {
                    Descricao = p.Categoria.Descricao
                }
            }).ToList(),
        };
    }
}