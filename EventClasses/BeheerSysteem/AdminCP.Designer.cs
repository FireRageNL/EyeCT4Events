namespace BeheerSysteem
{
    partial class AdminCP
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
            this.btnGebruiker = new System.Windows.Forms.Button();
            this.btnMateriaal = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnReservering = new System.Windows.Forms.Button();
            this.btnVerhuur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGebruiker
            // 
            this.btnGebruiker.Location = new System.Drawing.Point(22, 40);
            this.btnGebruiker.Name = "btnGebruiker";
            this.btnGebruiker.Size = new System.Drawing.Size(72, 53);
            this.btnGebruiker.TabIndex = 0;
            this.btnGebruiker.Text = "Gebruiker beheer";
            this.btnGebruiker.UseVisualStyleBackColor = true;
            this.btnGebruiker.Click += new System.EventHandler(this.btnGebruiker_Click);
            // 
            // btnMateriaal
            // 
            this.btnMateriaal.Location = new System.Drawing.Point(22, 121);
            this.btnMateriaal.Name = "btnMateriaal";
            this.btnMateriaal.Size = new System.Drawing.Size(72, 53);
            this.btnMateriaal.TabIndex = 1;
            this.btnMateriaal.Text = "Materiaal beheer";
            this.btnMateriaal.UseVisualStyleBackColor = true;
            this.btnMateriaal.Click += new System.EventHandler(this.btnMateriaal_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.Location = new System.Drawing.Point(200, 40);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(70, 53);
            this.btnEvent.TabIndex = 2;
            this.btnEvent.Text = "Event beheer";
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // btnReservering
            // 
            this.btnReservering.Location = new System.Drawing.Point(111, 40);
            this.btnReservering.Name = "btnReservering";
            this.btnReservering.Size = new System.Drawing.Size(72, 53);
            this.btnReservering.TabIndex = 3;
            this.btnReservering.Text = "Reservering beheer";
            this.btnReservering.UseVisualStyleBackColor = true;
            this.btnReservering.Click += new System.EventHandler(this.btnReservering_Click);
            // 
            // btnVerhuur
            // 
            this.btnVerhuur.Location = new System.Drawing.Point(111, 121);
            this.btnVerhuur.Name = "btnVerhuur";
            this.btnVerhuur.Size = new System.Drawing.Size(72, 53);
            this.btnVerhuur.TabIndex = 4;
            this.btnVerhuur.Text = "Verhuur beheer";
            this.btnVerhuur.UseVisualStyleBackColor = true;
            this.btnVerhuur.Click += new System.EventHandler(this.btnVerhuur_Click);
            // 
            // AdminCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnVerhuur);
            this.Controls.Add(this.btnReservering);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.btnMateriaal);
            this.Controls.Add(this.btnGebruiker);
            this.Name = "AdminCP";
            this.Text = "AdminCP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGebruiker;
        private System.Windows.Forms.Button btnMateriaal;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnReservering;
        private System.Windows.Forms.Button btnVerhuur;
    }
}