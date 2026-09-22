using System.ComponentModel.DataAnnotations;

namespace ProjectTracker.Models;

public class Project
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Project Name is required.")]
    public string Name { get; set; } = "";
    [Required(ErrorMessage = "Please select a client.")]
    public string ClientName { get; set; } = "";
    [Required(ErrorMessage = "Please select a category.")]
    public string Category { get; set; } = "";
    [Required(ErrorMessage = "Please select a fiscal year.")]
    public string FiscalYear { get; set; } = "";
    [Range(1, double.MaxValue, ErrorMessage = "Design cost must be greater than 0.")]
    public decimal DesignCost { get; set; }
    public decimal Received { get; set; }
    public decimal Balance => DesignCost - Received;
    public string Status => Received <= 0 ? "Unpaid" : Received >= DesignCost ? "Paid" : "Partial";
}
