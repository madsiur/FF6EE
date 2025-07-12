using ReactiveUI;

namespace FF6EE.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get => _currentView;
            set => this.RaiseAndSetIfChanged(ref _currentView, value);
        }

        private MainMenuViewModel _mainMenuVM;
        public MainMenuViewModel MainMenuVM
        {
            get => _mainMenuVM;
            set => this.RaiseAndSetIfChanged(ref _mainMenuVM, value);
        }

        public MainWindowViewModel()
        {
            //var fileDialogService = new FileDialogService();
            //var windowService = new WindowService();
            //CurrentView = new MainMenuViewModel(fileDialogService, windowService);
            CurrentView = new MainMenuViewModel();
        }
    }
}
