namespace BeheerSysteem
{
    partial class Materiaalbeheer
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
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnZoeken = new System.Windows.Forms.Button();
            this.TbType = new System.Windows.Forms.TextBox();
            this.TbMerk = new System.Windows.Forms.TextBox();
            this.TbProductnaam = new System.Windows.Forms.TextBox();
            this.LblType = new System.Windows.Forms.Label();
            this.LblMerk = new System.Windows.Forms.Label();
            this.LblProductnaam = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWissen.Location = new System.Drawing.Point(374, 136);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(64, 23);
            this.BtnWissen.TabIndex = 23;
            this.BtnWissen.Text = "Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnZoeken
            // 
            this.BtnZoeken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZoeken.Location = new System.Drawing.Point(299, 136);
            this.BtnZoeken.Name = "BtnZoeken";
            this.BtnZoeken.Size = new System.Drawing.Size(64, 23);
            this.BtnZoeken.TabIndex = 22;
            this.BtnZoeken.Text = "Zoeken";
            this.BtnZoeken.UseVisualStyleBackColor = true;
            this.BtnZoeken.Click += new System.EventHandler(this.BtnZoeken_Click);
            // 
            // TbType
            // 
            this.TbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbType.Location = new System.Drawing.Point(299, 97);
            this.TbType.Name = "TbType";
            this.TbType.Size = new System.Drawing.Size(139, 22);
            this.TbType.TabIndex = 21;
            // 
            // TbMerk
            // 
            this.TbMerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMerk.Location = new System.Drawing.Point(299, 67);
            this.TbMerk.Name = "TbMerk";
            this.TbMerk.Size = new System.Drawing.Size(139, 22);
            this.TbMerk.TabIndex = 20;
            // 
            // TbProductnaam
            // 
            this.TbProductnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbProductnaam.Location = new System.Drawing.Point(299, 35);
            this.TbProductnaam.Name = "TbProductnaam";
            this.TbProductnaam.Size = new System.Drawing.Size(139, 22);
            this.TbProductnaam.TabIndex = 19;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.Location = new System.Drawing.Point(250, 100);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(43, 16);
            this.LblType.TabIndex = 18;
            this.LblType.Text = "Type:";
            // 
            // LblMerk
            // 
            this.LblMerk.AutoSize = true;
            this.LblMerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMerk.Location = new System.Drawing.Point(252, 70);
            this.LblMerk.Name = "LblMerk";
            this.LblMerk.Size = new System.Drawing.Size(41, 16);
            this.LblMerk.TabIndex = 17;
            this.LblMerk.Text = "Merk:";
            // 
            // LblProductnaam
            // 
            this.LblProductnaam.AutoSize = true;
            this.LblProductnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductnaam.Location = new System.Drawing.Point(202, 38);
            this.LblProductnaam.Name = "LblProductnaam";
            this.LblProductnaam.Size = new System.Drawing.Size(91, 16);
            this.LblProductnaam.TabIndex = 16;
            this.LblProductnaam.Text = "Productnaam:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 329);
            this.dataGridView1.TabIndex = 24;
            // 
            // Materiaalbeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 538);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnZoeken);
            this.Controls.Add(this.TbType);
            this.Controls.Add(this.TbMerk);
            this.Controls.Add(this.TbProductnaam);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.LblMerk);
            this.Controls.Add(this.LblProductnaam);
            this.Name = "Materiaalbeheer";
            this.Text = "Materiaalbeheer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnWissen;
        private System.Windows.Forms.Button BtnZoeken;
        private System.Windows.Forms.TextBox TbType;
        private System.Windows.Forms.TextBox TbMerk;
        private System.Windows.Forms.TextBox TbProductnaam;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblMerk;
        private System.Windows.Forms.Label LblProductnaam;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}