using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTaskManager.Models
{
    [Table("Tasks")]
    public class Tasks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TaskId")]
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Column("Title")]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; }
        [Column("Description")]
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }
        [Column("IsComplete")]
        [Display(Name = "Completa")]
        public bool TarefaConcluida { get; set; }
    }
}
