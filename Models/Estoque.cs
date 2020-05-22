using System.Numerics;
using System;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Estoque
    {
        [Key]
        public Int64 idProduto { get; set; }
        public string codProduto { get; set; }

        [Required(ErrorMessage = "Nome do produto obrigatório")]
        public string nomeProduto { get; set; }

        [Required(ErrorMessage = "Codigo do produto obrigatório")]
        public string categoriaProduto { get; set; }

        [Required(ErrorMessage = "Quantidade do produto obrigatório")]
        public Int64 qtdProduto { get; set; }

        [Required(ErrorMessage = "Preco do produto obrigatório")]
        public float precoProduto { get; set; }
    }
}