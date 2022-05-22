namespace DuckHunt
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
            this.MovementAnim = new System.Windows.Forms.Timer(this.components);
            this.Tracking = new System.Windows.Forms.Timer(this.components);
            this.MainControl = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InfoControl = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UpDown = new System.Windows.Forms.Timer(this.components);
            this.fall = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.InfoControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovementAnim
            // 
            this.MovementAnim.Enabled = true;
            this.MovementAnim.Tick += new System.EventHandler(this.MovementAnim_Tick);
            // 
            // Tracking
            // 
            this.Tracking.Tick += new System.EventHandler(this.Tracking_Tick);
            // 
            // MainControl
            // 
            this.MainControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(227)))), ((int)(((byte)(163)))));
            this.MainControl.Controls.Add(this.pictureBox1);
            this.MainControl.Location = new System.Drawing.Point(12, 12);
            this.MainControl.Name = "MainControl";
            this.MainControl.Size = new System.Drawing.Size(1097, 548);
            this.MainControl.TabIndex = 0;
            this.MainControl.TabStop = false;
            this.MainControl.Text = "MainControl";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox1.Image = global::DuckHunt.Properties.Resources.b1_1;
            this.pictureBox1.Location = new System.Drawing.Point(27, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InfoControl
            // 
            this.InfoControl.Controls.Add(this.radioButton3);
            this.InfoControl.Controls.Add(this.radioButton2);
            this.InfoControl.Controls.Add(this.radioButton1);
            this.InfoControl.Controls.Add(this.button1);
            this.InfoControl.Controls.Add(this.label1);
            this.InfoControl.Location = new System.Drawing.Point(12, 566);
            this.InfoControl.Name = "InfoControl";
            this.InfoControl.Size = new System.Drawing.Size(1097, 184);
            this.InfoControl.TabIndex = 1;
            this.InfoControl.TabStop = false;
            this.InfoControl.Text = "InfoControl";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(97, 119);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(107, 29);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "Ludilo!";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 135);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 29);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Tezi";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 100);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 29);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Lak";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(964, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 134);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zapocni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(947, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stisni dugme da bi zapoceo/la ---->";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UpDown
            // 
            this.UpDown.Tick += new System.EventHandler(this.UpDown_Tick);
            // 
            // fall
            // 
            this.fall.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1097, 548);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credits";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(766, 108);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bravo na pobedi!";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 75);
            this.label3.TabIndex = 1;
            this.label3.Text = "Radili su: Filip (404oops), Zoran i Marko\r\nVecinom radio Filip zbog izolacije.\r\n\r" +
    "\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(684, 108);
            this.label2.TabIndex = 0;
            this.label2.Text = "DuckHunt.NET";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 762);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InfoControl);
            this.Controls.Add(this.MainControl);
            this.Name = "Form1";
            this.Text = "Duck Hunt - Filip, Marko & Zoran";
            this.MainControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.InfoControl.ResumeLayout(false);
            this.InfoControl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer MovementAnim;
        private System.Windows.Forms.Timer Tracking;
        private System.Windows.Forms.GroupBox MainControl;
        private System.Windows.Forms.GroupBox InfoControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer UpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer fall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
    }
}

