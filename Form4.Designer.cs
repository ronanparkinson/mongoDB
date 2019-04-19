namespace MongoPortfolio
{
    partial class Form4
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
            this.label5 = new System.Windows.Forms.Label();
            this.league = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numPlayers = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.teamText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(202, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 44);
            this.label5.TabIndex = 19;
            this.label5.Text = "Team league:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // league
            // 
            this.league.Location = new System.Drawing.Point(502, 356);
            this.league.Name = "league";
            this.league.Size = new System.Drawing.Size(309, 31);
            this.league.TabIndex = 18;
            this.league.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(202, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 44);
            this.label4.TabIndex = 17;
            this.label4.Text = "Num Players:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numPlayers
            // 
            this.numPlayers.Location = new System.Drawing.Point(502, 260);
            this.numPlayers.Name = "numPlayers";
            this.numPlayers.Size = new System.Drawing.Size(309, 31);
            this.numPlayers.TabIndex = 16;
            this.numPlayers.TextChanged += new System.EventHandler(this.numPlayers_TextChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(559, 482);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(131, 51);
            this.submit.TabIndex = 15;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(202, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 44);
            this.label3.TabIndex = 14;
            this.label3.Text = "Team Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // teamText
            // 
            this.teamText.Location = new System.Drawing.Point(502, 171);
            this.teamText.Name = "teamText";
            this.teamText.Size = new System.Drawing.Size(309, 31);
            this.teamText.TabIndex = 13;
            this.teamText.TextChanged += new System.EventHandler(this.teamText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(495, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Update Item";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 575);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.league);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPlayers);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teamText);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox league;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numPlayers;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teamText;
        private System.Windows.Forms.Label label1;
    }
}