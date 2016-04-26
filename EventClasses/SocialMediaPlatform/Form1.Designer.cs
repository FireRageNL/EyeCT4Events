using System.ComponentModel;
using System.Windows.Forms;

namespace SocialMediaPlatform
{
    partial class Form1
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
            this.LblNaam = new System.Windows.Forms.Label();
            this.LblDatum = new System.Windows.Forms.Label();
            this.PbMedia = new System.Windows.Forms.PictureBox();
            this.Lblstaticreactie = new System.Windows.Forms.Label();
            this.LblReacties = new System.Windows.Forms.Label();
            this.RtbReactie = new System.Windows.Forms.RichTextBox();
            this.Lblstaticreactie2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LblPost = new System.Windows.Forms.Label();
            this.BtnPlaats = new System.Windows.Forms.Button();
            this.BtnDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNaam
            // 
            this.LblNaam.AutoSize = true;
            this.LblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNaam.Location = new System.Drawing.Point(69, 13);
            this.LblNaam.Name = "LblNaam";
            this.LblNaam.Size = new System.Drawing.Size(45, 16);
            this.LblNaam.TabIndex = 1;
            this.LblNaam.Text = "Naam";
            // 
            // LblDatum
            // 
            this.LblDatum.AutoSize = true;
            this.LblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatum.Location = new System.Drawing.Point(69, 46);
            this.LblDatum.Name = "LblDatum";
            this.LblDatum.Size = new System.Drawing.Size(47, 16);
            this.LblDatum.TabIndex = 2;
            this.LblDatum.Text = "Datum";
            // 
            // PbMedia
            // 
            this.PbMedia.Location = new System.Drawing.Point(13, 237);
            this.PbMedia.Name = "PbMedia";
            this.PbMedia.Size = new System.Drawing.Size(456, 224);
            this.PbMedia.TabIndex = 4;
            this.PbMedia.TabStop = false;
            // 
            // Lblstaticreactie
            // 
            this.Lblstaticreactie.AutoSize = true;
            this.Lblstaticreactie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblstaticreactie.Location = new System.Drawing.Point(348, 475);
            this.Lblstaticreactie.Name = "Lblstaticreactie";
            this.Lblstaticreactie.Size = new System.Drawing.Size(100, 16);
            this.Lblstaticreactie.TabIndex = 5;
            this.Lblstaticreactie.Text = "Aantal reacties:";
            // 
            // LblReacties
            // 
            this.LblReacties.AutoSize = true;
            this.LblReacties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReacties.Location = new System.Drawing.Point(454, 475);
            this.LblReacties.Name = "LblReacties";
            this.LblReacties.Size = new System.Drawing.Size(15, 16);
            this.LblReacties.TabIndex = 6;
            this.LblReacties.Text = "0";
            // 
            // RtbReactie
            // 
            this.RtbReactie.Location = new System.Drawing.Point(72, 500);
            this.RtbReactie.Name = "RtbReactie";
            this.RtbReactie.Size = new System.Drawing.Size(397, 50);
            this.RtbReactie.TabIndex = 8;
            this.RtbReactie.Text = "";
            // 
            // Lblstaticreactie2
            // 
            this.Lblstaticreactie2.AutoSize = true;
            this.Lblstaticreactie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblstaticreactie2.Location = new System.Drawing.Point(10, 475);
            this.Lblstaticreactie2.Name = "Lblstaticreactie2";
            this.Lblstaticreactie2.Size = new System.Drawing.Size(116, 16);
            this.Lblstaticreactie2.TabIndex = 9;
            this.Lblstaticreactie2.Text = "Plaats een reactie";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(456, 121);
            this.listBox1.TabIndex = 10;
            // 
            // LblPost
            // 
            this.LblPost.AutoSize = true;
            this.LblPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPost.Location = new System.Drawing.Point(69, 78);
            this.LblPost.Name = "LblPost";
            this.LblPost.Size = new System.Drawing.Size(0, 20);
            this.LblPost.TabIndex = 11;
            // 
            // BtnPlaats
            // 
            this.BtnPlaats.Location = new System.Drawing.Point(3, 500);
            this.BtnPlaats.Name = "BtnPlaats";
            this.BtnPlaats.Size = new System.Drawing.Size(63, 50);
            this.BtnPlaats.TabIndex = 12;
            this.BtnPlaats.Text = "Plaats";
            this.BtnPlaats.UseVisualStyleBackColor = true;
            this.BtnPlaats.Click += new System.EventHandler(this.BtnPlaats_Click);
            // 
            // BtnDownload
            // 
            this.BtnDownload.Location = new System.Drawing.Point(3, 556);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(63, 50);
            this.BtnDownload.TabIndex = 13;
            this.BtnDownload.Text = "Download image";
            this.BtnDownload.UseVisualStyleBackColor = true;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 608);
            this.Controls.Add(this.BtnDownload);
            this.Controls.Add(this.BtnPlaats);
            this.Controls.Add(this.LblPost);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Lblstaticreactie2);
            this.Controls.Add(this.RtbReactie);
            this.Controls.Add(this.LblReacties);
            this.Controls.Add(this.Lblstaticreactie);
            this.Controls.Add(this.PbMedia);
            this.Controls.Add(this.LblDatum);
            this.Controls.Add(this.LblNaam);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LblNaam;
        private Label LblDatum;
        private PictureBox PbMedia;
        private Label Lblstaticreactie;
        private Label LblReacties;
        private RichTextBox RtbReactie;
        private Label Lblstaticreactie2;
        private ListBox listBox1;
        private Label LblPost;
        private Button BtnPlaats;
        private Button BtnDownload;
    }
}

