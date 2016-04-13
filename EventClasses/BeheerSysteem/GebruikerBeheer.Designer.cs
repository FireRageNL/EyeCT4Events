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
            this.TbAchternaam = new System.Windows.Forms.TextBox();
            this.LblRFID = new System.Windows.Forms.Label();
            this.LbLEmail = new System.Windows.Forms.Label();
            this.LblAchternaam = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbDatum = new System.Windows.Forms.TextBox();
            this.BtnZoeken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBeheer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbAchternaam
            // 
            this.TbAchternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAchternaam.Location = new System.Drawing.Point(246, 40);
            this.TbAchternaam.Name = "TbAchternaam";
            this.TbAchternaam.Size = new System.Drawing.Size(139, 22);
            this.TbAchternaam.TabIndex = 11;
            // 
            // LblRFID
            // 
            this.LblRFID.AutoSize = true;
            this.LblRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRFID.Location = new System.Drawing.Point(135, 105);
            this.LblRFID.Name = "LblRFID";
            this.LblRFID.Size = new System.Drawing.Size(105, 16);
            this.LblRFID.TabIndex = 10;
            this.LblRFID.Text = "Geboortedatum:";
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
            // LblAchternaam
            // 
            this.LblAchternaam.AutoSize = true;
            this.LblAchternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAchternaam.Location = new System.Drawing.Point(157, 43);
            this.LblAchternaam.Name = "LblAchternaam";
            this.LblAchternaam.Size = new System.Drawing.Size(83, 16);
            this.LblAchternaam.TabIndex = 7;
            this.LblAchternaam.Text = "Achternaam:";
            // 
            // TbEmail
            // 
            this.TbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEmail.Location = new System.Drawing.Point(246, 72);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(139, 22);
            this.TbEmail.TabIndex = 12;
            // 
            // TbDatum
            // 
            this.TbDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDatum.Location = new System.Drawing.Point(246, 102);
            this.TbDatum.Name = "TbDatum";
            this.TbDatum.Size = new System.Drawing.Size(139, 22);
            this.TbDatum.TabIndex = 13;
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
            this.BtnZoeken.Click += new System.EventHandler(this.BtnZoeken_Click);
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
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 329);
            this.dataGridView1.TabIndex = 25;
            // 
            // BtnBeheer
            // 
            this.BtnBeheer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBeheer.Location = new System.Drawing.Point(481, 57);
            this.BtnBeheer.Name = "BtnBeheer";
            this.BtnBeheer.Size = new System.Drawing.Size(78, 53);
            this.BtnBeheer.TabIndex = 26;
            this.BtnBeheer.Text = "Beheer";
            this.BtnBeheer.UseVisualStyleBackColor = true;
            this.BtnBeheer.Click += new System.EventHandler(this.BtnBeheer_Click);
            // 
            // FormGebruikersBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 533);
            this.Controls.Add(this.BtnBeheer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnZoeken);
            this.Controls.Add(this.TbDatum);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.TbAchternaam);
            this.Controls.Add(this.LblRFID);
            this.Controls.Add(this.LbLEmail);
            this.Controls.Add(this.LblAchternaam);
            this.Name = "FormGebruikersBeheer";
            this.Text = "Gebruikers beheer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbAchternaam;
        private System.Windows.Forms.Label LblRFID;
        private System.Windows.Forms.Label LbLEmail;
        private System.Windows.Forms.Label LblAchternaam;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbDatum;
        private System.Windows.Forms.Button BtnZoeken;
        private System.Windows.Forms.Button BtnWissen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnBeheer;
    }
}

