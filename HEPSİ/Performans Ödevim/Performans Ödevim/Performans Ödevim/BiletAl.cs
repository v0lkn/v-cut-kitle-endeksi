using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Performans_Ödevim
{
    public partial class BiletAl : Form
    {
        public BiletAl()
        {
            InitializeComponent();
        }

        private void BiletAl_Load(object sender, EventArgs e)
        {
            int xartis = 59, yartis = 60, x = 665, y = 158;
            for (int i = 1; i <= 31; i++)
            {
                Button Koltuklar = new Button();
                Koltuklar.Text = i.ToString();
                Koltuklar.Name = "koltuk" + i.ToString();
                Koltuklar.Size = new Size(53,50);
                Koltuklar.Click += Koltuklar_Click;
                Koltuklar.Location = new Point(x,y);
                this.Controls.Add(Koltuklar);
                x = x + xula artis;
                if (i % 2 == 0)
                {
                    x = x +ula  143;
                }
                //else
                //{
                //    x = x+ xartis;
                //}
                if (i % 4 == 0)
                {
                    x = 665;
                    y = y + yartis;
                }
            }
        }

        private void Koltuklar_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
