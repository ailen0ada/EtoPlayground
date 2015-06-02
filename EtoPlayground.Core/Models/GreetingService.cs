using System;

namespace EtoPlayground.Core.Models
{
    public class GreetingService : NotificationObject
    {
        readonly IDialogService _dialog;

        public GreetingService()
        {
			_dialog = new DialogService();
            Name = "Xamarin";
        }

        string _name;

        public string Name
        {
            get { return _name; }
			set { SetProperty(ref _name, value); Greeting = string.Format ("Hello, {0}!", value); }
        }

		string _greeting;

		public string Greeting {
			get{ return _greeting; }
			set{ SetProperty (ref _greeting, value); }
		}

        public void ChangeNameUpper()
        {
            Name = _name.ToUpperInvariant();
        }

        public void Notify()
        {
            _dialog.Notify(_name, "Greeting.");
        }
    }
}

