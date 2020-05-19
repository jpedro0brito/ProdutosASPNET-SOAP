using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace PRODUTO.ASP.NET.MVC.SOAP.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }
        public string Descricao { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }

    [XmlRoot("WSCategoria"), XmlType("Categoria")]
    public class XmlCategoria
    {
        [XmlElement("Descricao")]
        public string Descricao { get; set; }
        [XmlElement("Produtos")]
        public List<XmlProduto> XmlProdutos { get; set; }
    }
}