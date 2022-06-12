using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
    public class Organiser
    {
        [Key]
        public int IdOrganiser { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual ICollection<EventOrganiser> EventOrganisers { get; set; }

        public Organiser()
        {
            EventOrganisers = new HashSet<EventOrganiser>();   
        }
    }
}
