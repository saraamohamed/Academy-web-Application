using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademyFP.Models
{
    public class Branch
    {
        [Key]
        public int Branch_ID { get; set; }

        [MaxLength(100)]
        public string BranchName { get; set; }

        [MaxLength(100)]
        public string SupervisorName { get; set; }
        public bool DeletionStatus { get; set; } = false;
        public int SupervisorLandlineNumber { get; set; }
        public int SupervisorPhoneNumber { get; set; }
        
        [ForeignKey("User")]
        public int Username { get; set; }

        //Relational Mapping
        public virtual ICollection<User> Users { set; get; }
        public virtual ICollection<Trainee>Trainees { set; get; }



    }
}
