namespace CryptoStats
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.aboutForm = new ModalTheme();
            this.backButton = new ModalButton();
            this.close = new ModalControlButton();
            this.aboutForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutForm
            // 
            this.aboutForm.BorderThickness = 1;
            this.aboutForm.Controls.Add(this.backButton);
            this.aboutForm.Controls.Add(this.close);
            this.aboutForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.aboutForm.Location = new System.Drawing.Point(0, 0);
            this.aboutForm.Name = "aboutForm";
            this.aboutForm.ShowIcon = false;
            this.aboutForm.Size = new System.Drawing.Size(351, 329);
            this.aboutForm.TabIndex = 0;
            this.aboutForm.Text = "About";
            this.aboutForm.TitleTextPostion = ModalTheme.TitlePostion.Left;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(135, 277);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 29);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.ControlStyle = ModalControlButton.Style.Close;
            this.close.Location = new System.Drawing.Point(322, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 23);
            this.close.TabIndex = 0;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 329);
            this.Controls.Add(this.aboutForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            this.aboutForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ModalTheme aboutForm;
        private ModalControlButton close;
        private ModalButton backButton;
    }
}