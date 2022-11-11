namespace Sherlock
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.quickLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.exitButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.sadPictureBox = new System.Windows.Forms.PictureBox();
            this.happyPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.happyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // quickLabel
            // 
            this.quickLabel.AutoSize = true;
            this.quickLabel.Location = new System.Drawing.Point(28, 36);
            this.quickLabel.Name = "quickLabel";
            this.quickLabel.Size = new System.Drawing.Size(225, 13);
            this.quickLabel.TabIndex = 0;
            this.quickLabel.Text = "The quick brown fox jumped over the lazy dog";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(31, 52);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(237, 20);
            this.textBox.TabIndex = 1;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.webBrowser);
            this.groupBox.Location = new System.Drawing.Point(403, 36);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(371, 316);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "http://https://people.rit.edu/dxsigm/sherlock.html";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 16);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(365, 297);
            this.webBrowser.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(690, 395);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.Red;
            this.timerLabel.Location = new System.Drawing.Point(91, 96);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(86, 31);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "label1";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // sadPictureBox
            // 
            this.sadPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("sadPictureBox.Image")));
            this.sadPictureBox.Location = new System.Drawing.Point(31, 176);
            this.sadPictureBox.Name = "sadPictureBox";
            this.sadPictureBox.Size = new System.Drawing.Size(237, 173);
            this.sadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sadPictureBox.TabIndex = 5;
            this.sadPictureBox.TabStop = false;
            // 
            // happyPictureBox
            // 
            this.happyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("happyPictureBox.Image")));
            this.happyPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("happyPictureBox.InitialImage")));
            this.happyPictureBox.Location = new System.Drawing.Point(31, 179);
            this.happyPictureBox.Name = "happyPictureBox";
            this.happyPictureBox.Size = new System.Drawing.Size(237, 173);
            this.happyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.happyPictureBox.TabIndex = 6;
            this.happyPictureBox.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.happyPictureBox);
            this.Controls.Add(this.sadPictureBox);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.quickLabel);
            this.Name = "Form";
            this.Text = "Sherlock";
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.happyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quickLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox sadPictureBox;
        private System.Windows.Forms.PictureBox happyPictureBox;
    }
}

