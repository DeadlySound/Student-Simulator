
namespace Student_Simulator
{
    partial class PlayerIndicator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PhysicalHealth_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.MentalHealth_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Time_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PhysicalHealth_label = new System.Windows.Forms.Label();
            this.MentalHealth_label = new System.Windows.Forms.Label();
            this.Time_label = new System.Windows.Forms.Label();
            this.EndTurn_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PhysicalHealth_ProgressBar
            // 
            this.PhysicalHealth_ProgressBar.Location = new System.Drawing.Point(14, 23);
            this.PhysicalHealth_ProgressBar.Name = "PhysicalHealth_ProgressBar";
            this.PhysicalHealth_ProgressBar.Size = new System.Drawing.Size(131, 13);
            this.PhysicalHealth_ProgressBar.TabIndex = 0;
            // 
            // MentalHealth_ProgressBar
            // 
            this.MentalHealth_ProgressBar.Location = new System.Drawing.Point(178, 23);
            this.MentalHealth_ProgressBar.Name = "MentalHealth_ProgressBar";
            this.MentalHealth_ProgressBar.Size = new System.Drawing.Size(131, 13);
            this.MentalHealth_ProgressBar.TabIndex = 1;
            // 
            // Time_ProgressBar
            // 
            this.Time_ProgressBar.Location = new System.Drawing.Point(342, 23);
            this.Time_ProgressBar.Name = "Time_ProgressBar";
            this.Time_ProgressBar.Size = new System.Drawing.Size(131, 13);
            this.Time_ProgressBar.TabIndex = 2;
            // 
            // PhysicalHealth_label
            // 
            this.PhysicalHealth_label.AutoSize = true;
            this.PhysicalHealth_label.Location = new System.Drawing.Point(14, 5);
            this.PhysicalHealth_label.Name = "PhysicalHealth_label";
            this.PhysicalHealth_label.Size = new System.Drawing.Size(85, 15);
            this.PhysicalHealth_label.TabIndex = 3;
            this.PhysicalHealth_label.Text = "PhysicalHealth";
            // 
            // MentalHealth_label
            // 
            this.MentalHealth_label.AutoSize = true;
            this.MentalHealth_label.Location = new System.Drawing.Point(178, 5);
            this.MentalHealth_label.Name = "MentalHealth_label";
            this.MentalHealth_label.Size = new System.Drawing.Size(79, 15);
            this.MentalHealth_label.TabIndex = 4;
            this.MentalHealth_label.Text = "MentalHealth";
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Location = new System.Drawing.Point(342, 5);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(33, 15);
            this.Time_label.TabIndex = 5;
            this.Time_label.Text = "Time";
            // 
            // EndTurn_button
            // 
            this.EndTurn_button.Location = new System.Drawing.Point(479, 5);
            this.EndTurn_button.Name = "EndTurn_button";
            this.EndTurn_button.Size = new System.Drawing.Size(75, 37);
            this.EndTurn_button.TabIndex = 7;
            this.EndTurn_button.Text = "End Turn";
            this.EndTurn_button.UseVisualStyleBackColor = true;
            this.EndTurn_button.Click += new System.EventHandler(this.EndTurn_button_Click);
            // 
            // PlayerIndicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EndTurn_button);
            this.Controls.Add(this.Time_label);
            this.Controls.Add(this.MentalHealth_label);
            this.Controls.Add(this.PhysicalHealth_label);
            this.Controls.Add(this.Time_ProgressBar);
            this.Controls.Add(this.MentalHealth_ProgressBar);
            this.Controls.Add(this.PhysicalHealth_ProgressBar);
            this.Name = "PlayerIndicator";
            this.Size = new System.Drawing.Size(564, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar PhysicalHealth_ProgressBar;
        private System.Windows.Forms.ProgressBar MentalHealth_ProgressBar;
        private System.Windows.Forms.ProgressBar Time_ProgressBar;
        private System.Windows.Forms.Label PhysicalHealth_label;
        private System.Windows.Forms.Label MentalHealth_label;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.Button EndTurn_button;
    }
}
