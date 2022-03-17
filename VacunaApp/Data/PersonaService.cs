using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacunaApp.Models;

namespace VacunaApp.Data
{
    public class PersonaService : IPersonasServices
    {

        private readonly MyPersonaContext _personaContext;

        public PersonaService(MyPersonaContext personaContext)
        {
            _personaContext = personaContext;
        }



        public async Task<bool> deletePersona(int id)
        {
            var persona = await _personaContext.Personas.FindAsync(id);

            _personaContext.Personas.Remove(persona);

            return await _personaContext.SaveChangesAsync() > 0;
        }


        public async Task<IEnumerable<Persona>> getAllPersonas()
        {
            return await _personaContext.Personas.ToListAsync();
        }

        public async Task<Persona> getPersonaDetails(int id)
        {

            return await _personaContext.Personas.FindAsync(id);
        }

        public async Task<bool> insertPersona(Persona persona)
        {
            _personaContext.Personas.Add(persona);
            return await _personaContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> savePersona(Persona persona)
        {
            if (persona.id >    0)
                return await updatePersona(persona);
            else
                return await insertPersona(persona);
        }

        public async Task<IEnumerable<Persona>> getByProvincias(string provincia)
        {
                var query = _personaContext.Personas
                    .Where(p => p.provincia == provincia)
                    .ToListAsync();
            return await query;
            
        }

        public async Task<bool> updatePersona(Persona persona)
        {
            _personaContext.Entry(persona).State = EntityState.Modified;
            return await _personaContext.SaveChangesAsync() > 0;

        }

    }
}
