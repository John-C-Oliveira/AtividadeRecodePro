using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaSemStress.Models
{
    public class ReservasModel
    {
        
        [Key] 
        [ScaffoldColumn(false)]
        public int ReservaID { get; set; }

        [Display(Name ="Marque para cadastrar a reserva, depois pressione Confirmar")]
        public Boolean IsReserva { get; set; } = true;
        [ScaffoldColumn(false)]
        
        public int FKDestinoID { get; set; }
        
        [ScaffoldColumn(false)]
        public int FKClienteID { get; set; }

        [ScaffoldColumn(false)]
        
        public int FKAnuncioID { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastroReserva { get; set; }

       
    }
}
