using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.DTO;

namespace WebApplication1.Service
{
    public interface IDBService
    {
        Task<List<EventWithOrganisers>> GetEventWithOrganisers(bool EndDataExist);
    }
}
