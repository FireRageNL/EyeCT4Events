using System.ComponentModel;
using System.Windows.Forms;

namespace Toegangscontrole
{
    partial class Toegangscontrole
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
            this.LblTitel = new System.Windows.Forms.Label();
            this.LblstaticRFID = new System.Windows.Forms.Label();
            this.LbLstaticnaam = new System.Windows.Forms.Label();
            this.LblNaam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbRFID = new System.Windows.Forms.TextBox();
            this.ChkBetaald = new System.Windows.Forms.CheckBox();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnBetaald = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.Lblstaticevent = new System.Windows.Forms.Label();
            this.CbEvent = new System.Windows.Forms.ComboBox();
            this.btnShowAll = new System.Windows.Forms.Button();
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
            // LblstaticRFID
            // 
            this.LblstaticRFID.AutoSize = true;
            this.LblstaticRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblstaticRFID.Location = new System.Drawing.Point(272, 212);
            this.LblstaticRFID.Name = "LblstaticRFID";
            this.LblstaticRFID.Size = new System.Drawing.Size(42, 16);
            this.LblstaticRFID.TabIndex = 1;
            this.LblstaticRFID.Text = "RFID:";
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
            this.LblNaam.Size = new System.Drawing.Size(0, 16);
            this.LblNaam.TabIndex = 3;
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
            // BtnCheck
            // 
            this.BtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheck.Location = new System.Drawing.Point(260, 281);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(75, 23);
            this.BtnCheck.TabIndex = 7;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnBetaald
            // 
            this.BtnBetaald.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBetaald.Location = new System.Drawing.Point(345, 281);
            this.BtnBetaald.Name = "BtnBetaald";
            this.BtnBetaald.Size = new System.Drawing.Size(75, 23);
            this.BtnBetaald.TabIndex = 8;
            this.BtnBetaald.Text = "Betaald";
            this.BtnBetaald.UseVisualStyleBackColor = true;
            this.BtnBetaald.Click += new System.EventHandler(this.BtnBetaald_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Location = new System.Drawing.Point(304, 310);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Lblstaticevent
            // 
            this.Lblstaticevent.AutoSize = true;
            this.Lblstaticevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblstaticevent.Location = new System.Drawing.Point(272, 187);
            this.Lblstaticevent.Name = "Lblstaticevent";
            this.Lblstaticevent.Size = new System.Drawing.Size(45, 16);
            this.Lblstaticevent.TabIndex = 10;
            this.Lblstaticevent.Text = "Event:";
            // 
            // CbEvent
            // 
            this.CbEvent.FormattingEnabled = true;
            this.CbEvent.Location = new System.Drawing.Point(320, 187);
            this.CbEvent.Name = "CbEvent";
            this.CbEvent.Size = new System.Drawing.Size(121, 21);
            this.CbEvent.TabIndex = 11;
            // 
            // btnShowAll
            // 
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Location = new System.Drawing.Point(586, 187);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 46);
            this.btnShowAll.TabIndex = 12;
            this.btnShowAll.Text = "Toon Aanwezigen";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Toegangscontrole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 386);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.CbEvent);
            this.Controls.Add(this.Lblstaticevent);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnBetaald);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.ChkBetaald);
            this.Controls.Add(this.TbRFID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblNaam);
            this.Controls.Add(this.LbLstaticnaam);
            this.Controls.Add(this.LblstaticRFID);
            this.Controls.Add(this.LblTitel);
            this.Name = "Toegangscontrole";
            this.Text = "Toegangscontrole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblTitel;
        private Label LblstaticRFID;
        private Label LbLstaticnaam;
        private Label LblNaam;
        private Label label4;
        private TextBox TbRFID;
        private CheckBox ChkBetaald;
        private Button BtnCheck;
        private Button BtnBetaald;
        private Button BtnReset;
        private Label Lblstaticevent;
        private ComboBox CbEvent;
        public Button btnShowAll;
    }
}

