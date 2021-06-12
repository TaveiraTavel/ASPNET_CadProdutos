using System.ComponentModel.DataAnnotations;

namespace Projeto01Web.Models
{
    public class Produto
    {
        // Código
        [Required(ErrorMessage = "* Campo obrigatório")]
        public int Codigo { get; set; }

        // Nome
        [StringLength(50, MinimumLength = 5, ErrorMessage = "O nome do produto deve ter entre 5 e 50 caracteres")]
        [Required(ErrorMessage = "* Campo obrigatório")]
        public string Nome { get; set; }

        // Descrição
        [Required(ErrorMessage = "* Campo obrigatório")]
        public string Descricao { get; set; }

        // Peso
        [Required(ErrorMessage = "* Campo obrigatório")]
        public decimal Peso { get; set; }

        // Categoria
        [Required(ErrorMessage = "* Campo obrigatório")]
        public string Categoria { get; set; }

        // ValorUnit
        [Required(ErrorMessage = "* Campo obrigatório")]
        public decimal ValorUnit { get; set; }
    }
}