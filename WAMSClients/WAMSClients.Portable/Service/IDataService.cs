using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAMSClients.Portable.Service
{
  public interface IDataService
  {

    Task<IEnumerable<DemoTable>> GetDemoTableAsync();

  }
}
