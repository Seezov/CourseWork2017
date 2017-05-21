namespace TRUTLEGRAPH3
{
    partial class BlueTurtleForm
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
            this.DRTextBox = new System.Windows.Forms.TextBox();
            this.DrawRectangleButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TRTextBox = new System.Windows.Forms.TextBox();
            this.TLTextBox = new System.Windows.Forms.TextBox();
            this.MBTextBox = new System.Windows.Forms.TextBox();
            this.MFTextBox = new System.Windows.Forms.TextBox();
            this.PenCheckBox = new System.Windows.Forms.CheckBox();
            this.TurnRightButton = new System.Windows.Forms.Button();
            this.TurnLeftButton = new System.Windows.Forms.Button();
            this.MoveBackwardsButton = new System.Windows.Forms.Button();
            this.MoveForwardButton = new System.Windows.Forms.Button();
            this.DrawingArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // DRTextBox
            // 
            this.DRTextBox.Location = new System.Drawing.Point(479, 205);
            this.DRTextBox.Name = "DRTextBox";
            this.DRTextBox.Size = new System.Drawing.Size(99, 20);
            this.DRTextBox.TabIndex = 49;
            // 
            // DrawRectangleButton
            // 
            this.DrawRectangleButton.Location = new System.Drawing.Point(479, 176);
            this.DrawRectangleButton.Name = "DrawRectangleButton";
            this.DrawRectangleButton.Size = new System.Drawing.Size(99, 23);
            this.DrawRectangleButton.TabIndex = 48;
            this.DrawRectangleButton.Text = "Draw Rectangle";
            this.DrawRectangleButton.UseVisualStyleBackColor = true;
            this.DrawRectangleButton.Click += new System.EventHandler(this.DrawRectangleButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(479, 147);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(99, 23);
            this.ClearButton.TabIndex = 47;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TRTextBox
            // 
            this.TRTextBox.Location = new System.Drawing.Point(531, 121);
            this.TRTextBox.Name = "TRTextBox";
            this.TRTextBox.Size = new System.Drawing.Size(99, 20);
            this.TRTextBox.TabIndex = 46;
            // 
            // TLTextBox
            // 
            this.TLTextBox.Location = new System.Drawing.Point(426, 121);
            this.TLTextBox.Name = "TLTextBox";
            this.TLTextBox.Size = new System.Drawing.Size(99, 20);
            this.TLTextBox.TabIndex = 45;
            // 
            // MBTextBox
            // 
            this.MBTextBox.Location = new System.Drawing.Point(531, 43);
            this.MBTextBox.Name = "MBTextBox";
            this.MBTextBox.Size = new System.Drawing.Size(99, 20);
            this.MBTextBox.TabIndex = 44;
            // 
            // MFTextBox
            // 
            this.MFTextBox.Location = new System.Drawing.Point(426, 43);
            this.MFTextBox.Name = "MFTextBox";
            this.MFTextBox.Size = new System.Drawing.Size(99, 20);
            this.MFTextBox.TabIndex = 43;
            // 
            // PenCheckBox
            // 
            this.PenCheckBox.AutoSize = true;
            this.PenCheckBox.Location = new System.Drawing.Point(479, 69);
            this.PenCheckBox.Name = "PenCheckBox";
            this.PenCheckBox.Size = new System.Drawing.Size(87, 17);
            this.PenCheckBox.TabIndex = 42;
            this.PenCheckBox.Text = "Pen is active";
            this.PenCheckBox.UseVisualStyleBackColor = true;
            // 
            // TurnRightButton
            // 
            this.TurnRightButton.Location = new System.Drawing.Point(531, 92);
            this.TurnRightButton.Name = "TurnRightButton";
            this.TurnRightButton.Size = new System.Drawing.Size(99, 23);
            this.TurnRightButton.TabIndex = 41;
            this.TurnRightButton.Text = "Turn Right";
            this.TurnRightButton.UseVisualStyleBackColor = true;
            this.TurnRightButton.Click += new System.EventHandler(this.TurnRightButton_Click);
            // 
            // TurnLeftButton
            // 
            this.TurnLeftButton.Location = new System.Drawing.Point(426, 92);
            this.TurnLeftButton.Name = "TurnLeftButton";
            this.TurnLeftButton.Size = new System.Drawing.Size(99, 23);
            this.TurnLeftButton.TabIndex = 40;
            this.TurnLeftButton.Text = "Turn Left";
            this.TurnLeftButton.UseVisualStyleBackColor = true;
            this.TurnLeftButton.Click += new System.EventHandler(this.TurnLeftButton_Click);
            // 
            // MoveBackwardsButton
            // 
            this.MoveBackwardsButton.Location = new System.Drawing.Point(531, 13);
            this.MoveBackwardsButton.Name = "MoveBackwardsButton";
            this.MoveBackwardsButton.Size = new System.Drawing.Size(99, 23);
            this.MoveBackwardsButton.TabIndex = 39;
            this.MoveBackwardsButton.Text = "Move Backwards";
            this.MoveBackwardsButton.UseVisualStyleBackColor = true;
            this.MoveBackwardsButton.Click += new System.EventHandler(this.MoveBackwardsButton_Click);
            // 
            // MoveForwardButton
            // 
            this.MoveForwardButton.Location = new System.Drawing.Point(426, 13);
            this.MoveForwardButton.Name = "MoveForwardButton";
            this.MoveForwardButton.Size = new System.Drawing.Size(99, 23);
            this.MoveForwardButton.TabIndex = 38;
            this.MoveForwardButton.Text = "Move Forward";
            this.MoveForwardButton.UseVisualStyleBackColor = true;
            this.MoveForwardButton.Click += new System.EventHandler(this.MoveForwardButton_Click);
            // 
            // DrawingArea
            // 
            this.DrawingArea.BackColor = System.Drawing.SystemColors.Window;
            this.DrawingArea.Location = new System.Drawing.Point(12, 12);
            this.DrawingArea.Name = "DrawingArea";
            this.DrawingArea.Size = new System.Drawing.Size(397, 354);
            this.DrawingArea.TabIndex = 37;
            this.DrawingArea.TabStop = false;
            // 
            // BlueTurtleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 378);
            this.Controls.Add(this.DRTextBox);
            this.Controls.Add(this.DrawRectangleButton);
            this.Controls.Add(this.ClearButton);
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
            this.Name = "BlueTurtleForm";
            this.Text = "BlueTurtleForm";
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DRTextBox;
        private System.Windows.Forms.Button DrawRectangleButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox TRTextBox;
        private System.Windows.Forms.TextBox TLTextBox;
        private System.Windows.Forms.TextBox MBTextBox;
        private System.Windows.Forms.TextBox MFTextBox;
        private System.Windows.Forms.CheckBox PenCheckBox;
        private System.Windows.Forms.Button TurnRightButton;
        private System.Windows.Forms.Button TurnLeftButton;
        private System.Windows.Forms.Button MoveBackwardsButton;
        private System.Windows.Forms.Button MoveForwardButton;
        private System.Windows.Forms.PictureBox DrawingArea;
    }
}