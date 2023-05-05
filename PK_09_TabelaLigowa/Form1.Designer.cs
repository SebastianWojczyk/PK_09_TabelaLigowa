namespace PK_09_TabelaLigowa
{
    partial class Form1
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
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonAddMatch = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Location = new System.Drawing.Point(12, 12);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(113, 23);
            this.buttonAddTeam.TabIndex = 0;
            this.buttonAddTeam.Text = "Dodaj drużynę";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // buttonAddMatch
            // 
            this.buttonAddMatch.Location = new System.Drawing.Point(131, 12);
            this.buttonAddMatch.Name = "buttonAddMatch";
            this.buttonAddMatch.Size = new System.Drawing.Size(113, 23);
            this.buttonAddMatch.TabIndex = 1;
            this.buttonAddMatch.Text = "Dodaj mecz";
            this.buttonAddMatch.UseVisualStyleBackColor = true;
            this.buttonAddMatch.Click += new System.EventHandler(this.buttonAddMatch_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(13, 42);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(853, 506);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 560);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.buttonAddMatch);
            this.Controls.Add(this.buttonAddTeam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonAddMatch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}

