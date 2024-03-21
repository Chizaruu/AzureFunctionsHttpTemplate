using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AzureFunctionsHttpTemplate.Models
{
    [Table("Logs", Schema = "dbo")]
    public class Log(string message)
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Message { get; set; } = message;

        [Required]
        [StringLength(50)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
