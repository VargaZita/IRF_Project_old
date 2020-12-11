using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando_NKJBXO
{
    public partial class ErtekelesForm : Form
    {
        public ErtekelesForm()
        {
            InitializeComponent();
            ErtekelesClass ec = new ErtekelesClass();
            this.Controls.Add(ec);
        }

        
    }
}
