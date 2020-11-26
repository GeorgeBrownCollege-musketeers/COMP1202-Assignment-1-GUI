namespace COMP1202_Assignment_1_GUI
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomerOptions = new System.Windows.Forms.Button();
            this.btnEventOptions = new System.Windows.Forms.Button();
            this.btnRSVP = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(212, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnCustomerOptions
            // 
            this.btnCustomerOptions.Location = new System.Drawing.Point(47, 45);
            this.btnCustomerOptions.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerOptions.Name = "btnCustomerOptions";
            this.btnCustomerOptions.Size = new System.Drawing.Size(113, 21);
            this.btnCustomerOptions.TabIndex = 1;
            this.btnCustomerOptions.Text = "Customer Options";
            this.btnCustomerOptions.UseVisualStyleBackColor = true;
            this.btnCustomerOptions.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEventOptions
            // 
            this.btnEventOptions.Location = new System.Drawing.Point(47, 82);
            this.btnEventOptions.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventOptions.Name = "btnEventOptions";
            this.btnEventOptions.Size = new System.Drawing.Size(113, 21);
            this.btnEventOptions.TabIndex = 2;
            this.btnEventOptions.Text = "Event Options";
            this.btnEventOptions.UseVisualStyleBackColor = true;
            this.btnEventOptions.Click += new System.EventHandler(this.btnEventOptions_Click);
            // 
            // btnRSVP
            // 
            this.btnRSVP.Location = new System.Drawing.Point(47, 120);
            this.btnRSVP.Margin = new System.Windows.Forms.Padding(2);
            this.btnRSVP.Name = "btnRSVP";
            this.btnRSVP.Size = new System.Drawing.Size(113, 21);
            this.btnRSVP.TabIndex = 3;
            this.btnRSVP.Text = "RSVP For Event";
            this.btnRSVP.UseVisualStyleBackColor = true;
            this.btnRSVP.Click += new System.EventHandler(this.btnRSVP_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(47, 160);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 21);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 223);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRSVP);
            this.Controls.Add(this.btnEventOptions);
            this.Controls.Add(this.btnCustomerOptions);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnCustomerOptions;
        private System.Windows.Forms.Button btnEventOptions;
        private System.Windows.Forms.Button btnRSVP;
        private System.Windows.Forms.Button btnExit;
    }
}

