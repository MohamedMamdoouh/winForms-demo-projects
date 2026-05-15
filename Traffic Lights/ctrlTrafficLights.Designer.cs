namespace TestWinForms_22
{
    partial class ctrlTrafficLights
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblLightCounter = new System.Windows.Forms.Label();
            this.pbLight = new System.Windows.Forms.PictureBox();
            this.LightTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLightCounter
            // 
            this.lblLightCounter.AutoSize = true;
            this.lblLightCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblLightCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLightCounter.Location = new System.Drawing.Point(34, 171);
            this.lblLightCounter.Name = "lblLightCounter";
            this.lblLightCounter.Size = new System.Drawing.Size(36, 25);
            this.lblLightCounter.TabIndex = 1;
            this.lblLightCounter.Text = "??";
            // 
            // pbLight
            // 
            this.pbLight.Image = global::TestWinForms_22.Properties.Resources.Yellow;
            this.pbLight.Location = new System.Drawing.Point(3, 3);
            this.pbLight.Name = "pbLight";
            this.pbLight.Size = new System.Drawing.Size(90, 180);
            this.pbLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLight.TabIndex = 0;
            this.pbLight.TabStop = false;
            // 
            // LightTimer
            // 
            this.LightTimer.Interval = 1000;
            this.LightTimer.Tick += new System.EventHandler(this.LightTimer_Tick);
            // 
            // ctrlTrafficLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLightCounter);
            this.Controls.Add(this.pbLight);
            this.Name = "ctrlTrafficLights";
            this.Size = new System.Drawing.Size(112, 214);
            this.Load += new System.EventHandler(this.ctrlTrafficLights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLight;
        private System.Windows.Forms.Label lblLightCounter;
        private System.Windows.Forms.Timer LightTimer;
    }
}
