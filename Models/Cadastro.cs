using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeladeCadastro.Models
{
    [Table("Cadastro")]
    public class Cadastro
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }


        [Column("Nome")]
        [Display(Name = "Nome")]
        public string nome { get; set; }


        [Column("CPF")]
        [Display(Name = "CPF")]
        public int cpf { get; set; }


        [Column("Email")]
        [Display(Name = "Email")]
        public string email { get; set; }


        [Column("Idade")]
        [Display(Name = "Idade")]
        public int idade { get; set; }


        [Column("Faixa")]
        [Display(Name = "Faixa")]

        public string faixa { get; set; }
    }
}
