using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Stay_Alone_интерфейс
{
    public partial class FMainMenu : Form
    {
        public static float FormHeight, FormWidth, FormTop, FormLeft;
        public float NameHeight, NameWidth, NameTop, NameLeft;
        public float PlayHeight, PlayWidth, PlayTop, PlayLeft;
        public float SettingsHeight, SettingsWidth, SettingsTop, SettingsLeft;
        public float ExitHeight, ExitWidth, ExitTop, ExitLeft;

        private void FMainMenu_Move(object sender, EventArgs e)
        {
            FormTop = Top;
            FormLeft = Left;
        }

        private void PBSettings_Click(object sender, EventArgs e)
        {
            Form FSettings = new FSettingsGeneral();
            FSettings.ShowDialog();
        }

        public float VolumeHeight, VolumeWidth, VolumeTop, VolumeLeft;
        public float VRegHeight, VRegWidth, VRegTop, VRegLeft;

        public static float KHeight, KWidth;  //Коэффициентs изменения формы
        public int Min; // Позиция при минимальной громкости
        public int Max; // Позиция при максимальной громкости

        public int PosRegProc; // Позиция регулятора громкости в процентах
        public FMainMenu()
        {
            InitializeComponent();
        }
        public void MinMaxReg() // Функция определения миним-го и максим-го положений регулятора громкости
        {
            Min = (int)(PBVolume.Left + KWidth * 30); // Минимум от левого края формы в пикселях
            Max = (int)(PBVolume.Left + PBVolume.Width   - KWidth * 17); // Максимум от левого края формы в пикселях
        }

        private void FMainMenu_Load(object sender, EventArgs e)
        {
            //Получаем исходные координаты формы и всех элементов:
            FormHeight = Height;
            FormWidth = Width;
            KWidth = 1;
            KHeight = 1;

            NameHeight = PBName.Height;
            NameWidth = PBName.Width;
            NameTop = PBName.Top;
            NameLeft = PBName.Left;

            PlayHeight = PBPlay.Height;
            PlayWidth = PBPlay.Width;
            PlayTop = PBPlay.Top;
            PlayLeft = PBPlay.Left;

            SettingsHeight = PBSettings.Height;
            SettingsWidth = PBSettings.Width;
            SettingsTop = PBSettings.Top;
            SettingsLeft = PBSettings.Left;

            ExitHeight = PBExit.Height;
            ExitWidth = PBExit.Width;
            ExitTop = PBExit.Top;
            ExitLeft = PBExit.Left;

            VolumeHeight = PBVolume.Height;
            VolumeWidth = PBVolume.Width;
            VolumeTop = PBVolume.Top;
            VolumeLeft = PBVolume.Left;

            VRegHeight = PBReg.Height;
            VRegWidth = PBReg.Width;
            VRegTop = PBReg.Top;
            VRegLeft = PBReg.Left;

            MinMaxReg();
            PosRegProc = (int)(100 * (VRegLeft - Min) / (Max - Min)); // Позиция регулятора в процентах громкости

            SystemVolumeConfigurator SVCClass = new SystemVolumeConfigurator(); // Вызываем класс SystemVolumeConfigurator из файла
            SVCClass.SetVolume(PosRegProc); // Вызываем из класса SystemVolumeConfigurator функцию SetVolume

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Riders_on_the_Storm);
            player.PlayLooping(); // PlayLooping - проигрывает музыку по кругу
        }

        private void PBExit_Click(object sender, EventArgs e)
        {
            Form FExit = new FExit();
            FExit.ShowDialog();
        }

        private void FMainMenu_Resize(object sender, EventArgs e)
        {
            KHeight = Height / FormHeight; //Коэффициент изменения высоты формы
            KWidth = Width / FormWidth;    //Коэффициент изменения ширины формы

            PBName.Height = (int)(KHeight * NameHeight);
            PBName.Width = (int)(KWidth * NameWidth);
            PBName.Top = (int)(KHeight * NameTop);
            PBName.Left = (int)(KWidth * NameLeft);
            PBName.Refresh();
            PBPlay.Height = (int)(KHeight * PlayHeight);
            PBPlay.Width = (int)(KWidth * PlayWidth);
            PBPlay.Top = (int)(KHeight * PlayTop);
            PBPlay.Left = (int)(KWidth * PlayLeft);
            PBPlay.Refresh();
            PBSettings.Height = (int)(KHeight * SettingsHeight);
            PBSettings.Width = (int)(KWidth * SettingsWidth);
            PBSettings.Top = (int)(KHeight * SettingsTop);
            PBSettings.Left = (int)(KWidth * SettingsLeft);
            PBSettings.Refresh();
            PBExit.Height = (int)(KHeight * ExitHeight);
            PBExit.Width = (int)(KWidth * ExitWidth);
            PBExit.Top = (int)(KHeight * ExitTop);
            PBExit.Left = (int)(KWidth * ExitLeft);
            PBExit.Refresh();
            PBVolume.Height = (int)(KHeight * VolumeHeight);
            PBVolume.Width = (int)(KWidth * VolumeWidth);
            PBVolume.Top = (int)(KHeight * VolumeTop);
            PBVolume.Left = (int)(KWidth * VolumeLeft);
            PBVolume.Refresh();
            PBReg.Height = (int)(KHeight * VRegHeight);
            PBReg.Width = (int)(KWidth * VRegWidth);
            PBReg.Top = (int)(KHeight * VRegTop);
            //PBReg.Left = (int)(KWidth * VRegLeft);
            PBReg.Refresh();

            MinMaxReg();
            PBReg.Left = (int)(PosRegProc * (Max - Min) / 100 + Min); // Позиция регулятора от левого края формы в пикселях
        }

        private void PBReg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Cursor.Position.X - Left >= Min && Cursor.Position.X - Left <= Max)
                    PBReg.Location = new Point((int)(Cursor.Position.X - Left - KWidth * 10), PBVolume.Top);

            PosRegProc = (int)(100 * (PBReg.Left - Min) / (Max - Min)); // Позиция регулятора в процентах громкости

            SystemVolumeConfigurator SVCClass = new SystemVolumeConfigurator(); // Вызываем класс SystemVolumeConfigurator из файла
            SVCClass.SetVolume(PosRegProc); // Вызываем из класса SystemVolumeConfigurator функцию SetVolume
        }
    }
}
