namespace boxtganme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            redBox = new PictureBox();
            blueBox = new PictureBox();
            greenBox = new PictureBox();
            numericRed = new NumericUpDown();
            numericBlue = new NumericUpDown();
            numericGreen = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)redBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGreen).BeginInit();
            SuspendLayout();
            // 
            // redBox
            // 
            redBox.Location = new Point(34, 32);
            redBox.Name = "redBox";
            redBox.Size = new Size(250, 250);
            redBox.TabIndex = 1;
            redBox.TabStop = false;
            // 
            // blueBox
            // 
            blueBox.Location = new Point(290, 32);
            blueBox.Name = "blueBox";
            blueBox.Size = new Size(250, 250);
            blueBox.TabIndex = 2;
            blueBox.TabStop = false;
            // 
            // greenBox
            // 
            greenBox.Location = new Point(546, 32);
            greenBox.Name = "greenBox";
            greenBox.Size = new Size(250, 250);
            greenBox.TabIndex = 3;
            greenBox.TabStop = false;
            // 
            // numericRed
            // 
            numericRed.Location = new Point(34, 320);
            numericRed.Name = "numericRed";
            numericRed.Size = new Size(120, 23);
            numericRed.TabIndex = 4;
            // 
            // numericBlue
            // 
            numericBlue.Location = new Point(290, 320);
            numericBlue.Name = "numericBlue";
            numericBlue.Size = new Size(120, 23);
            numericBlue.TabIndex = 5;
            numericBlue.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericGreen
            // 
            numericGreen.Location = new Point(546, 320);
            numericGreen.Name = "numericGreen";
            numericGreen.Size = new Size(120, 23);
            numericGreen.TabIndex = 6;
            numericGreen.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericGreen);
            Controls.Add(numericBlue);
            Controls.Add(numericRed);
            Controls.Add(greenBox);
            Controls.Add(blueBox);
            Controls.Add(redBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)redBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGreen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox redBox;
        private PictureBox blueBox;
        private PictureBox greenBox;
        private NumericUpDown numericRed;
        private NumericUpDown numericBlue;
        private NumericUpDown numericGreen;
    }
}