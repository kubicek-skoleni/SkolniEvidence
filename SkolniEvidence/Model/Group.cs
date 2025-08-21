using System;
using Microsoft.EntityFrameworkCore;

namespace SkolniEvidence.Model
{
    [Index(nameof(Name), IsUnique = true)]
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public List<Student> Students { get; set; } = new List<Student>();
    }
}
