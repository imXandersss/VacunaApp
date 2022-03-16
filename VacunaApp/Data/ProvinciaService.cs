using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacunaApp.Models;

namespace VacunaApp.Data
{
    public class ProvinciaService : IProvinciaServices
    {
        private readonly MyPersonaContext _personaContext;

        public ProvinciaService(MyPersonaContext personaContext)
        {
            _personaContext = personaContext;
        }

        public async Task<bool> deleteProvincia(int id)
        {
            var provincia = await _personaContext.Provincias.FindAsync(id);

            _personaContext.Provincias.Remove(provincia);

            return await _personaContext.SaveChangesAsync() > 0;
        }

        public  async Task<IEnumerable<Provincia>> getAllProvincias()
        {
            return await _personaContext.Provincias.ToListAsync();
        }

        public async Task<Provincia> getProvinciaDetails(int id)
        {
            return await _personaContext.Provincias.FindAsync(id);
        }

        public async Task<bool> insertProvincia(Provincia provincia)
        {
            _personaContext.Provincias.Add(provincia);
            return await _personaContext.SaveChangesAsync() > 0;
        }

        public Task<bool> saveProvincia(Provincia provincia)
        {
            if (provincia.id > 0)
                return updateProvincia(provincia);
            else
                return insertProvincia(provincia);
        }

        public async Task<bool> updateProvincia(Provincia provincia)
        {
            _personaContext.Entry(provincia).State = EntityState.Modified;
            return await _personaContext.SaveChangesAsync() > 0;
        }
    }
}
