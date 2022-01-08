
namespace PyPaint
{
    partial class Palette
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GreenTB = new System.Windows.Forms.TextBox();
            this.BlueTB = new System.Windows.Forms.TextBox();
            this.RedTB = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.thisColor = new System.Windows.Forms.PictureBox();
            this.redBar = new System.Windows.Forms.TrackBar();
            this.greenBar = new System.Windows.Forms.TrackBar();
            this.blueBar = new System.Windows.Forms.TrackBar();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.thisColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GreenTB
            // 
            this.GreenTB.Location = new System.Drawing.Point(77, 95);
            this.GreenTB.Name = "GreenTB";
            this.GreenTB.Size = new System.Drawing.Size(31, 22);
            this.GreenTB.TabIndex = 1;
            this.GreenTB.Text = "0";
            this.GreenTB.TextChanged += new System.EventHandler(this.GreenTB_TextChanged);
            // 
            // BlueTB
            // 
            this.BlueTB.Location = new System.Drawing.Point(77, 149);
            this.BlueTB.Name = "BlueTB";
            this.BlueTB.Size = new System.Drawing.Size(31, 22);
            this.BlueTB.TabIndex = 2;
            this.BlueTB.Text = "0";
            this.BlueTB.TextChanged += new System.EventHandler(this.BlueTB_TextChanged);
            // 
            // RedTB
            // 
            this.RedTB.Location = new System.Drawing.Point(77, 36);
            this.RedTB.Name = "RedTB";
            this.RedTB.Size = new System.Drawing.Size(31, 22);
            this.RedTB.TabIndex = 3;
            this.RedTB.Text = "0";
            this.RedTB.TextChanged += new System.EventHandler(this.RedTB_TextChanged);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(12, 149);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(36, 17);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "Blue";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(9, 95);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(48, 17);
            this.labelG.TabIndex = 5;
            this.labelG.Text = "Green";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(12, 36);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(34, 17);
            this.labelR.TabIndex = 6;
            this.labelR.Text = "Red";
            // 
            // thisColor
            // 
            this.thisColor.Location = new System.Drawing.Point(151, 36);
            this.thisColor.Name = "thisColor";
            this.thisColor.Size = new System.Drawing.Size(87, 114);
            this.thisColor.TabIndex = 7;
            this.thisColor.TabStop = false;
            // 
            // redBar
            // 
            this.redBar.Location = new System.Drawing.Point(12, 6);
            this.redBar.Maximum = 255;
            this.redBar.Name = "redBar";
            this.redBar.Size = new System.Drawing.Size(96, 56);
            this.redBar.TabIndex = 8;
            this.redBar.TabStop = false;
            this.redBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.redBar.Scroll += new System.EventHandler(this.redBar_Scroll);
            // 
            // greenBar
            // 
            this.greenBar.Location = new System.Drawing.Point(12, 64);
            this.greenBar.Maximum = 255;
            this.greenBar.Name = "greenBar";
            this.greenBar.Size = new System.Drawing.Size(96, 56);
            this.greenBar.TabIndex = 10;
            this.greenBar.TabStop = false;
            this.greenBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.greenBar.Scroll += new System.EventHandler(this.greenBar_Scroll);
            // 
            // blueBar
            // 
            this.blueBar.Location = new System.Drawing.Point(12, 123);
            this.blueBar.Maximum = 255;
            this.blueBar.Name = "blueBar";
            this.blueBar.Size = new System.Drawing.Size(96, 56);
            this.blueBar.TabIndex = 11;
            this.blueBar.TabStop = false;
            this.blueBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.blueBar.Scroll += new System.EventHandler(this.blueBar_Scroll);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(163, 156);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Palette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 190);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.thisColor);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.RedTB);
            this.Controls.Add(this.BlueTB);
            this.Controls.Add(this.GreenTB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.redBar);
            this.Controls.Add(this.greenBar);
            this.Controls.Add(this.blueBar);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(264, 103);
            this.Name = "Palette";
            this.Text = "Palette";
            ((System.ComponentModel.ISupportInitialize)(this.thisColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox GreenTB;
        private System.Windows.Forms.TextBox BlueTB;
        private System.Windows.Forms.TextBox RedTB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.PictureBox thisColor;
        private System.Windows.Forms.TrackBar redBar;
        private System.Windows.Forms.TrackBar greenBar;
        private System.Windows.Forms.TrackBar blueBar;
        private System.Windows.Forms.Button buttonClear;
    }
}