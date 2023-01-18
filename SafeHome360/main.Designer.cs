
namespace SafeHome360
{
    partial class main
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.closeConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panImage = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnF6 = new System.Windows.Forms.Button();
            this.btnF5 = new System.Windows.Forms.Button();
            this.btnF4 = new System.Windows.Forms.Button();
            this.btnF3 = new System.Windows.Forms.Button();
            this.btnF2 = new System.Windows.Forms.Button();
            this.btnF1 = new System.Windows.Forms.Button();
            this.btnP5 = new System.Windows.Forms.Button();
            this.btnP4 = new System.Windows.Forms.Button();
            this.btnP3 = new System.Windows.Forms.Button();
            this.btnP2 = new System.Windows.Forms.Button();
            this.btnP1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.mnuBar.SuspendLayout();
            this.panImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.statusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 917);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(748, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            // 
            // statusMessage
            // 
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(0, 16);
            // 
            // mnuBar
            // 
            this.mnuBar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mnuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeConnectionToolStripMenuItem});
            this.mnuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(748, 31);
            this.mnuBar.TabIndex = 5;
            this.mnuBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuBar_ItemClicked);
            // 
            // closeConnectionToolStripMenuItem
            // 
            this.closeConnectionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeConnectionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeConnectionToolStripMenuItem.Image = global::SafeHome360.Properties.Resources.icons8_close_64;
            this.closeConnectionToolStripMenuItem.Name = "closeConnectionToolStripMenuItem";
            this.closeConnectionToolStripMenuItem.Size = new System.Drawing.Size(181, 27);
            this.closeConnectionToolStripMenuItem.Text = "Close Connection";
            this.closeConnectionToolStripMenuItem.Click += new System.EventHandler(this.closeConnectionToolStripMenuItem_Click);
            // 
            // panImage
            // 
            this.panImage.BackgroundImage = global::SafeHome360.Properties.Resources.Katryne_web_2cc_20191;
            this.panImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panImage.Controls.Add(this.button1);
            this.panImage.Controls.Add(this.btnF6);
            this.panImage.Controls.Add(this.btnF5);
            this.panImage.Controls.Add(this.btnF4);
            this.panImage.Controls.Add(this.btnF3);
            this.panImage.Controls.Add(this.btnF2);
            this.panImage.Controls.Add(this.btnF1);
            this.panImage.Controls.Add(this.btnP5);
            this.panImage.Controls.Add(this.btnP4);
            this.panImage.Controls.Add(this.btnP3);
            this.panImage.Controls.Add(this.btnP2);
            this.panImage.Controls.Add(this.btnP1);
            this.panImage.Location = new System.Drawing.Point(37, 62);
            this.panImage.Name = "panImage";
            this.panImage.Size = new System.Drawing.Size(668, 717);
            this.panImage.TabIndex = 3;
            this.panImage.Click += new System.EventHandler(this.panImage_Click);
            this.panImage.Paint += new System.Windows.Forms.PaintEventHandler(this.panImage_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(497, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "P6";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnF6
            // 
            this.btnF6.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnF6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF6.Location = new System.Drawing.Point(606, 513);
            this.btnF6.Name = "btnF6";
            this.btnF6.Size = new System.Drawing.Size(44, 33);
            this.btnF6.TabIndex = 10;
            this.btnF6.Text = "F6";
            this.btnF6.UseVisualStyleBackColor = false;
            this.btnF6.Click += new System.EventHandler(this.btnF6_Click);
            // 
            // btnF5
            // 
            this.btnF5.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnF5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF5.Location = new System.Drawing.Point(64, 547);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(44, 33);
            this.btnF5.TabIndex = 9;
            this.btnF5.Text = "F5";
            this.btnF5.UseVisualStyleBackColor = false;
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // btnF4
            // 
            this.btnF4.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF4.Location = new System.Drawing.Point(221, 183);
            this.btnF4.Name = "btnF4";
            this.btnF4.Size = new System.Drawing.Size(44, 33);
            this.btnF4.TabIndex = 8;
            this.btnF4.Text = "F4";
            this.btnF4.UseVisualStyleBackColor = false;
            this.btnF4.Click += new System.EventHandler(this.btnF4_Click);
            // 
            // btnF3
            // 
            this.btnF3.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF3.Location = new System.Drawing.Point(12, 414);
            this.btnF3.Name = "btnF3";
            this.btnF3.Size = new System.Drawing.Size(44, 33);
            this.btnF3.TabIndex = 7;
            this.btnF3.Text = "F3";
            this.btnF3.UseVisualStyleBackColor = false;
            this.btnF3.Click += new System.EventHandler(this.btnF3_Click);
            // 
            // btnF2
            // 
            this.btnF2.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF2.Location = new System.Drawing.Point(368, 183);
            this.btnF2.Name = "btnF2";
            this.btnF2.Size = new System.Drawing.Size(44, 33);
            this.btnF2.TabIndex = 6;
            this.btnF2.Text = "F2";
            this.btnF2.UseVisualStyleBackColor = false;
            this.btnF2.Click += new System.EventHandler(this.btnF2_Click);
            // 
            // btnF1
            // 
            this.btnF1.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF1.Location = new System.Drawing.Point(322, 656);
            this.btnF1.Name = "btnF1";
            this.btnF1.Size = new System.Drawing.Size(44, 33);
            this.btnF1.TabIndex = 5;
            this.btnF1.Text = "F1";
            this.btnF1.UseVisualStyleBackColor = false;
            this.btnF1.Click += new System.EventHandler(this.btnF1_Click);
            // 
            // btnP5
            // 
            this.btnP5.BackColor = System.Drawing.Color.LightCyan;
            this.btnP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP5.Location = new System.Drawing.Point(102, 183);
            this.btnP5.Name = "btnP5";
            this.btnP5.Size = new System.Drawing.Size(44, 33);
            this.btnP5.TabIndex = 4;
            this.btnP5.Text = "P5";
            this.btnP5.UseVisualStyleBackColor = false;
            this.btnP5.Click += new System.EventHandler(this.btnP5_Click);
            // 
            // btnP4
            // 
            this.btnP4.BackColor = System.Drawing.Color.LightCyan;
            this.btnP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP4.Location = new System.Drawing.Point(244, 354);
            this.btnP4.Name = "btnP4";
            this.btnP4.Size = new System.Drawing.Size(44, 33);
            this.btnP4.TabIndex = 3;
            this.btnP4.Text = "P4";
            this.btnP4.UseVisualStyleBackColor = false;
            this.btnP4.Click += new System.EventHandler(this.btnP4_Click);
            // 
            // btnP3
            // 
            this.btnP3.BackColor = System.Drawing.Color.LightCyan;
            this.btnP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP3.Location = new System.Drawing.Point(322, 365);
            this.btnP3.Name = "btnP3";
            this.btnP3.Size = new System.Drawing.Size(44, 33);
            this.btnP3.TabIndex = 2;
            this.btnP3.Text = "P3";
            this.btnP3.UseVisualStyleBackColor = false;
            this.btnP3.Click += new System.EventHandler(this.btnP3_Click);
            // 
            // btnP2
            // 
            this.btnP2.BackColor = System.Drawing.Color.LightCyan;
            this.btnP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP2.Location = new System.Drawing.Point(284, 449);
            this.btnP2.Name = "btnP2";
            this.btnP2.Size = new System.Drawing.Size(44, 33);
            this.btnP2.TabIndex = 1;
            this.btnP2.Text = "P2";
            this.btnP2.UseVisualStyleBackColor = false;
            this.btnP2.Click += new System.EventHandler(this.btnP2_Click);
            // 
            // btnP1
            // 
            this.btnP1.BackColor = System.Drawing.Color.LightCyan;
            this.btnP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP1.Location = new System.Drawing.Point(174, 641);
            this.btnP1.Name = "btnP1";
            this.btnP1.Size = new System.Drawing.Size(44, 33);
            this.btnP1.TabIndex = 0;
            this.btnP1.Text = "P1";
            this.btnP1.UseVisualStyleBackColor = false;
            this.btnP1.Click += new System.EventHandler(this.btnP1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 939);
            this.Controls.Add(this.panImage);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuBar);
            this.MainMenuStrip = this.mnuBar;
            this.MaximumSize = new System.Drawing.Size(766, 986);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(766, 986);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafeHome360";
            this.Load += new System.EventHandler(this.main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mnuBar.ResumeLayout(false);
            this.mnuBar.PerformLayout();
            this.panImage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Panel panImage;
        private System.Windows.Forms.Button btnP1;
        private System.Windows.Forms.Button btnP5;
        private System.Windows.Forms.Button btnP4;
        private System.Windows.Forms.Button btnP3;
        private System.Windows.Forms.Button btnP2;
        private System.Windows.Forms.Button btnF6;
        private System.Windows.Forms.Button btnF5;
        private System.Windows.Forms.Button btnF4;
        private System.Windows.Forms.Button btnF3;
        private System.Windows.Forms.Button btnF2;
        private System.Windows.Forms.Button btnF1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip mnuBar;
        private System.Windows.Forms.ToolStripMenuItem closeConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusMessage;
    }
}

