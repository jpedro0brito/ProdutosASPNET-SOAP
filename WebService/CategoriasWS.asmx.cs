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
    /// Descrição resumida de CategoriasWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class CategoriasWS : System.Web.Services.WebService
    {

        private readonly CategoriasDao categoriasDao = new CategoriasDao();

        [WebMethod]
        public XmlCategoria BuscarCategoriaXML(int categoriaId) =>
            categoriasDao
                .Buscar(categoriaId)?
                .ToXmlCategoria();

        [WebMethod]
        public List<XmlCategoria> ListarCategoriasXML() =>
            categoriasDao
                .Listar()
                .Select(p => p?.ToXmlCategoria())
                .ToList();
    }
}
