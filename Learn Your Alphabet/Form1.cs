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

namespace Learn_Your_Alphabet
{
    public partial class LearnYourAlphabet : Form
    {
        
        public LearnYourAlphabet()
        {
            InitializeComponent();
        }

                private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Image = Properties.Resources.A;
            buttonA.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.a1);
            sound.Play();
            imageBox.Image = Properties.Resources.abby;
            
            
        }
        
        private void buttonReset_Click(object sender, EventArgs e)
        {
            imageBox.Image = null;

            buttonA.Image = null;
            buttonA.Font = new Font(buttonA.Font.FontFamily, 48);
            buttonA.Text = "A";

            buttonB.Image = null;
            buttonB.Font = new Font(buttonB.Font.FontFamily, 48);
            buttonB.Text = "B";

            buttonC.Image = null;
            buttonC.Font = new Font(buttonC.Font.FontFamily, 48);
            buttonC.Text = "C";

            buttonD.Image = null;
            buttonD.Font = new Font(buttonD.Font.FontFamily, 48);
            buttonD.Text = "D";

            buttonE.Image = null;
            buttonE.Font = new Font(buttonE.Font.FontFamily, 48);
            buttonE.Text = "E";

            buttonF.Image = null;
            buttonF.Font = new Font(buttonF.Font.FontFamily, 48);
            buttonF.Text = "F";

            buttonG.Image = null;
            buttonG.Font = new Font(buttonG.Font.FontFamily, 48);
            buttonG.Text = "G";

            buttonH.Image = null;
            buttonH.Font = new Font(buttonH.Font.FontFamily, 48);
            buttonH.Text = "H";

            buttonI.Image = null;
            buttonI.Font = new Font(buttonI.Font.FontFamily, 48);
            buttonI.Text = "I";

            buttonJ.Image = null;
            buttonJ.Font = new Font(buttonJ.Font.FontFamily, 48);
            buttonJ.Text = "J";

            buttonK.Image = null;
            buttonK.Font = new Font(buttonK.Font.FontFamily, 48);
            buttonK.Text = "K";

            buttonL.Image = null;
            buttonL.Font = new Font(buttonL.Font.FontFamily, 48);
            buttonL.Text = "L";

            buttonM.Image = null;
            buttonM.Font = new Font(buttonM.Font.FontFamily, 48);
            buttonM.Text = "M";

            buttonN.Image = null;
            buttonN.Font = new Font(buttonN.Font.FontFamily, 48);
            buttonN.Text = "N";

            buttonM.Image = null;
            buttonM.Font = new Font(buttonM.Font.FontFamily, 48);
            buttonM.Text = "M";

            buttonN.Image = null;
            buttonN.Font = new Font(buttonN.Font.FontFamily, 48);
            buttonN.Text = "N";

            buttonO.Image = null;
            buttonO.Font = new Font(buttonO.Font.FontFamily, 48);
            buttonO.Text = "O";

            buttonP.Image = null;
            buttonP.Font = new Font(buttonP.Font.FontFamily, 48);
            buttonP.Text = "P";

            buttonQ.Image = null;
            buttonQ.Font = new Font(buttonQ.Font.FontFamily, 48);
            buttonQ.Text = "Q";

            buttonR.Image = null;
            buttonR.Font = new Font(buttonR.Font.FontFamily, 48);
            buttonR.Text = "R";

            buttonS.Image = null;
            buttonS.Font = new Font(buttonS.Font.FontFamily, 48);
            buttonS.Text = "S";

            buttonT.Image = null;
            buttonT.Font = new Font(buttonT.Font.FontFamily, 48);
            buttonT.Text = "T";

            buttonU.Image = null;
            buttonU.Font = new Font(buttonU.Font.FontFamily, 48);
            buttonU.Text = "U";

            buttonV.Image = null;
            buttonV.Font = new Font(buttonV.Font.FontFamily, 48);
            buttonV.Text = "V";

            buttonW.Image = null;
            buttonW.Font = new Font(buttonW.Font.FontFamily, 48);
            buttonW.Text = "W";

            buttonX.Image = null;
            buttonX.Font = new Font(buttonX.Font.FontFamily, 48);
            buttonX.Text = "X";

            buttonY.Image = null;
            buttonY.Font = new Font(buttonY.Font.FontFamily, 48);
            buttonY.Text = "Y";

            buttonZ.Image = null;
            buttonZ.Font = new Font(buttonZ.Font.FontFamily, 48);
            buttonZ.Text = "Z";

        }
        
        private void buttonB_Click(object sender, EventArgs e)
        {
            
            buttonB.Image = Properties.Resources.B;
            buttonB.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.b1);
            sound.Play();
            imageBox.Image = Properties.Resources.bert;

        }
        
        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonC.Image = Properties.Resources.C;
            buttonC.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.c1);
            sound.Play();
            imageBox.Image = Properties.Resources.cookie_monster;
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            buttonD.Image = Properties.Resources.D;
            buttonD.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.d1);
            sound.Play();
            imageBox.Image = Properties.Resources.doggy;
        }
       
        private void button7_Click(object sender, EventArgs e)
        {
            buttonE.Image = Properties.Resources.E;
            buttonE.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.e1);
            sound.Play();
            imageBox.Image = Properties.Resources.elmo;
        }
        
        private void button18_Click(object sender, EventArgs e)
        {
            buttonF.Image = Properties.Resources.F;
            buttonF.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.f1);
            sound.Play();
            imageBox.Image = Properties.Resources.froggy;
        }
        
        private void button15_Click(object sender, EventArgs e)
        {
            buttonG.Image = Properties.Resources.G;
            buttonG.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.g1);
            sound.Play();
            imageBox.Image = Properties.Resources.grover;
        }
        
        private void buttonH_Click(object sender, EventArgs e)
        {
            buttonH.Image = Properties.Resources.H;
            buttonH.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.h1);
            sound.Play();
            imageBox.Image = Properties.Resources.hoot;
        }
        
        private void buttonI_Click(object sender, EventArgs e)
        {
            buttonI.Image = Properties.Resources.I;
            buttonI.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.i1);
            sound.Play();
            imageBox.Image = Properties.Resources.insect;
        }
        
        private void buttonJ_Click(object sender, EventArgs e)
        {
            buttonJ.Image = Properties.Resources.J;
            buttonJ.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.j1);
            sound.Play();
            imageBox.Image = Properties.Resources.jam;
        }
        
        private void buttonK_Click(object sender, EventArgs e)
        {
            buttonK.Image = Properties.Resources.K;
            buttonK.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.k1);
            sound.Play();
            imageBox.Image = Properties.Resources.kitten;
        }
        
        private void buttonL_Click(object sender, EventArgs e)
        {
            buttonL.Image = Properties.Resources.L;
            buttonL.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.l1);
            sound.Play();
            imageBox.Image = Properties.Resources.lamb;
        }
        
        private void buttonM_Click(object sender, EventArgs e)
        {
            buttonM.Image = Properties.Resources.M;
            buttonM.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.m1);
            sound.Play();
            imageBox.Image = Properties.Resources.murray;
        }
        
        private void buttonN_Click(object sender, EventArgs e)
        {
            buttonN.Image = Properties.Resources.N;
            buttonN.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.n1);
            sound.Play();
            imageBox.Image = Properties.Resources.napkin;
        }
        
        private void buttonO_Click(object sender, EventArgs e)
        {
            buttonO.Image = Properties.Resources.O_100;
            buttonO.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.o);
            sound.Play();
            imageBox.Image = Properties.Resources.oscar;
        }
        
        private void buttonP_Click(object sender, EventArgs e)
        {
            buttonP.Image = Properties.Resources.P_100;
            buttonP.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.p);
            sound.Play();
            imageBox.Image = Properties.Resources.piano;
        }
        
        private void buttonQ_Click(object sender, EventArgs e)
        {
            buttonQ.Image = Properties.Resources.Q_100;
            buttonQ.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.q);
            sound.Play();
            imageBox.Image = Properties.Resources.queen;
        }
      
        private void buttonR_Click(object sender, EventArgs e)
        {
            buttonR.Image = Properties.Resources.R_100;
            buttonR.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.r);
            sound.Play();
            imageBox.Image = Properties.Resources.rosita;
        }
        
        private void buttonS_Click(object sender, EventArgs e)
        {
            buttonS.Image = Properties.Resources.S_100;
            buttonS.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.s);
            sound.Play();
            imageBox.Image = Properties.Resources.snuffy;
        }
        
        private void buttonT_Click(object sender, EventArgs e)
        {
            buttonT.Image = Properties.Resources.T_100;
            buttonT.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.t);
            sound.Play();
            imageBox.Image = Properties.Resources.telly;
        }
        
        private void buttonU_Click(object sender, EventArgs e)
        {
            buttonU.Image = Properties.Resources.U_100;
            buttonU.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.u);
            sound.Play();
            imageBox.Image = Properties.Resources.ukalele;
        }
        
        private void buttonV_Click(object sender, EventArgs e)
        {
            buttonV.Image = Properties.Resources.V_100;
            buttonV.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.v);
            sound.Play();
            imageBox.Image = Properties.Resources.violin;
        }
       
        private void buttonW_Click(object sender, EventArgs e)
        {
            buttonW.Image = Properties.Resources.W_100;
            buttonW.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.w);
            sound.Play();
            imageBox.Image = Properties.Resources.wand;
        }
        
        private void buttonX_Click(object sender, EventArgs e)
        {
            buttonX.Image = Properties.Resources.X_100;
            buttonX.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.x);
            sound.Play();
            imageBox.Image = Properties.Resources.xylaphone;
        }
        
        private void buttonY_Click(object sender, EventArgs e)
        {
            buttonY.Image = Properties.Resources.Y_100;
            buttonY.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.y);
            sound.Play();
            imageBox.Image = Properties.Resources.you;
        }
        
        private void buttonZ_Click(object sender, EventArgs e)
        {
            buttonZ.Image = Properties.Resources.Z_100;
            buttonZ.Text = " ";
            SoundPlayer sound = new SoundPlayer(@Learn_Your_Alphabet.Properties.Resources.z);
            sound.Play();
            imageBox.Image = Properties.Resources.zoey;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult onExit;

            onExit = MessageBox.Show("Would you like to exit?", "Learn Your Alphabet App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(onExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
    
}
