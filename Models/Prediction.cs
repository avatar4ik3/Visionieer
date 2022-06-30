using System.ComponentModel.DataAnnotations;

namespace Visionieer.Models;

public class Prediction
{
    [Key]
    public int Id { get; set; }
    public string? Value { get; set; }

    public Prediction(int id, string? value)
    {
        Id = id;
        Value = value;
    }
}