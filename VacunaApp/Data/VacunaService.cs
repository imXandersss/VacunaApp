using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacunaApp.Models;

namespace VacunaApp.Data
{
    public class VacunaService: IVacunaServices
    {
        private readonly MyPersonaContext _personaContext;

        public VacunaService(MyPersonaContext personaContext)
        {
            _personaContext = personaContext;
        }



        public async Task<bool> deleteVacuna(int id)
        {
            var vacuna = await _personaContext.Vacunas.FindAsync(id);

            _personaContext.Vacunas.Remove(vacuna);

            return await _personaContext.SaveChangesAsync() > 0;
        }


        public async Task<IEnumerable<Vacuna>> getAllVacunas()
        {
            return await _personaContext.Vacunas.ToListAsync();
        }

        public async Task<Vacuna> getVacunaDetails(int id)
        {
            return await _personaContext.Vacunas.FindAsync(id);
        }

        public async Task<bool> insertVacuna(Vacuna vacuna)
        {
            _personaContext.Vacunas.Add(vacuna);
            return await _personaContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> saveVacuna(Vacuna vacuna)
        {
            if (vacuna.id > 0)
                return await updateVacuna(vacuna);
            else
                return await insertVacuna(vacuna);
        }

        public async Task<bool> updateVacuna(Vacuna vacuna)
        {
            _personaContext.Entry(vacuna).State = EntityState.Modified;
            return await _personaContext.SaveChangesAsync() > 0;

        }
    }
}
