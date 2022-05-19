using System.ComponentModel.DataAnnotations;

namespace WebAPICasino.Validaciones
{
    public class EspacioEnBlanco : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validation)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            var cadena = value.ToString();

            bool espacio = cadena.Contains(' ');

            if (!espacio)
            {
                return new ValidationResult("El nombre del cliente no contiene apellido");
            }
            return ValidationResult.Success;
        }
    }
}
