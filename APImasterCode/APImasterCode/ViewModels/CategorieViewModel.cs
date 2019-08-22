using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using APImasterCode.Models;
using APImasterCode.Views;
using System.Windows.Input;

namespace APImasterCode.ViewModels
{
    public class CategorieViewModel : BaseViewModel
    {

        public ObservableCollection<Categorie> Categories { get; set; }

        public Command LoadCategorieCommand { get; set; }
        public CategorieViewModel()
        {

            Categories = new ObservableCollection<Categorie>();
            LoadCategorieCommand = new Command(async () => await ExcuteLoadCategoriesCommand());
        }
        async Task ExcuteLoadCategoriesCommand()
        {
            if (IsBusy)
                return;
            IsBusy = true;
            try
            {
                Categories.Clear();
            }
            catch (global::System.Exception)
            {

                throw;
            }
        }
        
        public ICommand OpenWebCommand { get; }

    }

}