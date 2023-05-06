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
        public float WindowHeight, WindowWidth,WindowTop, WindowLeft;
        public float YesHeight, YesWidth, YesTop, YesLeft;
        public float NoHeight, NoWidth, NoTop, NoLeft;
        public float GeneralLHeight, GeneralLWidth, GeneralLTop, GeneralLLeft;
        public float GraphicsLHeight, GraphicsLWidth, GraphicsLTop, GraphicsLLeft;
        public float ControlLHeight, ControlLWidth, ControlLTop, ControlLLeft;
        public float General1Height, General1Width, General1Top, General1Left;
        public float General2Height, General2Width, General2Top, General2Left;
        public float Graphics1Height, Graphics1Width, Graphics1Top, Graphics1Left;
        public float Graphics2Height, Graphics2Width, Graphics2Top, Graphics2Left;
        public float Control1Height, Control1Width, Control1Top, Control1Left;
        public float Control2Height, Control2Width, Control2Top, Control2Left;
        public float Back1Height, Back1Width, Back1Top, Back1Left;
        public float Back2Height, Back2Width, Back2Top, Back2Left;
        public float Back3Height, Back3Width, Back3Top, Back3Left;
        public float Apply1Height, Apply1Width, Apply1Top, Apply1Left;
        public float Apply2Height, Apply2Width, Apply2Top, Apply2Left;
        public float Apply3Height, Apply3Width, Apply3Top, Apply3Left;
        public float LanguageHeight, LanguageWidth, LanguageTop, LanguageLeft;
        public float DifficultyHeight, DifficultyWidth, DifficultyTop, DifficultyLeft;
        public float SensitivityHeight, SensitivityWidth, SensitivityTop, SensitivityLeft;
        public float SubtitlesHeight, SubtitlesWidth, SubtitlesTop, SubtitlesLeft;
        public float ResolutionHeight, ResolutionWidth, ResolutionTop, ResolutionLeft;
        public float TextureQualityHeight, TextureQualityWidth, TextureQualityTop, TextureQualityLeft;
        public float TextureFilteringHeight, TextureFilteringWidth, TextureFilteringTop, TextureFilteringLeft;
        public float ShadowQualityHeight, ShadowQualityWidth, ShadowQualityTop, ShadowQualityLeft;
        public float EffectQualityHeight, EffectQualityWidth, EffectQualityTop, EffectQualityLeft;
        public float SmoothingHeight, SmoothingWidth, SmoothingTop, SmoothingLeft;
        public float FullScreenHeight, FullScreenWidth, FullScreenTop, FullScreenLeft;
        public float SquatHeight, SquatWidth, SquatTop, SquatLeft;
        public float JumpHeight, JumpWidth, JumpTop, JumpLeft;
        public float AttackHeight, AttackWidth, AttackTop, AttackLeft;
        public float MovingForwardHeight, MovingForwardWidth, MovingForwardTop, MovingForwardLeft;
        public float MovingBackwardsHeight, MovingBackwardsWidth, MovingBackwardsTop, MovingBackwardsLeft;
        public float MovementLeftHeight, MovementLeftWidth, MovementLeftTop, MovementLeftLeft;
        public float MovementRightHeight, MovementRightWidth, MovementRightTop, MovementRightLeft;

        private void PBNo_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 0;
        }

        private void PBBack1_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 0;
        }

        private void PBGraphics1_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 3;
        }

        private void PBControl1_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 4;
        }

        private void PBGeneral1_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 2;
        }

        private void PBControl2_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 4;
        }

        private void PBBack2_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 0;
        }

        private void PBGeneral2_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 2;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PBGraphics2_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 3;
        }

        private void PBBack3_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 0;
        }

        private void PBMovementRight_Click(object sender, EventArgs e)
        {

        }

        private void PBYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBExit_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 1;
        }

        private void PBSettings_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 2;
        }

        private void FMainMenu_Move(object sender, EventArgs e)
        {
            FormTop = Top;
            FormLeft = Left;
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
            // Это всё делает невидимыми закладки:
            TabControl.Appearance = TabAppearance.FlatButtons;
            TabControl.ItemSize = new Size(0, 1);
            TabControl.SizeMode = TabSizeMode.Fixed;
            TabControl.TabStop = false;


            try  // Загружаем картинки из папки Images при запуске EXE
            {
                TP0_Main.BackgroundImage = Image.FromFile("Images\\Background.png");
                PBName.Image = Image.FromFile("Images\\StayAlone.png");
                PBPlay.Image = Image.FromFile("Images\\Play.png");
                PBSettings.Image = Image.FromFile("Images\\Settings.png");
                PBExit.Image = Image.FromFile("Images\\Exit.png");
                
                TP1_Exit.BackgroundImage = Image.FromFile("Images\\BackgroundBlurred.png");
                PBWindow.Image = Image.FromFile("Images\\Window.png");
                PBYes.Image = Image.FromFile("Images\\Yes.png");
                PBNo.Image = Image.FromFile("Images\\No.png");
                
                TP2_SettingsGeneral.BackgroundImage = Image.FromFile("Images\\BackgroundBlurred.png");
                PBGeneralL.Image = Image.FromFile("Images\\GeneralWithLine.png");
                PBGraphics1.Image = Image.FromFile("Images\\Graphics.png");
                PBControl1.Image = Image.FromFile("Images\\Control.png");
                PBBack1.Image = Image.FromFile("Images\\Back.png");
                PBApply1.Image = Image.FromFile("Images\\Apply.png");
                PBLanguage.Image = Image.FromFile("Images\\Language.png");
                PBDifficulty.Image = Image.FromFile("Images\\Difficulty.png");
                PBSensitivity.Image = Image.FromFile("Images\\Sensitivity.png");
                PBSubtitles.Image = Image.FromFile("Images\\Subtitles.png");
                PBVolume.Image = Image.FromFile("Images\\Volume.png");
                PBReg.Image = Image.FromFile("Images\\VolumeReg.png");

                TP3_SettingsGraphics.BackgroundImage = Image.FromFile("Images\\BackgroundBlurred.png");
                PBGeneral1.Image = Image.FromFile("Images\\General.png");
                PBGraphicsL.Image = Image.FromFile("Images\\GraphicsWithLine.png");
                PBControl2.Image = Image.FromFile("Images\\Control.png");
                PBBack2.Image = Image.FromFile("Images\\Back.png");
                PBApply2.Image = Image.FromFile("Images\\Apply.png");
                PBResolution.Image = Image.FromFile("Images\\Resolution.png");
                PBTextureQuality.Image = Image.FromFile("Images\\TextureQuality.png");
                PBTextureFiltering.Image = Image.FromFile("Images\\TextureFiltering.png");
                PBShadowQuality.Image = Image.FromFile("Images\\ShadowQuality.png");
                PBEffectQuality.Image = Image.FromFile("Images\\EffectQuality.png");
                PBSmoothing.Image = Image.FromFile("Images\\Smoothing.png");
                PBFullScreen.Image = Image.FromFile("Images\\FullScreen.png");

                TP4_SettingsControl.BackgroundImage = Image.FromFile("Images\\BackgroundBlurred.png");
                PBGeneral2.Image = Image.FromFile("Images\\General.png");
                PBGraphics2.Image = Image.FromFile("Images\\Graphics.png");
                PBControlL.Image = Image.FromFile("Images\\ControlWithLine.png");
                PBBack3.Image = Image.FromFile("Images\\Back.png");
                PBApply3.Image = Image.FromFile("Images\\Apply.png");
                PBSquat.Image = Image.FromFile("Images\\Squat.png");
                PBJump.Image = Image.FromFile("Images\\Jump.png");
                PBAttack.Image = Image.FromFile("Images\\Attack.png");
                PBMovingForward.Image = Image.FromFile("Images\\MovingForward.png");
                PBMovingBackwards.Image = Image.FromFile("Images\\MovingBackwards.png");
                PBMovementLeft.Image = Image.FromFile("Images\\MovementLeft.png");
                PBMovementRight.Image = Image.FromFile("Images\\MovementRight.png");

            }
            catch (System.IO.FileNotFoundException) { }




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

            WindowHeight = PBWindow.Height;
            WindowWidth = PBWindow.Width;
            WindowTop = PBWindow.Top;
            WindowLeft = PBWindow.Left;

            YesHeight = PBYes.Height;
            YesWidth = PBYes.Width;
            YesTop = PBYes.Top;
            YesLeft = PBYes.Left;

            NoHeight = PBNo.Height;
            NoWidth = PBNo.Width;
            NoTop = PBNo.Top;
            NoLeft = PBNo.Left;

            GeneralLHeight = PBGeneralL.Height;
            GeneralLWidth = PBGeneralL.Width;
            GeneralLTop = PBGeneralL.Top;
            GeneralLLeft = PBGeneralL.Left;

            GraphicsLHeight = PBGraphicsL.Height;
            GraphicsLWidth = PBGraphicsL.Width;
            GraphicsLTop = PBGraphicsL.Top;
            GraphicsLLeft = PBGraphicsL.Left;

            ControlLHeight = PBControlL.Height;
            ControlLWidth = PBControlL.Width;
            ControlLTop = PBControlL.Top;
            ControlLLeft = PBControlL.Left;

            General1Height = PBGeneral1.Height;
            General1Width = PBGeneral1.Width;
            General1Top = PBGeneral1.Top;
            General1Left = PBGeneral1.Left;

            General2Height = PBGeneral2.Height;
            General2Width = PBGeneral2.Width;
            General2Top = PBGeneral2.Top;
            General2Left = PBGeneral2.Left;

            Graphics1Height = PBGraphics1.Height;
            Graphics1Width = PBGraphics1.Width;
            Graphics1Top = PBGraphics1.Top;
            Graphics1Left = PBGraphics1.Left;

            Graphics2Height = PBGraphics2.Height;
            Graphics2Width = PBGraphics2.Width;
            Graphics2Top = PBGraphics2.Top;
            Graphics2Left = PBGraphics2.Left;

            Control1Height = PBControl1.Height;
            Control1Width = PBControl1.Width;
            Control1Top = PBControl1.Top;
            Control1Left = PBControl1.Left;

            Control2Height = PBControl2.Height;
            Control2Width = PBControl2.Width;
            Control2Top = PBControl2.Top;
            Control2Left = PBControl2.Left;

            Back1Height = PBBack1.Height;
            Back1Width = PBBack1.Width;
            Back1Top = PBBack1.Top;
            Back1Left = PBBack1.Left;

            Back2Height = PBBack2.Height;
            Back2Width = PBBack2.Width;
            Back2Top = PBBack2.Top;
            Back2Left = PBBack2.Left;

            Back3Height = PBBack3.Height;
            Back3Width = PBBack3.Width;
            Back3Top = PBBack3.Top;
            Back3Left = PBBack3.Left;

            Apply1Height = PBApply1.Height;
            Apply1Width = PBApply1.Width;
            Apply1Top = PBApply1.Top;
            Apply1Left = PBApply1.Left;

            Apply2Height = PBApply2.Height;
            Apply2Width = PBApply2.Width;
            Apply2Top = PBApply2.Top;
            Apply2Left = PBApply2.Left;

            Apply3Height = PBApply3.Height;
            Apply3Width = PBApply3.Width;
            Apply3Top = PBApply3.Top;
            Apply3Left = PBApply3.Left;

            LanguageHeight = PBLanguage.Height;
            LanguageWidth = PBLanguage.Width;
            LanguageTop = PBLanguage.Top;
            LanguageLeft = PBLanguage.Left;

            DifficultyHeight = PBDifficulty.Height;
            DifficultyWidth = PBDifficulty.Width;
            DifficultyTop = PBDifficulty.Top;
            DifficultyLeft = PBDifficulty.Left;

            SensitivityHeight = PBSensitivity.Height;
            SensitivityWidth = PBSensitivity.Width;
            SensitivityTop = PBSensitivity.Top;
            SensitivityLeft = PBSensitivity.Left;

            SubtitlesHeight = PBSubtitles.Height;
            SubtitlesWidth = PBSubtitles.Width;
            SubtitlesTop = PBSubtitles.Top;
            SubtitlesLeft = PBSubtitles.Left;

            ResolutionHeight = PBResolution.Height;
            ResolutionWidth = PBResolution.Width;
            ResolutionTop = PBResolution.Top;
            ResolutionLeft = PBResolution.Left;

            TextureQualityHeight = PBTextureQuality.Height;
            TextureQualityWidth = PBTextureQuality.Width;
            TextureQualityTop = PBTextureQuality.Top;
            TextureQualityLeft = PBTextureQuality.Left;

            TextureFilteringHeight = PBTextureFiltering.Height;
            TextureFilteringWidth = PBTextureFiltering.Width;
            TextureFilteringTop = PBTextureFiltering.Top;
            TextureFilteringLeft = PBTextureFiltering.Left;

            ShadowQualityHeight = PBShadowQuality.Height;
            ShadowQualityWidth = PBShadowQuality.Width;
            ShadowQualityTop = PBShadowQuality.Top;
            ShadowQualityLeft = PBShadowQuality.Left;

            EffectQualityHeight = PBEffectQuality.Height;
            EffectQualityWidth = PBEffectQuality.Width;
            EffectQualityTop = PBEffectQuality.Top;
            EffectQualityLeft = PBEffectQuality.Left;

            SmoothingHeight = PBSmoothing.Height;
            SmoothingWidth = PBSmoothing.Width;
            SmoothingTop = PBSmoothing.Top;
            SmoothingLeft = PBSmoothing.Left;

            FullScreenHeight = PBFullScreen.Height;
            FullScreenWidth = PBFullScreen.Width;
            FullScreenTop = PBFullScreen.Top;
            FullScreenLeft = PBFullScreen.Left;

            SquatHeight = PBSquat.Height;
            SquatWidth = PBSquat.Width;
            SquatTop = PBSquat.Top;
            SquatLeft = PBSquat.Left;

            JumpHeight = PBJump.Height;
            JumpWidth = PBJump.Width;
            JumpTop = PBJump.Top;
            JumpLeft = PBJump.Left;

            AttackHeight = PBAttack.Height;
            AttackWidth = PBAttack.Width;
            AttackTop = PBAttack.Top;
            AttackLeft = PBAttack.Left;

            MovingForwardHeight = PBMovingForward.Height;
            MovingForwardWidth = PBMovingForward.Width;
            MovingForwardTop = PBMovingForward.Top;
            MovingForwardLeft = PBMovingForward.Left;

            MovingBackwardsHeight = PBMovingBackwards.Height;
            MovingBackwardsWidth = PBMovingBackwards.Width;
            MovingBackwardsTop = PBMovingBackwards.Top;
            MovingBackwardsLeft = PBMovingBackwards.Left;

            MovementLeftHeight = PBMovementLeft.Height;
            MovementLeftWidth = PBMovementLeft.Width;
            MovementLeftTop = PBMovementLeft.Top;
            MovementLeftLeft = PBMovementLeft.Left;

            MovementRightHeight = PBMovementRight.Height;
            MovementRightWidth = PBMovementRight.Width;
            MovementRightTop = PBMovementRight.Top;
            MovementRightLeft = PBMovementRight.Left;






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

            PBWindow.Height = (int)(KHeight * WindowHeight);
            PBWindow.Width = (int)(KWidth * WindowWidth);
            PBWindow.Top = (int)(KHeight * WindowTop);
            PBWindow.Left = (int)(KWidth * WindowLeft);
            PBWindow.Refresh();

            PBYes.Height = (int)(KHeight * YesHeight);
            PBYes.Width = (int)(KWidth * YesWidth);
            PBYes.Top = (int)(KHeight * YesTop);
            PBYes.Left = (int)(KWidth * YesLeft);
            PBYes.Refresh();

            PBNo.Height = (int)(KHeight * NoHeight);
            PBNo.Width = (int)(KWidth * NoWidth);
            PBNo.Top = (int)(KHeight * NoTop);
            PBNo.Left = (int)(KWidth * NoLeft);
            PBNo.Refresh();

            PBGeneralL.Height = (int)(KHeight * GeneralLHeight);
            PBGeneralL.Width = (int)(KWidth * GeneralLWidth);
            PBGeneralL.Top = (int)(KHeight * GeneralLTop);
            PBGeneralL.Left = (int)(KWidth * GeneralLLeft);
            PBGeneralL.Refresh();

            PBGraphicsL.Height = (int)(KHeight * GraphicsLHeight);
            PBGraphicsL.Width = (int)(KWidth * GraphicsLWidth);
            PBGraphicsL.Top = (int)(KHeight * GraphicsLTop);
            PBGraphicsL.Left = (int)(KWidth * GraphicsLLeft);
            PBGraphicsL.Refresh();

            PBControlL.Height = (int)(KHeight * ControlLHeight);
            PBControlL.Width = (int)(KWidth * ControlLWidth);
            PBControlL.Top = (int)(KHeight * ControlLTop);
            PBControlL.Left = (int)(KWidth * ControlLLeft);
            PBControlL.Refresh();

            PBGeneral1.Height = (int)(KHeight * General1Height);
            PBGeneral1.Width = (int)(KWidth * General1Width);
            PBGeneral1.Top = (int)(KHeight * General1Top);
            PBGeneral1.Left = (int)(KWidth * General1Left);
            PBGeneral1.Refresh();

            PBGeneral2.Height = (int)(KHeight * General2Height);
            PBGeneral2.Width = (int)(KWidth * General2Width);
            PBGeneral2.Top = (int)(KHeight * General2Top);
            PBGeneral2.Left = (int)(KWidth * General2Left);
            PBGeneral2.Refresh();

            PBGraphics1.Height = (int)(KHeight * Graphics1Height);
            PBGraphics1.Width = (int)(KWidth * Graphics1Width);
            PBGraphics1.Top = (int)(KHeight * Graphics1Top);
            PBGraphics1.Left = (int)(KWidth * Graphics1Left);
            PBGraphics1.Refresh();

            PBGraphics2.Height = (int)(KHeight * Graphics2Height);
            PBGraphics2.Width = (int)(KWidth * Graphics2Width);
            PBGraphics2.Top = (int)(KHeight * Graphics2Top);
            PBGraphics2.Left = (int)(KWidth * Graphics2Left);
            PBGraphics2.Refresh();

            PBControl1.Height = (int)(KHeight * Control1Height);
            PBControl1.Width = (int)(KWidth * Control1Width);
            PBControl1.Top = (int)(KHeight * Control1Top);
            PBControl1.Left = (int)(KWidth * Control1Left);
            PBControl1.Refresh();

            PBControl2.Height = (int)(KHeight * Control2Height);
            PBControl2.Width = (int)(KWidth * Control2Width);
            PBControl2.Top = (int)(KHeight * Control2Top);
            PBControl2.Left = (int)(KWidth * Control2Left);
            PBControl2.Refresh();

            PBBack1.Height = (int)(KHeight * Back1Height);
            PBBack1.Width = (int)(KWidth * Back1Width);
            PBBack1.Top = (int)(KHeight * Back1Top);
            PBBack1.Left = (int)(KWidth * Back1Left);
            PBBack1.Refresh();

            PBBack2.Height = (int)(KHeight * Back2Height);
            PBBack2.Width = (int)(KWidth * Back2Width);
            PBBack2.Top = (int)(KHeight * Back2Top);
            PBBack2.Left = (int)(KWidth * Back2Left);
            PBBack2.Refresh();

            PBBack3.Height = (int)(KHeight * Back3Height);
            PBBack3.Width = (int)(KWidth * Back3Width);
            PBBack3.Top = (int)(KHeight * Back3Top);
            PBBack3.Left = (int)(KWidth * Back3Left);
            PBBack3.Refresh();

            PBApply1.Height = (int)(KHeight * Apply1Height);
            PBApply1.Width = (int)(KWidth * Apply1Width);
            PBApply1.Top = (int)(KHeight * Apply1Top);
            PBApply1.Left = (int)(KWidth * Apply1Left);
            PBApply1.Refresh();

            PBApply2.Height = (int)(KHeight * Apply2Height);
            PBApply2.Width = (int)(KWidth * Apply2Width);
            PBApply2.Top = (int)(KHeight * Apply2Top);
            PBApply2.Left = (int)(KWidth * Apply2Left);
            PBApply2.Refresh();

            PBApply3.Height = (int)(KHeight * Apply3Height);
            PBApply3.Width = (int)(KWidth * Apply3Width);
            PBApply3.Top = (int)(KHeight * Apply3Top);
            PBApply3.Left = (int)(KWidth * Apply3Left);
            PBApply3.Refresh();

            PBLanguage.Height = (int)(KHeight * LanguageHeight);
            PBLanguage.Width = (int)(KWidth * LanguageWidth);
            PBLanguage.Top = (int)(KHeight * LanguageTop);
            PBLanguage.Left = (int)(KWidth * LanguageLeft);
            PBLanguage.Refresh();

            PBDifficulty.Height = (int)(KHeight * DifficultyHeight);
            PBDifficulty.Width = (int)(KWidth * DifficultyWidth);
            PBDifficulty.Top = (int)(KHeight * DifficultyTop);
            PBDifficulty.Left = (int)(KWidth * DifficultyLeft);
            PBDifficulty.Refresh();

            PBSensitivity.Height = (int)(KHeight * SensitivityHeight);
            PBSensitivity.Width = (int)(KWidth * SensitivityWidth);
            PBSensitivity.Top = (int)(KHeight * SensitivityTop);
            PBSensitivity.Left = (int)(KWidth * SensitivityLeft);
            PBSensitivity.Refresh();

            PBSubtitles.Height = (int)(KHeight * SubtitlesHeight);
            PBSubtitles.Width = (int)(KWidth * SubtitlesWidth);
            PBSubtitles.Top = (int)(KHeight * SubtitlesTop);
            PBSubtitles.Left = (int)(KWidth * SubtitlesLeft);
            PBSubtitles.Refresh();

            PBResolution.Height = (int)(KHeight * ResolutionHeight);
            PBResolution.Width = (int)(KWidth * ResolutionWidth);
            PBResolution.Top = (int)(KHeight * ResolutionTop);
            PBResolution.Left = (int)(KWidth * ResolutionLeft);
            PBResolution.Refresh();

            PBTextureQuality.Height = (int)(KHeight * TextureQualityHeight);
            PBTextureQuality.Width = (int)(KWidth * TextureQualityWidth);
            PBTextureQuality.Top = (int)(KHeight * TextureQualityTop);
            PBTextureQuality.Left = (int)(KWidth * TextureQualityLeft);
            PBTextureQuality.Refresh();

            PBTextureFiltering.Height = (int)(KHeight * TextureFilteringHeight);
            PBTextureFiltering.Width = (int)(KWidth * TextureFilteringWidth);
            PBTextureFiltering.Top = (int)(KHeight * TextureFilteringTop);
            PBTextureFiltering.Left = (int)(KWidth * TextureFilteringLeft);
            PBTextureFiltering.Refresh();

            PBShadowQuality.Height = (int)(KHeight * ShadowQualityHeight);
            PBShadowQuality.Width = (int)(KWidth * ShadowQualityWidth);
            PBShadowQuality.Top = (int)(KHeight * ShadowQualityTop);
            PBShadowQuality.Left = (int)(KWidth * ShadowQualityLeft);
            PBShadowQuality.Refresh();

            PBEffectQuality.Height = (int)(KHeight * EffectQualityHeight);
            PBEffectQuality.Width = (int)(KWidth * EffectQualityWidth);
            PBEffectQuality.Top = (int)(KHeight * EffectQualityTop);
            PBEffectQuality.Left = (int)(KWidth * EffectQualityLeft);
            PBEffectQuality.Refresh();

            PBSmoothing.Height = (int)(KHeight * SmoothingHeight);
            PBSmoothing.Width = (int)(KWidth * SmoothingWidth);
            PBSmoothing.Top = (int)(KHeight * SmoothingTop);
            PBSmoothing.Left = (int)(KWidth * SmoothingLeft);
            PBSmoothing.Refresh();

            PBFullScreen.Height = (int)(KHeight * FullScreenHeight);
            PBFullScreen.Width = (int)(KWidth * FullScreenWidth);
            PBFullScreen.Top = (int)(KHeight * FullScreenTop);
            PBFullScreen.Left = (int)(KWidth * FullScreenLeft);
            PBFullScreen.Refresh();

            PBSquat.Height = (int)(KHeight * SquatHeight);
            PBSquat.Width = (int)(KWidth * SquatWidth);
            PBSquat.Top = (int)(KHeight * SquatTop);
            PBSquat.Left = (int)(KWidth * SquatLeft);
            PBSquat.Refresh();

            PBJump.Height = (int)(KHeight * JumpHeight);
            PBJump.Width = (int)(KWidth * JumpWidth);
            PBJump.Top = (int)(KHeight * JumpTop);
            PBJump.Left = (int)(KWidth * JumpLeft);
            PBJump.Refresh();

            PBAttack.Height = (int)(KHeight * AttackHeight);
            PBAttack.Width = (int)(KWidth * AttackWidth);
            PBAttack.Top = (int)(KHeight * AttackTop);
            PBAttack.Left = (int)(KWidth * AttackLeft);
            PBAttack.Refresh();

            PBMovingForward.Height = (int)(KHeight * MovingForwardHeight);
            PBMovingForward.Width = (int)(KWidth * MovingForwardWidth);
            PBMovingForward.Top = (int)(KHeight * MovingForwardTop);
            PBMovingForward.Left = (int)(KWidth * MovingForwardLeft);
            PBMovingForward.Refresh();

            PBMovingBackwards.Height = (int)(KHeight * MovingBackwardsHeight);
            PBMovingBackwards.Width = (int)(KWidth * MovingBackwardsWidth);
            PBMovingBackwards.Top = (int)(KHeight * MovingBackwardsTop);
            PBMovingBackwards.Left = (int)(KWidth * MovingBackwardsLeft);
            PBMovingBackwards.Refresh();

            PBMovementLeft.Height = (int)(KHeight * MovementLeftHeight);
            PBMovementLeft.Width = (int)(KWidth * MovementLeftWidth);
            PBMovementLeft.Top = (int)(KHeight * MovementLeftTop);
            PBMovementLeft.Left = (int)(KWidth * MovementLeftLeft);
            PBMovementLeft.Refresh();

            PBMovementRight.Height = (int)(KHeight * MovementRightHeight);
            PBMovementRight.Width = (int)(KWidth * MovementRightWidth);
            PBMovementRight.Top = (int)(KHeight * MovementRightTop);
            PBMovementRight.Left = (int)(KWidth * MovementRightLeft);
            PBMovementRight.Refresh();


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
