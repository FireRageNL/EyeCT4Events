namespace Toegangscontrole
{
    partial class Gebruikerslijst
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
            this.lbAanwezigheid = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbAanwezigheid
            // 
            this.lbAanwezigheid.FormattingEnabled = true;
            this.lbAanwezigheid.Location = new System.Drawing.Point(12, 3);
            this.lbAanwezigheid.Name = "lbAanwezigheid";
            this.lbAanwezigheid.Size = new System.Drawing.Size(260, 446);
            this.lbAanwezigheid.TabIndex = 0;
            // 
            // Gebruikerslijst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 505);
            this.Controls.Add(this.lbAanwezigheid);
            this.Name = "Gebruikerslijst";
            this.Text = "Gebruikerslijst";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAanwezigheid;
    }
}