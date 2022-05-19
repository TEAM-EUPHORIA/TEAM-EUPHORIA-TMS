using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Department.Model;

public class DepartmentModel{
    [Key]
    public int DepartmentId { get; set; }
    [Required]
    public string? DepartmentName { get; set; }

}