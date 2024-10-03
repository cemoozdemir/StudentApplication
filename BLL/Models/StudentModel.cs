using System.ComponentModel.DataAnnotations;

namespace BLL.Models;

public partial class StudentModel
{
    public int id { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    
    public DateTime? birthday { get; set; }
    public int gpa { get; set; }
    
}