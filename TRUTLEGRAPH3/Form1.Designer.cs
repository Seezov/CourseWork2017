namespace TRUTLEGRAPH3
{
    partial class MainForm
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
            this.DrawingArea = new System.Windows.Forms.PictureBox();
            this.MoveForwardButton = new System.Windows.Forms.Button();
            this.MoveBackwardsButton = new System.Windows.Forms.Button();
            this.TurnRightButton = new System.Windows.Forms.Button();
            this.TurnLeftButton = new System.Windows.Forms.Button();
            this.PenCheckBox = new System.Windows.Forms.CheckBox();
            this.MFTextBox = new System.Windows.Forms.TextBox();
            this.MBTextBox = new System.Windows.Forms.TextBox();
            this.TRTextBox = new System.Windows.Forms.TextBox();
            this.TLTextBox = new System.Windows.Forms.TextBox();
            this.DrawTriangleButton = new System.Windows.Forms.Button();
            this.DrawCircleButton = new System.Windows.Forms.Button();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.TriangleTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawingArea
            // 
            this.DrawingArea.BackColor = System.Drawing.SystemColors.Window;
            this.DrawingArea.Location = new System.Drawing.Point(12, 12);
            this.DrawingArea.Name = "DrawingArea";
            this.DrawingArea.Size = new System.Drawing.Size(397, 354);
            this.DrawingArea.TabIndex = 0;
            this.DrawingArea.TabStop = false;
            // 
            // MoveForwardButton
            // 
            this.MoveForwardButton.Location = new System.Drawing.Point(426, 13);
            this.MoveForwardButton.Name = "MoveForwardButton";
            this.MoveForwardButton.Size = new System.Drawing.Size(99, 23);
            this.MoveForwardButton.TabIndex = 1;
            this.MoveForwardButton.Text = "Move Forward";
            this.MoveForwardButton.UseVisualStyleBackColor = true;
            this.MoveForwardButton.Click += new System.EventHandler(this.MoveForwardButton_Click);
            // 
            // MoveBackwardsButton
            // 
            this.MoveBackwardsButton.Location = new System.Drawing.Point(531, 13);
            this.MoveBackwardsButton.Name = "MoveBackwardsButton";
            this.MoveBackwardsButton.Size = new System.Drawing.Size(99, 23);
            this.MoveBackwardsButton.TabIndex = 2;
            this.MoveBackwardsButton.Text = "Move Backwards";
            this.MoveBackwardsButton.UseVisualStyleBackColor = true;
            this.MoveBackwardsButton.Click += new System.EventHandler(this.MoveBackwardsButton_Click);
            // 
            // TurnRightButton
            // 
            this.TurnRightButton.Location = new System.Drawing.Point(531, 92);
            this.TurnRightButton.Name = "TurnRightButton";
            this.TurnRightButton.Size = new System.Drawing.Size(99, 23);
            this.TurnRightButton.TabIndex = 4;
            this.TurnRightButton.Text = "Turn Right";
            this.TurnRightButton.UseVisualStyleBackColor = true;
            this.TurnRightButton.Click += new System.EventHandler(this.TurnRightButton_Click);
            // 
            // TurnLeftButton
            // 
            this.TurnLeftButton.Location = new System.Drawing.Point(426, 92);
            this.TurnLeftButton.Name = "TurnLeftButton";
            this.TurnLeftButton.Size = new System.Drawing.Size(99, 23);
            this.TurnLeftButton.TabIndex = 3;
            this.TurnLeftButton.Text = "Turn Left";
            this.TurnLeftButton.UseVisualStyleBackColor = true;
            this.TurnLeftButton.Click += new System.EventHandler(this.TurnLeftButton_Click);
            // 
            // PenCheckBox
            // 
            this.PenCheckBox.AutoSize = true;
            this.PenCheckBox.Location = new System.Drawing.Point(484, 69);
            this.PenCheckBox.Name = "PenCheckBox";
            this.PenCheckBox.Size = new System.Drawing.Size(87, 17);
            this.PenCheckBox.TabIndex = 5;
            this.PenCheckBox.Text = "Pen is active";
            this.PenCheckBox.UseVisualStyleBackColor = true;
            // 
            // MFTextBox
            // 
            this.MFTextBox.Location = new System.Drawing.Point(426, 43);
            this.MFTextBox.Name = "MFTextBox";
            this.MFTextBox.Size = new System.Drawing.Size(99, 20);
            this.MFTextBox.TabIndex = 6;
            // 
            // MBTextBox
            // 
            this.MBTextBox.Location = new System.Drawing.Point(531, 43);
            this.MBTextBox.Name = "MBTextBox";
            this.MBTextBox.Size = new System.Drawing.Size(99, 20);
            this.MBTextBox.TabIndex = 7;
            // 
            // TRTextBox
            // 
            this.TRTextBox.Location = new System.Drawing.Point(531, 121);
            this.TRTextBox.Name = "TRTextBox";
            this.TRTextBox.Size = new System.Drawing.Size(99, 20);
            this.TRTextBox.TabIndex = 9;
            // 
            // TLTextBox
            // 
            this.TLTextBox.Location = new System.Drawing.Point(426, 121);
            this.TLTextBox.Name = "TLTextBox";
            this.TLTextBox.Size = new System.Drawing.Size(99, 20);
            this.TLTextBox.TabIndex = 8;
            // 
            // DrawTriangleButton
            // 
            this.DrawTriangleButton.Location = new System.Drawing.Point(531, 164);
            this.DrawTriangleButton.Name = "DrawTriangleButton";
            this.DrawTriangleButton.Size = new System.Drawing.Size(99, 23);
            this.DrawTriangleButton.TabIndex = 11;
            this.DrawTriangleButton.Text = "Draw Triangle";
            this.DrawTriangleButton.UseVisualStyleBackColor = true;
            this.DrawTriangleButton.Click += new System.EventHandler(this.DrawTriangleButton_Click);
            // 
            // DrawCircleButton
            // 
            this.DrawCircleButton.Location = new System.Drawing.Point(426, 164);
            this.DrawCircleButton.Name = "DrawCircleButton";
            this.DrawCircleButton.Size = new System.Drawing.Size(99, 23);
            this.DrawCircleButton.TabIndex = 10;
            this.DrawCircleButton.Text = "Draw Circle";
            this.DrawCircleButton.UseVisualStyleBackColor = true;
            this.DrawCircleButton.Click += new System.EventHandler(this.DrawCircleButton_Click);
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(426, 193);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(99, 20);
            this.RadiusTextBox.TabIndex = 12;
            // 
            // TriangleTextBox
            // 
            this.TriangleTextBox.Location = new System.Drawing.Point(531, 193);
            this.TriangleTextBox.Name = "TriangleTextBox";
            this.TriangleTextBox.Size = new System.Drawing.Size(99, 20);
            this.TriangleTextBox.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 378);
            this.Controls.Add(this.TriangleTextBox);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.DrawTriangleButton);
            this.Controls.Add(this.DrawCircleButton);
            this.Controls.Add(this.TRTextBox);
            this.Controls.Add(this.TLTextBox);
            this.Controls.Add(this.MBTextBox);
            this.Controls.Add(this.MFTextBox);
            this.Controls.Add(this.PenCheckBox);
            this.Controls.Add(this.TurnRightButton);
            this.Controls.Add(this.TurnLeftButton);
            this.Controls.Add(this.MoveBackwardsButton);
            this.Controls.Add(this.MoveForwardButton);
            this.Controls.Add(this.DrawingArea);
            this.Name = "MainForm";
            this.Text = "Turtle Graphics";
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawingArea;
        private System.Windows.Forms.Button MoveForwardButton;
        private System.Windows.Forms.Button MoveBackwardsButton;
        private System.Windows.Forms.Button TurnRightButton;
        private System.Windows.Forms.Button TurnLeftButton;
        private System.Windows.Forms.CheckBox PenCheckBox;
        private System.Windows.Forms.TextBox MFTextBox;
        private System.Windows.Forms.TextBox MBTextBox;
        private System.Windows.Forms.TextBox TRTextBox;
        private System.Windows.Forms.TextBox TLTextBox;
        private System.Windows.Forms.Button DrawTriangleButton;
        private System.Windows.Forms.Button DrawCircleButton;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.TextBox TriangleTextBox;
    }
}

