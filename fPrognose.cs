using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meteo_decode
{
    public partial class fPrognose : Form
    {
        public fPrognose()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fMeteoDecode.ActiveForm.Activate();
            fMeteoDecode.ActiveForm.Text = "asdasdasdasdasdasd";
        }
    }
}
