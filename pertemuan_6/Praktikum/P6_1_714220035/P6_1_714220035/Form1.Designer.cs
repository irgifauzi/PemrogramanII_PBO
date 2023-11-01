namespace P6_1_714220035
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
            this.vbButton = new System.Windows.Forms.Button();
            this.csButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vbButton
            // 
            this.vbButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.vbButton.Location = new System.Drawing.Point(164, 152);
            this.vbButton.Name = "vbButton";
            this.vbButton.Size = new System.Drawing.Size(134, 40);
            this.vbButton.TabIndex = 0;
            this.vbButton.Text = "Visual Basic";
            this.vbButton.UseVisualStyleBackColor = false;
            this.vbButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vbButton_MouseMove);
            // 
            // csButton
            // 
            this.csButton.BackColor = System.Drawing.Color.DarkGray;
            this.csButton.Location = new System.Drawing.Point(405, 152);
            this.csButton.Name = "csButton";
            this.csButton.Size = new System.Drawing.Size(149, 40);
            this.csButton.TabIndex = 1;
            this.csButton.Text = "C#";
            this.csButton.UseVisualStyleBackColor = false;
            this.csButton.Click += new System.EventHandler(this.csButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.Location = new System.Drawing.Point(98, 331);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(155, 40);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Which do you think is better, Visual Basic or C#?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.csButton);
            this.Controls.Add(this.vbButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vbButton;
        private System.Windows.Forms.Button csButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
    }
}

