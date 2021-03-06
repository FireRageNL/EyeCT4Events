﻿using System.ComponentModel;
using System.Windows.Forms;

namespace BeheerSysteem
{
    partial class EventDialog
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
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStraat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbToev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPlaats = new System.Windows.Forms.TextBox();
            this.tbPost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLand = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(104, 29);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(382, 20);
            this.tbNaam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eventnaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Begindatum:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(104, 110);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Einddatum: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Straat:";
            // 
            // tbStraat
            // 
            this.tbStraat.AcceptsReturn = true;
            this.tbStraat.Location = new System.Drawing.Point(103, 158);
            this.tbStraat.Name = "tbStraat";
            this.tbStraat.Size = new System.Drawing.Size(203, 20);
            this.tbStraat.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nr:";
            // 
            // tbNr
            // 
            this.tbNr.AcceptsReturn = true;
            this.tbNr.Location = new System.Drawing.Point(343, 158);
            this.tbNr.Name = "tbNr";
            this.tbNr.Size = new System.Drawing.Size(26, 20);
            this.tbNr.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Toevoeging:";
            // 
            // tbToev
            // 
            this.tbToev.AcceptsReturn = true;
            this.tbToev.Location = new System.Drawing.Point(463, 158);
            this.tbToev.Name = "tbToev";
            this.tbToev.Size = new System.Drawing.Size(26, 20);
            this.tbToev.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Plaats:";
            // 
            // tbPlaats
            // 
            this.tbPlaats.AcceptsReturn = true;
            this.tbPlaats.Location = new System.Drawing.Point(103, 202);
            this.tbPlaats.Name = "tbPlaats";
            this.tbPlaats.Size = new System.Drawing.Size(203, 20);
            this.tbPlaats.TabIndex = 24;
            // 
            // tbPost
            // 
            this.tbPost.Location = new System.Drawing.Point(389, 202);
            this.tbPost.Name = "tbPost";
            this.tbPost.Size = new System.Drawing.Size(100, 20);
            this.tbPost.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Postcode:";
            // 
            // tbLand
            // 
            this.tbLand.AcceptsReturn = true;
            this.tbLand.Location = new System.Drawing.Point(104, 251);
            this.tbLand.Name = "tbLand";
            this.tbLand.Size = new System.Drawing.Size(203, 20);
            this.tbLand.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Land:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Opslaan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EventDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbLand);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPost);
            this.Controls.Add(this.tbPlaats);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbToev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbStraat);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNaam);
            this.Name = "EventDialog";
            this.Text = "EventDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbNaam;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label7;
        private TextBox tbStraat;
        private Label label4;
        private TextBox tbNr;
        private Label label5;
        private TextBox tbToev;
        private Label label6;
        private TextBox tbPlaats;
        private TextBox tbPost;
        private Label label8;
        private TextBox tbLand;
        private Label label9;
        private Button button1;
    }
}