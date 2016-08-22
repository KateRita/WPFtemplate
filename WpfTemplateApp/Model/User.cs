using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfTemplateApp.Model
{
    class User
    {
        #region Properties
        private String _name;
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion

        #region Constructors
        public User()
        {
            _name = "";
        }

        public User(String userName)
        {
            _name = userName;
        }
        #endregion

        #region Public Methods


        #endregion

        #region Private Methods
        

        #endregion
    }
}
