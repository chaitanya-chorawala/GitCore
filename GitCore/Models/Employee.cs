using System.ComponentModel.DataAnnotations;

namespace GitCore.Models;

public class Employee
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Name { get; set; }

    [MaxLength(250)]
    public string Address { get; set; }
}
