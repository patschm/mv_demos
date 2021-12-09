using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekenMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string sA = txtA.Text;
            string sB = txtB.Text;

            int a = int.Parse(sA);
            int b = int.Parse(sB);


            //int result = LongAdd(a, b);
            //UpdateLabel(result);

            //var ctx = SynchronizationContext.Current;
            //Task.Run(() => LongAdd(a, b))
            //    .ContinueWith(pt => ctx.Post(UpdateLabel, pt.Result));

            var t1 = LongAddAsync(a, b);//.ConfigureAwait(false);
            int result = await t1;
            
            await UpdateLabel(result);
        }   

        private Task UpdateLabel(object result)
        {
            lblAnswer.Text = result.ToString();
            return Task.CompletedTask;
        }

        private int LongAdd(int a, int b)
        {
            Task.Delay(10000).Wait();
            
            return a + b;
        }
        private Task<int> LongAddAsync(int a, int b)
        {
            return Task.Run(() => LongAdd(a, b));
        }
    }
}
