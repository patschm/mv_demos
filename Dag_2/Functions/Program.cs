using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Form f1 = new Form();
            f1.Text = "Hoi";

            Button btn = new Button();
            btn.Location = new Point { X = 100, Y = 200 };
            btn.Click += Bla;
            btn.Text = "OK";

            f1.Controls.Add(btn);
            f1.ShowDialog();

            Console.ReadLine();
        }

        static void Bla(object sender, EventArgs e)
        {
            Console.WriteLine("Blaablabla");
        }
    }
}
