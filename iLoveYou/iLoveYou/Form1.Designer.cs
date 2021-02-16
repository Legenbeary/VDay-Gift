
namespace iLoveYou
{
    partial class iLoveYouForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iLoveYouForm));
            this.iLoveYouPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iLoveYouPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iLoveYouPictureBox
            // 
            this.iLoveYouPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("iLoveYouPictureBox.Image")));
            this.iLoveYouPictureBox.Location = new System.Drawing.Point(-5, -3);
            this.iLoveYouPictureBox.Name = "iLoveYouPictureBox";
            this.iLoveYouPictureBox.Size = new System.Drawing.Size(642, 639);
            this.iLoveYouPictureBox.TabIndex = 0;
            this.iLoveYouPictureBox.TabStop = false;
            // 
            // iLoveYouForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 633);
            this.Controls.Add(this.iLoveYouPictureBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "iLoveYouForm";
            ((System.ComponentModel.ISupportInitialize)(this.iLoveYouPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iLoveYouPictureBox;
    }
}

