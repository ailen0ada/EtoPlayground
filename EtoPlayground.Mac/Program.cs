using System;
using Eto.Forms;

namespace EtoPlayground.Mac
{
	public class Program
	{
		[STAThread]
		public static void Main (string[] args)
		{
			new Application (Eto.Platforms.Mac).Run (new EtoPlayground.Core.Views.MainForm ());
		}
	}
}

