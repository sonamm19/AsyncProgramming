using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncProgramming
{
	public partial class Form1 : Form
	{
		delegate void TaskTextHandler(string text);
		public Form1()
		{
			InitializeComponent();
		}

		private List<string> Prepdata()
		{
			List<string> urlList = new List<string>();
			urlList.Add("https://stackoverflow.com/questions/1048199/easiest-way-to-read-from-a-url-into-a-string-in-net/1048204");
			urlList.Add("https://nz.news.yahoo.com/");
			urlList.Add("https://stackoverflow.com/questions/298745/how-do-i-send-a-cross-domain-post-request-via-javascript?rq=1");
			urlList.Add("https://stackoverflow.com/questions/46155/how-can-i-validate-an-email-address-in-javascript?rq=1");
			urlList.Add("https://stackoverflow.com/questions/55686928/using-stopwatch-in-c-sharp");

			return urlList;
		}

		private void SetTaskText(string taskId)
		{
			string separator = "";
			if (!string.IsNullOrEmpty(txtTaskId.Text))
				separator = "_";
			txtTaskId.Text += separator + taskId ;
		}
		DataModel DownloadUrl(string url)
		{
			try
			{
				string s;
				DataModel dm = new DataModel();
				dm.urlName = url;
				if (this.txtTaskId.InvokeRequired)
				{
					TaskTextHandler d = SetTaskText;
					Invoke(d, Thread.CurrentThread.ManagedThreadId.ToString());
				}
				else
				{
					SetTaskText(Thread.CurrentThread.ManagedThreadId.ToString());
				}
				Console.WriteLine("**" + Thread.CurrentThread.ManagedThreadId);
				using (WebClient client = new WebClient())
				{
					s = client.DownloadString(url);
				}

				dm.count = s.Length;
				return dm;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
		void PrintInfo(DataModel dm)
		{
			richTxtInfo.Text += "\ncount " + dm.count + " " + dm.urlName;
		}

		/// <summary>
		/// Download contents from all website in a sequential manner. One by one
		/// Waits for results and UI gets stuck until all work is done.
		/// Result shows on the screen all at once
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void syncMethod_Click(object sender, EventArgs e)
		{
			txtTaskId.Text = "";
			richTxtInfo.Text = "";
			List<string> urls = Prepdata();
			var timer = new Stopwatch();
			timer.Start();
			DownloadContents(urls);
			timer.Stop();
			txtSyncTime.Text = timer.ElapsedMilliseconds.ToString();
		}

		/// <summary>
		/// Download content asynchronously (Not all together)
		/// Still waits for each other but UI allows user to go on with their work. Even while we are waiting for this.
		/// Result shows on the screen on by one
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void asyncMethod_Click(object sender, EventArgs e)
		{
			txtTaskId.Text = "";
			richTxtInfo.Text = "";
			List<string> urls = Prepdata();
			var timer = new Stopwatch();
			timer.Start();
			await DownloadContentsAsync(urls);
			timer.Stop();
			txtAsyncTime.Text = timer.ElapsedMilliseconds.ToString();
		}

		/// <summary>
		/// Download content asynchronously (all together)
		/// Still waits for result for each other but UI alows user to go on with their work. Even while we are waiting for this.
		/// Result shows on the screen all at once
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void parallelMethod_Click(object sender, EventArgs e)
		{
			txtTaskId.Text = "";
			richTxtInfo.Text = "";
			List<string> urls = Prepdata();
			var timer = new Stopwatch();
			timer.Start();
			await DownloadContentsParallelAsync(urls);
			timer.Stop();
			txtParellelTime.Text = timer.ElapsedMilliseconds.ToString();
		}

		#region Sync
		void DownloadContents(List<string> urls)
		{
			ReadUrlLength(urls);
		}


		void ReadUrlLength(List<string> urls)
		{
			foreach (string url in urls)
			{
				DataModel dm = DownloadUrl(url);
				PrintInfo(dm);
			}
		}
		#endregion

		#region Async
		async Task ReadUrlLengthAsync(List<string> urls)
		{
			List<Task<DataModel>> tasks = new List<Task<DataModel>>();

			foreach (string url in urls)
			{
				DataModel dm = await Task.Run(()=> DownloadUrl(url));
				PrintInfo(dm);
			}
		}
		async Task DownloadContentsAsync(List<string> urls)
		{
			await ReadUrlLengthAsync(urls);
		}

		#endregion

		#region ParallelAsync
		async Task ReadUrlLengthParallelAsync(List<string> urls)
		{
			List<Task<DataModel>> tasks = new List<Task<DataModel>>();

			foreach (string url in urls)
			{
				tasks.Add(Task.Run(() => DownloadUrl(url)));
			}

			var result = await Task.WhenAll(tasks);
			foreach (var item in result)
			{
				PrintInfo(item);
			}

		}
		async Task DownloadContentsParallelAsync(List<string> urls)
		{
			await ReadUrlLengthParallelAsync(urls);
		}

		#endregion

	}

	public class DataModel
	{
		public int count;
		public string urlName;
	}
}
