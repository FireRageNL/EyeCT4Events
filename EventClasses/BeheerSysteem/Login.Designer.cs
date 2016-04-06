namespace BeheerSysteem
{
    partial class Login
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
            this.BtnInloggen = new System.Windows.Forms.Button();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbNaam = new System.Windows.Forms.TextBox();
            this.LbLEmail = new System.Windows.Forms.Label();
            this.LblWachtwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnInloggen
            // 
            this.BtnInloggen.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnInloggen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInloggen.Location = new System.Drawing.Point(343, 252);
            this.BtnInloggen.Name = "BtnInloggen";
            this.BtnInloggen.Size = new System.Drawing.Size(64, 23);
            this.BtnInloggen.TabIndex = 22;
            this.BtnInloggen.Text = "Inloggen";
            this.BtnInloggen.UseVisualStyleBackColor = true;
            // 
            // TbEmail
            // 
            this.TbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEmail.Location = new System.Drawing.Point(310, 224);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(139, 22);
            this.TbEmail.TabIndex = 20;
            // 
            // TbNaam
            // 
            this.TbNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNaam.Location = new System.Drawing.Point(310, 192);
            this.TbNaam.Name = "TbNaam";
            this.TbNaam.Size = new System.Drawing.Size(139, 22);
            this.TbNaam.TabIndex = 19;
            // 
            // LbLEmail
            // 
            this.LbLEmail.AutoSize = true;
            this.LbLEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLEmail.Location = new System.Drawing.Point(259, 195);
            this.LbLEmail.Name = "LbLEmail";
            this.LbLEmail.Size = new System.Drawing.Size(45, 16);
            this.LbLEmail.TabIndex = 17;
            this.LbLEmail.Text = "Email:";
            // 
            // LblWachtwoord
            // 
            this.LblWachtwoord.AutoSize = true;
            this.LblWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWachtwoord.Location = new System.Drawing.Point(218, 227);
            this.LblWachtwoord.Name = "LblWachtwoord";
            this.LblWachtwoord.Size = new System.Drawing.Size(86, 16);
            this.LblWachtwoord.TabIndex = 16;
            this.LblWachtwoord.Text = "Wachtwoord:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 559);
            this.Controls.Add(this.BtnInloggen);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.TbNaam);
            this.Controls.Add(this.LbLEmail);
            this.Controls.Add(this.LblWachtwoord);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInloggen;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbNaam;
        private System.Windows.Forms.Label LbLEmail;
        private System.Windows.Forms.Label LblWachtwoord;
    }
}