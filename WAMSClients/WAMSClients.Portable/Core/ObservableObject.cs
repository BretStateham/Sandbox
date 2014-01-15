using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WAMSClients.Portable.Core
{
  public class ObservableObject : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    public void Set<T>(ref T Field, T Value, [CallerMemberName] string PropertyName = "")
    {
      if (!Equals(Field, Value))
      {
        Field = Value;
        NotifyPropertyChanged(PropertyName);
      }
    }

    private void NotifyPropertyChanged(string PropertyName)
    {
      if (PropertyChanged != null)
        PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
    }
  }
}
