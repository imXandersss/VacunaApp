using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacunaApp.Models;

namespace VacunaApp.Data
{
    public interface IVacunaServices
    {
        Task<IEnumerable<Vacuna>> getAllVacunas();

        Task<Vacuna> getVacunaDetails(int id);

        Task<bool> insertVacuna(Vacuna vacuna);

        Task<bool> updateVacuna(Vacuna  vacuna);

        Task<bool> deleteVacuna(int id);

        Task<bool> saveVacuna(Vacuna vacuna);
    }
}
