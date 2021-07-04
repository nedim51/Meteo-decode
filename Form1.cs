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
    public partial class fMeteoDecode : Form
    {
        public fMeteoDecode()
        {
            InitializeComponent();
        }
        
        int vCount = 1; // Счетчик таймера

        // Таймер
        private void tWorkApp_Tick(object sender, EventArgs e)
        {

            if (vCount > 2)
            {
                vCount = 1;
            }
            else
            {
                vCount++;
            }

            string sTmp = "Выполняется" + new string('.', vCount);

            this.Text = sTmp;
            lProgress.Text = sTmp;
        }

        private void bDecode_Click(object sender, EventArgs e)
        {
            tWorkApp.Enabled = true;
        }

        private void bPrognose_Click(object sender, EventArgs e)
        {
            fPrognose Prognose = new fPrognose();
            Prognose.Show();
        }
    }
}
