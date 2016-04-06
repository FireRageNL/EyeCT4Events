namespace Toegangscontrole
{
    partial class Toegangscontrole
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
            this.LblTitel = new System.Windows.Forms.Label();
            this.LblRFID = new System.Windows.Forms.Label();
            this.LbLstaticnaam = new System.Windows.Forms.Label();
            this.LblNaam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbRFID = new System.Windows.Forms.TextBox();
            this.ChkBetaald = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LblTitel
            // 
            this.LblTitel.AutoSize = true;
            this.LblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.LblTitel.Location = new System.Drawing.Point(76, 75);
            this.LblTitel.Name = "LblTitel";
            this.LblTitel.Size = new System.Drawing.Size(570, 91);
            this.LblTitel.TabIndex = 0;
            this.LblTitel.Text = "EyeCT4Events";
            // 
            // LblRFID
            // 
            this.LblRFID.AutoSize = true;
            this.LblRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRFID.Location = new System.Drawing.Point(272, 212);
            this.LblRFID.Name = "LblRFID";
            this.LblRFID.Size = new System.Drawing.Size(42, 16);
            this.LblRFID.TabIndex = 1;
            this.LblRFID.Text = "RFID:";
            // 
            // LbLstaticnaam
            // 
            this.LbLstaticnaam.AutoSize = true;
            this.LbLstaticnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLstaticnaam.Location = new System.Drawing.Point(266, 236);
            this.LbLstaticnaam.Name = "LbLstaticnaam";
            this.LbLstaticnaam.Size = new System.Drawing.Size(48, 16);
            this.LbLstaticnaam.TabIndex = 2;
            this.LbLstaticnaam.Text = "Naam:";
            // 
            // LblNaam
            // 
            this.LblNaam.AutoSize = true;
            this.LblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNaam.Location = new System.Drawing.Point(317, 236);
            this.LblNaam.Name = "LblNaam";
            this.LblNaam.Size = new System.Drawing.Size(45, 16);
            this.LblNaam.TabIndex = 3;
            this.LblNaam.Text = "Naam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Betaald:";
            // 
            // TbRFID
            // 
            this.TbRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbRFID.Location = new System.Drawing.Point(320, 211);
            this.TbRFID.Name = "TbRFID";
            this.TbRFID.Size = new System.Drawing.Size(100, 22);
            this.TbRFID.TabIndex = 5;
            // 
            // ChkBetaald
            // 
            this.ChkBetaald.AutoSize = true;
            this.ChkBetaald.Location = new System.Drawing.Point(320, 261);
            this.ChkBetaald.Name = "ChkBetaald";
            this.ChkBetaald.Size = new System.Drawing.Size(15, 14);
            this.ChkBetaald.TabIndex = 6;
            this.ChkBetaald.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 386);
            this.Controls.Add(this.ChkBetaald);
            this.Controls.Add(this.TbRFID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblNaam);
            this.Controls.Add(this.LbLstaticnaam);
            this.Controls.Add(this.LblRFID);
            this.Controls.Add(this.LblTitel);
            this.Name = "Form1";
            this.Text = "Toegangscontrole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitel;
        private System.Windows.Forms.Label LblRFID;
        private System.Windows.Forms.Label LbLstaticnaam;
        private System.Windows.Forms.Label LblNaam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbRFID;
        private System.Windows.Forms.CheckBox ChkBetaald;
    }
}

