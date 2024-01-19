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
        // commands to switch between views
        public RelayCommand NavigateToHomeCommand { get; set; }
        public RelayCommand NavigateToDiscoveryCommand { get; set; }
        public HomeViewModel Home { get; set; }
        public DiscoveryViewModel Discovery { get; set; }

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
            Discovery = new DiscoveryViewModel();
            CurrentView = Home;

            NavigateToHomeCommand = new RelayCommand(
                o => 
                    {
                       CurrentView = Home;
                    }, 
                null
            );

            NavigateToDiscoveryCommand = new RelayCommand(
               o =>
               {
                   CurrentView = Discovery;
               },
               null
           );
        }
    }
}
