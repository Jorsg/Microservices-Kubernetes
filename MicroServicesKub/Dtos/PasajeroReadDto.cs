using System;
using System.ComponentModel.DataAnnotations;

namespace MicroServicesKub.Dtos
{
    public class PasajeroReadDto
    {
        public int Id { get; set; }
        public string NombresCompletos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string TipoDocumento { get; set; }
        public string NumDocumento { get; set; }
        public string Email { get; set; }
        public string TelefonoContacto { get; set; }
        public int IdTipoContacto { get; set; }
    }
}
