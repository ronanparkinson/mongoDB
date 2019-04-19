namespace MongoPortfolio
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.TeamName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.leaguetext = new System.Windows.Forms.TextBox();
            this.numplayerstext = new System.Windows.Forms.TextBox();
            this.teamnametext = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(431, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Team";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TeamName.Location = new System.Drawing.Point(76, 210);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(270, 51);
            this.TeamName.TabIndex = 1;
            this.TeamName.Text = "Team Name:";
            this.TeamName.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(76, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Num Players:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(76, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 51);
            this.label4.TabIndex = 3;
            this.label4.Text = "League:";
            // 
            // leaguetext
            // 
            this.leaguetext.Location = new System.Drawing.Point(479, 466);
            this.leaguetext.Name = "leaguetext";
            this.leaguetext.Size = new System.Drawing.Size(276, 31);
            this.leaguetext.TabIndex = 5;
            // 
            // numplayerstext
            // 
            this.numplayerstext.Location = new System.Drawing.Point(479, 328);
            this.numplayerstext.Name = "numplayerstext";
            this.numplayerstext.Size = new System.Drawing.Size(276, 31);
            this.numplayerstext.TabIndex = 6;
            // 
            // teamnametext
            // 
            this.teamnametext.Location = new System.Drawing.Point(479, 228);
            this.teamnametext.Name = "teamnametext";
            this.teamnametext.Size = new System.Drawing.Size(276, 31);
            this.teamnametext.TabIndex = 7;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(498, 551);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(153, 73);
            this.addbutton.TabIndex = 9;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 670);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.teamnametext);
            this.Controls.Add(this.numplayerstext);
            this.Controls.Add(this.leaguetext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox leaguetext;
        private System.Windows.Forms.TextBox numplayerstext;
        private System.Windows.Forms.TextBox teamnametext;
        private System.Windows.Forms.Button addbutton;
    }
}