namespace Mitarbeiterverwaltung
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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MitarbeiterDB = new System.Windows.Forms.DataGridView();
            this.vornameInput = new System.Windows.Forms.TextBox();
            this.vornameLabel = new System.Windows.Forms.Label();
            this.nachnameLabel = new System.Windows.Forms.Label();
            this.nachnameInput = new System.Windows.Forms.TextBox();
            this.geschlechtDropdown = new System.Windows.Forms.ComboBox();
            this.geschlechtLabel = new System.Windows.Forms.Label();
            this.btnSaveMitarbeiter = new System.Windows.Forms.Button();
            this.btnChangeMitarbeiter = new System.Windows.Forms.Button();
            this.btnDeleteMitarbeiter = new System.Windows.Forms.Button();
            this.btnClearMitarbeiter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MitarbeiterDB)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MitarbeiterDB
            // 
            this.MitarbeiterDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MitarbeiterDB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MitarbeiterDB.Location = new System.Drawing.Point(0, 183);
            this.MitarbeiterDB.MultiSelect = false;
            this.MitarbeiterDB.Name = "MitarbeiterDB";
            this.MitarbeiterDB.ReadOnly = true;
            this.MitarbeiterDB.RowHeadersWidth = 51;
            this.MitarbeiterDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MitarbeiterDB.Size = new System.Drawing.Size(1107, 367);
            this.MitarbeiterDB.TabIndex = 0;
            this.MitarbeiterDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MitarbeiterDB_CellContentClick);
            this.MitarbeiterDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MitarbeiterDB_CellContentClick);
            // 
            // vornameInput
            // 
            this.vornameInput.Location = new System.Drawing.Point(132, 26);
            this.vornameInput.Name = "vornameInput";
            this.vornameInput.Size = new System.Drawing.Size(225, 20);
            this.vornameInput.TabIndex = 1;
            // 
            // vornameLabel
            // 
            this.vornameLabel.AutoSize = true;
            this.vornameLabel.Location = new System.Drawing.Point(46, 26);
            this.vornameLabel.Name = "vornameLabel";
            this.vornameLabel.Size = new System.Drawing.Size(49, 13);
            this.vornameLabel.TabIndex = 2;
            this.vornameLabel.Text = "Vorname";
            // 
            // nachnameLabel
            // 
            this.nachnameLabel.AutoSize = true;
            this.nachnameLabel.Location = new System.Drawing.Point(50, 58);
            this.nachnameLabel.Name = "nachnameLabel";
            this.nachnameLabel.Size = new System.Drawing.Size(59, 13);
            this.nachnameLabel.TabIndex = 3;
            this.nachnameLabel.Text = "Nachname";
            // 
            // nachnameInput
            // 
            this.nachnameInput.Location = new System.Drawing.Point(132, 58);
            this.nachnameInput.Name = "nachnameInput";
            this.nachnameInput.Size = new System.Drawing.Size(225, 20);
            this.nachnameInput.TabIndex = 4;
            // 
            // geschlechtDropdown
            // 
            this.geschlechtDropdown.FormattingEnabled = true;
            this.geschlechtDropdown.Location = new System.Drawing.Point(132, 94);
            this.geschlechtDropdown.Name = "geschlechtDropdown";
            this.geschlechtDropdown.Size = new System.Drawing.Size(225, 21);
            this.geschlechtDropdown.TabIndex = 5;
            // 
            // geschlechtLabel
            // 
            this.geschlechtLabel.AutoSize = true;
            this.geschlechtLabel.Location = new System.Drawing.Point(50, 94);
            this.geschlechtLabel.Name = "geschlechtLabel";
            this.geschlechtLabel.Size = new System.Drawing.Size(61, 13);
            this.geschlechtLabel.TabIndex = 6;
            this.geschlechtLabel.Text = "Geschlecht";
            // 
            // btnSaveMitarbeiter
            // 
            this.btnSaveMitarbeiter.Location = new System.Drawing.Point(53, 154);
            this.btnSaveMitarbeiter.Name = "btnSaveMitarbeiter";
            this.btnSaveMitarbeiter.Size = new System.Drawing.Size(155, 23);
            this.btnSaveMitarbeiter.TabIndex = 7;
            this.btnSaveMitarbeiter.Text = "speichern";
            this.btnSaveMitarbeiter.UseVisualStyleBackColor = true;
            this.btnSaveMitarbeiter.Click += new System.EventHandler(this.btnSaveMitarbeiter_Click);
            // 
            // btnChangeMitarbeiter
            // 
            this.btnChangeMitarbeiter.Location = new System.Drawing.Point(245, 154);
            this.btnChangeMitarbeiter.Name = "btnChangeMitarbeiter";
            this.btnChangeMitarbeiter.Size = new System.Drawing.Size(155, 23);
            this.btnChangeMitarbeiter.TabIndex = 8;
            this.btnChangeMitarbeiter.Text = "bearbeiten";
            this.btnChangeMitarbeiter.UseVisualStyleBackColor = true;
            this.btnChangeMitarbeiter.Click += new System.EventHandler(this.btnChangeMitarbeiter_Click);
            // 
            // btnDeleteMitarbeiter
            // 
            this.btnDeleteMitarbeiter.Location = new System.Drawing.Point(439, 154);
            this.btnDeleteMitarbeiter.Name = "btnDeleteMitarbeiter";
            this.btnDeleteMitarbeiter.Size = new System.Drawing.Size(155, 23);
            this.btnDeleteMitarbeiter.TabIndex = 9;
            this.btnDeleteMitarbeiter.Text = "löschen";
            this.btnDeleteMitarbeiter.UseVisualStyleBackColor = true;
            this.btnDeleteMitarbeiter.Click += new System.EventHandler(this.btnDeleteMitarbeiter_Click);
            // 
            // btnClearMitarbeiter
            // 
            this.btnClearMitarbeiter.Location = new System.Drawing.Point(632, 154);
            this.btnClearMitarbeiter.Name = "btnClearMitarbeiter";
            this.btnClearMitarbeiter.Size = new System.Drawing.Size(155, 23);
            this.btnClearMitarbeiter.TabIndex = 10;
            this.btnClearMitarbeiter.Text = "Felder leeren";
            this.btnClearMitarbeiter.UseVisualStyleBackColor = true;
            this.btnClearMitarbeiter.Click += new System.EventHandler(this.btnClearMitarbeiter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 550);
            this.Controls.Add(this.btnClearMitarbeiter);
            this.Controls.Add(this.btnDeleteMitarbeiter);
            this.Controls.Add(this.btnChangeMitarbeiter);
            this.Controls.Add(this.btnSaveMitarbeiter);
            this.Controls.Add(this.geschlechtLabel);
            this.Controls.Add(this.geschlechtDropdown);
            this.Controls.Add(this.nachnameInput);
            this.Controls.Add(this.nachnameLabel);
            this.Controls.Add(this.vornameLabel);
            this.Controls.Add(this.vornameInput);
            this.Controls.Add(this.MitarbeiterDB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mitarbeiterverwaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MitarbeiterDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridView MitarbeiterDB;
        private System.Windows.Forms.TextBox vornameInput;
        private System.Windows.Forms.Label vornameLabel;
        private System.Windows.Forms.Label nachnameLabel;
        private System.Windows.Forms.TextBox nachnameInput;
        private System.Windows.Forms.ComboBox geschlechtDropdown;
        private System.Windows.Forms.Label geschlechtLabel;
        private System.Windows.Forms.Button btnSaveMitarbeiter;
        private System.Windows.Forms.Button btnChangeMitarbeiter;
        private System.Windows.Forms.Button btnDeleteMitarbeiter;
        private System.Windows.Forms.Button btnClearMitarbeiter;
    }
}

