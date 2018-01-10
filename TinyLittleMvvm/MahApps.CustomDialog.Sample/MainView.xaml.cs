using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using TinyLittleMvvm;

namespace MahApps.CustomDialog.Sample
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : MetroWindow
    {
        private IDialogManager _dialogManager;

        public MainView(IDialogManager dialogManager)
        {
            InitializeComponent();
            _dialogManager = dialogManager;
        }

        private async void ButtonOnClick(object sender, RoutedEventArgs e)
        {
            var dialogViewModel = new ChoiceDialogViewModel();
            dialogViewModel.Title = "What's your choice?";
            dialogViewModel.Message = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt?";

            var result = await _dialogManager.ShowDialogAsync(dialogViewModel);
            await this.ShowMessageAsync("Result", $"Your choice was: {result}");
        }
    }
}