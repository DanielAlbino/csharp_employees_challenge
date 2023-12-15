using System.ComponentModel.DataAnnotations;

namespace Employee_Challange.Model
{
    public class Status
    {
        [Key]
        public int StatusID { get; set; }
        public string Name { get; set; }
    }
}
