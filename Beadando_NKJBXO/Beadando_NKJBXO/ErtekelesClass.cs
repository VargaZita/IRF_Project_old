using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando_NKJBXO
{
    class ErtekelesClass : Button
    {
        private int csillagszam;
        public int Csillagszam
        {
            get { return csillagszam; }
            set
            {
                csillagszam = value;
                if (csillagszam < 1)
                    csillagszam = 5;
                else if (csillagszam > 5)
                    csillagszam = 1;

                if (csillagszam == 0)
                    Text = "";

                else
                    Text = csillagszam.ToString();
            }
        }

        public ErtekelesClass()
        {
            Height = 30;
            Width = Height;
            BackColor = Color.White;
            Csillagszam = 5;
            MouseDown += ErtekelesClass_MouseDown;
        }

        private void ErtekelesClass_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Csillagszam++;
            if (e.Button == MouseButtons.Right)
                Csillagszam--;
        }
    }
}
