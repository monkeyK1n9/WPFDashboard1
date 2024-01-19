using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDashboard1.Core;

namespace WPFDashboard1.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public HomeViewModel Home { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChange();
            }
        }

        public MainViewModel()
        {
            Home = new HomeViewModel();
            CurrentView = Home;
        }
    }
}
