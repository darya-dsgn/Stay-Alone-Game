using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stay_Alone_интерфейс
{
    public partial class FSettingsGeneral : Form
    {
        public FSettingsGeneral()
        {
            InitializeComponent();
        }

        private void FSettings_Load(object sender, EventArgs e)
        {

        }

        private void PBBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PBGraphics_Click(object sender, EventArgs e)
        {
            Form FSettingsGraphics = new FSettingsGraphics();
            FSettingsGraphics.ShowDialog();
        }
    }
}
