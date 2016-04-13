namespace BeheerSysteem
{
    partial class FormGebruikersBeheer
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
            this.TbNaam = new System.Windows.Forms.TextBox();
            this.LblRFID = new System.Windows.Forms.Label();
            this.LbLEmail = new System.Windows.Forms.Label();
            this.LblNaam = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbRFID = new System.Windows.Forms.TextBox();
            this.BtnZoeken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbNaam
            // 
            this.TbNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNaam.Location = new System.Drawing.Point(246, 40);
            this.TbNaam.Name = "TbNaam";
            this.TbNaam.Size = new System.Drawing.Size(139, 22);
            this.TbNaam.TabIndex = 11;
            // 
            // LblRFID
            // 
            this.LblRFID.AutoSize = true;
            this.LblRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRFID.Location = new System.Drawing.Point(198, 105);
            this.LblRFID.Name = "LblRFID";
            this.LblRFID.Size = new System.Drawing.Size(42, 16);
            this.LblRFID.TabIndex = 10;
            this.LblRFID.Text = "RFID:";
            // 
            // LbLEmail
            // 
            this.LbLEmail.AutoSize = true;
            this.LbLEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLEmail.Location = new System.Drawing.Point(195, 75);
            this.LbLEmail.Name = "LbLEmail";
            this.LbLEmail.Size = new System.Drawing.Size(45, 16);
            this.LbLEmail.TabIndex = 8;
            this.LbLEmail.Text = "Email:";
            // 
            // LblNaam
            // 
            this.LblNaam.AutoSize = true;
            this.LblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNaam.Location = new System.Drawing.Point(192, 43);
            this.LblNaam.Name = "LblNaam";
            this.LblNaam.Size = new System.Drawing.Size(48, 16);
            this.LblNaam.TabIndex = 7;
            this.LblNaam.Text = "Naam:";
            // 
            // TbEmail
            // 
            this.TbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEmail.Location = new System.Drawing.Point(246, 72);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(139, 22);
            this.TbEmail.TabIndex = 12;
            // 
            // TbRFID
            // 
            this.TbRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbRFID.Location = new System.Drawing.Point(246, 102);
            this.TbRFID.Name = "TbRFID";
            this.TbRFID.Size = new System.Drawing.Size(139, 22);
            this.TbRFID.TabIndex = 13;
            // 
            // BtnZoeken
            // 
            this.BtnZoeken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZoeken.Location = new System.Drawing.Point(246, 141);
            this.BtnZoeken.Name = "BtnZoeken";
            this.BtnZoeken.Size = new System.Drawing.Size(64, 23);
            this.BtnZoeken.TabIndex = 14;
            this.BtnZoeken.Text = "Zoeken";
            this.BtnZoeken.UseVisualStyleBackColor = true;
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWissen.Location = new System.Drawing.Point(321, 141);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(64, 23);
            this.BtnWissen.TabIndex = 15;
            this.BtnWissen.Text = "Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 329);
            this.dataGridView1.TabIndex = 25;
            // 
            // FormGebruikersBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 533);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnZoeken);
            this.Controls.Add(this.TbRFID);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.TbNaam);
            this.Controls.Add(this.LblRFID);
            this.Controls.Add(this.LbLEmail);
            this.Controls.Add(this.LblNaam);
            this.Name = "FormGebruikersBeheer";
            this.Text = "Gebruikers beheer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbNaam;
        private System.Windows.Forms.Label LblRFID;
        private System.Windows.Forms.Label LbLEmail;
        private System.Windows.Forms.Label LblNaam;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbRFID;
        private System.Windows.Forms.Button BtnZoeken;
        private System.Windows.Forms.Button BtnWissen;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

