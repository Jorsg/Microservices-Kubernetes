using System;
using System.ComponentModel.DataAnnotations;

namespace MicroServicesKub.Dtos
{
    public class PasajeroCreateDto
    {
        [Required]
        public string NombresCompletos { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string TipoDocumento { get; set; }
        [Required]
        public string NumDocumento { get; set; }
        [Required]
        public string Email { get; set; }
        public string TelefonoContacto { get; set; }
        public int? IdTipoContacto { get; set; }
    }
}
