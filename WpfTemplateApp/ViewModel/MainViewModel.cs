using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfTemplateApp.Model;

namespace WpfTemplateApp.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        #region private
        private User _user;
        #endregion

        #region Properties
        public String Greeting
        {
            get
            {
                if (String.IsNullOrEmpty(_user.Name))
                    return "Welcome...whoever you are.";
                else
                    return "Welcome " + _user.Name;
            }
        }

        public String UserEntry
        {
            get { return _user.Name; }
            set { _user.Name = value; }
        }
        #endregion

        #region Commands
        public ICommand SetNameCommand
        {
            get
            {
                return new RelayCommand(() => OnPropertyChanged("Greeting"));
            }
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            _user = new User();
        }

        public MainViewModel(User user)
        {
            _user = user;
        }
        #endregion


    }
}
