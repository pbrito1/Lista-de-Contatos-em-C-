using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCRUD.DBContext
{
    public class Contatos
    {
        [Key]
        public int Id { get; set; }
        [Column("nome", TypeName ="Varchar(200)")]
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public double Telefone { get; set; }
    }
}
