using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DexDesktop.Models;

namespace DexDesktop
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public ObservableCollection<CuvantModel> Cuvinte = new ObservableCollection<CuvantModel>();
        public AdminWindow()
        {
            InitializeComponent();
            //this.DataContext = this;
        }

        public AdminWindow(string cuvant, string categorie, string definitie)
        {
            InitializeComponent();
            //this.DataContext = this;
        }

        Register registration = new Register();

        //private void buttonAdd_Click(object sender, RoutedEventArgs e)
        //{
        //    string cuvant_box = addWordBox.Text;
        //    string categorie_box = categoryBox.Text;
        //    string definitie_box = definitionBox.Text;

        //    CuvantViewModel cuvantVM = this.DataContext as CuvantViewModel;
        //    cuvantVM.Cuvinte.Add(new CuvantModel() { Cuvant = "lamaie", Categorie = "fructe", Definitie = "fruct" });
        //}
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as CuvantViewModel).Cuvinte.Add(new CuvantModel() 
            { 
                Cuvant = (DataContext as CuvantViewModel).MyCuvantModel.Cuvant, 
                Categorie = (DataContext as CuvantViewModel).MyCuvantModel.Categorie,
                Definitie = (DataContext as CuvantViewModel).MyCuvantModel.Definitie
            });
        }

       

        //private void wordChanged(object sender, TextChangedEventArgs e)
        //{
        //    (DataContext as CuvantModel).Cuvant = sender.ToString();
        //}

        //private void categoryChanged(object sender, TextChangedEventArgs e)
        //{
        //    (DataContext as CuvantModel).Categorie = sender.ToString();
        //}
        //private void definitionChanged(object sender, TextChangedEventArgs e)
        //{
        //    (DataContext as CuvantModel).Definitie = sender.ToString();
        //}

        //private void word_Input(object sender, TextCompositionEventArgs e)
        //{
        //    e.SystemText.Replace("cuvant", "Cuvant");
        //}
        //private void category_Input(object sender, TextCompositionEventArgs e)
        //{
        //    e.SystemText.Replace("categorie", "Categorie");
        //}
        //private void definition_Input(object sender, TextCompositionEventArgs e)
        //{
        //    e.SystemText.Replace("definitie", "Definitie");
        //}

        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            registration.Show();
            Close();
        }
    }
}
