namespace LED_QUIZ
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
            this.revealButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.questNo = new System.Windows.Forms.Label();
            this.questLabel = new System.Windows.Forms.Label();
            this.optALabel = new System.Windows.Forms.Label();
            this.optBLabel = new System.Windows.Forms.Label();
            this.optCLabel = new System.Windows.Forms.Label();
            this.optDLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // revealButton
            // 
            this.revealButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.revealButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.revealButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revealButton.ForeColor = System.Drawing.Color.White;
            this.revealButton.Location = new System.Drawing.Point(31, 416);
            this.revealButton.Name = "revealButton";
            this.revealButton.Size = new System.Drawing.Size(260, 86);
            this.revealButton.TabIndex = 0;
            this.revealButton.Text = "REVEAL ANSWER";
            this.revealButton.UseVisualStyleBackColor = false;
            this.revealButton.Click += new System.EventHandler(this.revealButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prevButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.prevButton.Font = new System.Drawing.Font("Eras Demi ITC", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevButton.ForeColor = System.Drawing.Color.White;
            this.prevButton.Location = new System.Drawing.Point(597, 416);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(130, 86);
            this.prevButton.TabIndex = 1;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // questNo
            // 
            this.questNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questNo.AutoSize = true;
            this.questNo.BackColor = System.Drawing.Color.Transparent;
            this.questNo.Font = new System.Drawing.Font("Eras Demi ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.questNo.Location = new System.Drawing.Point(361, 24);
            this.questNo.Name = "questNo";
            this.questNo.Size = new System.Drawing.Size(179, 31);
            this.questNo.TabIndex = 2;
            this.questNo.Text = "QUESTION #";
            // 
            // questLabel
            // 
            this.questLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questLabel.AutoSize = true;
            this.questLabel.BackColor = System.Drawing.Color.Transparent;
            this.questLabel.Font = new System.Drawing.Font("Eras Demi ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.questLabel.Location = new System.Drawing.Point(319, 94);
            this.questLabel.Name = "questLabel";
            this.questLabel.Size = new System.Drawing.Size(260, 23);
            this.questLabel.TabIndex = 3;
            this.questLabel.Text = "Your Question Goes Here?";
            // 
            // optALabel
            // 
            this.optALabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optALabel.AutoSize = true;
            this.optALabel.BackColor = System.Drawing.Color.Transparent;
            this.optALabel.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optALabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.optALabel.Location = new System.Drawing.Point(368, 170);
            this.optALabel.Name = "optALabel";
            this.optALabel.Size = new System.Drawing.Size(174, 19);
            this.optALabel.TabIndex = 4;
            this.optALabel.Text = "a. Opition a goes here";
            // 
            // optBLabel
            // 
            this.optBLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optBLabel.AutoSize = true;
            this.optBLabel.BackColor = System.Drawing.Color.Transparent;
            this.optBLabel.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optBLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.optBLabel.Location = new System.Drawing.Point(368, 208);
            this.optBLabel.Name = "optBLabel";
            this.optBLabel.Size = new System.Drawing.Size(176, 19);
            this.optBLabel.TabIndex = 4;
            this.optBLabel.Text = "b. Opition b goes here";
            // 
            // optCLabel
            // 
            this.optCLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optCLabel.AutoSize = true;
            this.optCLabel.BackColor = System.Drawing.Color.Transparent;
            this.optCLabel.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.optCLabel.Location = new System.Drawing.Point(368, 246);
            this.optCLabel.Name = "optCLabel";
            this.optCLabel.Size = new System.Drawing.Size(172, 19);
            this.optCLabel.TabIndex = 4;
            this.optCLabel.Text = "c. Opition c goes here";
            // 
            // optDLabel
            // 
            this.optDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optDLabel.AutoSize = true;
            this.optDLabel.BackColor = System.Drawing.Color.Transparent;
            this.optDLabel.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.optDLabel.Location = new System.Drawing.Point(368, 282);
            this.optDLabel.Name = "optDLabel";
            this.optDLabel.Size = new System.Drawing.Size(176, 19);
            this.optDLabel.TabIndex = 4;
            this.optDLabel.Text = "d. Opition d goes here";
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.nextButton.Font = new System.Drawing.Font("Eras Demi ITC", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(724, 416);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(130, 86);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.questNo);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.optDLabel);
            this.panel1.Controls.Add(this.prevButton);
            this.panel1.Controls.Add(this.questLabel);
            this.panel1.Controls.Add(this.revealButton);
            this.panel1.Controls.Add(this.optCLabel);
            this.panel1.Controls.Add(this.optALabel);
            this.panel1.Controls.Add(this.optBLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 526);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(887, 526);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button revealButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Label questNo;
        private System.Windows.Forms.Label questLabel;
        private System.Windows.Forms.Label optALabel;
        private System.Windows.Forms.Label optBLabel;
        private System.Windows.Forms.Label optCLabel;
        private System.Windows.Forms.Label optDLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Panel panel1;
    }
}

