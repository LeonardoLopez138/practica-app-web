namespace practica_backend1.Publishing.Domain.Model.ValueObject;


//Este es el value object, se crea una clase que es el molde que vamos a utilizar para obtener los datos
//con sus restricciones


//dato CourseCode
public sealed record CourseCode
{
    //solo es una variable que dice que el maximo de letras es 50
 private const int MaxLength = 50;
 
   //el get
 public string Value { get; }
 
 
   //Se crea el constructor con validaciones
 public CourseCode(string value)
 {
     //si es nulo o con espacios en blancos (evalue value) que salga una excepcion
     if (string.IsNullOrWhiteSpace(value))
     {
         throw new ArgumentException("Coursecode cannot be null or empty", nameof(value));
     }
     
     //si se soberpasa al maximo de letras salta el error
     if(value.Length > MaxLength)
     {
         throw new ArgumentException("Coursecode cannot exceed 50 characters ", nameof(value));
     }
     //en caso contrario que no pase nada de lo anterior
     //se valida que value pasa al value original
     Value = value;
 }
 
 //este develuve un texto normal
 public override string ToString() => Value;

}