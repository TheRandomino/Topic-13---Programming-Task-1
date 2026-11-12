namespace Topic_13___Programming_Task_1
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
            this.grpBackColor = new System.Windows.Forms.GroupBox();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.lblColor = new System.Windows.Forms.Label();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.grpTextColor = new System.Windows.Forms.GroupBox();
            this.radYellow = new System.Windows.Forms.RadioButton();
            this.radMagenta = new System.Windows.Forms.RadioButton();
            this.radCyan = new System.Windows.Forms.RadioButton();
            this.grpBackColor.SuspendLayout();
            this.grpTextColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBackColor
            // 
            this.grpBackColor.Controls.Add(this.radBlue);
            this.grpBackColor.Controls.Add(this.radGreen);
            this.grpBackColor.Controls.Add(this.radRed);
            this.grpBackColor.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBackColor.Location = new System.Drawing.Point(16, 63);
            this.grpBackColor.Name = "grpBackColor";
            this.grpBackColor.Size = new System.Drawing.Size(200, 117);
            this.grpBackColor.TabIndex = 0;
            this.grpBackColor.TabStop = false;
            this.grpBackColor.Text = "Choose a background color";
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(7, 20);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(54, 25);
            this.radRed.TabIndex = 0;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRedSelected);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(163, 9);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(112, 21);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Choose a Color!";
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Location = new System.Drawing.Point(7, 51);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(67, 25);
            this.radGreen.TabIndex = 1;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreenSelected);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(7, 82);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(58, 25);
            this.radBlue.TabIndex = 2;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlueSelected);
            // 
            // grpTextColor
            // 
            this.grpTextColor.Controls.Add(this.radYellow);
            this.grpTextColor.Controls.Add(this.radMagenta);
            this.grpTextColor.Controls.Add(this.radCyan);
            this.grpTextColor.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTextColor.Location = new System.Drawing.Point(222, 63);
            this.grpTextColor.Name = "grpTextColor";
            this.grpTextColor.Size = new System.Drawing.Size(200, 117);
            this.grpTextColor.TabIndex = 3;
            this.grpTextColor.TabStop = false;
            this.grpTextColor.Text = "Choose a text color";
            // 
            // radYellow
            // 
            this.radYellow.AutoSize = true;
            this.radYellow.Location = new System.Drawing.Point(7, 82);
            this.radYellow.Name = "radYellow";
            this.radYellow.Size = new System.Drawing.Size(68, 25);
            this.radYellow.TabIndex = 2;
            this.radYellow.Text = "Yellow";
            this.radYellow.UseVisualStyleBackColor = true;
            this.radYellow.CheckedChanged += new System.EventHandler(this.radYellowSelected);
            // 
            // radMagenta
            // 
            this.radMagenta.AutoSize = true;
            this.radMagenta.Location = new System.Drawing.Point(7, 51);
            this.radMagenta.Name = "radMagenta";
            this.radMagenta.Size = new System.Drawing.Size(79, 25);
            this.radMagenta.TabIndex = 1;
            this.radMagenta.Text = "Magenta";
            this.radMagenta.UseVisualStyleBackColor = true;
            this.radMagenta.CheckedChanged += new System.EventHandler(this.radMagentaSelected);
            // 
            // radCyan
            // 
            this.radCyan.AutoSize = true;
            this.radCyan.Location = new System.Drawing.Point(7, 20);
            this.radCyan.Name = "radCyan";
            this.radCyan.Size = new System.Drawing.Size(62, 25);
            this.radCyan.TabIndex = 0;
            this.radCyan.Text = "Cyan";
            this.radCyan.UseVisualStyleBackColor = true;
            this.radCyan.CheckedChanged += new System.EventHandler(this.radCyanSelected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 195);
            this.Controls.Add(this.grpTextColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.grpBackColor);
            this.Name = "Form1";
            this.Text = "Color 🤤";
            this.grpBackColor.ResumeLayout(false);
            this.grpBackColor.PerformLayout();
            this.grpTextColor.ResumeLayout(false);
            this.grpTextColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBackColor;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.GroupBox grpTextColor;
        private System.Windows.Forms.RadioButton radYellow;
        private System.Windows.Forms.RadioButton radMagenta;
        private System.Windows.Forms.RadioButton radCyan;
    }
}

