using System.ComponentModel.DataAnnotations;
using WebAPICasino.Validaciones;

namespace WebAPICasino.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Se require ingresar el nombre del cliente")]
        [EspacioEnBlanco]
        [AmbasMayuscula]
        public string Nombre { get; set; }

    }
}
