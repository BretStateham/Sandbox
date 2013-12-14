using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAMSClients.Portable.Model
{
  public static class ServiceLocator 
  {

    static Dictionary<Type, Object> services;

    static ServiceLocator()
    {
      services = new Dictionary<Type, object>();
    }

    public static void AddService<T>(Object Service)
    {
      services.Add(typeof(T),Service);
    }

    public static T GetService<T>()
    {
      try
      {
        return (T)services[typeof(T)];
      }
      catch (KeyNotFoundException)
      {
        throw new Exception("The requested service is not registered");
      }

    }


  }
}
