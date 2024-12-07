using System;
using System.ComponentModel.DataAnnotations;

namespace PocketDecisionMaker.App.Models.HomePage;

public class Option
{
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Value1 { get; set; }
    [Required]
    public string? Value2 { get; set; }
}
