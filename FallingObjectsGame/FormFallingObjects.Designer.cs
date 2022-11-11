namespace FallingObjectsGame
{
    partial class FormFallingObjects
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.TxtPoints = new System.Windows.Forms.TextBox();
            this.LblPoints = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.TxtTimeLeft = new System.Windows.Forms.TextBox();
            this.LblTimeLeft = new System.Windows.Forms.Label();
            this.TxtGameOver = new System.Windows.Forms.TextBox();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(42, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 498);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(678, 292);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(118, 46);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(679, 344);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(117, 43);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // TxtPoints
            // 
            this.TxtPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtPoints.Location = new System.Drawing.Point(679, 44);
            this.TxtPoints.Multiline = true;
            this.TxtPoints.Name = "TxtPoints";
            this.TxtPoints.Size = new System.Drawing.Size(103, 45);
            this.TxtPoints.TabIndex = 3;
            // 
            // LblPoints
            // 
            this.LblPoints.AutoSize = true;
            this.LblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPoints.Location = new System.Drawing.Point(674, 16);
            this.LblPoints.Name = "LblPoints";
            this.LblPoints.Size = new System.Drawing.Size(66, 25);
            this.LblPoints.TabIndex = 4;
            this.LblPoints.Text = "Points";
            // 
            // timer3
            // 
            this.timer3.Interval = 60000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // TxtTimeLeft
            // 
            this.TxtTimeLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtTimeLeft.Location = new System.Drawing.Point(679, 120);
            this.TxtTimeLeft.Multiline = true;
            this.TxtTimeLeft.Name = "TxtTimeLeft";
            this.TxtTimeLeft.Size = new System.Drawing.Size(103, 48);
            this.TxtTimeLeft.TabIndex = 5;
            // 
            // LblTimeLeft
            // 
            this.LblTimeLeft.AutoSize = true;
            this.LblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTimeLeft.Location = new System.Drawing.Point(674, 92);
            this.LblTimeLeft.Name = "LblTimeLeft";
            this.LblTimeLeft.Size = new System.Drawing.Size(93, 25);
            this.LblTimeLeft.TabIndex = 6;
            this.LblTimeLeft.Text = "Time Left";
            // 
            // TxtGameOver
            // 
            this.TxtGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtGameOver.Location = new System.Drawing.Point(679, 200);
            this.TxtGameOver.Multiline = true;
            this.TxtGameOver.Name = "TxtGameOver";
            this.TxtGameOver.Size = new System.Drawing.Size(103, 58);
            this.TxtGameOver.TabIndex = 7;
            this.TxtGameOver.Visible = false;
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(678, 393);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(118, 38);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FormFallingObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 631);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxtGameOver);
            this.Controls.Add(this.LblTimeLeft);
            this.Controls.Add(this.TxtTimeLeft);
            this.Controls.Add(this.LblPoints);
            this.Controls.Add(this.TxtPoints);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FormFallingObjects";
            this.Text = "Falling Objects Game";
            this.Load += new System.EventHandler(this.FormFallingObjects_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFallingObjects_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox TxtPoints;
        private System.Windows.Forms.Label LblPoints;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox TxtTimeLeft;
        private System.Windows.Forms.Label LblTimeLeft;
        private System.Windows.Forms.TextBox TxtGameOver;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Button BtnExit;
    }
}

