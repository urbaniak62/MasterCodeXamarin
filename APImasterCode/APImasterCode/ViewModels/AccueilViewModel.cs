using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace APImasterCode.ViewModels
{
    public class AccueilViewModel : BaseViewModel
    {
        public AccueilViewModel()
        {
            Title = "MASTER CODE";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

       

        public ICommand OpenWebCommand { get; }
    }
}