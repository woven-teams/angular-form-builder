using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormBuilder.Data.Entities;
using FormBuilder.Repository;
using Microsoft.EntityFrameworkCore;

namespace FormBuilder.Repository
{
    public class DbInitializer
    {
        private FormBuilderDbContext _context;

        public DbInitializer(FormBuilderDbContext context)
        {
            _context = context;
        }

        public void Migrate()
        {
            _context.Database.Migrate();
        }

        public void Seed()
        {
            // no-op in this project
        }
    }
}
