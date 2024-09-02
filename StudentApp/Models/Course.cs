//Will sho the table for us
using System.ComponentModel.DataAnnotations;

namespace StudentApp.Models

{

    public class Course
    {
        public int Id { get; set; }

        [MaxLength(100)] //Length for thr name field
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";

        [MaxLength(100)]
        public string ModuleName { get; set; } = "";

    }
}
