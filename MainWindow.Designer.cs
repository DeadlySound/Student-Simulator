
using System.Windows.Forms;

namespace Student_Simulator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.DBC = new System.Windows.Forms.Button();
            this.NewGame_btn = new System.Windows.Forms.Button();
            this.Quit_btn = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuPanel.BackgroundImage")));
            this.MenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuPanel.Controls.Add(this.DBC);
            this.MenuPanel.Controls.Add(this.NewGame_btn);
            this.MenuPanel.Controls.Add(this.Quit_btn);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1001, 606);
            this.MenuPanel.TabIndex = 0;
            // 
            // DBC
            // 
            this.DBC.Location = new System.Drawing.Point(462, 336);
            this.DBC.Name = "DBC";
            this.DBC.Size = new System.Drawing.Size(75, 23);
            this.DBC.TabIndex = 2;
            this.DBC.Text = "DBC";
            this.DBC.UseVisualStyleBackColor = true;
            this.DBC.Click += new System.EventHandler(this.DBC_Click);
            // 
            // NewGame_btn
            // 
            this.NewGame_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewGame_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewGame_btn.Location = new System.Drawing.Point(411, 217);
            this.NewGame_btn.Name = "NewGame_btn";
            this.NewGame_btn.Size = new System.Drawing.Size(181, 46);
            this.NewGame_btn.TabIndex = 1;
            this.NewGame_btn.Text = "New Game";
            this.NewGame_btn.UseVisualStyleBackColor = true;
            this.NewGame_btn.Click += new System.EventHandler(this.NewGame_btn_Click);
            // 
            // Quit_btn
            // 
            this.Quit_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Quit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Quit_btn.Location = new System.Drawing.Point(411, 464);
            this.Quit_btn.Name = "Quit_btn";
            this.Quit_btn.Size = new System.Drawing.Size(181, 46);
            this.Quit_btn.TabIndex = 0;
            this.Quit_btn.Text = "Quit";
            this.Quit_btn.UseVisualStyleBackColor = true;
            this.Quit_btn.Click += new System.EventHandler(this.Quit_btn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 603);
            this.Controls.Add(this.MenuPanel);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Simulator";
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button Quit_btn;
        private Button NewGame_btn;
        private Button DBC;
    }
}

