namespace TextAdventureSummative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.redImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(16, 11);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(469, 74);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "ESCAPE FROM THE LOST NATION";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.subtitleLabel.ForeColor = System.Drawing.Color.White;
            this.subtitleLabel.Location = new System.Drawing.Point(16, 85);
            this.subtitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(469, 74);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "A TEXT ADVENTURE";
            this.subtitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 244);
            this.label1.TabIndex = 2;
            // 
            // redImage
            // 
            this.redImage.Location = new System.Drawing.Point(24, 404);
            this.redImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.redImage.Name = "redImage";
            this.redImage.Size = new System.Drawing.Size(52, 40);
            this.redImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redImage.TabIndex = 3;
            this.redImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(501, 561);
            this.Controls.Add(this.redImage);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Escape from the Lost Nation";
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox redImage;
    }
}

