using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP04_202873
{
    public partial class FrmGeral : Form
    {
        #region Variaveis
        int jogada = 1;
        int cebolinhaPoints = 0;
        int auxCebolinha1, auxCebolinha2, auxCebolinha3, auxCebolinha4, auxCebolinha5, auxCebolinha6, auxCebolinha7, auxCebolinha8, auxCebolinha9;
        int monicaPoints = 0;
        int auxMonica1, auxMonica2, auxMonica3, auxMonica4, auxMonica5, auxMonica6, auxMonica7, auxMonica8, auxMonica9;
        int auxDiagonal = 0, auxVertical = 2, auxHorizontal = 3;
        int Empates = 0;
        #endregion

        public FrmGeral()
        {
            InitializeComponent();
            PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
            PBox1.Image = null;
            PBox2.Image = null;
            PBox3.Image = null;
            PBox4.Image = null;
            PBox5.Image = null;
            PBox6.Image = null;
            PBox7.Image = null;
            PBox8.Image = null;
            PBox9.Image = null;
        }

        #region SAIR
        private void BtnSAIR_Click(object sender, EventArgs e)
        {
            string msg = "Tem certeza?";
            string titulo = "Sair do programa...";
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            MessageBoxIcon icone = MessageBoxIcon.Question;
            MessageBoxDefaultButton definido = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region RESET
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            string msg = "Confirma?";
            string titulo = "Reiniciar o jogo todo...";
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            MessageBoxIcon icone = MessageBoxIcon.Information;
            MessageBoxDefaultButton definido = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                jogada = 1;
                cebolinhaPoints = 0;
                monicaPoints = 0;
                Empates = 0;
                lblCEBOLINHA.Text = Convert.ToString(cebolinhaPoints);
                lblMONICA.Text = Convert.ToString(monicaPoints);
                lblEMPATES.Text = Convert.ToString(Empates);
            }
        }
        #endregion

        #region BOX
        private void PBox1_Click(object sender, EventArgs e)
        {
            Jogadas();
            if (jogada == 1 || jogada == 3 || jogada == 5 || jogada == 7 || jogada == 9)
            {
                PBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                auxCebolinha1 = 1;
                jogada++;
            }
            else
            {
                PBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                auxMonica1 = 1;
                jogada++;
            }
            CompararHORIZONTAL();
            CompararVERTICAL();
            CompararDIAGONAL();
            CompararEMPATE();
        }

        private void PBox2_Click(object sender, EventArgs e)
        {
            Jogadas();
            if (jogada == 1 || jogada == 3 || jogada == 5 || jogada == 7 || jogada == 9)
            {
                PBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                auxCebolinha2 = 2;
                jogada++;
            }
            else
            {
                PBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                auxMonica2 = 2;
                jogada++;
            }
            CompararHORIZONTAL();
            CompararVERTICAL();
            CompararDIAGONAL();
            CompararEMPATE();
        }

        private void PBox3_Click(object sender, EventArgs e)
        {
            Jogadas();
            if (jogada == 1 || jogada == 3 || jogada == 5 || jogada == 7 || jogada == 9)
            {
                PBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                auxCebolinha3 = 3;
                jogada++;
            }
            else
            {
                PBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                auxMonica3 = 3;
                jogada++;
            }
            CompararHORIZONTAL();
            CompararVERTICAL();
            CompararDIAGONAL();
            CompararEMPATE();
        }

        private void PBox4_Click(object sender, EventArgs e)
        {
            Jogadas();
            if (jogada == 1 || jogada == 3 || jogada == 5 || jogada == 7 || jogada == 9)
            {
                PBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                auxCebolinha4 = 4;
                jogada++;
            }
            else
            {
                PBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                auxMonica4 = 4;
                jogada++;
            }
            CompararHORIZONTAL();
            CompararVERTICAL();
            CompararDIAGONAL();
            CompararEMPATE();
        }

        private void PBox5_Click(object sender, EventArgs e)
        {
            Jogadas();
            if (jogada == 1 || jogada == 3 || jogada == 5 || jogada == 7 || jogada == 9)
            {
                PBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                auxCebolinha5 = 5;
                jogada++;
            }
            else
            {
                PBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                auxMonica5 = 5;
                jogada++;
            }
            CompararHORIZONTAL();
            CompararVERTICAL();
            CompararDIAGONAL();
            CompararEMPATE();
        }

        private void PBox6_Click(object sender, EventArgs e)
        {
            Jogadas();
            if (jogada == 1 || jogada == 3 || jogada == 5 || jogada == 7 || jogada == 9)
            {
                PBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                auxCebolinha6 = 6;
                jogada++;
            }
            else
            {
                PBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                auxMonica6 = 6;
                jogada++;
            }
            CompararHORIZONTAL();
            CompararVERTICAL();
            CompararDIAGONAL();
            CompararEMPATE();
        }

        private void PBox7_Click(object sender, EventArgs e)
        {
            Jogadas();
            if (jogada == 1 || jogada == 3 || jogada == 5 || jogada == 7 || jogada == 9)
            {
                PBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                auxCebolinha7 = 7;
                jogada++;
            }
            else
            {
                PBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                auxMonica7 = 7;
                jogada++;
            }
            CompararHORIZONTAL();
            CompararVERTICAL();
            CompararDIAGONAL();
            CompararEMPATE();
        }

        private void PBox8_Click(object sender, EventArgs e)
        {
            Jogadas();
            if (jogada == 1 || jogada == 3 || jogada == 5 || jogada == 7 || jogada == 9)
            {
                PBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                auxCebolinha8 = 8;
                jogada++;
            }
            else
            {
                PBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                auxMonica8 = 8;
                jogada++;
            }
            CompararHORIZONTAL();
            CompararVERTICAL();
            CompararDIAGONAL();
            CompararEMPATE();
        }

        private void PBox9_Click(object sender, EventArgs e)
        {
            Jogadas();
            if (jogada == 1 || jogada == 3 || jogada == 5 || jogada == 7 || jogada == 9)
            {
                PBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                jogada++;
                auxCebolinha9 = 9;
            }
            else
            {
                PBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                auxMonica9 = 9;
                jogada++;
            }
            CompararHORIZONTAL();
            CompararVERTICAL();
            CompararDIAGONAL();
            CompararEMPATE();
        }
        #endregion

        #region IMAGEM_VEZ
        void Jogadas()
        {
            if ( jogada == 2 || jogada == 4 || jogada == 6 || jogada == 8)
            {
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
            }
            else
            {
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
            }
        }
        #endregion

        #region HORIZONTAL  
        void CompararHORIZONTAL()
        {
            if (auxCebolinha1 == 1 && auxCebolinha2 == 2 && auxCebolinha3 == 3)
            {
                cebolinhaPoints++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                jogada = 1;
                lblCEBOLINHA.Text = Convert.ToString(cebolinhaPoints);
                MessageBox.Show("CEBOLINHA Ganhou!!");
            }
            else if (auxCebolinha4 == 4 && auxCebolinha5 == 5 && auxCebolinha6 == 6)
            {
                cebolinhaPoints++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                jogada = 1;
                lblCEBOLINHA.Text = Convert.ToString(cebolinhaPoints);
                MessageBox.Show("CEBOLINHA Ganhou!!");
            }
            else if (auxCebolinha7 == 7 && auxCebolinha8 == 8 && auxCebolinha9 == 9)
            {
                cebolinhaPoints++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                jogada = 1;
                lblCEBOLINHA.Text = Convert.ToString(cebolinhaPoints);
                MessageBox.Show("CEBOLINHA Ganhou!!");
            }
            else if (auxMonica1 == 1 && auxMonica2 == 2 && auxMonica3 == 3)
            {
                monicaPoints++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                jogada = 1;
                lblMONICA.Text = Convert.ToString(monicaPoints);
                MessageBox.Show("MONICA Ganhou!!");
            }
            else if (auxMonica4 == 4 && auxMonica5 == 5 && auxMonica6 == 6)
            {
                monicaPoints++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                jogada = 1;
                lblMONICA.Text = Convert.ToString(monicaPoints);
                MessageBox.Show("MONICA Ganhou!!");
            }
            else if (auxMonica7 == 7 && auxMonica8 == 8 && auxMonica9 == 9)
            {
                monicaPoints++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                jogada = 1;
                lblMONICA.Text = Convert.ToString(monicaPoints);
                MessageBox.Show("MONICA Ganhou!!");
            }
            else if(jogada == 9)
            {
                auxHorizontal = 1;
            }
        }
        #endregion

        #region VERTICAL    
        void CompararVERTICAL()
        {
            if (auxCebolinha1 == 1 && auxCebolinha4 == 4 && auxCebolinha7 == 7)
            {
                cebolinhaPoints++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                jogada = 1;
                lblCEBOLINHA.Text = Convert.ToString(cebolinhaPoints);
                MessageBox.Show("CEBOLINHA Ganhou!!");
            }
            else if (auxCebolinha2 == 2 && auxCebolinha5 == 5 && auxCebolinha8 == 8)
            {
                cebolinhaPoints++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                jogada = 1;
                lblCEBOLINHA.Text = Convert.ToString(cebolinhaPoints);
                MessageBox.Show("CEBOLINHA Ganhou!!");
            }
            else if (auxCebolinha3 == 3 && auxCebolinha6 == 6 && auxCebolinha9 == 9)
            {
                cebolinhaPoints++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                jogada = 1;
                lblCEBOLINHA.Text = Convert.ToString(cebolinhaPoints);
                MessageBox.Show("CEBOLINHA Ganhou!!");
            }
            else if (auxMonica1 == 1 && auxMonica4 == 4 && auxMonica7 == 7)
            {
                monicaPoints++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                jogada = 1;
                lblMONICA.Text = Convert.ToString(monicaPoints);
                MessageBox.Show("MONICA Ganhou!!");
            }
            else if (auxMonica2 == 2 && auxMonica5 == 5 && auxMonica8 == 8)
            {
                monicaPoints++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                jogada = 1;
                lblMONICA.Text = Convert.ToString(monicaPoints);
                MessageBox.Show("MONICA Ganhou!!");
            }
            else if (auxMonica3 == 3 && auxMonica6 == 6 && auxMonica9 == 9)
            {
                monicaPoints++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                jogada = 1;
                lblMONICA.Text = Convert.ToString(monicaPoints);
                MessageBox.Show("MONICA Ganhou!!");
            }
            else if (jogada == 9)
            {
                auxVertical = 1;
            }
        }
        #endregion

        #region DIAGONAL
        void CompararDIAGONAL()
        {
            if (auxCebolinha1 == 1 && auxCebolinha5 == 5 && auxCebolinha9 == 9)
            {
                cebolinhaPoints++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                jogada = 1;
                lblCEBOLINHA.Text = Convert.ToString(cebolinhaPoints);
                MessageBox.Show("CEBOLINHA Ganhou!!");
            }
            else if (auxCebolinha3 == 3 && auxCebolinha5 == 5 && auxCebolinha7 == 7)
            {
                cebolinhaPoints++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                jogada = 1;
                lblCEBOLINHA.Text = Convert.ToString(cebolinhaPoints);
                MessageBox.Show("CEBOLINHA Ganhou!!");
            }
            else if (auxMonica1 == 1 && auxMonica5 == 5 && auxMonica9 == 9)
            {
                monicaPoints++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                jogada = 1;
                lblMONICA.Text = Convert.ToString(monicaPoints);
                MessageBox.Show("MONICA Ganhou!!");
            }
            else if (auxMonica3 == 3 && auxMonica5 == 5 && auxMonica7 == 7)
            {
                monicaPoints++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\monica2.jpg");
                jogada = 1;
                lblMONICA.Text = Convert.ToString(monicaPoints);
                MessageBox.Show("MONICA Ganhou!!");
            }
            else if (jogada == 9)
            {
                auxDiagonal = 1;
            }
        }
        #endregion

        #region EMPATE  
        void CompararEMPATE()
        {
            if (auxDiagonal == 1 && auxVertical == 1 && auxHorizontal == 1)
            {
                Empates++;
                PBox1.Image = null;
                PBox2.Image = null;
                PBox3.Image = null;
                PBox4.Image = null;
                PBox5.Image = null;
                PBox6.Image = null;
                PBox7.Image = null;
                PBox8.Image = null;
                PBox9.Image = null;
                auxCebolinha1 = 0;
                auxCebolinha2 = 0;
                auxCebolinha3 = 0;
                auxCebolinha4 = 0;
                auxCebolinha5 = 0;
                auxCebolinha6 = 0;
                auxCebolinha7 = 0;
                auxCebolinha8 = 0;
                auxCebolinha9 = 0;
                auxMonica1 = 0;
                auxMonica2 = 0;
                auxMonica3 = 0;
                auxMonica4 = 0;
                auxMonica5 = 0;
                auxMonica6 = 0;
                auxMonica7 = 0;
                auxMonica8 = 0;
                auxMonica9 = 0;
                auxDiagonal = 0;
                auxVertical = 0;
                auxHorizontal = 0;
                PBoxVEZ.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cebolinha2.jpg");
                jogada = 1;
                lblEMPATES.Text = Convert.ToString(Empates);
                MessageBox.Show("EMPATOU!!");
            }
        }
        #endregion
    }
}
