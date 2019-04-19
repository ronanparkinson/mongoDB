namespace MongoPortfolio
{
    partial class Form3
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teamText = new System.Windows.Forms.TextBox();
            this.numPlayers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.teamId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(368, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Read Item";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(376, 422);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(309, 31);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(76, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Team Id:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(76, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "Team Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // teamText
            // 
            this.teamText.Location = new System.Drawing.Point(376, 237);
            this.teamText.Name = "teamText";
            this.teamText.Size = new System.Drawing.Size(309, 31);
            this.teamText.TabIndex = 3;
            this.teamText.TextChanged += new System.EventHandler(this.teamText_TextChanged);
            // 
            // numPlayers
            // 
            this.numPlayers.Location = new System.Drawing.Point(376, 326);
            this.numPlayers.Name = "numPlayers";
            this.numPlayers.Size = new System.Drawing.Size(309, 31);
            this.numPlayers.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(76, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 44);
            this.label4.TabIndex = 7;
            this.label4.Text = "Num Players:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(76, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 44);
            this.label5.TabIndex = 9;
            this.label5.Text = "Team league:";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(432, 490);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(131, 51);
            this.submit.TabIndex = 5;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // teamId
            // 
            this.teamId.Location = new System.Drawing.Point(376, 125);
            this.teamId.Name = "teamId";
            this.teamId.Size = new System.Drawing.Size(309, 31);
            this.teamId.TabIndex = 1;
            this.teamId.TextChanged += new System.EventHandler(this.teamId_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 600);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPlayers);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teamText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teamId);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teamText;
        private System.Windows.Forms.TextBox numPlayers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox teamId;
    }
}