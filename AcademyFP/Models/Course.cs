using System.ComponentModel.DataAnnotations;

namespace AcademyFP.Models
{
    public class Course
    {
        [Key]
        public int Course_ID { get; set; }

        [MaxLength(100)]
        public string CourseName { get; set; }

        [MaxLength(255)]
        public string CourseDescription { get; set; }

        public int CourseCost { get; set;}
      
        public  bool DeletionStatus { get; set; }

        public int CourseDurationInHours { get; set; }

        //navigation properities
        public  virtual List<TraineeFinancialTranscations> TraineeFinancialTranscations { get; set; } = new List<TraineeFinancialTranscations>();
        public virtual List<Subject> Subjects { get; set; } = new List<Subject>();
        public virtual List<TraineeHasCourse> TraineeHasCourses { get; set; } = new List<TraineeHasCourse>();

    }
}
