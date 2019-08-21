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
    public class ItemsViewModel : BaseViewModel
    {


        public ItemsViewModel()
        {
            Title = "CONNEXION";
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
       
    }
    
}