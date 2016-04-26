using System.ComponentModel;
using System.Windows.Forms;

namespace BeheerSysteem
{
    partial class MateriaalDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.TbMerk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbPrijs = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbMerk
            // 
            this.TbMerk.Location = new System.Drawing.Point(12, 42);
            this.TbMerk.Name = "TbMerk";
            this.TbMerk.Size = new System.Drawing.Size(278, 20);
            this.TbMerk.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Merk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Productnaam";
            // 
            // TbProduct
            // 
            this.TbProduct.Location = new System.Drawing.Point(12, 122);
            this.TbProduct.Name = "TbProduct";
            this.TbProduct.Size = new System.Drawing.Size(278, 20);
            this.TbProduct.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Typenummer";
            // 
            // TbType
            // 
            this.TbType.Location = new System.Drawing.Point(12, 204);
            this.TbType.Name = "TbType";
            this.TbType.Size = new System.Drawing.Size(278, 20);
            this.TbType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Prijs";
            // 
            // TbPrijs
            // 
            this.TbPrijs.Location = new System.Drawing.Point(12, 288);
            this.TbPrijs.Name = "TbPrijs";
            this.TbPrijs.Size = new System.Drawing.Size(278, 20);
            this.TbPrijs.TabIndex = 9;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(116, 348);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Ok";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // MateriaalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 408);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbPrijs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbMerk);
            this.Name = "MateriaalDialog";
            this.Text = "MateriaalDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TbMerk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnConfirm;
        private TextBox TbPrijs;
        private TextBox TbType;
        private TextBox TbProduct;
    }
}