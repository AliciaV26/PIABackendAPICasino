
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPICasino.DTOs
{
    public class GanadoresDTO
    {
       
        public int Id_Rifa { get; set; }

        public string Nombre_Rifa { get; set; }

        [NotMapped]
        public string Carta_Rifa { get; set; }
        public string Nombre_Cliente { get; set; }

        [NotMapped]
        public string Premio { get; set; }

       

    }
}
