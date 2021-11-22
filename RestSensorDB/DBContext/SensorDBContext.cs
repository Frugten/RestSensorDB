using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSensorDB.DBContext
{
    class SensorDBContext
    {
        public class ItemContext : DbContext
        {
            public ItemContext(DbContextOptions<ItemContext> options) : base(options) { }

            public DbSet<Item> Items { get; set; }
        }
    }
}
