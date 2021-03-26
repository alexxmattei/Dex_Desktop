using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexDesktop.Models
{
    public class UserViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; 
        public void NotifyPropertyChanged(string propertyName) 
        { 
            if (this.PropertyChanged != null) 
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); 
        }

        private UserModel myUser;

        public UserModel MyUser
        {
            get
            {
                return myUser;
            }
            set
            {
                myUser = value;
                NotifyPropertyChanged("MyUser");
            }
        }

        public ObservableCollection<UserModel> Users { get; set; }

        public UserViewModel()
        {
            MyUser = new UserModel();
            MyUser.Firstname = "Alex";
            MyUser.Lastname = "Matei";
            MyUser.Email = "alexxmattei@gmail.com";
            MyUser.Password = "parola";
            MyUser.ConfirmPassword = "parola";
            MyUser.Address = "Adresa";

            Users = new ObservableCollection<UserModel>()
            {
                new UserModel()
                {
                    Firstname = "Ion",
                    Lastname = "Petre",
                    Email = "ionpetre@gmail.com",
                    Password = "parola",
                    ConfirmPassword ="parola",
                    Address ="adresa"
                }
            };
        }

    }
}
