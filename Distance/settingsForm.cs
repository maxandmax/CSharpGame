using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance
{
    public partial class settingsForm : Form
    {

        bool bgSelected = false;

        public settingsForm()
        {
            InitializeComponent();

            if (Game1.showErrorMsg)
                noAnswerGame.Enabled = false;

            encreaseObj.Value = Game1.cObj;
            
            encreaseObj.Maximum = Game1.maxColObj;
            encreaseObj.Minimum = 3;

            rrrObj.Minimum = 1;
            rrrObj.Maximum = 12;
            
            rrrObj.Value = Game1.rObj;

            pic_bg = Game1.bground;

            spObj.Value = Game1.mainObjSpeed;

            endBooster.Checked = Game1.endBoost;
            timerUse.Checked = Game1.useTimer;

            noLandScapeObj.Checked = Game1.useLandObjs;
            noAnswerGame.Checked = Game1.useQuestions;
            useAutoMove.Checked = Game1.dontUseAutomaticMoving;
        }



        string pic_bg = "default";

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Game1.cObj = (int)encreaseObj.Value; // Применяем кол-во объектов

            if (bgSelected == true) Game1.bground = pic_bg;

            bgSelected = false;

            Game1.rObj = (int)rrrObj.Value;
            Game1.cObj = (int)encreaseObj.Value;
            Game1.endBoost = endBooster.Checked;
            Game1.useTimer = timerUse.Checked;

            Game1.useLandObjs = noLandScapeObj.Checked;
            Game1.useQuestions = noAnswerGame.Checked;
            Game1.dontUseAutomaticMoving = useAutoMove.Checked;

            Close();
        }

        private void chooseBackground(object sender, EventArgs e)
        {

            bgSelected = true;

            // Определяем какая была нажата картинка

            switch (((PictureBox)sender).Name)
                {
                    case "pBlue":
                        pic_bg = ((PictureBox)sender).Name;
                        ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
                        break;
                    case "pPink":
                        pic_bg = ((PictureBox)sender).Name;
                        ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
                        break;
                    case "pRed":
                        pic_bg = ((PictureBox)sender).Name;
                        ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
                        break;
                    case "pGreen":
                        pic_bg = ((PictureBox)sender).Name;
                        ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
                        break;
                    case "pDefault":
                        pic_bg = ((PictureBox)sender).Name;
                        ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
                        break;
                    default:
                        pic_bg = "default";
                        break;
                }

                if (((PictureBox)sender).Name != "pBlue") { pBlue.BorderStyle = BorderStyle.None; }
                if (((PictureBox)sender).Name != "pPink") { pPink.BorderStyle = BorderStyle.None; }
                if (((PictureBox)sender).Name != "pRed") { pRed.BorderStyle = BorderStyle.None; }
                if (((PictureBox)sender).Name != "pGreen") { pGreen.BorderStyle = BorderStyle.None; }
                if (((PictureBox)sender).Name != "pDefault") { pDefault.BorderStyle = BorderStyle.None; }
        }

    }
}
