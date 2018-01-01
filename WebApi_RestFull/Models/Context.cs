using System;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core;

namespace WebApi_RestFull.Models
{
    class Context : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public Context() : base("name=Context")
        {
            this.Database.CreateIfNotExists();
        }

    }
}