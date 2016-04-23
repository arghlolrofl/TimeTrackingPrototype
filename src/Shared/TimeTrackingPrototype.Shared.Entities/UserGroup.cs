using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingPrototype.Shared.Entities.Base;

namespace TimeTrackingPrototype.Shared.Entities {
  public class UserGroup : EntityBase {
    private string _description;
    private string _name;
    private ICollection<User> _users;


    public string Name {
      get { return _name; }
      set { _name = value; RaisePropertyChanged(); }
    }

    public string Description {
      get { return _description; }
      set { _description = value; RaisePropertyChanged(); }
    }

    public virtual ICollection<User> Users
    {
      get { return _users; }
      set { _users = value; }
    }

  }
}
