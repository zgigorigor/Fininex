using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DataLibrary.Models
{
    public partial class EntryEntities : Microsoft.EntityFrameworkCore.DbContext
    {
        public EntryEntities() : base("FininexDatabase") 
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    }
}
