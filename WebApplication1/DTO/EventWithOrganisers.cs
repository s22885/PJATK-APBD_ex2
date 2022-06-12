using System.Collections.Generic;

namespace WebApplication1.DTO
{
    public class EventWithOrganisers
    {
        public int IdEvent { get; set; }
        public IList<Organiser> MainOrganisers { get; set; }
        public IList<Organiser> SupportOrganisers { get; set; }
    }
}
