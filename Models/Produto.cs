using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace PRODUTO.ASP.NET.MVC.SOAP.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int CategoriaID { get; set; }
        [ForeignKey("CategoriaID")]
        public Categoria Categoria { get; set; }
    }

    [XmlRoot("WSProduto"), XmlType("Produto")]
    public class XmlProduto
    {
        [XmlElement("Nome")]
        public string Nome { get; set; }
        [XmlElement("Valor")]
        public string Valor { get; set; }

        [XmlElement("Categoria")]
        public XmlCategoria XmlCategoria { get; set; }
    }
}