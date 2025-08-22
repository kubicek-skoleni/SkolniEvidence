using System.ComponentModel.DataAnnotations;

namespace SkolniEvidence.Model
{
    public class Student
    {
        public int Id { get; set; }

        //[Key]
        //public Guid PrimaryKey { get; set; }

        [MaxLength(100, ErrorMessage = "Moc dlouhé jméno")]
        public string FirstName { get; set; } = string.Empty;

        [MaxLength(100)]
        public string LastName { get; set; } = string.Empty;

        public bool Male { get; set; } 

        public DateOnly BirthDate { get; set; }

        /// <summary>
        /// Název souboru s profilovou fotkou
        /// </summary>
        public string? ProfilePhoto { get; set; } = string.Empty;

        [Required]
        public Group Group { get; set; }
    }
}
