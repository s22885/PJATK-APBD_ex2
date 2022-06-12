using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
    public class Event
    {
        [Key]
        public int IdEvent { get; set; }
        [MaxLength (60)]
        public string Name { get; set; }
        public System.DateTime DateFrom { get; set; }
        public System.DateTime? DateTo { get; set; }

        public virtual ICollection<EventOrganiser> EventOrganisers { get; set; }
        public Event()
        {
            EventOrganisers=new HashSet<EventOrganiser>();
        }
    }
}
