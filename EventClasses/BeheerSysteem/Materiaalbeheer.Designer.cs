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
            this.SuspendLayout();
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWissen.Location = new System.Drawing.Point(375, 271);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(64, 23);
            this.BtnWissen.TabIndex = 23;
            this.BtnWissen.Text = "Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            // 
            // BtnZoeken
            // 
            this.BtnZoeken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZoeken.Location = new System.Drawing.Point(300, 271);
            this.BtnZoeken.Name = "BtnZoeken";
            this.BtnZoeken.Size = new System.Drawing.Size(64, 23);
            this.BtnZoeken.TabIndex = 22;
            this.BtnZoeken.Text = "Zoeken";
            this.BtnZoeken.UseVisualStyleBackColor = true;
            // 
            // TbType
            // 
            this.TbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbType.Location = new System.Drawing.Point(300, 232);
            this.TbType.Name = "TbType";
            this.TbType.Size = new System.Drawing.Size(139, 22);
            this.TbType.TabIndex = 21;
            // 
            // TbMerk
            // 
            this.TbMerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMerk.Location = new System.Drawing.Point(300, 202);
            this.TbMerk.Name = "TbMerk";
            this.TbMerk.Size = new System.Drawing.Size(139, 22);
            this.TbMerk.TabIndex = 20;
            // 
            // TbProductnaam
            // 
            this.TbProductnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbProductnaam.Location = new System.Drawing.Point(300, 170);
            this.TbProductnaam.Name = "TbProductnaam";
            this.TbProductnaam.Size = new System.Drawing.Size(139, 22);
            this.TbProductnaam.TabIndex = 19;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.Location = new System.Drawing.Point(251, 235);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(43, 16);
            this.LblType.TabIndex = 18;
            this.LblType.Text = "Type:";
            // 
            // LblMerk
            // 
            this.LblMerk.AutoSize = true;
            this.LblMerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMerk.Location = new System.Drawing.Point(253, 205);
            this.LblMerk.Name = "LblMerk";
            this.LblMerk.Size = new System.Drawing.Size(41, 16);
            this.LblMerk.TabIndex = 17;
            this.LblMerk.Text = "Merk:";
            // 
            // LblProductnaam
            // 
            this.LblProductnaam.AutoSize = true;
            this.LblProductnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductnaam.Location = new System.Drawing.Point(203, 173);
            this.LblProductnaam.Name = "LblProductnaam";
            this.LblProductnaam.Size = new System.Drawing.Size(91, 16);
            this.LblProductnaam.TabIndex = 16;
            this.LblProductnaam.Text = "Productnaam:";
            // 
            // Materiaalbeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 538);
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
    }
}