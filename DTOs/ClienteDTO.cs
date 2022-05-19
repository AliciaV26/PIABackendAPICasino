using System.ComponentModel.DataAnnotations;
using WebAPICasino.Validaciones;

namespace WebAPICasino.DTOs
{
    public class ClienteDTO
    {
        [Required(ErrorMessage = "Se require ingresar el nombre del cliente")]
        [EspacioEnBlanco]
        [AmbasMayuscula]
        public string Nombre { get; set; }
    }
}
