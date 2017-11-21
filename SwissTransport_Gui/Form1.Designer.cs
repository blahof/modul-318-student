namespace SwissTransport_Gui
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStart = new System.Windows.Forms.Label();
            this.lblZiel = new System.Windows.Forms.Label();
            this.btnVerbindungSuchen = new System.Windows.Forms.Button();
            this.cboxZiel = new System.Windows.Forms.ComboBox();
            this.cboxStart = new System.Windows.Forms.ComboBox();
            this.lbAusgabe = new System.Windows.Forms.ListBox();
            this.btnVerbindungenAnzeigen = new System.Windows.Forms.Button();
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(34, 33);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(42, 17);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start:";
            // 
            // lblZiel
            // 
            this.lblZiel.AutoSize = true;
            this.lblZiel.Location = new System.Drawing.Point(34, 67);
            this.lblZiel.Name = "lblZiel";
            this.lblZiel.Size = new System.Drawing.Size(35, 17);
            this.lblZiel.TabIndex = 1;
            this.lblZiel.Text = "Ziel:";
            // 
            // btnVerbindungSuchen
            // 
            this.btnVerbindungSuchen.Location = new System.Drawing.Point(280, 64);
            this.btnVerbindungSuchen.Name = "btnVerbindungSuchen";
            this.btnVerbindungSuchen.Size = new System.Drawing.Size(177, 24);
            this.btnVerbindungSuchen.TabIndex = 4;
            this.btnVerbindungSuchen.Text = "&Verbindung suchen ";
            this.btnVerbindungSuchen.UseVisualStyleBackColor = true;
            this.btnVerbindungSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // cboxZiel
            // 
            this.cboxZiel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxZiel.FormattingEnabled = true;
            this.cboxZiel.Location = new System.Drawing.Point(98, 64);
            this.cboxZiel.Name = "cboxZiel";
            this.cboxZiel.Size = new System.Drawing.Size(149, 24);
            this.cboxZiel.TabIndex = 3;
            this.cboxZiel.DropDown += new System.EventHandler(this.cboxZiel_DropDown);
            // 
            // cboxStart
            // 
            this.cboxStart.FormattingEnabled = true;
            this.cboxStart.Location = new System.Drawing.Point(98, 26);
            this.cboxStart.Name = "cboxStart";
            this.cboxStart.Size = new System.Drawing.Size(153, 24);
            this.cboxStart.TabIndex = 1;
            this.cboxStart.DropDown += new System.EventHandler(this.cboxStart_DropDown);
            // 
            // lbAusgabe
            // 
            this.lbAusgabe.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAusgabe.FormattingEnabled = true;
            this.lbAusgabe.ItemHeight = 15;
            this.lbAusgabe.Location = new System.Drawing.Point(12, 159);
            this.lbAusgabe.Name = "lbAusgabe";
            this.lbAusgabe.Size = new System.Drawing.Size(730, 184);
            this.lbAusgabe.TabIndex = 5;
            // 
            // btnVerbindungenAnzeigen
            // 
            this.btnVerbindungenAnzeigen.Location = new System.Drawing.Point(280, 26);
            this.btnVerbindungenAnzeigen.Name = "btnVerbindungenAnzeigen";
            this.btnVerbindungenAnzeigen.Size = new System.Drawing.Size(177, 24);
            this.btnVerbindungenAnzeigen.TabIndex = 2;
            this.btnVerbindungenAnzeigen.Text = "&Verbindungen anzeigen ";
            this.btnVerbindungenAnzeigen.UseVisualStyleBackColor = true;
            this.btnVerbindungenAnzeigen.Click += new System.EventHandler(this.btnVerbindungenAnzeigen_Click);
            // 
            // btnSchliessen
            // 
            this.btnSchliessen.Location = new System.Drawing.Point(644, 453);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(98, 23);
            this.btnSchliessen.TabIndex = 6;
            this.btnSchliessen.Text = "Schliessen";
            this.btnSchliessen.UseVisualStyleBackColor = true;
            this.btnSchliessen.Click += new System.EventHandler(this.btnSchliessen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 488);
            this.Controls.Add(this.btnSchliessen);
            this.Controls.Add(this.btnVerbindungenAnzeigen);
            this.Controls.Add(this.lbAusgabe);
            this.Controls.Add(this.cboxStart);
            this.Controls.Add(this.cboxZiel);
            this.Controls.Add(this.btnVerbindungSuchen);
            this.Controls.Add(this.lblZiel);
            this.Controls.Add(this.lblStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblZiel;
        private System.Windows.Forms.Button btnVerbindungSuchen;
        private System.Windows.Forms.ComboBox cboxZiel;
        private System.Windows.Forms.ComboBox cboxStart;
        private System.Windows.Forms.ListBox lbAusgabe;
        private System.Windows.Forms.Button btnVerbindungenAnzeigen;
        private System.Windows.Forms.Button btnSchliessen;
    }
}

