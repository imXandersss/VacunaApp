using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacunaApp.Models;

namespace VacunaApp.Data
{
    public interface IPersonasServices
    {
        Task<IEnumerable<Persona>> getAllPersonas();

        Task<Persona> getPersonaDetails(int id);

        Task<bool> insertPersona(Persona persona);

        Task<bool> updatePersona(Persona persona);

        Task<bool> deletePersona(int id);

        Task<bool> savePersona(Persona persona);
        Task<IEnumerable<Persona>> getByProvincias(string provincia);

    }
}
