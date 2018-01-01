using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_RestFull.Models;

namespace WebApi_RestFull.Controllers
{
    [RoutePrefix("api/produto")]
    public class ProdutoController : ApiController
    {
        private static List<Produto> Produtos = new List<Produto>();

        [AcceptVerbs("POST")]
        [Route("inserir")]
        public string inserir(Produto prod)
        {
            using (Context bd = new Context())
            {
                bd.Produtos.Add(prod);
                bd.SaveChanges();
                prod.IdProduto.ToString();
            }
            return "-1";
        }

        [AcceptVerbs("PUT")]
        [Route("alterar")]
        public Boolean alterar(Produto prod)
        {
            using (Context bd = new Context())
            {
                var p = bd.Produtos.Where(prop => prop.IdProduto.Equals(prod.IdProduto)).FirstOrDefault();
                p.NomeProduto = prod.NomeProduto;
                p.ValorProduto = prod.ValorProduto;
                p.Descricao = prod.Descricao;
                bd.Entry(p).CurrentValues.SetValues(p);
                var retorno = bd.SaveChanges();
                return (retorno > 0);
            }
        }

        [AcceptVerbs("DELETE")]
        [Route("excluir/{codigo}")]
        public Boolean excluir(int codigo)
        {
            using (Context bd = new Context())
            {
                var p = bd.Produtos.Where(prop => prop.IdProduto.Equals(codigo)).FirstOrDefault();
                bd.Produtos.Remove(p);
                var retorno = bd.SaveChanges();
                return (retorno > 0);
            }
        }

        [AcceptVerbs("GET")]
        [Route("consultar/{codigo}")]
        public Produto consultar(int codigo)
        {
            Context bd = new Context();
            return bd.Produtos.Where(prop => prop.IdProduto.Equals(codigo)).FirstOrDefault();
        }

        [AcceptVerbs("GET")]
        [Route("listar")]
        public List<Produto> listar()
        {
            Context bd = new Context();
            return bd.Produtos.ToList<Produto>();
        }
    }
}
