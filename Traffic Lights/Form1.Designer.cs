namespace TestWinForms_22
{
    partial class frmTrafficLights
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ctrlTrafficLights1 = new TestWinForms_22.ctrlTrafficLights();
            this.ctrlTrafficLights3 = new TestWinForms_22.ctrlTrafficLights();
            this.ctrlTrafficLights2 = new TestWinForms_22.ctrlTrafficLights();
            this.ctrlTrafficLights4 = new TestWinForms_22.ctrlTrafficLights();
            this.LightTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestWinForms_22.Properties.Resources.street;
            this.pictureBox1.Location = new System.Drawing.Point(99, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 513);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(346, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Road 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(524, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Road 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(345, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Road 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(168, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Road 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(679, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Road 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(420, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Road 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(13, 587);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Road 4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(420, 819);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Road 1";
            // 
            // ctrlTrafficLights1
            // 
            this.ctrlTrafficLights1.CurrentLight = TestWinForms_22.ctrlTrafficLights.enLight.Green;
            this.ctrlTrafficLights1.GreenLightDuration = ((byte)(10));
            this.ctrlTrafficLights1.Location = new System.Drawing.Point(331, 735);
            this.ctrlTrafficLights1.Name = "ctrlTrafficLights1";
            this.ctrlTrafficLights1.RedLightDuration = ((byte)(15));
            this.ctrlTrafficLights1.Size = new System.Drawing.Size(94, 201);
            this.ctrlTrafficLights1.TabIndex = 2;
            this.ctrlTrafficLights1.YellowLightDuration = ((byte)(10));
            // 
            // ctrlTrafficLights3
            // 
            this.ctrlTrafficLights3.CurrentLight = TestWinForms_22.ctrlTrafficLights.enLight.Green;
            this.ctrlTrafficLights3.GreenLightDuration = ((byte)(10));
            this.ctrlTrafficLights3.Location = new System.Drawing.Point(331, 9);
            this.ctrlTrafficLights3.Name = "ctrlTrafficLights3";
            this.ctrlTrafficLights3.RedLightDuration = ((byte)(15));
            this.ctrlTrafficLights3.Size = new System.Drawing.Size(95, 201);
            this.ctrlTrafficLights3.TabIndex = 4;
            this.ctrlTrafficLights3.YellowLightDuration = ((byte)(10));
            // 
            // ctrlTrafficLights2
            // 
            this.ctrlTrafficLights2.BackColor = System.Drawing.Color.Transparent;
            this.ctrlTrafficLights2.CurrentLight = TestWinForms_22.ctrlTrafficLights.enLight.Green;
            this.ctrlTrafficLights2.GreenLightDuration = ((byte)(10));
            this.ctrlTrafficLights2.Location = new System.Drawing.Point(665, 385);
            this.ctrlTrafficLights2.Name = "ctrlTrafficLights2";
            this.ctrlTrafficLights2.RedLightDuration = ((byte)(15));
            this.ctrlTrafficLights2.Size = new System.Drawing.Size(94, 199);
            this.ctrlTrafficLights2.TabIndex = 0;
            this.ctrlTrafficLights2.YellowLightDuration = ((byte)(10));
            // 
            // ctrlTrafficLights4
            // 
            this.ctrlTrafficLights4.CurrentLight = TestWinForms_22.ctrlTrafficLights.enLight.Green;
            this.ctrlTrafficLights4.GreenLightDuration = ((byte)(10));
            this.ctrlTrafficLights4.Location = new System.Drawing.Point(-2, 385);
            this.ctrlTrafficLights4.Name = "ctrlTrafficLights4";
            this.ctrlTrafficLights4.RedLightDuration = ((byte)(15));
            this.ctrlTrafficLights4.Size = new System.Drawing.Size(95, 199);
            this.ctrlTrafficLights4.TabIndex = 3;
            this.ctrlTrafficLights4.YellowLightDuration = ((byte)(10));
            // 
            // LightTimer
            // 
            this.LightTimer.Interval = 1000;
            this.LightTimer.Tick += new System.EventHandler(this.LightTimer_Tick);
            // 
            // frmTrafficLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 944);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlTrafficLights1);
            this.Controls.Add(this.ctrlTrafficLights3);
            this.Controls.Add(this.ctrlTrafficLights2);
            this.Controls.Add(this.ctrlTrafficLights4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTrafficLights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traffic Lights";
            this.Load += new System.EventHandler(this.frmTrafficLights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlTrafficLights ctrlTrafficLights2;
        private ctrlTrafficLights ctrlTrafficLights1;
        private ctrlTrafficLights ctrlTrafficLights4;
        private ctrlTrafficLights ctrlTrafficLights3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer LightTimer;
    }
}

