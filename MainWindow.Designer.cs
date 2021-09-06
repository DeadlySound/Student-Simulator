
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
            this.Continue_btn = new System.Windows.Forms.Button();
            this.NewGame_btn = new System.Windows.Forms.Button();
            this.Quit_btn = new System.Windows.Forms.Button();
            this.Game_panel = new System.Windows.Forms.Panel();
            this.WorkOut_btn = new System.Windows.Forms.Button();
            this.GoSocialise_btn = new System.Windows.Forms.Button();
            this.StudyAtHome_btn = new System.Windows.Forms.Button();
            this.GoToUni_btn = new System.Windows.Forms.Button();
            this.EndTurn_btn = new System.Windows.Forms.Button();
            this.PlayerIndicator_UserControl = new Student_Simulator.PlayerIndicator();
            this.Menu_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SkillsetLevel_listbox = new System.Windows.Forms.ListBox();
            this.SkillsetName_listbox = new System.Windows.Forms.ListBox();
            this.Skillset_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.WeeklySchedule_label = new System.Windows.Forms.Label();
            this.CurrentTurn_label = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.Game_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.MenuPanel.Controls.Add(this.Continue_btn);
            this.MenuPanel.Controls.Add(this.NewGame_btn);
            this.MenuPanel.Controls.Add(this.Quit_btn);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(998, 603);
            this.MenuPanel.TabIndex = 0;
            // 
            // Continue_btn
            // 
            this.Continue_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Continue_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Continue_btn.Enabled = false;
            this.Continue_btn.Location = new System.Drawing.Point(410, 153);
            this.Continue_btn.Name = "Continue_btn";
            this.Continue_btn.Size = new System.Drawing.Size(181, 46);
            this.Continue_btn.TabIndex = 2;
            this.Continue_btn.Text = "Continue";
            this.Continue_btn.UseVisualStyleBackColor = true;
            this.Continue_btn.Click += new System.EventHandler(this.Continue_btn_Click);
            // 
            // NewGame_btn
            // 
            this.NewGame_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewGame_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewGame_btn.Location = new System.Drawing.Point(410, 259);
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
            this.Quit_btn.Location = new System.Drawing.Point(410, 461);
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
            this.Game_panel.BackColor = System.Drawing.Color.Gray;
            this.Game_panel.Controls.Add(this.MenuPanel);
            this.Game_panel.Controls.Add(this.WorkOut_btn);
            this.Game_panel.Controls.Add(this.GoSocialise_btn);
            this.Game_panel.Controls.Add(this.StudyAtHome_btn);
            this.Game_panel.Controls.Add(this.GoToUni_btn);
            this.Game_panel.Controls.Add(this.EndTurn_btn);
            this.Game_panel.Controls.Add(this.PlayerIndicator_UserControl);
            this.Game_panel.Controls.Add(this.Menu_btn);
            this.Game_panel.Controls.Add(this.panel1);
            this.Game_panel.Controls.Add(this.panel2);
            this.Game_panel.Controls.Add(this.CurrentTurn_label);
            this.Game_panel.Location = new System.Drawing.Point(0, 0);
            this.Game_panel.Name = "Game_panel";
            this.Game_panel.Size = new System.Drawing.Size(998, 603);
            this.Game_panel.TabIndex = 3;
            // 
            // WorkOut_btn
            // 
            this.WorkOut_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkOut_btn.Location = new System.Drawing.Point(592, 367);
            this.WorkOut_btn.Name = "WorkOut_btn";
            this.WorkOut_btn.Size = new System.Drawing.Size(182, 80);
            this.WorkOut_btn.TabIndex = 4;
            this.WorkOut_btn.Text = "Exercise";
            this.WorkOut_btn.UseVisualStyleBackColor = true;
            this.WorkOut_btn.Click += new System.EventHandler(this.WorkOut_btn_Click);
            // 
            // GoSocialise_btn
            // 
            this.GoSocialise_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GoSocialise_btn.Location = new System.Drawing.Point(224, 367);
            this.GoSocialise_btn.Name = "GoSocialise_btn";
            this.GoSocialise_btn.Size = new System.Drawing.Size(182, 80);
            this.GoSocialise_btn.TabIndex = 3;
            this.GoSocialise_btn.Text = "Go out with friends";
            this.GoSocialise_btn.UseVisualStyleBackColor = true;
            this.GoSocialise_btn.Click += new System.EventHandler(this.GoSocialise_btn_Click);
            // 
            // StudyAtHome_btn
            // 
            this.StudyAtHome_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StudyAtHome_btn.Location = new System.Drawing.Point(592, 156);
            this.StudyAtHome_btn.Name = "StudyAtHome_btn";
            this.StudyAtHome_btn.Size = new System.Drawing.Size(182, 80);
            this.StudyAtHome_btn.TabIndex = 2;
            this.StudyAtHome_btn.Text = "Study at home";
            this.StudyAtHome_btn.UseVisualStyleBackColor = true;
            this.StudyAtHome_btn.Click += new System.EventHandler(this.StudyAtHome_btn_Click);
            // 
            // GoToUni_btn
            // 
            this.GoToUni_btn.Location = new System.Drawing.Point(224, 156);
            this.GoToUni_btn.Name = "GoToUni_btn";
            this.GoToUni_btn.Size = new System.Drawing.Size(182, 80);
            this.GoToUni_btn.TabIndex = 1;
            this.GoToUni_btn.Text = "Go to university";
            this.GoToUni_btn.UseVisualStyleBackColor = true;
            this.GoToUni_btn.Click += new System.EventHandler(this.GoToUni_btn_Click);
            // 
            // EndTurn_btn
            // 
            this.EndTurn_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EndTurn_btn.Location = new System.Drawing.Point(701, 519);
            this.EndTurn_btn.Name = "EndTurn_btn";
            this.EndTurn_btn.Size = new System.Drawing.Size(82, 45);
            this.EndTurn_btn.TabIndex = 7;
            this.EndTurn_btn.Text = "End Turn";
            this.EndTurn_btn.UseMnemonic = false;
            this.EndTurn_btn.UseVisualStyleBackColor = true;
            this.EndTurn_btn.Click += new System.EventHandler(this.EndTurn_btn_Click);
            // 
            // PlayerIndicator_UserControl
            // 
            this.PlayerIndicator_UserControl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PlayerIndicator_UserControl.Location = new System.Drawing.Point(215, 519);
            this.PlayerIndicator_UserControl.MentalHealth = 0;
            this.PlayerIndicator_UserControl.Name = "PlayerIndicator_UserControl";
            this.PlayerIndicator_UserControl.PhysicalHealth = 0;
            this.PlayerIndicator_UserControl.Size = new System.Drawing.Size(480, 45);
            this.PlayerIndicator_UserControl.TabIndex = 5;
            this.PlayerIndicator_UserControl.Time = 0;
            // 
            // Menu_btn
            // 
            this.Menu_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu_btn.Location = new System.Drawing.Point(925, 12);
            this.Menu_btn.Name = "Menu_btn";
            this.Menu_btn.Size = new System.Drawing.Size(61, 32);
            this.Menu_btn.TabIndex = 6;
            this.Menu_btn.Text = "Menu";
            this.Menu_btn.UseMnemonic = false;
            this.Menu_btn.UseVisualStyleBackColor = true;
            this.Menu_btn.Click += new System.EventHandler(this.Menu_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Controls.Add(this.SkillsetLevel_listbox);
            this.panel1.Controls.Add(this.SkillsetName_listbox);
            this.panel1.Controls.Add(this.Skillset_label);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 579);
            this.panel1.TabIndex = 9;
            // 
            // SkillsetLevel_listbox
            // 
            this.SkillsetLevel_listbox.BackColor = System.Drawing.Color.Gray;
            this.SkillsetLevel_listbox.FormattingEnabled = true;
            this.SkillsetLevel_listbox.ItemHeight = 15;
            this.SkillsetLevel_listbox.Location = new System.Drawing.Point(170, 26);
            this.SkillsetLevel_listbox.Name = "SkillsetLevel_listbox";
            this.SkillsetLevel_listbox.Size = new System.Drawing.Size(27, 544);
            this.SkillsetLevel_listbox.TabIndex = 13;
            // 
            // SkillsetName_listbox
            // 
            this.SkillsetName_listbox.BackColor = System.Drawing.Color.Gray;
            this.SkillsetName_listbox.FormattingEnabled = true;
            this.SkillsetName_listbox.ItemHeight = 15;
            this.SkillsetName_listbox.Location = new System.Drawing.Point(3, 26);
            this.SkillsetName_listbox.Name = "SkillsetName_listbox";
            this.SkillsetName_listbox.Size = new System.Drawing.Size(170, 544);
            this.SkillsetName_listbox.TabIndex = 12;
            // 
            // Skillset_label
            // 
            this.Skillset_label.AutoSize = true;
            this.Skillset_label.Location = new System.Drawing.Point(80, 8);
            this.Skillset_label.Name = "Skillset_label";
            this.Skillset_label.Size = new System.Drawing.Size(36, 15);
            this.Skillset_label.TabIndex = 10;
            this.Skillset_label.Text = "Skills:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.WeeklySchedule_label);
            this.panel2.Location = new System.Drawing.Point(786, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 495);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "WeeklySchedule";
            // 
            // WeeklySchedule_label
            // 
            this.WeeklySchedule_label.AutoSize = true;
            this.WeeklySchedule_label.Location = new System.Drawing.Point(17, 35);
            this.WeeklySchedule_label.MinimumSize = new System.Drawing.Size(170, 450);
            this.WeeklySchedule_label.Name = "WeeklySchedule_label";
            this.WeeklySchedule_label.Size = new System.Drawing.Size(170, 450);
            this.WeeklySchedule_label.TabIndex = 0;
            // 
            // CurrentTurn_label
            // 
            this.CurrentTurn_label.Location = new System.Drawing.Point(392, 79);
            this.CurrentTurn_label.Name = "CurrentTurn_label";
            this.CurrentTurn_label.Size = new System.Drawing.Size(214, 40);
            this.CurrentTurn_label.TabIndex = 11;
            this.CurrentTurn_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button Quit_btn;
        private Button NewGame_btn;
        private Panel Game_panel;
        private Button WorkOut_btn;
        private Button GoSocialise_btn;
        private Button StudyAtHome_btn;
        private Button GoToUni_btn;
        private PlayerIndicator PlayerIndicator_UserControl;
        private Button EndTurn_btn;
        private Button Menu_btn;
        private Button Continue_btn;
        private Panel panel1;
        private ListBox SkillsetName_listbox;
        private Label Skillset_label;
        private ListBox SkillsetLevel_listbox;
        private Panel panel2;
        private Label WeeklySchedule_label;
        private Label label1;
        private Label CurrentTurn_label;
    }
}

