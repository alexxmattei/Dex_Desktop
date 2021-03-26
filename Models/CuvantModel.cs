using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexDesktop.Models
{
    public class CuvantModel : INotifyPropertyChanged
    {
        public CuvantModel()
        {

        }

        private string cuvant;
        private string categorie;
        private string definitie;

        public string Cuvant
        {
            get
            {
                return cuvant;
            }
            set
            {
                cuvant = value;
                NotifyPropertyChanged("Cuvant");
            }
        }

        public string Categorie
        {
            get
            {
                return categorie;
            }
            set
            {
                categorie = value;
                NotifyPropertyChanged("Categorie");
            }
        }

        public string Definitie
        {
            get
            {
                return definitie;
            }
            set
            {
                definitie = value;
                NotifyPropertyChanged("Definitie");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged; 
        public void NotifyPropertyChanged(string propertyName) 
        { 
            if (PropertyChanged != null) 
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); 
        }
    }
}
