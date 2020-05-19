using PRODUTO.ASP.NET.MVC.SOAP.Dao;
using PRODUTO.ASP.NET.MVC.SOAP.Models;
using PRODUTO.ASP.NET.MVC.SOAP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services;

namespace PRODUTO.ASP.NET.MVC.SOAP.WebService
{
    /// <summary>
    /// Descrição resumida de ProdutosWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class ProdutosWS : System.Web.Services.WebService
    {

        private readonly ProdutosDao produtosDao = new ProdutosDao();

        [WebMethod]
        public XmlProduto BuscarProdutosXML(int produtoId) =>
            produtosDao
                .Buscar(produtoId)?
                .ToXmlProduto();

        [WebMethod]
        public List<XmlProduto> ListarProdutosXML() =>
            produtosDao
                .Listar()
                .Select(p => p?.ToXmlProduto())
                .ToList();
    }
}
