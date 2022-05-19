using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPICasino.DTOs
{
    public class LoteriaDTO
    {
        public int Id { get; set; }

        [NotMapped] //Este atributo no se encuentra en la base de datos
        public List<string> CartasDisponibles { get; set; }
    }
}
