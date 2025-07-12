using FF6EE.ViewModels;

namespace FF6EE.Interfaces
{
    public interface IWindowService
    {
        void Show<TViewModel>(params object[] parameters) where TViewModel : ViewModelBase;
        bool? ShowDialog<TViewModel>(params object[] parameters) where TViewModel : ViewModelBase;
        void CloseDialog(bool? dialogResult);
    }
}
