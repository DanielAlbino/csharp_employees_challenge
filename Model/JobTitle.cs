using System.ComponentModel.DataAnnotations;

namespace Employee_Challange.Model
{
    public class JobTitle
    {
        [Key]
        public int JobTitleID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
