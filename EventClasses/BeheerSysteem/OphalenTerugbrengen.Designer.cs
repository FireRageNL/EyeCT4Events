namespace BeheerSysteem
{
    partial class OphalenTerugbrengen
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeefUit = new System.Windows.Forms.Button();
            this.btnNeemTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(491, 160);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 312);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(491, 160);
            this.listBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nog op te halen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nog terug te brengen";
            // 
            // btnGeefUit
            // 
            this.btnGeefUit.Location = new System.Drawing.Point(21, 225);
            this.btnGeefUit.Name = "btnGeefUit";
            this.btnGeefUit.Size = new System.Drawing.Size(75, 23);
            this.btnGeefUit.TabIndex = 4;
            this.btnGeefUit.Text = "Uitgeven";
            this.btnGeefUit.UseVisualStyleBackColor = true;
            this.btnGeefUit.Click += new System.EventHandler(this.btnGeefUit_Click);
            // 
            // btnNeemTerug
            // 
            this.btnNeemTerug.Location = new System.Drawing.Point(21, 478);
            this.btnNeemTerug.Name = "btnNeemTerug";
            this.btnNeemTerug.Size = new System.Drawing.Size(75, 23);
            this.btnNeemTerug.TabIndex = 5;
            this.btnNeemTerug.Text = "Terugnemen";
            this.btnNeemTerug.UseVisualStyleBackColor = true;
            this.btnNeemTerug.Click += new System.EventHandler(this.btnNeemTerug_Click);
            // 
            // OphalenTerugbrengen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 581);
            this.Controls.Add(this.btnNeemTerug);
            this.Controls.Add(this.btnGeefUit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "OphalenTerugbrengen";
            this.Text = "OphalenTerugbrengen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGeefUit;
        private System.Windows.Forms.Button btnNeemTerug;
    }
}