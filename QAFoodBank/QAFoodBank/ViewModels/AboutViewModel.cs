using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace QAFoodBank
{
    public class AboutViewModel : ViewModelBase
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.qafb.org/")));
        }

        public ICommand OpenWebCommand { get; }
    }
}
