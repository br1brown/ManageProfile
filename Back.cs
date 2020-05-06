using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Profili {
	public static class Back {

		public const string CARTELLA = "prof";
		public const string EXTENSION = ".txt";

		public static string[] GetProfiles {
			get {
				Directory.CreateDirectory(CARTELLA);
				try {
					return Directory.GetFiles(CARTELLA,"*"+EXTENSION).Select(fil => Path.GetFileNameWithoutExtension(fil)).ToArray();
				} catch {
					return new List<string>().ToArray();
				}
			}
		}

		[DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);

		private static string Realfile(string Profile) {
			return CARTELLA + @"\" + Profile + EXTENSION;
		}
		public static string[] GetItems(string Profile) {
			try {
				return File.ReadAllLines(Realfile(Profile)).ToArray();
			} catch {
				return new List<string>().ToArray();
			}
		}
		public static void SetItem(string Profile, string[] item, Func<bool> REWRITE_IF_EXIST) {
			var szwirte = Realfile(Profile);
			bool write = true;
			if (File.Exists(szwirte))
				write = REWRITE_IF_EXIST();
			if (write)
				File.WriteAllLines(szwirte, item);
		}
		public static void Dels(string Profile) {
			File.Delete(Realfile(Profile));
		}

		private static Dictionary<string, string> _installati;
		public static Dictionary<string, string> INSTALLATI {
			get {
				if (_installati == null) {
					_installati = new Dictionary<string, string>();
					List<string> keys = new List<string>() {
						  @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall",
						  @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall"
						};
					foreach (var uninstallKey in keys)
						using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey)) {
							foreach (string skName in rk.GetSubKeyNames()) {
								using (RegistryKey sk = rk.OpenSubKey(skName)) {
									try {

										var displayName = sk.GetValue("DisplayName")?.ToString();
										var path = sk.GetValue("InstallLocation")?.ToString();
										if (!string.IsNullOrEmpty(displayName) && !string.IsNullOrEmpty(path)) {
											_installati.Add(displayName, path);
										}
									} catch (Exception ex) { }
								}
							}
						}
				}
				return _installati;
			}
		}



	}
}
