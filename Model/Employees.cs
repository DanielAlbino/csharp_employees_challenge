using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee_Challange.Model
{
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Name { get; set; }

        public int StatusID { get; set; }

        [ForeignKey("StatusID")]
        public ICollection<Status>? Status { get; }

        [NotMapped]
        public DateTime Birthday { get; set; }

        public int JobTitleID { get; set; }

        [ForeignKey("JobTitleID")]
        public ICollection<JobTitle>? JobTitle { get; }

    }
}
