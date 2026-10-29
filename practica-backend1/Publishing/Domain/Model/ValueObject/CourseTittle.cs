namespace practica_backend1.Publishing.Domain.Model.ValueObject;

public sealed record CourseTitle
{
   private const int MaxLength = 50;
    public string Value { get; }

    public CourseTitle(String value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("CourseTittle cannot be null or empty", nameof(value));
        }

        if (value.Length > MaxLength)
        {
            throw new ArgumentException("CourseTittle cannot exceed 50 characters", nameof(value));
        }
        Value = value;
    }
    public override string ToString() => Value;

}