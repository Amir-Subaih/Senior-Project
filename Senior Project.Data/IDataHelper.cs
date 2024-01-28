using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Project.Data
{
    public interface IDataHelper<Table>
    {
        List<Table> GetData();
        List<Table> Search(String SearchItem);
        Table Find(int id);
        void Add(Table item);
        void Update(int id,Table item);
        void Delete(int id);
    }
}
