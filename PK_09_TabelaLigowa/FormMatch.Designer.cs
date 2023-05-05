namespace PK_09_TabelaLigowa
{
    partial class FormMatch
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
            this.listBoxTeamHost = new System.Windows.Forms.ListBox();
            this.listBoxTeamGuest = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownGoalHost = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGoalGuest = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoalHost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoalGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxTeamHost
            // 
            this.listBoxTeamHost.FormattingEnabled = true;
            this.listBoxTeamHost.Location = new System.Drawing.Point(12, 29);
            this.listBoxTeamHost.Name = "listBoxTeamHost";
            this.listBoxTeamHost.Size = new System.Drawing.Size(120, 95);
            this.listBoxTeamHost.TabIndex = 0;
            // 
            // listBoxTeamGuest
            // 
            this.listBoxTeamGuest.FormattingEnabled = true;
            this.listBoxTeamGuest.Location = new System.Drawing.Point(158, 29);
            this.listBoxTeamGuest.Name = "listBoxTeamGuest";
            this.listBoxTeamGuest.Size = new System.Drawing.Size(120, 95);
            this.listBoxTeamGuest.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gospodarz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gość";
            // 
            // numericUpDownGoalHost
            // 
            this.numericUpDownGoalHost.Location = new System.Drawing.Point(12, 130);
            this.numericUpDownGoalHost.Name = "numericUpDownGoalHost";
            this.numericUpDownGoalHost.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGoalHost.TabIndex = 4;
            // 
            // numericUpDownGoalGuest
            // 
            this.numericUpDownGoalGuest.Location = new System.Drawing.Point(158, 130);
            this.numericUpDownGoalGuest.Name = "numericUpDownGoalGuest";
            this.numericUpDownGoalGuest.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGoalGuest.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 157);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(266, 25);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 191);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownGoalGuest);
            this.Controls.Add(this.numericUpDownGoalHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTeamGuest);
            this.Controls.Add(this.listBoxTeamHost);
            this.Name = "FormMatch";
            this.Text = "FormMatch";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoalHost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoalGuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTeamHost;
        private System.Windows.Forms.ListBox listBoxTeamGuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownGoalHost;
        private System.Windows.Forms.NumericUpDown numericUpDownGoalGuest;
        private System.Windows.Forms.Button buttonSave;
    }
}