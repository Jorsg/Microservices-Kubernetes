using MicroServicesKub.Models;
using System.Collections.Generic;

namespace MicroServicesKub.Interfaces
{
    public interface IPasajero
    {
        IEnumerable<Pasajero> GetPasajeros();
        Pasajero GetPasajero(int id);
        int CrearPasajero(Pasajero pasajero);

        void SaveChanges();

    }
}
