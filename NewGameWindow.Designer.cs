
namespace Student_Simulator
{
    partial class NewGameWindow
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
            this.components = new System.ComponentModel.Container();
            this.NicknameInput_textBox = new System.Windows.Forms.TextBox();
            this.EnterNickname_label = new System.Windows.Forms.Label();
            this.Start_button = new System.Windows.Forms.Button();
            this.Textbox_ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Select_label = new System.Windows.Forms.Label();
            this.FieldOfStudy_checkbox = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Textbox_ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NicknameInput_textBox
            // 
            this.NicknameInput_textBox.Location = new System.Drawing.Point(33, 33);
            this.NicknameInput_textBox.Name = "NicknameInput_textBox";
            this.NicknameInput_textBox.Size = new System.Drawing.Size(279, 23);
            this.NicknameInput_textBox.TabIndex = 0;
            // 
            // EnterNickname_label
            // 
            this.EnterNickname_label.AutoSize = true;
            this.EnterNickname_label.Location = new System.Drawing.Point(108, 15);
            this.EnterNickname_label.Name = "EnterNickname_label";
            this.EnterNickname_label.Size = new System.Drawing.Size(116, 15);
            this.EnterNickname_label.TabIndex = 1;
            this.EnterNickname_label.Text = "Enter your nickname";
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(134, 121);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(75, 23);
            this.Start_button.TabIndex = 2;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Textbox_ErrorProvider
            // 
            this.Textbox_ErrorProvider.ContainerControl = this;
            // 
            // Select_label
            // 
            this.Select_label.AutoSize = true;
            this.Select_label.Location = new System.Drawing.Point(118, 69);
            this.Select_label.Name = "Select_label";
            this.Select_label.Size = new System.Drawing.Size(115, 15);
            this.Select_label.TabIndex = 5;
            this.Select_label.Text = "Select Field of study:";
            // 
            // FieldOfStudy_checkbox
            // 
            this.FieldOfStudy_checkbox.AutoSize = true;
            this.FieldOfStudy_checkbox.Checked = true;
            this.FieldOfStudy_checkbox.Location = new System.Drawing.Point(111, 96);
            this.FieldOfStudy_checkbox.Name = "FieldOfStudy_checkbox";
            this.FieldOfStudy_checkbox.Size = new System.Drawing.Size(122, 19);
            this.FieldOfStudy_checkbox.TabIndex = 4;
            this.FieldOfStudy_checkbox.TabStop = true;
            this.FieldOfStudy_checkbox.Text = "Computer Science";
            this.FieldOfStudy_checkbox.UseVisualStyleBackColor = true;
            // 
            // NewGameWindow
            // 
            this.AcceptButton = this.Start_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 150);
            this.Controls.Add(this.Select_label);
            this.Controls.Add(this.FieldOfStudy_checkbox);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.EnterNickname_label);
            this.Controls.Add(this.NicknameInput_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "NewGameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Game";
            this.FormClosing += OnClosing;
            ((System.ComponentModel.ISupportInitialize)(this.Textbox_ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox NicknameInput_textBox;
        private System.Windows.Forms.Label EnterNickname_label;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.ErrorProvider Textbox_ErrorProvider;
        private System.Windows.Forms.Label Select_label;
        private System.Windows.Forms.RadioButton FieldOfStudy_checkbox;
    }
}