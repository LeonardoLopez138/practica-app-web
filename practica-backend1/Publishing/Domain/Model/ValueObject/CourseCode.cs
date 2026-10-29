namespace practica_backend1.Publishing.Domain.Model.ValueObject;

public sealed record CourseCode
{
 private const int MaxLength = 50;
 public string Value { get; }

 public CourseCode(string value)
 {
     if (string.IsNullOrWhiteSpace(value))
     {
         throw new ArgumentException("Coursecode cannot be null or empty", nameof(value));
     }
     if(value.Length > MaxLength)
     {
         throw new ArgumentException("Coursecode cannot exceed 50 characters ", nameof(value));
     }
     Value = value;
 }
 public override string ToString() => Value;

}