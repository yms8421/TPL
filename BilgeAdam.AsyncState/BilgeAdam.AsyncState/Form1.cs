using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.AsyncState
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private async void btnProcess1_Click(object sender, EventArgs e)
        {
            await LongRunningLoop(1, (int value, bool updateUI) =>
            {
                if (updateUI)
                {
                    btnProcess1.Invoke(new Action(() => { progressBar1.Value = value; }));
                }
            });

            btnProcess1.Text = "Huray!";
        }

        private async void btnProcess2_Click(object sender, EventArgs e)
        {
            await LongRunningLoop(1, (int value, bool updateUI) =>
            {
                if (updateUI)
                {
                    btnProcess2.Invoke(new Action(() => { btnProcess2.Text = value.ToString(); }));
                }
            });
            btnProcess2.Text = "Huray!";
        }

        private async void btnProcess3_Click(object sender, EventArgs e)
        {
            await LongRunningLoop(1, (int value, bool updateUI) =>
            {
                if (updateUI)
                {
                    btnProcess3.Invoke(new Action(() => { btnProcess3.Text = value.ToString(); }));
                }
            });
            btnProcess3.Text = "Huray!";
        }
        /// <summary>
        /// Creates a loop with 100K times of parameter
        /// </summary>
        /// <param name="count">loop count</param>
        /// <param name="callback">callback method</param>
        private async Task LongRunningLoop(int count, Action<int, bool> callback)
        {
            await Task.Run(() =>
            {
                var length = count * 1000000;
                for (int i = 0; i <= length; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        var a = Math.Sin(i);
                        var b = Math.Tan(i);
                        var c = Math.Pow(a, Math.Sqrt(b));
                    }
                    callback(i, i % 50000 == 0);
                }
            });
        }

        private void SetForm(int value)
        {
            this.Text = value.ToString();
        }

        private void btnLongProcess_Click(object sender, EventArgs e)
        {
            var t = Task.Run(() => LongTaskWith5Seconds());
            t.ContinueWith((v) => 
            {
                if (!v.IsFaulted)
                {
                    txtResult.Invoke(new Action(() => { txtResult.Text = v.Result.ToString(); }));
                }
            });

            
        }

        private async Task<int> LongTaskWith5Seconds()
        {
            await Task.Delay(5000);
            return new Random().Next(int.MaxValue);
        }
    }
}
