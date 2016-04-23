using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingPrototype.Shared.Entities.Base;

namespace TimeTrackingPrototype.Shared.Entities {
  public class User : EntityBase {
    private string _lastName;
    private string _firstName;


    public string FirstName {
      get { return _firstName; }
      set { _firstName = value; RaisePropertyChanged(); }
    }

    public string LastName {
      get { return _lastName; }
      set { _lastName = value; RaisePropertyChanged(); }
    }
  }
}
