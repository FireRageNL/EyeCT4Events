using System.ComponentModel;
using System.Windows.Forms;

namespace BeheerSysteem
{
    partial class Beheergebruiker
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnVerwijder = new System.Windows.Forms.Button();
            this.BtnWijzigen = new System.Windows.Forms.Button();
            this.BtnToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(416, 498);
            this.listBox1.TabIndex = 0;
            // 
            // BtnVerwijder
            // 
            this.BtnVerwijder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerwijder.Location = new System.Drawing.Point(460, 12);
            this.BtnVerwijder.Name = "BtnVerwijder";
            this.BtnVerwijder.Size = new System.Drawing.Size(78, 53);
            this.BtnVerwijder.TabIndex = 26;
            this.BtnVerwijder.Text = "Verwijder";
            this.BtnVerwijder.UseVisualStyleBackColor = true;
            this.BtnVerwijder.Click += new System.EventHandler(this.BtnVerwijder_Click);
            // 
            // BtnWijzigen
            // 
            this.BtnWijzigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWijzigen.Location = new System.Drawing.Point(460, 91);
            this.BtnWijzigen.Name = "BtnWijzigen";
            this.BtnWijzigen.Size = new System.Drawing.Size(78, 53);
            this.BtnWijzigen.TabIndex = 27;
            this.BtnWijzigen.Text = "Wijzigen";
            this.BtnWijzigen.UseVisualStyleBackColor = true;
            this.BtnWijzigen.Click += new System.EventHandler(this.BtnWijzigen_Click);
            // 
            // BtnToevoegen
            // 
            this.BtnToevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToevoegen.Location = new System.Drawing.Point(460, 170);
            this.BtnToevoegen.Name = "BtnToevoegen";
            this.BtnToevoegen.Size = new System.Drawing.Size(78, 53);
            this.BtnToevoegen.TabIndex = 28;
            this.BtnToevoegen.Text = "Toevoegen";
            this.BtnToevoegen.UseVisualStyleBackColor = true;
            this.BtnToevoegen.Click += new System.EventHandler(this.BtnToevoegen_Click);
            // 
            // Beheergebruiker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 523);
            this.Controls.Add(this.BtnToevoegen);
            this.Controls.Add(this.BtnWijzigen);
            this.Controls.Add(this.BtnVerwijder);
            this.Controls.Add(this.listBox1);
            this.Name = "Beheergebruiker";
            this.Text = "Beheer Gebruiker";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private Button BtnVerwijder;
        private Button BtnWijzigen;
        private Button BtnToevoegen;
    }
}