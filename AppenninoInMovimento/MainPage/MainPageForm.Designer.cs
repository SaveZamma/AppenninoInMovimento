namespace AppenninoInMovimento.MainPage
{
    partial class MainPageForm
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
            this.modificaDatiUtente_btn = new System.Windows.Forms.Button();
            this.ricercaAttivita_btn = new System.Windows.Forms.Button();
            this.descrizioneAttivita_lbl = new System.Windows.Forms.Label();
            this.descrizioneAttivita_txtbox = new System.Windows.Forms.TextBox();
            this.difficolta_lbl = new System.Windows.Forms.Label();
            this.difficolta_num = new System.Windows.Forms.NumericUpDown();
            this.numPartecipanti_num = new System.Windows.Forms.NumericUpDown();
            this.numPartecipanti_lbl = new System.Windows.Forms.Label();
            this.createAttivita_btn = new System.Windows.Forms.Button();
            this.periodo_lbl = new System.Windows.Forms.Label();
            this.periodo_tb = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.nome_tb = new System.Windows.Forms.TextBox();
            this.nome_lbl = new System.Windows.Forms.Label();
            this.cognome_lbl = new System.Windows.Forms.Label();
            this.cognome_tb = new System.Windows.Forms.TextBox();
            this.searchUser_btn = new System.Windows.Forms.Button();
            this.searchEvents_btn = new System.Windows.Forms.Button();
            this.eventoDescrizione_lbl = new System.Windows.Forms.Label();
            this.eventoDescrizione_tb = new System.Windows.Forms.TextBox();
            this.nuovoEvento_btn = new System.Windows.Forms.Button();
            this.nuovoGruppo_btn = new System.Windows.Forms.Button();
            this.descrizioneGruppo_tb = new System.Windows.Forms.TextBox();
            this.descrizioneGruppo_lbl = new System.Windows.Forms.Label();
            this.searchGroup_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.difficolta_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPartecipanti_num)).BeginInit();
            this.SuspendLayout();
            // 
            // modificaDatiUtente_btn
            // 
            this.modificaDatiUtente_btn.Location = new System.Drawing.Point(26, 818);
            this.modificaDatiUtente_btn.Name = "modificaDatiUtente_btn";
            this.modificaDatiUtente_btn.Size = new System.Drawing.Size(228, 29);
            this.modificaDatiUtente_btn.TabIndex = 0;
            this.modificaDatiUtente_btn.Text = "Modifica Dati Personali";
            this.modificaDatiUtente_btn.UseVisualStyleBackColor = true;
            this.modificaDatiUtente_btn.Click += new System.EventHandler(this.modificaDatiUtente_btn_Click);
            // 
            // ricercaAttivita_btn
            // 
            this.ricercaAttivita_btn.Location = new System.Drawing.Point(64, 176);
            this.ricercaAttivita_btn.Name = "ricercaAttivita_btn";
            this.ricercaAttivita_btn.Size = new System.Drawing.Size(190, 29);
            this.ricercaAttivita_btn.TabIndex = 1;
            this.ricercaAttivita_btn.Text = "Cerca Attività";
            this.ricercaAttivita_btn.UseVisualStyleBackColor = true;
            this.ricercaAttivita_btn.Click += new System.EventHandler(this.ricercaAttivita_btn_Click);
            // 
            // descrizioneAttivita_lbl
            // 
            this.descrizioneAttivita_lbl.AutoSize = true;
            this.descrizioneAttivita_lbl.Location = new System.Drawing.Point(26, 21);
            this.descrizioneAttivita_lbl.Name = "descrizioneAttivita_lbl";
            this.descrizioneAttivita_lbl.Size = new System.Drawing.Size(86, 20);
            this.descrizioneAttivita_lbl.TabIndex = 2;
            this.descrizioneAttivita_lbl.Text = "Descrizione";
            // 
            // descrizioneAttivita_txtbox
            // 
            this.descrizioneAttivita_txtbox.Location = new System.Drawing.Point(177, 18);
            this.descrizioneAttivita_txtbox.Name = "descrizioneAttivita_txtbox";
            this.descrizioneAttivita_txtbox.Size = new System.Drawing.Size(254, 27);
            this.descrizioneAttivita_txtbox.TabIndex = 5;
            // 
            // difficolta_lbl
            // 
            this.difficolta_lbl.AutoSize = true;
            this.difficolta_lbl.Location = new System.Drawing.Point(26, 64);
            this.difficolta_lbl.Name = "difficolta_lbl";
            this.difficolta_lbl.Size = new System.Drawing.Size(71, 20);
            this.difficolta_lbl.TabIndex = 6;
            this.difficolta_lbl.Text = "Difficolta";
            // 
            // difficolta_num
            // 
            this.difficolta_num.Location = new System.Drawing.Point(177, 62);
            this.difficolta_num.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.difficolta_num.Name = "difficolta_num";
            this.difficolta_num.Size = new System.Drawing.Size(150, 27);
            this.difficolta_num.TabIndex = 7;
            // 
            // numPartecipanti_num
            // 
            this.numPartecipanti_num.Location = new System.Drawing.Point(177, 95);
            this.numPartecipanti_num.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPartecipanti_num.Name = "numPartecipanti_num";
            this.numPartecipanti_num.Size = new System.Drawing.Size(150, 27);
            this.numPartecipanti_num.TabIndex = 9;
            // 
            // numPartecipanti_lbl
            // 
            this.numPartecipanti_lbl.AutoSize = true;
            this.numPartecipanti_lbl.Location = new System.Drawing.Point(26, 97);
            this.numPartecipanti_lbl.Name = "numPartecipanti_lbl";
            this.numPartecipanti_lbl.Size = new System.Drawing.Size(145, 20);
            this.numPartecipanti_lbl.TabIndex = 8;
            this.numPartecipanti_lbl.Text = "Numero Partecipanti";
            // 
            // createAttivita_btn
            // 
            this.createAttivita_btn.Location = new System.Drawing.Point(274, 176);
            this.createAttivita_btn.Name = "createAttivita_btn";
            this.createAttivita_btn.Size = new System.Drawing.Size(119, 29);
            this.createAttivita_btn.TabIndex = 10;
            this.createAttivita_btn.Text = "Nuova Attività";
            this.createAttivita_btn.UseVisualStyleBackColor = true;
            this.createAttivita_btn.Click += new System.EventHandler(this.createAttivita_btn_Click);
            // 
            // periodo_lbl
            // 
            this.periodo_lbl.AutoSize = true;
            this.periodo_lbl.Location = new System.Drawing.Point(26, 130);
            this.periodo_lbl.Name = "periodo_lbl";
            this.periodo_lbl.Size = new System.Drawing.Size(60, 20);
            this.periodo_lbl.TabIndex = 11;
            this.periodo_lbl.Text = "Periodo";
            // 
            // periodo_tb
            // 
            this.periodo_tb.Location = new System.Drawing.Point(177, 127);
            this.periodo_tb.Name = "periodo_tb";
            this.periodo_tb.Size = new System.Drawing.Size(254, 27);
            this.periodo_tb.TabIndex = 12;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(491, 21);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(75, 20);
            this.username_lbl.TabIndex = 13;
            this.username_lbl.Text = "Username";
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(578, 18);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(224, 27);
            this.username_tb.TabIndex = 14;
            // 
            // nome_tb
            // 
            this.nome_tb.Location = new System.Drawing.Point(578, 57);
            this.nome_tb.Name = "nome_tb";
            this.nome_tb.Size = new System.Drawing.Size(224, 27);
            this.nome_tb.TabIndex = 16;
            // 
            // nome_lbl
            // 
            this.nome_lbl.AutoSize = true;
            this.nome_lbl.Location = new System.Drawing.Point(491, 60);
            this.nome_lbl.Name = "nome_lbl";
            this.nome_lbl.Size = new System.Drawing.Size(50, 20);
            this.nome_lbl.TabIndex = 15;
            this.nome_lbl.Text = "Nome";
            // 
            // cognome_lbl
            // 
            this.cognome_lbl.AutoSize = true;
            this.cognome_lbl.Location = new System.Drawing.Point(491, 100);
            this.cognome_lbl.Name = "cognome_lbl";
            this.cognome_lbl.Size = new System.Drawing.Size(74, 20);
            this.cognome_lbl.TabIndex = 17;
            this.cognome_lbl.Text = "Cognome";
            // 
            // cognome_tb
            // 
            this.cognome_tb.Location = new System.Drawing.Point(578, 97);
            this.cognome_tb.Name = "cognome_tb";
            this.cognome_tb.Size = new System.Drawing.Size(224, 27);
            this.cognome_tb.TabIndex = 18;
            // 
            // searchUser_btn
            // 
            this.searchUser_btn.Location = new System.Drawing.Point(578, 176);
            this.searchUser_btn.Name = "searchUser_btn";
            this.searchUser_btn.Size = new System.Drawing.Size(190, 29);
            this.searchUser_btn.TabIndex = 19;
            this.searchUser_btn.Text = "Cerca Utente";
            this.searchUser_btn.UseVisualStyleBackColor = true;
            this.searchUser_btn.Click += new System.EventHandler(this.searchUser_btn_Click);
            // 
            // searchEvents_btn
            // 
            this.searchEvents_btn.Location = new System.Drawing.Point(902, 51);
            this.searchEvents_btn.Name = "searchEvents_btn";
            this.searchEvents_btn.Size = new System.Drawing.Size(180, 29);
            this.searchEvents_btn.TabIndex = 20;
            this.searchEvents_btn.Text = "Cerca Eventi";
            this.searchEvents_btn.UseVisualStyleBackColor = true;
            this.searchEvents_btn.Click += new System.EventHandler(this.searchEvents_btn_Click);
            // 
            // eventoDescrizione_lbl
            // 
            this.eventoDescrizione_lbl.AutoSize = true;
            this.eventoDescrizione_lbl.Location = new System.Drawing.Point(888, 21);
            this.eventoDescrizione_lbl.Name = "eventoDescrizione_lbl";
            this.eventoDescrizione_lbl.Size = new System.Drawing.Size(86, 20);
            this.eventoDescrizione_lbl.TabIndex = 21;
            this.eventoDescrizione_lbl.Text = "Descrizione";
            // 
            // eventoDescrizione_tb
            // 
            this.eventoDescrizione_tb.Location = new System.Drawing.Point(990, 18);
            this.eventoDescrizione_tb.Name = "eventoDescrizione_tb";
            this.eventoDescrizione_tb.Size = new System.Drawing.Size(224, 27);
            this.eventoDescrizione_tb.TabIndex = 22;
            // 
            // nuovoEvento_btn
            // 
            this.nuovoEvento_btn.Location = new System.Drawing.Point(1099, 51);
            this.nuovoEvento_btn.Name = "nuovoEvento_btn";
            this.nuovoEvento_btn.Size = new System.Drawing.Size(115, 29);
            this.nuovoEvento_btn.TabIndex = 23;
            this.nuovoEvento_btn.Text = "Nuovo Evento";
            this.nuovoEvento_btn.UseVisualStyleBackColor = true;
            this.nuovoEvento_btn.Click += new System.EventHandler(this.nuovoEvento_btn_Click);
            // 
            // nuovoGruppo_btn
            // 
            this.nuovoGruppo_btn.Location = new System.Drawing.Point(1099, 176);
            this.nuovoGruppo_btn.Name = "nuovoGruppo_btn";
            this.nuovoGruppo_btn.Size = new System.Drawing.Size(115, 29);
            this.nuovoGruppo_btn.TabIndex = 27;
            this.nuovoGruppo_btn.Text = "Nuovo Gruppo";
            this.nuovoGruppo_btn.UseVisualStyleBackColor = true;
            this.nuovoGruppo_btn.Click += new System.EventHandler(this.nuovoGruppo_btn_Click);
            // 
            // descrizioneGruppo_tb
            // 
            this.descrizioneGruppo_tb.Location = new System.Drawing.Point(990, 143);
            this.descrizioneGruppo_tb.Name = "descrizioneGruppo_tb";
            this.descrizioneGruppo_tb.Size = new System.Drawing.Size(224, 27);
            this.descrizioneGruppo_tb.TabIndex = 26;
            // 
            // descrizioneGruppo_lbl
            // 
            this.descrizioneGruppo_lbl.AutoSize = true;
            this.descrizioneGruppo_lbl.Location = new System.Drawing.Point(888, 146);
            this.descrizioneGruppo_lbl.Name = "descrizioneGruppo_lbl";
            this.descrizioneGruppo_lbl.Size = new System.Drawing.Size(50, 20);
            this.descrizioneGruppo_lbl.TabIndex = 25;
            this.descrizioneGruppo_lbl.Text = "Nome";
            // 
            // searchGroup_btn
            // 
            this.searchGroup_btn.Location = new System.Drawing.Point(902, 176);
            this.searchGroup_btn.Name = "searchGroup_btn";
            this.searchGroup_btn.Size = new System.Drawing.Size(180, 29);
            this.searchGroup_btn.TabIndex = 24;
            this.searchGroup_btn.Text = "Cerca Gruppi";
            this.searchGroup_btn.UseVisualStyleBackColor = true;
            this.searchGroup_btn.Click += new System.EventHandler(this.searchGroup_btn_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 859);
            this.Controls.Add(this.nuovoGruppo_btn);
            this.Controls.Add(this.descrizioneGruppo_tb);
            this.Controls.Add(this.descrizioneGruppo_lbl);
            this.Controls.Add(this.searchGroup_btn);
            this.Controls.Add(this.nuovoEvento_btn);
            this.Controls.Add(this.eventoDescrizione_tb);
            this.Controls.Add(this.eventoDescrizione_lbl);
            this.Controls.Add(this.searchEvents_btn);
            this.Controls.Add(this.searchUser_btn);
            this.Controls.Add(this.cognome_tb);
            this.Controls.Add(this.cognome_lbl);
            this.Controls.Add(this.nome_tb);
            this.Controls.Add(this.nome_lbl);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.periodo_tb);
            this.Controls.Add(this.periodo_lbl);
            this.Controls.Add(this.createAttivita_btn);
            this.Controls.Add(this.numPartecipanti_num);
            this.Controls.Add(this.numPartecipanti_lbl);
            this.Controls.Add(this.difficolta_num);
            this.Controls.Add(this.difficolta_lbl);
            this.Controls.Add(this.descrizioneAttivita_txtbox);
            this.Controls.Add(this.descrizioneAttivita_lbl);
            this.Controls.Add(this.ricercaAttivita_btn);
            this.Controls.Add(this.modificaDatiUtente_btn);
            this.Name = "MainPageForm";
            this.Text = "Appennino in Movimento - ";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.difficolta_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPartecipanti_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button modificaDatiUtente_btn;
        private Button ricercaAttivita_btn;
        private Label descrizioneAttivita_lbl;
        private TextBox descrizioneAttivita_txtbox;
        private Label difficolta_lbl;
        private NumericUpDown difficolta_num;
        private NumericUpDown numPartecipanti_num;
        private Label numPartecipanti_lbl;
        private Button createAttivita_btn;
        private Label periodo_lbl;
        private TextBox periodo_tb;
        private Label username_lbl;
        private TextBox username_tb;
        private TextBox nome_tb;
        private Label nome_lbl;
        private Label cognome_lbl;
        private TextBox cognome_tb;
        private Button searchUser_btn;
        private Button searchEvents_btn;
        private Label eventoDescrizione_lbl;
        private TextBox eventoDescrizione_tb;
        private Button nuovoEvento_btn;
        private Button nuovoGruppo_btn;
        private TextBox descrizioneGruppo_tb;
        private Label descrizioneGruppo_lbl;
        private Button searchGroup_btn;
    }
}