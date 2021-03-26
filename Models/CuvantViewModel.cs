using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexDesktop.Models
{
    public class CuvantViewModel : INotifyPropertyChanged
    {
       public event PropertyChangedEventHandler PropertyChanged; 
        public void NotifyPropertyChanged(string propertyName) 
        { 
            if (this.PropertyChanged != null) 
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); 
        }

        private CuvantModel myCuvantModel;

        public CuvantModel MyCuvantModel
        {
            get
            {
                return myCuvantModel;
            }
            set
            {
                myCuvantModel = value;
                NotifyPropertyChanged("MyCuvantModel");
            }
        }

        public ObservableCollection<CuvantModel> Cuvinte { get; set; }

        public CuvantViewModel()
        {
            MyCuvantModel = new CuvantModel();
            MyCuvantModel.Categorie = "Fructe";
            MyCuvantModel.Cuvant = "Para";
            MyCuvantModel.Definitie = "Un fruct care creste in par";

            Cuvinte = new ObservableCollection<CuvantModel>()
            {
                new CuvantModel()
                {
                    Cuvant = "Mar",
                    Categorie = "Fructe",
                    Definitie = "Un fruct preferat de Alba ca Zapada"
                },
                new CuvantModel()
                {
                    Cuvant = "Piersica",
                    Categorie = "Fructe",
                    Definitie = "Un alt fruct mai exotic"
                }
            };
        }
    }
}
