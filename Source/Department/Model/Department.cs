using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COREMVC.Model;

public class Department{
    [Key]
    public int DepartmentId { get; set; }
    [Required]
    public string? DepartmentName { get; set; }

}