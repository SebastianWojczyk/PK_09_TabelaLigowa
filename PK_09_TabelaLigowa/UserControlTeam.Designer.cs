namespace PK_09_TabelaLigowa
{
    partial class UserControlTeam
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelGoalsScored = new System.Windows.Forms.Label();
            this.labelGoalsLost = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(23, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nazwa drużny";
            // 
            // labelGoalsScored
            // 
            this.labelGoalsScored.AutoSize = true;
            this.labelGoalsScored.Location = new System.Drawing.Point(304, 0);
            this.labelGoalsScored.Name = "labelGoalsScored";
            this.labelGoalsScored.Size = new System.Drawing.Size(79, 13);
            this.labelGoalsScored.TabIndex = 1;
            this.labelGoalsScored.Text = "Bramki zdobyte";
            // 
            // labelGoalsLost
            // 
            this.labelGoalsLost.AutoSize = true;
            this.labelGoalsLost.Location = new System.Drawing.Point(389, 0);
            this.labelGoalsLost.Name = "labelGoalsLost";
            this.labelGoalsLost.Size = new System.Drawing.Size(83, 13);
            this.labelGoalsLost.TabIndex = 2;
            this.labelGoalsLost.Text = "Bramki stracone";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(258, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(40, 13);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "Punkty";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(3, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(18, 13);
            this.labelNumber.TabIndex = 4;
            this.labelNumber.Text = "Nr";
            // 
            // UserControlTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelGoalsLost);
            this.Controls.Add(this.labelGoalsScored);
            this.Controls.Add(this.labelName);
            this.Name = "UserControlTeam";
            this.Size = new System.Drawing.Size(477, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGoalsScored;
        private System.Windows.Forms.Label labelGoalsLost;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelNumber;
    }
}
