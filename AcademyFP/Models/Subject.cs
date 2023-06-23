using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademyFP.Models
{
    public class Subject
    {
         [Key]
         public int Subject_ID { get; set; }

         [MaxLength(100)]
         public string SubjectName { get; set; }

         [MaxLength(100)]
         public string ContainingCourseName { get; set; }

         public bool DeletionStatus { get; set; }


          [ForeignKey("Course")]
          public int Course_ID { get; set; }

          public virtual Course Course  { get; set; }
    }
}
