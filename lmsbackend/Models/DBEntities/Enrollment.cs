using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace lmsbackend.Models.DBEntities
{
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnrollmentId { get; set; }

        [Required]
        public int  StudentId { get; set;}

        [Required]
        public string courseId { get; set; }

        [Required]
        public string semester { get; set; }
    }
}
