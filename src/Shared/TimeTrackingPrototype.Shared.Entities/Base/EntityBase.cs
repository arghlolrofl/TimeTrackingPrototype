using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimeTrackingPrototype.Shared.Entities.Base {
  public abstract class EntityBase : INotifyPropertyChanged {
    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;
    protected void RaisePropertyChanged([CallerMemberName]string propertyName = "")
      => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    #endregion


    private long _id;

    [Key]
    public long Id {
      get { return _id; }
      set { _id = value; RaisePropertyChanged(); }
    }

  }
}
