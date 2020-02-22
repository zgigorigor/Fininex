using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLibrary.DataAccess
{
    public class Entry : DbContext
    {
        public Entry() : base("Entry")
        {
        }

        public DbSet<Entry> Name { get; set; }
        public DbSet<Entry> Amount { get; set; }
        public DbSet<Entry> Currency { get; set; }
        public DbSet<Entry> Description { get; set; }
        
    }

    
}
