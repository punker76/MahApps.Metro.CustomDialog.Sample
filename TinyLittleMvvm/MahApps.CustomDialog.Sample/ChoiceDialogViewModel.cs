using System;
using System.Windows.Input;
using MahApps.Metro.Controls.Dialogs;
using TinyLittleMvvm;

namespace MahApps.CustomDialog.Sample
{
    public class ChoiceDialogViewModel : DialogViewModel<MessageDialogResult>
    {
        private string _title;
        private string _message;
        private string _affirmativeButtonText = "Yes";
        private string _negativeButtonText = "No";
        private ICommand _dialogCommand;

        public ChoiceDialogViewModel()
        {
            _dialogCommand = new RelayCommand<MessageDialogResult>(OnDialogCommandExecute, result => true);
        }

        private void OnDialogCommandExecute(MessageDialogResult messageDialogResult)
        {
            Close(messageDialogResult);
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (_title == value) return;
                _title = value;
                NotifyOfPropertyChange(nameof(Title));
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                if (_message == value) return;
                _message = value;
                NotifyOfPropertyChange(nameof(Message));
            }
        }

        public string AffirmativeButtonText
        {
            get { return _affirmativeButtonText; }
            set
            {
                if (_affirmativeButtonText == value) return;
                _affirmativeButtonText = value;
                NotifyOfPropertyChange(nameof(AffirmativeButtonText));
            }
        }

        public string NegativeButtonText
        {
            get { return _negativeButtonText; }
            set
            {
                if (_negativeButtonText == value) return;
                _negativeButtonText = value;
                NotifyOfPropertyChange(nameof(NegativeButtonText));
            }
        }

        public ICommand DialogCommand
        {
            get { return _dialogCommand; }
        }
    }
}