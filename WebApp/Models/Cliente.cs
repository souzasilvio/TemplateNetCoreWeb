using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "Informe o nome do cliente")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o e-mail do cliente")]
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
