namespace PageOpener
{
    partial class Opener
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
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.timeSpanNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.openButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.Location = new System.Drawing.Point(12, 12);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(525, 23);
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // timeSpanNumericUpDown
            // 
            this.timeSpanNumericUpDown.Location = new System.Drawing.Point(12, 41);
            this.timeSpanNumericUpDown.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.timeSpanNumericUpDown.Name = "timeSpanNumericUpDown";
            this.timeSpanNumericUpDown.Size = new System.Drawing.Size(88, 23);
            this.timeSpanNumericUpDown.TabIndex = 1;
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.SystemColors.Menu;
            this.openButton.Location = new System.Drawing.Point(12, 70);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(88, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "OpenButton";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Opener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(549, 105);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.timeSpanNumericUpDown);
            this.Controls.Add(this.urlTextBox);
            this.Name = "Opener";
            this.Text = "Opener";
            this.Load += new System.EventHandler(this.Opener_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox urlTextBox;
        private NumericUpDown timeSpanNumericUpDown;
        private Button openButton;
    }
}