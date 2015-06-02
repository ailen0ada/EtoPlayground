using System;
using Eto.Forms;

namespace EtoPlayground.Core.Models
{
	public class DialogService : IDialogService
	{
		#region IDialogService implementation

		public void Notify (string msg, string title)
		{
			MessageBox.Show (Application.Instance.MainForm, msg, title);
		}

		#endregion
	}
}

