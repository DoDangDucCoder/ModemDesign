using System;
using ModemDesign.Core;


namespace ModemDesign.MVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }

        private object _currenView;

        public object CurrenView 
        {
            get { return _currenView; }
            set 
            {
                _currenView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel() 
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();

            CurrenView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrenView = HomeVM;
            });
            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrenView = DiscoveryVM;
            });
        }
    }
}
