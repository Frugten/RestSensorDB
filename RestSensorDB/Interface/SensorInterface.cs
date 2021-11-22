using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSensorDB.Interface
{
    public interface SensorInterface
        {
            public IEnumerable<Item> GetAll(string name);
            public Item GetById(int id);
            Item Add(Item newItem);
            Item Delete(int id);
            Item Update(int id, Item updates);
        }
}
