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
    public partial class FSettingsGraphics : Form
    {
        public FSettingsGraphics()
        {
            InitializeComponent();
        }

        private void PBGeneral_Click(object sender, EventArgs e)
        {
            Form FSettingsGeneral = new FSettingsGeneral();
            FSettingsGeneral.ShowDialog();
        }
    }
}
