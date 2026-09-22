using System.ComponentModel.DataAnnotations;

public class Client
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Client name is required.")]
    [StringLength(150)]
    public string Name { get; set; } = "";
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string? Email { get; set; } = "";
    public string? PhoneNumber { get; set; } = "";
    public string? Address { get; set; } = "";
}