using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSample.ViewModel
{
    public partial class MainViewModel : ObservableRecipient
    {
        [ObservableProperty]
        public ObservableObject currentViewModel = new MenuViewModel();
    }
}
