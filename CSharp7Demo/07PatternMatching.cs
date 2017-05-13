using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
	public static class PatternMatching
	{
		public static void Demo()
		{
			// viz níže
		}

		// Pro účely Dema
		// Jinak zde by rozhodně byla lepší abstraktní metoda Eject na Storage
		public static void Eject_WithoutPatternMatching(Storage storage)
		{
			if (storage == null)
			{
				throw new ArgumentNullException();
			}

			if (storage is UsbKey)
			{
				UsbKey usbKey = (UsbKey)storage;
				if (usbKey.IsPluggedIn)
				{
					usbKey.Unload();
					Console.WriteLine("USB Drive Unloaded.");
				}
			}
			else if (storage is DVD)
			{				
				DVD dvd = (DVD)storage;
				if (dvd.IsInserted)
				{
					// ...
				}
			}
		}

		public static void Eject_WithPatternMatching_Is(Storage storage)
		{
			if (storage == null)
			{
				throw new ArgumentNullException();
			}
			//else
			//{
			if (storage is UsbKey usbKey && usbKey.IsPluggedIn)
				{
					usbKey.Unload();
					Console.WriteLine("USB Drive Unloaded.");
				}
				else if (storage is DVD dvd && dvd.IsInserted)
				{
					// ...
				}
			//}
			//Console.WriteLine(usbKey);
		}

		public static void Eject_WithPatternMatching_Switch(object storage)
		{
			switch (storage)
			{
				case int s :
					return;
				case UsbKey usbKey when usbKey.IsPluggedIn:
					usbKey.Unload();
					Console.WriteLine("USB Drive Unloaded.");
					break;
				case DVD dvd when dvd.IsInserted:
					//...
					break;
				// ...
				case null:
				default:
					throw new ArgumentNullException();
			}
		}

		public abstract class Storage
		{
		}

		public class DVD : Storage
		{
			public bool IsInserted
			{
				get { throw new NotImplementedException(); }
			}
		}

		public class UsbKey : Storage
		{
			public void Unload()
			{
				throw new NotImplementedException();
			}

			public bool IsPluggedIn
			{
				get { throw new NotImplementedException(); }
			}
		}
	}

}
