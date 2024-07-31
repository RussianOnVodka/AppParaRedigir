using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppParaRedigir
{
    public partial class Form1 : Form
    {
        
        int segundo = 0;
        int minuto = 0;
        int hora = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Shows messsage box asking if you want to exit the application
            if (MessageBox.Show("Você realmente deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                // return to the application
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Shows message box asking if you want to save
            if (MessageBox.Show("Deseja Salvar?", "Salvar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                //Return to app and close message box without saving
                return;  
            }

            else
            {

                if (checkBox1.Checked)
                {
                    //Create the txt file and save the textBox's text to the txt file
                    StreamWriter sw = new StreamWriter(Application.StartupPath + "\\saves\\" + textBox1.Text + ".txt");
                    {
                        sw.Write(txtCompo.Text);
                        sw.Close();
                    }
                }

                if (checkBox2.Checked)
                {
                    //Create the txt file and save the textBox's text to the docx file
                    StreamWriter sw = new StreamWriter(Application.StartupPath + "\\saves\\" + textBox1.Text + ".docx");
                    {
                        sw.Write(txtCompo.Text);
                        sw.Close();
                    }
                }

            }
        }

        private void lblNam_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCompo_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnStrtime_Click(object sender, EventArgs e)
        {
            if (chk15Minutes.Checked || chk1Hour.Checked || chkEnem.Checked || chk1Minute.Checked)
            {
                
                this.tempo.Start();
                
                
            }
            else
            {
                MessageBox.Show("Por favor selecione pelo menos uma caixa", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.pgTimebar.Value != 0)
            {
                //ZA WARUDOOOOOOOO!!!!!! (stops timer)
                this.tempo.Stop();
                //reset Progress bar 
                this.pgTimebar.Value = (0);
                this.txtCompo.ReadOnly = true;
                
            }
            else
            {
                MessageBox.Show("O timer já está parado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void chkEnem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este app foi criado por João Marcelo, sem fins lucrativos, apenas para fins educacionais, os créditos para a ideia do 'Timer', vão para Davi Galindo, que me ajudou a pensar no app","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            if (this.chkEnem.Checked)
            {
                this.pgTimebar.Maximum = 1800;
                this.pgTimebar.Increment(1);
                if (this.pgTimebar.Value == 1800)
                {
                    this.txtCompo.ReadOnly = true;
                }

                this.txtSec.Text = "00";
                this.txtMin.Text = "00";
                this.txtHour.Text = "00";

                hora = minuto / 60;
                minuto = segundo /60;
                segundo = this.pgTimebar.Value;

                if (segundo>= 60)
                {
                    segundo = 0;
                    minuto++;
                }

                if (minuto == 60)
                {
                    minuto = 0;
                    hora++;
                }

                if (this.segundo <= 9)
                {
                    this.txtSec.Text = Convert.ToString("0" + segundo);
                }

                if (this.segundo > 9)
                {
                    this.txtSec.Text = Convert.ToString(segundo);
                }

                if (this.minuto <= 9)
                {
                    this.txtMin.Text = Convert.ToString("0" + minuto);
                }

                if (this.minuto > 9)
                {
                    this.txtMin.Text = Convert.ToString(minuto);
                }

                if (this.hora <= 9)
                {
                    this.txtHour.Text = Convert.ToString("0" + hora);
                }

                if (this.hora > 9)
                {
                    this.txtHour.Text = Convert.ToString(hora);
                }

            }

            if (this.chk1Hour.Checked)
            {
                this.pgTimebar.Maximum = 3600;
                this.pgTimebar.Increment(1);
                if (this.pgTimebar.Value == 3600)
                {
                    this.txtCompo.ReadOnly = true;
                }

                this.txtSec.Text = "00";
                this.txtMin.Text = "00";
                this.txtHour.Text = "00";

                hora = minuto / 60;
                minuto = segundo / 60;
                segundo = this.pgTimebar.Value;

                if (segundo == 60)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 2)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 3)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 4)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 5)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 6)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 7)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 8)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 9)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 10)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 11)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 12)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 13)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 14)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 15)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 16)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 17)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 18)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 19)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 20)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 21)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 22)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 23)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 24)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 25)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 26)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 27)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 28)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 29)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 30)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 31)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 32)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 33)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 34)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 35)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 36)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 37)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 38)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 39)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 40)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 41)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 42)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 43)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 44)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 45)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 46)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 47)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 48)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 49)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 50)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 51)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 52)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 53)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 54)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 55)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 56)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 57)
                {
                    segundo = 0;
                    minuto++;
                }
                if (segundo == 60 * 58)
                {
                    segundo = 0;
                    minuto++;
                }
                if (segundo == 60 * 59)
                {
                    segundo = 0;
                    minuto++;
                }
                if (segundo == 60 * 60)
                {
                    segundo = 0;
                    minuto++;
                }

                if (minuto == 60)
                {
                    minuto = 0;
                    hora++;
                }

                if (this.segundo <= 9)
                {
                    this.txtSec.Text = Convert.ToString("0" + segundo);
                }

                if (this.segundo > 9)
                {
                    this.txtSec.Text = Convert.ToString(segundo);
                }

                if (this.minuto <= 9)
                {
                    this.txtMin.Text = Convert.ToString("0" + minuto);
                }

                if (this.minuto > 9)
                {
                    this.txtMin.Text = Convert.ToString(minuto);
                }

                if (this.hora <= 9)
                {
                    this.txtHour.Text = Convert.ToString("0" + hora);
                }

                if (this.hora > 9)
                {
                    this.txtHour.Text = Convert.ToString(hora);
                }

            }

            if (this.chk15Minutes.Checked)
            {
                this.pgTimebar.Maximum = 900;
                this.pgTimebar.Increment(1);
                if (this.pgTimebar.Value == 900)
                {
                    this.txtCompo.ReadOnly = true;
                }

                this.txtSec.Text = "00";
                this.txtMin.Text = "00";
                this.txtHour.Text = "00";

                hora = minuto / 60;
                minuto = segundo / 60;
                segundo = this.pgTimebar.Value;

                if (segundo == 60)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 2)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 3)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 4)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 5)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 6)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 7)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 8)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 9)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 10)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 11)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 12)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 13)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 14)
                {
                    segundo = 0;
                    minuto++;
                }

                if (segundo == 60 * 15)
                {
                    segundo = 0;
                    minuto++;
                }

                if (minuto == 60)
                {
                    minuto = 0;
                    hora++;
                }

                

                if (this.segundo <= 9)
                {
                    this.txtSec.Text = Convert.ToString("0" + segundo);
                }

                if (this.segundo > 9)
                {
                    this.txtSec.Text = Convert.ToString(segundo);
                }

                if (this.minuto <= 9)
                {
                    this.txtMin.Text = Convert.ToString("0" + minuto);
                }

                if (this.minuto > 9)
                {
                    this.txtMin.Text = Convert.ToString(minuto);
                }

                if (this.hora <= 9)
                {
                    this.txtHour.Text = Convert.ToString("0" + hora);
                }

                if (this.hora > 9)
                {
                    this.txtHour.Text = Convert.ToString(hora);
                }
                

            }

            if (this.chk1Minute.Checked)
            {
                this.pgTimebar.Maximum = 60;
                this.pgTimebar.Increment(1);
                if (this.pgTimebar.Value == 60)
                {
                    this.txtCompo.ReadOnly = true;
                }

                this.txtSec.Text = "00";
                this.txtMin.Text = "00";
                this.txtHour.Text = "00";

                hora = minuto / 60;
                minuto = segundo / 60;
                segundo = this.pgTimebar.Value;

                if (segundo == 60)
                {
                    segundo = 0;
                    minuto++;
                }

                if (minuto == 60)
                {
                    minuto = 0;
                    hora++;
                }

                

                if (this.segundo <= 9)
                {
                    this.txtSec.Text = Convert.ToString("0" + segundo);
                }

                if (this.segundo > 9)
                {
                    this.txtSec.Text = Convert.ToString(segundo);
                }

                if (this.minuto <= 9)
                {
                    this.txtMin.Text = Convert.ToString("0" + minuto);
                }

                if (this.minuto > 9)
                {
                    this.txtMin.Text = Convert.ToString(minuto);
                }

                if (this.hora <= 9)
                {
                    this.txtHour.Text = Convert.ToString("0" + hora);
                }

                if (this.hora > 9)
                {
                    this.txtHour.Text = Convert.ToString(hora);
                }

            }
        }

        private void pgTimebar_Click(object sender, EventArgs e)
        {
            if (this.chkEnem.Checked)
            {
                if (this.pgTimebar.Value == 1800)
                {
                    this.tempo.Stop();
                    this.pgTimebar.Value = 0;
                    this.txtCompo.ReadOnly = true;
                }
            }

            if (this.chk1Hour.Checked)
            {
                if (this.pgTimebar.Value == 3600)
                {
                    this.tempo.Stop();
                    this.pgTimebar.Value = 0;
                    this.txtCompo.ReadOnly = true;
                }
            }

            if (this.chk15Minutes.Checked)
            {
                if (this.pgTimebar.Value == 900)
                {
                    this.tempo.Stop();
                    this.pgTimebar.Value = 0;
                    this.txtCompo.ReadOnly = true;
                }
            }

            if (this.chk1Minute.Checked)
            {
                if (this.pgTimebar.Value == 60)
                {
                    this.tempo.Stop();
                    this.pgTimebar.Value = 0;
                    this.txtCompo.ReadOnly = true;
                }
            }
        }

        private void pgTimebar_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void btnResetcom_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Esta ação irá apagar todo seu progresso na redação, deseja mesmo fazer isso?", "AVISO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
           {
               return;
           }
           else
           {
               this.txtCompo.Text = "";
               this.txtCompo.ReadOnly = false;
               this.txtHour.Text = "00";
               this.txtMin.Text = "00";
               this.txtSec.Text = "00";

               
           }
            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtHour.ReadOnly = true;
            this.txtMin.ReadOnly = true;
            this.txtSec.ReadOnly = true;

            this.txtHour.Text = "00";
            this.txtMin.Text = "00";
            this.txtSec.Text = "00";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
