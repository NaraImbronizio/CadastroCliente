using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroCliente.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public required string Name { get; set; }

        [Required]
        public required string Telefone { get; set; }

        [Required]
        public required string Email { get; set; }

        [Required]
        public required string Logradouro { get; set; }

        [Required]
        public int Numero { get; set; }

        public string? Complemento { get; set; }

        [Required]
        public required string Bairro { get; set; }

        [Required]
        public required string Cidade { get; set; }

        [Required]
        public required string Estado { get; set; }

        [Required]
        public required string Cep { get; set; }

    }
}
