using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using MVVN_WPF.Model;
using System.Data;

namespace MVVN_WPF.ViewModel
{
     class UserViewModel
    {
        private IList<User> _users;
        public UserViewModel() 
        { 
            _users = new List<User>
            {
                new User { Id = 1, FirstName = "NANA", LastName = "SANI", City = "DAKAR", State = "SN", Country = "SENEGAL" },
                new User { Id = 2, FirstName = "NANA", LastName = "SANI", City = "DAKAR", State = "SN", Country = "SENEGAL" },
                new User { Id = 3, FirstName = "NANA", LastName = "SANI", City = "DAKAR", State = "SN", Country = "SENEGAL"}
            };
        }
        public IList<User> users 
        { 
            get { return _users; } 
            set { _users = value; }
        }
        private ICommand _mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (_mUpdater == null)
                    _mUpdater = new Updater();
                return _mUpdater;
            }
            set { _mUpdater = value; }
        }
        private class Updater : ICommand 
        {
            #region Icommand Members
            public bool CanExecute(object parameter) 
            {
                return true;
            }
            public event EventHandler CanExecuteChanged;
            public void Execute(object parameter) 
            {
            }
            #endregion
        }
    }
}
