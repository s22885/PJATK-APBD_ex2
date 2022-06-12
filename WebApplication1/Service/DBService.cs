using Microsoft.EntityFrameworkCore;
using PreKolos2.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DTO;

namespace WebApplication1.Service
{
    public class DBService : IDBService
    {
        private readonly ContextEvent _db;
        public DBService(ContextEvent db)
        {
            _db = db;
        }

        public Task<List<EventWithOrganisers>> GetEventWithOrganisers(bool EndDataExist)
        {
            var res = _db.Events.Where(e =>
            (EndDataExist && e.DateTo != null) || (!EndDataExist && e.DateTo == null))
            .Include(e => e.EventOrganisers).ThenInclude(e => e.IdOrganiserNavigation).Select(e => new EventWithOrganisers
            {
                IdEvent = e.IdEvent,
                MainOrganisers = e.EventOrganisers.Select(x => new Organiser
                {
                    IdOrganiser = x.IdOrganiserNavigation.IdOrganiser,
                    Name = x.IdOrganiserNavigation.Name
                }
                ).ToList(),
                SupportOrganisers = e.EventOrganisers.Select(x => new Organiser
                {
                    IdOrganiser = x.IdOrganiserNavigation.IdOrganiser,
                    Name = x.IdOrganiserNavigation.Name
                }
                ).ToList()
            }).ToList();
            return Task.FromResult(res);
        }
    }
}
/*{
    if (EndDataExist)
    {
        return e.DateTo != null;
    }
    else
    {
        return e.DateTo == null;
    }
}*/