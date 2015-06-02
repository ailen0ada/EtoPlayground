using System;
using Eto.Forms;

namespace EtoPlaygroundXamMac2
{
	public class Program
	{
		[STAThread]
		public static void Main (string[] args)
		{
			new Application (Eto.Platforms.XamMac2).Run (new EtoPlayground.Core.Views.MainForm ());
		}
	}
}

