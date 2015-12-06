using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Jcifs;
using Jcifs.Smb;

namespace samba
{
	[Activity (Label = "samba", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
				getFileContents ();
			};
		}

		// This is NOT best-practice code, just showing a demo Jcifs api call
		public async Task getFileContents ()
		{
			await Task.Run (() => {
				var smbStream = new SmbFileInputStream ("smb://guest@10.10.10.5/code/test.txt");
				byte[] b = new byte[8192];
				int n;
				while ((n = smbStream.Read (b)) > 0) {
					Console.Write (Encoding.UTF8.GetString (b).ToCharArray (), 0, n);
				}
				Button button = FindViewById<Button> (Resource.Id.myButton);
				RunOnUiThread(() => {
					button.Text = Encoding.UTF8.GetString (b);
				});
			}
			).ContinueWith ((Task arg) => {
				Console.WriteLine (arg.Status);
				if (arg.Status == TaskStatus.Faulted)
					Console.WriteLine (arg.Exception);
			}
			);
		}
	}
}


