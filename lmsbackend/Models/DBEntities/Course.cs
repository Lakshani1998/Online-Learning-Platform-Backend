using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lmsbackend.Models.DBEntities
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int courseId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string courseName { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string courseDescription { get; set; } 

    }
}
