using System.ComponentModel.DataAnnotations;

namespace AcademyFP.Models
{
    public class Language
    {
        [Key]
        public int Language_ID { get; set; }

        [MaxLength(100)]
        public string LanguageName { get; set; }

        public bool DeletionStatus { get; set; } = false;


        //Relational Mapping

        public virtual ICollection<User> Users { set; get; }

    }
}
