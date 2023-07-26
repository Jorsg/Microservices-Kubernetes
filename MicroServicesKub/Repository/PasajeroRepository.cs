using MicroServicesKub.Interfaces;
using MicroServicesKub.Models;
using System.Collections.Generic;

namespace MicroServicesKub.Repository
{
    public class PasajeroRepository : IPasajero
    {
        private readonly AppDbContext _context;

        public PasajeroRepository(AppDbContext context)
        {
            _context = context;
        }

        public int CrearPasajero(Pasajero pasajero)
        {
            int result = 0;
            try
            {
                if (pasajero == null)
                {
                    throw new System.ArgumentNullException(nameof(pasajero));
                }
                var id = _context.Pasajero.Add(pasajero);
                SaveChanges();
                result = id.Entity.Id;
            }
            catch (System.Exception)
            {
                throw new System.ArgumentNullException(nameof(pasajero));
            }
            return result;            
        }

        public Pasajero GetPasajero(int id)
        {
            return _context.Pasajero.Find(id);
        }

        public IEnumerable<Pasajero> GetPasajeros()
        {
            return _context.Pasajero;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
