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
            Produtos.Add(prod);
            return "1";
        }

        [AcceptVerbs("PUT")]
        [Route("alterar")]
        public Boolean alterar(Produto prod)
        {
            return true;
        }

        [AcceptVerbs("DELETE")]
        [Route("excluir/{codigo}")]
        public Boolean excluir(int codigo)
        {
            return true;
        }

        [AcceptVerbs("GET")]
        [Route("consultar/{codigo}")]
        public Produto consultar(int codigo)
        {
            Produto p = new Produto();

            p.Descricao = "caderno universitário.";
            p.IdProduto = 2;
            p.NomeProduto = "caderno";
            p.ValorProduto = 15.00;

            return p;
        }

        [AcceptVerbs("GET")]
        [Route("listar")]
        public List<Produto> listar()
        {

            Produto p = new Produto();

            p.Descricao = "caderno universitário.";
            p.IdProduto = 2;
            p.NomeProduto = "caderno";
            p.ValorProduto = 15.00;


            Produtos.Add(p);


            p = new Produto();

            p.Descricao = "Bloco de antação amarelo.";
            p.IdProduto = 3;
            p.NomeProduto = "bloco de notas";
            p.ValorProduto = 10.00;

            Produtos.Add(p);

            return Produtos;
        }
    }
}
