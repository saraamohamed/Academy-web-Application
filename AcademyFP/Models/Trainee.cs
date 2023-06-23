using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AcademyFP.Models
{
    public enum GenderEnum { Male, Female }
    public enum MilitaryEnum { ActiveDuty, Veteran, NoMilitaryService}

    public class Trainee
    {
        [Key]
        public int TraineeNational_ID { get; set; }

        [MaxLength(100)]
        public string ArabicFullName { get; set; }

        [MaxLength(100)]
        public string EnglishFullName { get; set; }

        [MaxLength(100)]
        public string Religion { get; set; }

        [MaxLength(255)]
        public string Address { get; set; }
        public GenderEnum Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public int FirstPhoneNumber { get; set; }
        public int SecondPhoneNumber { get; set; }
        public int LandlineNumber { get; set; }

        [MaxLength(100)]
        public string Recommender { get; set; }
        [MaxLength(255)]
        public string AcademicQualification { get; set; }
        public DateTime QualificationObtainingYear { get; set; }
        public DateTime AcademicYear { get; set; }
        public MilitaryEnum MilitaryStatus { get; set; }

        [MaxLength(255)]
        public string PersonalPhoto { get; set; }
        public int NationalIdCardCopy { get; set; }

        [MaxLength(100)]
        public string AcademicQualifictionCopy { get; set; }
        public bool ActivityStatus { get; set; }
        public bool DeletionStatus { get; set; } = false;


        [ForeignKey("Branch")]
        public int Branch_ID { get; set; }


        //Relational Mapping
        public virtual Branch Branch { get; set; }
        public virtual ICollection<TraineeFinancialTranscations> TraineeFinancialTranscations { get; set; }
        public virtual List<TraineeHasCourse> TraineeHasCourses { get; set; } = new List<TraineeHasCourse>();
    }
}
