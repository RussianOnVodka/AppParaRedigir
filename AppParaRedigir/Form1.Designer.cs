namespace AppParaRedigir
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.txtCompo = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEnem = new System.Windows.Forms.CheckBox();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.btnStrtime = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chk1Hour = new System.Windows.Forms.CheckBox();
            this.chk15Minutes = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pgTimebar = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.chk1Minute = new System.Windows.Forms.CheckBox();
            this.btnResetcom = new System.Windows.Forms.Button();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(675, 461);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(245, 44);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(733, 79);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 44);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(784, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblNam.Location = new System.Drawing.Point(675, 45);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(105, 16);
            this.lblNam.TabIndex = 5;
            this.lblNam.Text = "Nome do arquivo";
            this.lblNam.Click += new System.EventHandler(this.lblNam_Click);
            // 
            // txtCompo
            // 
            this.txtCompo.Location = new System.Drawing.Point(9, 10);
            this.txtCompo.Multiline = true;
            this.txtCompo.Name = "txtCompo";
            this.txtCompo.Size = new System.Drawing.Size(660, 504);
            this.txtCompo.TabIndex = 6;
            this.txtCompo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtCompo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompo_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.checkBox1.Location = new System.Drawing.Point(712, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(42, 20);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = ".txt";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.checkBox2.Location = new System.Drawing.Point(848, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 20);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = ".docx";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(709, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tempo para redação (beta)";
            // 
            // chkEnem
            // 
            this.chkEnem.AutoSize = true;
            this.chkEnem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.chkEnem.Location = new System.Drawing.Point(675, 184);
            this.chkEnem.Name = "chkEnem";
            this.chkEnem.Size = new System.Drawing.Size(183, 20);
            this.chkEnem.TabIndex = 19;
            this.chkEnem.Text = "Tempo Enem (30 minutos)";
            this.chkEnem.UseVisualStyleBackColor = true;
            this.chkEnem.CheckedChanged += new System.EventHandler(this.chkEnem_CheckedChanged);
            // 
            // tempo
            // 
            this.tempo.Interval = 1000;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // btnStrtime
            // 
            this.btnStrtime.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStrtime.FlatAppearance.BorderSize = 0;
            this.btnStrtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStrtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrtime.ForeColor = System.Drawing.Color.White;
            this.btnStrtime.Location = new System.Drawing.Point(834, 261);
            this.btnStrtime.Name = "btnStrtime";
            this.btnStrtime.Size = new System.Drawing.Size(77, 35);
            this.btnStrtime.TabIndex = 23;
            this.btnStrtime.Text = "Começar";
            this.btnStrtime.UseVisualStyleBackColor = false;
            this.btnStrtime.Click += new System.EventHandler(this.btnStrtime_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(834, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Parar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chk1Hour
            // 
            this.chk1Hour.AutoSize = true;
            this.chk1Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1Hour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.chk1Hour.Location = new System.Drawing.Point(675, 219);
            this.chk1Hour.Name = "chk1Hour";
            this.chk1Hour.Size = new System.Drawing.Size(138, 20);
            this.chk1Hour.TabIndex = 20;
            this.chk1Hour.Text = "1 hora (60 minutos)";
            this.chk1Hour.UseVisualStyleBackColor = true;
            // 
            // chk15Minutes
            // 
            this.chk15Minutes.AutoSize = true;
            this.chk15Minutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.chk15Minutes.Location = new System.Drawing.Point(675, 320);
            this.chk15Minutes.Name = "chk15Minutes";
            this.chk15Minutes.Size = new System.Drawing.Size(77, 17);
            this.chk15Minutes.TabIndex = 25;
            this.chk15Minutes.Text = "15 minutos";
            this.chk15Minutes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "DESAFIO:";
            // 
            // pgTimebar
            // 
            this.pgTimebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pgTimebar.Location = new System.Drawing.Point(675, 367);
            this.pgTimebar.Name = "pgTimebar";
            this.pgTimebar.Size = new System.Drawing.Size(245, 23);
            this.pgTimebar.TabIndex = 27;
            this.pgTimebar.VisibleChanged += new System.EventHandler(this.pgTimebar_Click);
            this.pgTimebar.Click += new System.EventHandler(this.pgTimebar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(678, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "Info";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chk1Minute
            // 
            this.chk1Minute.AutoSize = true;
            this.chk1Minute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.chk1Minute.Location = new System.Drawing.Point(675, 344);
            this.chk1Minute.Name = "chk1Minute";
            this.chk1Minute.Size = new System.Drawing.Size(66, 17);
            this.chk1Minute.TabIndex = 29;
            this.chk1Minute.Text = "1 minuto";
            this.chk1Minute.UseVisualStyleBackColor = true;
            // 
            // btnResetcom
            // 
            this.btnResetcom.BackColor = System.Drawing.Color.SeaGreen;
            this.btnResetcom.FlatAppearance.BorderSize = 0;
            this.btnResetcom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetcom.ForeColor = System.Drawing.Color.White;
            this.btnResetcom.Location = new System.Drawing.Point(758, 261);
            this.btnResetcom.Name = "btnResetcom";
            this.btnResetcom.Size = new System.Drawing.Size(65, 35);
            this.btnResetcom.TabIndex = 32;
            this.btnResetcom.Text = "Habilitar escrição";
            this.btnResetcom.UseVisualStyleBackColor = false;
            this.btnResetcom.Click += new System.EventHandler(this.btnResetcom_Click);
            // 
            // txtHour
            // 
            this.txtHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.Location = new System.Drawing.Point(758, 429);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(26, 26);
            this.txtHour.TabIndex = 34;
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(814, 429);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(26, 26);
            this.txtMin.TabIndex = 35;
            // 
            // txtSec
            // 
            this.txtSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSec.Location = new System.Drawing.Point(865, 429);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(26, 26);
            this.txtSec.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(792, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tempo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(790, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(841, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 517);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.btnResetcom);
            this.Controls.Add(this.chk1Minute);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pgTimebar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chk15Minutes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStrtime);
            this.Controls.Add(this.chk1Hour);
            this.Controls.Add(this.chkEnem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtCompo);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EasyComp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.TextBox txtCompo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEnem;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.Button btnStrtime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chk1Hour;
        private System.Windows.Forms.CheckBox chk15Minutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pgTimebar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chk1Minute;
        private System.Windows.Forms.Button btnResetcom;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

