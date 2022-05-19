using System.ComponentModel.DataAnnotations;

namespace WebAPICasino.Validaciones
{
    public class AmbasMayuscula : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            int espacio = 0;
            var cadena = value.ToString();

            var primeraLetraNombre = value.ToString()[0].ToString(); 

            if(primeraLetraNombre != primeraLetraNombre.ToUpper())
            {
                return new ValidationResult("La primera letra debe ser mayúscula");
            }

            for(int i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] == ' ')
                {
                    espacio = i;
                    i = cadena.Length;
                }
            }

            var primeraLetraApellido = value.ToString()[espacio + 1].ToString();

            if (primeraLetraApellido != primeraLetraApellido.ToUpper())
            {
                return new ValidationResult("La primera letra debe ser mayúscula");
            }

            return ValidationResult.Success;

        }
    }
}
