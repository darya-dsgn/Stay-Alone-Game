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
    public partial class FExit : Form
    {
        public float FExitHeight, FExitWidth, FExitTop, FExitLeft;
        public float YesHeight, YesWidth, YesTop, YesLeft;
        public float NoHeight, NoWidth, NoTop, NoLeft;
       
        public FExit()
        {
            InitializeComponent();
        }

        private void PBYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FExit_Load(object sender, EventArgs e)
        {
            FExitHeight = Height;
            FExitWidth = Width;

            YesHeight = PBYes.Height;
            YesWidth = PBYes.Width;
            YesTop = PBYes.Top;
            YesLeft = PBYes.Left;

            NoHeight = PBNo.Height;
            NoWidth = PBNo.Width;
            NoTop = PBNo.Top;
            NoLeft = PBNo.Left;

        }
        private void FExit_Activated(object sender, EventArgs e)
        {
            Height = (int)(FMainMenu.KHeight * FExitHeight);
            Width = (int)(FMainMenu.KWidth * FExitWidth);
            // Для положения этой формы в середине родительской формы ------------------------------
            Top = (int)(FMainMenu.FormTop + (FMainMenu.FormHeight * FMainMenu.KHeight) / 2 - Height / 2);
            Left = (int)(FMainMenu.FormLeft + (FMainMenu.FormWidth * FMainMenu.KWidth) / 2 - Width / 2);
            // -------------------------------------------------------------------------------------

            PBYes.Height = (int)(FMainMenu.KHeight * YesHeight);
            PBYes.Width = (int)(FMainMenu.KWidth * YesWidth);
            PBYes.Top = (int)(FMainMenu.KHeight * YesTop);
            PBYes.Left = (int)(FMainMenu.KWidth * YesLeft);
            PBYes.Refresh();

            PBNo.Height = (int)(FMainMenu.KHeight * NoHeight);
            PBNo.Width = (int)(FMainMenu.KWidth * NoWidth);
            PBNo.Top = (int)(FMainMenu.KHeight * NoTop);
            PBNo.Left = (int)(FMainMenu.KWidth * NoLeft);
            PBNo.Refresh();
            
        }
    }

}
