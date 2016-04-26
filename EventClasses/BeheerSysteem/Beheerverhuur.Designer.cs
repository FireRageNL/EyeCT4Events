using System.ComponentModel;
using System.Windows.Forms;

namespace BeheerSysteem
{
    partial class Beheerverhuur
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
            this.DTPBegin = new System.Windows.Forms.DateTimePicker();
            this.DTPEind = new System.Windows.Forms.DateTimePicker();
            this.LBGebruikers = new System.Windows.Forms.ListBox();
            this.LBMateriaal = new System.Windows.Forms.ListBox();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnZoeken = new System.Windows.Forms.Button();
            this.TbType = new System.Windows.Forms.TextBox();
            this.TbMerk = new System.Windows.Forms.TextBox();
            this.TbProductnaam = new System.Windows.Forms.TextBox();
            this.LblType = new System.Windows.Forms.Label();
            this.LblMerk = new System.Windows.Forms.Label();
            this.LblProductnaam = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnGebZoek = new System.Windows.Forms.Button();
            this.TbDatum = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbAchternaam = new System.Windows.Forms.TextBox();
            this.LblRFID = new System.Windows.Forms.Label();
            this.LbLEmail = new System.Windows.Forms.Label();
            this.LblAchternaam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBevestigen = new System.Windows.Forms.Button();
            this.CbOpgehaald = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DTPBegin
            // 
            this.DTPBegin.CustomFormat = "dd-MM-yyyy hh:mm";
            this.DTPBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPBegin.Location = new System.Drawing.Point(194, 503);
            this.DTPBegin.Name = "DTPBegin";
            this.DTPBegin.Size = new System.Drawing.Size(200, 20);
            this.DTPBegin.TabIndex = 0;
            // 
            // DTPEind
            // 
            this.DTPEind.CustomFormat = "dd-MM-yyyy hh:mm";
            this.DTPEind.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPEind.Location = new System.Drawing.Point(629, 503);
            this.DTPEind.Name = "DTPEind";
            this.DTPEind.Size = new System.Drawing.Size(200, 20);
            this.DTPEind.TabIndex = 1;
            // 
            // LBGebruikers
            // 
            this.LBGebruikers.FormattingEnabled = true;
            this.LBGebruikers.Location = new System.Drawing.Point(479, 164);
            this.LBGebruikers.Name = "LBGebruikers";
            this.LBGebruikers.Size = new System.Drawing.Size(384, 316);
            this.LBGebruikers.TabIndex = 2;
            // 
            // LBMateriaal
            // 
            this.LBMateriaal.FormattingEnabled = true;
            this.LBMateriaal.Location = new System.Drawing.Point(38, 164);
            this.LBMateriaal.Name = "LBMateriaal";
            this.LBMateriaal.Size = new System.Drawing.Size(384, 316);
            this.LBMateriaal.TabIndex = 3;
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWissen.Location = new System.Drawing.Point(269, 127);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(64, 23);
            this.BtnWissen.TabIndex = 31;
            this.BtnWissen.Text = "Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnZoeken
            // 
            this.BtnZoeken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZoeken.Location = new System.Drawing.Point(194, 127);
            this.BtnZoeken.Name = "BtnZoeken";
            this.BtnZoeken.Size = new System.Drawing.Size(64, 23);
            this.BtnZoeken.TabIndex = 30;
            this.BtnZoeken.Text = "Zoeken";
            this.BtnZoeken.UseVisualStyleBackColor = true;
            this.BtnZoeken.Click += new System.EventHandler(this.BtnZoeken_Click);
            // 
            // TbType
            // 
            this.TbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbType.Location = new System.Drawing.Point(194, 88);
            this.TbType.Name = "TbType";
            this.TbType.Size = new System.Drawing.Size(139, 22);
            this.TbType.TabIndex = 29;
            // 
            // TbMerk
            // 
            this.TbMerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMerk.Location = new System.Drawing.Point(194, 58);
            this.TbMerk.Name = "TbMerk";
            this.TbMerk.Size = new System.Drawing.Size(139, 22);
            this.TbMerk.TabIndex = 28;
            // 
            // TbProductnaam
            // 
            this.TbProductnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbProductnaam.Location = new System.Drawing.Point(194, 26);
            this.TbProductnaam.Name = "TbProductnaam";
            this.TbProductnaam.Size = new System.Drawing.Size(139, 22);
            this.TbProductnaam.TabIndex = 27;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.Location = new System.Drawing.Point(145, 91);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(43, 16);
            this.LblType.TabIndex = 26;
            this.LblType.Text = "Type:";
            // 
            // LblMerk
            // 
            this.LblMerk.AutoSize = true;
            this.LblMerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMerk.Location = new System.Drawing.Point(147, 61);
            this.LblMerk.Name = "LblMerk";
            this.LblMerk.Size = new System.Drawing.Size(41, 16);
            this.LblMerk.TabIndex = 25;
            this.LblMerk.Text = "Merk:";
            // 
            // LblProductnaam
            // 
            this.LblProductnaam.AutoSize = true;
            this.LblProductnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductnaam.Location = new System.Drawing.Point(97, 29);
            this.LblProductnaam.Name = "LblProductnaam";
            this.LblProductnaam.Size = new System.Drawing.Size(91, 16);
            this.LblProductnaam.TabIndex = 24;
            this.LblProductnaam.Text = "Productnaam:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(704, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Wissen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnGebZoek
            // 
            this.BtnGebZoek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGebZoek.Location = new System.Drawing.Point(629, 127);
            this.BtnGebZoek.Name = "BtnGebZoek";
            this.BtnGebZoek.Size = new System.Drawing.Size(64, 23);
            this.BtnGebZoek.TabIndex = 38;
            this.BtnGebZoek.Text = "Zoeken";
            this.BtnGebZoek.UseVisualStyleBackColor = true;
            this.BtnGebZoek.Click += new System.EventHandler(this.BtnGebZoek_Click);
            // 
            // TbDatum
            // 
            this.TbDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDatum.Location = new System.Drawing.Point(629, 88);
            this.TbDatum.Name = "TbDatum";
            this.TbDatum.Size = new System.Drawing.Size(139, 22);
            this.TbDatum.TabIndex = 37;
            // 
            // TbEmail
            // 
            this.TbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEmail.Location = new System.Drawing.Point(629, 58);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(139, 22);
            this.TbEmail.TabIndex = 36;
            // 
            // TbAchternaam
            // 
            this.TbAchternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAchternaam.Location = new System.Drawing.Point(629, 26);
            this.TbAchternaam.Name = "TbAchternaam";
            this.TbAchternaam.Size = new System.Drawing.Size(139, 22);
            this.TbAchternaam.TabIndex = 35;
            // 
            // LblRFID
            // 
            this.LblRFID.AutoSize = true;
            this.LblRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRFID.Location = new System.Drawing.Point(518, 91);
            this.LblRFID.Name = "LblRFID";
            this.LblRFID.Size = new System.Drawing.Size(105, 16);
            this.LblRFID.TabIndex = 34;
            this.LblRFID.Text = "Geboortedatum:";
            // 
            // LbLEmail
            // 
            this.LbLEmail.AutoSize = true;
            this.LbLEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLEmail.Location = new System.Drawing.Point(578, 61);
            this.LbLEmail.Name = "LbLEmail";
            this.LbLEmail.Size = new System.Drawing.Size(45, 16);
            this.LbLEmail.TabIndex = 33;
            this.LbLEmail.Text = "Email:";
            // 
            // LblAchternaam
            // 
            this.LblAchternaam.AutoSize = true;
            this.LblAchternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAchternaam.Location = new System.Drawing.Point(540, 29);
            this.LblAchternaam.Name = "LblAchternaam";
            this.LblAchternaam.Size = new System.Drawing.Size(83, 16);
            this.LblAchternaam.TabIndex = 32;
            this.LblAchternaam.Text = "Achternaam:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Begin Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Eind Datum:";
            // 
            // BtnBevestigen
            // 
            this.BtnBevestigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBevestigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.BtnBevestigen.Location = new System.Drawing.Point(407, 570);
            this.BtnBevestigen.Name = "BtnBevestigen";
            this.BtnBevestigen.Size = new System.Drawing.Size(81, 39);
            this.BtnBevestigen.TabIndex = 42;
            this.BtnBevestigen.Text = "Bevestigen";
            this.BtnBevestigen.UseVisualStyleBackColor = true;
            this.BtnBevestigen.Click += new System.EventHandler(this.BtnBevestigen_Click);
            // 
            // CbOpgehaald
            // 
            this.CbOpgehaald.AutoSize = true;
            this.CbOpgehaald.Location = new System.Drawing.Point(408, 547);
            this.CbOpgehaald.Name = "CbOpgehaald";
            this.CbOpgehaald.Size = new System.Drawing.Size(78, 17);
            this.CbOpgehaald.TabIndex = 43;
            this.CbOpgehaald.Text = "Opgehaald";
            this.CbOpgehaald.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(812, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 55);
            this.button2.TabIndex = 44;
            this.button2.Text = "Ophalen en Terugbrengen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Beheerverhuur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 619);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CbOpgehaald);
            this.Controls.Add(this.BtnBevestigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnGebZoek);
            this.Controls.Add(this.TbDatum);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.TbAchternaam);
            this.Controls.Add(this.LblRFID);
            this.Controls.Add(this.LbLEmail);
            this.Controls.Add(this.LblAchternaam);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnZoeken);
            this.Controls.Add(this.TbType);
            this.Controls.Add(this.TbMerk);
            this.Controls.Add(this.TbProductnaam);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.LblMerk);
            this.Controls.Add(this.LblProductnaam);
            this.Controls.Add(this.LBMateriaal);
            this.Controls.Add(this.LBGebruikers);
            this.Controls.Add(this.DTPEind);
            this.Controls.Add(this.DTPBegin);
            this.Name = "Beheerverhuur";
            this.Text = "Beheerverhuur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker DTPBegin;
        private DateTimePicker DTPEind;
        private ListBox LBGebruikers;
        private ListBox LBMateriaal;
        private Button BtnWissen;
        private Button BtnZoeken;
        private TextBox TbType;
        private TextBox TbMerk;
        private TextBox TbProductnaam;
        private Label LblType;
        private Label LblMerk;
        private Label LblProductnaam;
        private Button button1;
        private Button BtnGebZoek;
        private TextBox TbDatum;
        private TextBox TbEmail;
        private TextBox TbAchternaam;
        private Label LblRFID;
        private Label LbLEmail;
        private Label LblAchternaam;
        private Label label1;
        private Label label2;
        private Button BtnBevestigen;
        private CheckBox CbOpgehaald;
        private Button button2;
    }
}