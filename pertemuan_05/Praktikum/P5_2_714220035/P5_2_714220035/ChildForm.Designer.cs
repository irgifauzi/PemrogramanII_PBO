namespace P5_2_714220035
{
    partial class ChildForm
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
            this.OutputLabel = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.TimeOption = new System.Windows.Forms.RadioButton();
            this.DateOption = new System.Windows.Forms.RadioButton();
            this.OutputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutputLabel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(0, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(266, 32);
            this.OutputLabel.TabIndex = 0;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(24, 56);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(90, 33);
            this.DisplayButton.TabIndex = 1;
            this.DisplayButton.Text = "&Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(136, 56);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(96, 33);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputGroupBox.Controls.Add(this.TimeOption);
            this.OutputGroupBox.Controls.Add(this.DateOption);
            this.OutputGroupBox.Location = new System.Drawing.Point(24, 111);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(218, 132);
            this.OutputGroupBox.TabIndex = 3;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Choose Output";
            this.OutputGroupBox.Enter += new System.EventHandler(this.OutputGroupBox_Enter);
            // 
            // TimeOption
            // 
            this.TimeOption.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TimeOption.Location = new System.Drawing.Point(11, 74);
            this.TimeOption.Name = "TimeOption";
            this.TimeOption.Size = new System.Drawing.Size(197, 30);
            this.TimeOption.TabIndex = 1;
            this.TimeOption.TabStop = true;
            this.TimeOption.Text = "Display Current&Time";
            this.TimeOption.UseVisualStyleBackColor = true;
            this.TimeOption.Click += new System.EventHandler(this.TimeOption_Click);
            // 
            // DateOption
            // 
            this.DateOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateOption.Location = new System.Drawing.Point(11, 28);
            this.DateOption.Name = "DateOption";
            this.DateOption.Size = new System.Drawing.Size(197, 24);
            this.DateOption.TabIndex = 0;
            this.DateOption.TabStop = true;
            this.DateOption.Text = "Display Current D&ate";
            this.DateOption.UseVisualStyleBackColor = true;
            this.DateOption.Click += new System.EventHandler(this.DateOption_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 255);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.OutputLabel);
            this.Name = "ChildForm";
            this.Text = "3";
            this.OutputGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.RadioButton TimeOption;
        private System.Windows.Forms.RadioButton DateOption;
    }
}