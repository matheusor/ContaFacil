using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContaFacil.Models
{
    [Table("Cadastros")]
    public class Cadastro
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required(ErrorMessage ="Obrigatorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatorio")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Obrigatorio")]
        public string Logadouro { get; set; }
        [Required(ErrorMessage = "Obrigatorio")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Obrigatorio")]
        public string Uf { get; set; }
        [Required(ErrorMessage = "Obrigatorio")]
        public int CEP { get; set; }
        [Required(ErrorMessage = "Obrigatorio")]
        public int Telefone { get; set; }
        [Required(ErrorMessage = "Obrigatorio")]
        public int Cpf { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public int Senha { get; set; }

        public Perfil Perfil { get; set; }

    }

    public enum Perfil
    {
        Admin,
        User
    }
}
