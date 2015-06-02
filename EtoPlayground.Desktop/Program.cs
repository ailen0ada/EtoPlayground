using System;
using Eto.Forms;

namespace EtoPlayground.Desktop
{
	public class Program
	{
		[STAThread]
		public static void Main (string[] args)
		{
			new Application (Eto.Platform.Detect).Run (new EtoPlayground.Core.Views.MainForm ());
		}
	}
}

