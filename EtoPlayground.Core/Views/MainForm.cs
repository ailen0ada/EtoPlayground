using System;
using Eto.Forms;
using Eto.Drawing;
using EtoPlayground.Core.Models;

namespace EtoPlayground.Core.Views
{
	/// <summary>
	/// Your application's main form
	/// </summary>
	public class MainForm : Form
	{
		readonly GreetingService _service;

		public MainForm ()
		{
			_service = new GreetingService ();

			Title = "EtoPlayground";
			ClientSize = new Size (348, 80);

			var nameBox = new TextBox{ PlaceholderText = "Your name" };
			nameBox.Bind (c => c.Text, _service, m => m.Name);

			var greetingField = new Label { Text = "Waiting" };
			greetingField.Bind (c => c.Text, _service, m => m.Greeting);

			var upperButton = new Button{ Text = "Upper" };
			upperButton.Click += (sender, e) => _service.ChangeNameUpper ();
			var notifyButton = new Button{ Text = "Notify" };
			notifyButton.Click += (sender, e) => _service.Notify ();

			var layout = new DynamicLayout{ Padding = new Padding(10) };
			layout.BeginVertical ();
			layout.BeginHorizontal ();
			layout.Add (nameBox, true);
			layout.Add (upperButton);
			layout.EndHorizontal ();
			layout.BeginHorizontal ();
			layout.Add (greetingField, true);
			layout.Add (notifyButton);
			layout.EndHorizontal ();
			layout.EndVertical ();
			Content = layout;

			var quitCommand = new Command {
				MenuText = "Quit",
				Shortcut = Application.Instance.CommonModifier | Keys.Q
			};
			quitCommand.Executed += (sender, e) => Application.Instance.Quit ();

			var aboutCommand = new Command { MenuText = "About..." };
			aboutCommand.Executed += (sender, e) => MessageBox.Show (this, "About my app...");

			// create menu
			Menu = new MenuBar {
				Items = {
					// File submenu
					new ButtonMenuItem { Text = "&File", Items = {  } },
				},
				ApplicationItems = {
					// application (OS X) or file menu (others)
					new ButtonMenuItem { Text = "&Preferences..." },
				},
				QuitItem = quitCommand,
				AboutItem = aboutCommand
			};
		}
	}
}
