using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ControleCliente_ASP_MVC.Models

{
    [Table("Usuario")]
    public class Contato
    {
        [Display(Name ="codigo")]//nome amigavel para consulta
        [Column("Id")]//nome na tabela do banco
        public int Id { get;set;}

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Telefone")]
        [Column("Telefone")]
        public string Telefone { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        public string Email { get; set; }

        
    }
}
