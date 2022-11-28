using System;
using System.ComponentModel;

namespace MVVN_WPF.Model
{
    public class User:INotifyPropertyChanged
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _city;
        private string _state;
        private string _country;
        
        public int Id 
        {
            get{return _id;}
            set{_id = value; OnPropertyChanged("_id");}
        }
        public string FirstName
        {
            get{return _firstName;} 
            set{_firstName = value; OnPropertyChanged("FirstName");} 
        }
        public string LastName 
        {
            get{return _lastName;}
            set{_lastName = value; OnPropertyChanged("LastName");}
        }
        public string City 
        {
            get { return _city; }
            set { _city = value; OnPropertyChanged("City"); }
        }
        public string State 
        {
            get { return _state; }
            set { _state = value; OnPropertyChanged("State"); }
        }
        public string Country 
        {
            get { return _country; }
            set { _country = value;OnPropertyChanged("Country"); }
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
