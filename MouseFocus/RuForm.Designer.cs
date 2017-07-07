namespace MouseFocus
{
    partial class MouseFocus
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
            this.hoverMouseFocusButton = new System.Windows.Forms.Button();
            this.focusStatusLabel = new System.Windows.Forms.Label();
            this.clickMouseFocusButton = new System.Windows.Forms.Button();
            this.logOutWarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hoverMouseFocusButton
            // 
            this.hoverMouseFocusButton.Location = new System.Drawing.Point(12, 12);
            this.hoverMouseFocusButton.Name = "hoverMouseFocusButton";
            this.hoverMouseFocusButton.Size = new System.Drawing.Size(220, 62);
            this.hoverMouseFocusButton.TabIndex = 0;
            this.hoverMouseFocusButton.Text = "Hover Mouse Focus";
            this.hoverMouseFocusButton.UseVisualStyleBackColor = true;
            this.hoverMouseFocusButton.Click += new System.EventHandler(this.hoverMouseFocusButton_Click);
            // 
            // focusStatusLabel
            // 
            this.focusStatusLabel.AutoSize = true;
            this.focusStatusLabel.Location = new System.Drawing.Point(7, 77);
            this.focusStatusLabel.Name = "focusStatusLabel";
            this.focusStatusLabel.Size = new System.Drawing.Size(62, 25);
            this.focusStatusLabel.TabIndex = 1;
            this.focusStatusLabel.Text = "NULL";
            // 
            // clickMouseFocusButton
            // 
            this.clickMouseFocusButton.Location = new System.Drawing.Point(238, 12);
            this.clickMouseFocusButton.Name = "clickMouseFocusButton";
            this.clickMouseFocusButton.Size = new System.Drawing.Size(220, 62);
            this.clickMouseFocusButton.TabIndex = 2;
            this.clickMouseFocusButton.Text = "Click Mouse Focus";
            this.clickMouseFocusButton.UseVisualStyleBackColor = true;
            this.clickMouseFocusButton.Click += new System.EventHandler(this.clickMouseFocusButton_Click);
            // 
            // logOutWarningLabel
            // 
            this.logOutWarningLabel.AutoSize = true;
            this.logOutWarningLabel.Location = new System.Drawing.Point(7, 102);
            this.logOutWarningLabel.Name = "logOutWarningLabel";
            this.logOutWarningLabel.Size = new System.Drawing.Size(62, 25);
            this.logOutWarningLabel.TabIndex = 3;
            this.logOutWarningLabel.Text = "NULL";
            // 
            // MouseFocus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 136);
            this.Controls.Add(this.logOutWarningLabel);
            this.Controls.Add(this.clickMouseFocusButton);
            this.Controls.Add(this.focusStatusLabel);
            this.Controls.Add(this.hoverMouseFocusButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MouseFocus";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Mouse Focus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Windows Form Designer generated code


        #endregion

        private System.Windows.Forms.Button hoverMouseFocusButton;
        private System.Windows.Forms.Label focusStatusLabel;
        private System.Windows.Forms.Button clickMouseFocusButton;
        private System.Windows.Forms.Label logOutWarningLabel;
    }
}

