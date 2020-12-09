namespace OTAI.Scenario {
    partial class FormCarte {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pictureCarte = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCarte)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCarte
            // 
            this.pictureCarte.BackgroundImage = global::OTAI.Scenario.Properties.Resources.carte;
            this.pictureCarte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureCarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureCarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureCarte.Location = new System.Drawing.Point(0, 0);
            this.pictureCarte.Name = "pictureCarte";
            this.pictureCarte.Size = new System.Drawing.Size(1008, 473);
            this.pictureCarte.TabIndex = 0;
            this.pictureCarte.TabStop = false;
            this.pictureCarte.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureCarte_MouseClick);
            // 
            // FormCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 473);
            this.Controls.Add(this.pictureCarte);
            this.Name = "FormCarte";
            this.Text = "Sélection d\'une position";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCarte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCarte;
    }
}