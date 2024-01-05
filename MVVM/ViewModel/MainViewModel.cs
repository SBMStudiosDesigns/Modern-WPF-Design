using ModernWPFDesign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWPFDesign.MVVM.ViewModel
{
    class MainViewModel : ObservableObjects
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public RelayCommand FeaturedViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }
        public FeaturedViewModel FeaturedVM { get; set; }
        private object _currentView;

        // get+set current view
        public object CurrentView
        {
            get { return _currentView; }
            set 
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        // change content view
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            FeaturedVM = new FeaturedViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => { CurrentView = HomeVM;});
            DiscoveryViewCommand = new RelayCommand(o => { CurrentView = DiscoveryVM;});
            FeaturedViewCommand = new RelayCommand(o => { CurrentView = FeaturedVM;});
        }
    }
}
