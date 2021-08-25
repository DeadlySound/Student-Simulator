
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
            this.label1 = new System.Windows.Forms.Label();
            this.Start_button = new System.Windows.Forms.Button();
            this.NoEmptyNickname_ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NoEmptyNickname_ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NicknameInput_textBox
            // 
            this.NicknameInput_textBox.Location = new System.Drawing.Point(33, 33);
            this.NicknameInput_textBox.Name = "NicknameInput_textBox";
            this.NicknameInput_textBox.Size = new System.Drawing.Size(279, 23);
            this.NicknameInput_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your nickname";
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(129, 64);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(75, 23);
            this.Start_button.TabIndex = 2;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // NoEmptyNickname_ErrorProvider
            // 
            this.NoEmptyNickname_ErrorProvider.ContainerControl = this;
            // 
            // NewGameWindow
            // 
            this.AcceptButton = this.Start_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 99);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NicknameInput_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "NewGameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NewGameWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NoEmptyNickname_ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NicknameInput_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.ErrorProvider NoEmptyNickname_ErrorProvider;
    }
}