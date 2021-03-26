using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexDesktop.Models
{
    public class UserModel : INotifyPropertyChanged
    {
        private string _firstname;
        private string _lastname;
        private string _email;
        private string _password;
        private string _confirmPassword;
        private string _address;

        public UserModel()
        {

        }

        public UserModel(string firstname, string lastname, string email, string password, string address)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            Address = address;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public void NotifyPropertyChanged(string propertyName) 
        { 
            if (PropertyChanged != null) 
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); 
        }

        public string Firstname
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                OnPropertyChanged("Firstname");
            }
        }
        public string Lastname
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
                OnPropertyChanged("Lastname");
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }
        [Required]
        [DataType(DataType.Password)]
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set
            {
                if (value != _password)
                {
                    throw new ArgumentException("Parolele trebuie sa fie identice!");
                }
                _confirmPassword = value;
                OnPropertyChanged("ConfirmPassword");
            }
        }
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged("Address");
            }
        }
    }
}
