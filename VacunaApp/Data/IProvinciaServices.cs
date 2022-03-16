using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacunaApp.Models;

namespace VacunaApp.Data
{
    public interface IProvinciaServices
    {


        Task<IEnumerable<Provincia>> getAllProvincias();

        Task<Provincia> getProvinciaDetails(int id);

        Task<bool> insertProvincia(Provincia provincia);

        Task<bool> updateProvincia(Provincia provincia);

        Task<bool> deleteProvincia(int id);

        Task<bool> saveProvincia(Provincia provincia);
    }
}
