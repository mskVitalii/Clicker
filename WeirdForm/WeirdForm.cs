using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeirdForm
{
    public partial class WeirdForm : Form
    {
        static Random Random = new Random();
        public WeirdForm()
        {
            InitializeComponent();
            this.MouseClick += (object sender, MouseEventArgs e) => BackColor = Color.PaleVioletRed;
            //this.MouseEnter += (object sender, EventArgs e) => BackColor = DefaultBackColor;
            //this.MouseDoubleClick += (object sender, MouseEventArgs e) => {
            //    Size = new Size(new Point(Random.Next(100, 1001), Random.Next(100, 1001)));
            //};
            // Virus
            this.MouseEnter += (object sender, EventArgs e) =>
            {
                Location = new Point(Random.Next(0, 1920 - Size.Width),
                                     Random.Next(0, 880 - Size.Height));
            };
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        static int LohCounter = 0;
        string defaultText = "Количество промахов: ";

        private void EXITBtn_MouseEnter(object sender, EventArgs e)
        {
            GetAway();
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            GetAway();
        }

        private void WeirdForm_MouseHover(object sender, EventArgs e)
        {
            GetAway();
        }

        private void GetAway()
        {
            Location = new Point(Random.Next(0, 1920 - Size.Width),
                                 Random.Next(0, 880 - Size.Height));
            LohCounter = unchecked(LohCounter + 1);
            Loh.Text = defaultText + LohCounter;
        }
    }
}
