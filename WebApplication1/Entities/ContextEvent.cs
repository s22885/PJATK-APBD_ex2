using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace PreKolos2.Entities
{
    public class ContextEvent : DbContext
    {
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventOrganiser> EventOrganisers { get; set; }
        public virtual DbSet<Organiser> Organisers { get; set; }

        public ContextEvent(DbContextOptions<ContextEvent> options) : base(options)
        {

        }

        public ContextEvent()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Event).GetTypeInfo().Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EventOrganiser).GetTypeInfo().Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Organiser).GetTypeInfo().Assembly);

           

           
        }
    }
}

