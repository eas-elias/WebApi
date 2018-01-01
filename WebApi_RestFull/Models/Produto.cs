using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_RestFull.Models
{
    [Table("TB_PRODUTO_WEBAPI")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_PRODUTO")]
        public int IdProduto { get; set; }

        [Required]
        [StringLength(100)]
        [Column("NM_PRODUTO")]
        public string NomeProduto { get; set; }

        [Column("VL_PRODUTO")]
        public double ValorProduto { get; set; }

        [Column("NM_DESCRICAO")]
        [StringLength(500)]
        public string Descricao { get; set; }
    }
}