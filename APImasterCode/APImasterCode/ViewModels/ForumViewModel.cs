using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace APImasterCode.ViewModels
{
    class ForumViewModel : BaseViewModel
    {
        public ForumViewModel()
        {
            Title = "FORUM";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}

