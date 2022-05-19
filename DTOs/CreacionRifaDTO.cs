using System.ComponentModel.DataAnnotations;

namespace WebAPICasino.DTOs
{
    public class CreacionRifaDTO
    {

        [Required(ErrorMessage = "Se require ingresar el nombre de la rifa")]
        public string Nombre { get; set; }
    }
}
