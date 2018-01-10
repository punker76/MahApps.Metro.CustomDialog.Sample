using TinyLittleMvvm;

namespace MahApps.CustomDialog.Sample
{
    public class MainViewModel : PropertyChangedBase, IShell
    {
        private readonly IDialogManager _dialogManager;

        public MainViewModel(IDialogManager dialogManager)
        {
            _dialogManager = dialogManager;
        }
    }
}