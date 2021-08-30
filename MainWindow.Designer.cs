
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
            this.Game_panel = new System.Windows.Forms.Panel();
            this.PlayerIndicator_UserControl = new Student_Simulator.PlayerIndicator();
            this.MenuPanel.SuspendLayout();
            this.Game_panel.SuspendLayout();
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
            this.MenuPanel.Size = new System.Drawing.Size(998, 606);
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
            this.NewGame_btn.Location = new System.Drawing.Point(410, 217);
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
            this.Quit_btn.Location = new System.Drawing.Point(410, 464);
            this.Quit_btn.Name = "Quit_btn";
            this.Quit_btn.Size = new System.Drawing.Size(181, 46);
            this.Quit_btn.TabIndex = 0;
            this.Quit_btn.Text = "Quit";
            this.Quit_btn.UseVisualStyleBackColor = true;
            this.Quit_btn.Click += new System.EventHandler(this.Quit_btn_Click);
            // 
            // Game_panel
            // 
            this.Game_panel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Game_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Game_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Game_panel.Controls.Add(this.MenuPanel);
            this.Game_panel.Controls.Add(this.PlayerIndicator_UserControl);
            this.Game_panel.Location = new System.Drawing.Point(0, 0);
            this.Game_panel.Name = "Game_panel";
            this.Game_panel.Size = new System.Drawing.Size(998, 603);
            this.Game_panel.TabIndex = 3;
            // 
            // PlayerIndicator_UserControl
            // 
            this.PlayerIndicator_UserControl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PlayerIndicator_UserControl.Location = new System.Drawing.Point(217, 546);
            this.PlayerIndicator_UserControl.Name = "PlayerIndicator_UserControl";
            this.PlayerIndicator_UserControl.Size = new System.Drawing.Size(564, 45);
            this.PlayerIndicator_UserControl.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 603);
            this.Controls.Add(this.Game_panel);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Simulator";
            this.MenuPanel.ResumeLayout(false);
            this.Game_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button Quit_btn;
        private Button NewGame_btn;
        private Button DBC;
        private Panel Game_panel;
        private PlayerIndicator PlayerIndicator_UserControl;
    }
}

