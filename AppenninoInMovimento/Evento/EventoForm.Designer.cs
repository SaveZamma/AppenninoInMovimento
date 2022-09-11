namespace AppenninoInMovimento.Evento
{
    partial class EventoForm
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
            this.nome_lbl = new System.Windows.Forms.Label();
            this.nome_txtbox = new System.Windows.Forms.TextBox();
            this.pause_lbl = new System.Windows.Forms.Label();
            this.pause_num = new System.Windows.Forms.NumericUpDown();
            this.numPartecipanti_lbl = new System.Windows.Forms.Label();
            this.numPartecipanti_num = new System.Windows.Forms.NumericUpDown();
            this.quota_lbl = new System.Windows.Forms.Label();
            this.quota_txtbox = new System.Windows.Forms.TextBox();
            this.attivita_lbl = new System.Windows.Forms.Label();
            this.attivita_lv = new System.Windows.Forms.ListView();
            this.intrattenimento_lbl = new System.Windows.Forms.Label();
            this.intrattenimenti_lv = new System.Windows.Forms.ListView();
            this.modificaAttivita_btn = new System.Windows.Forms.Button();
            this.modificaIntrattenimento_btn = new System.Windows.Forms.Button();
            this.salva_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.subscribe_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pause_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPartecipanti_num)).BeginInit();
            this.SuspendLayout();
            // 
            // nome_lbl
            // 
            this.nome_lbl.AutoSize = true;
            this.nome_lbl.Location = new System.Drawing.Point(30, 29);
            this.nome_lbl.Name = "nome_lbl";
            this.nome_lbl.Size = new System.Drawing.Size(50, 20);
            this.nome_lbl.TabIndex = 0;
            this.nome_lbl.Text = "Nome";
            // 
            // nome_txtbox
            // 
            this.nome_txtbox.Location = new System.Drawing.Point(86, 26);
            this.nome_txtbox.Name = "nome_txtbox";
            this.nome_txtbox.Size = new System.Drawing.Size(340, 27);
            this.nome_txtbox.TabIndex = 1;
            // 
            // pause_lbl
            // 
            this.pause_lbl.AutoSize = true;
            this.pause_lbl.Location = new System.Drawing.Point(30, 77);
            this.pause_lbl.Name = "pause_lbl";
            this.pause_lbl.Size = new System.Drawing.Size(101, 20);
            this.pause_lbl.TabIndex = 2;
            this.pause_lbl.Text = "Pause Previste";
            // 
            // pause_num
            // 
            this.pause_num.Location = new System.Drawing.Point(137, 75);
            this.pause_num.Name = "pause_num";
            this.pause_num.Size = new System.Drawing.Size(150, 27);
            this.pause_num.TabIndex = 3;
            // 
            // numPartecipanti_lbl
            // 
            this.numPartecipanti_lbl.AutoSize = true;
            this.numPartecipanti_lbl.Location = new System.Drawing.Point(30, 122);
            this.numPartecipanti_lbl.Name = "numPartecipanti_lbl";
            this.numPartecipanti_lbl.Size = new System.Drawing.Size(145, 20);
            this.numPartecipanti_lbl.TabIndex = 3;
            this.numPartecipanti_lbl.Text = "Numero Partecipanti";
            // 
            // numPartecipanti_num
            // 
            this.numPartecipanti_num.Enabled = false;
            this.numPartecipanti_num.Location = new System.Drawing.Point(181, 120);
            this.numPartecipanti_num.Name = "numPartecipanti_num";
            this.numPartecipanti_num.Size = new System.Drawing.Size(150, 27);
            this.numPartecipanti_num.TabIndex = 4;
            // 
            // quota_lbl
            // 
            this.quota_lbl.AutoSize = true;
            this.quota_lbl.Location = new System.Drawing.Point(30, 167);
            this.quota_lbl.Name = "quota_lbl";
            this.quota_lbl.Size = new System.Drawing.Size(116, 20);
            this.quota_lbl.TabIndex = 5;
            this.quota_lbl.Text = "Quota Iscrizione";
            // 
            // quota_txtbox
            // 
            this.quota_txtbox.Enabled = false;
            this.quota_txtbox.Location = new System.Drawing.Point(152, 164);
            this.quota_txtbox.Name = "quota_txtbox";
            this.quota_txtbox.Size = new System.Drawing.Size(179, 27);
            this.quota_txtbox.TabIndex = 6;
            // 
            // attivita_lbl
            // 
            this.attivita_lbl.AutoSize = true;
            this.attivita_lbl.Location = new System.Drawing.Point(30, 214);
            this.attivita_lbl.Name = "attivita_lbl";
            this.attivita_lbl.Size = new System.Drawing.Size(112, 20);
            this.attivita_lbl.TabIndex = 7;
            this.attivita_lbl.Text = "Attività Previste";
            // 
            // attivita_lv
            // 
            this.attivita_lv.Location = new System.Drawing.Point(30, 237);
            this.attivita_lv.Name = "attivita_lv";
            this.attivita_lv.Size = new System.Drawing.Size(396, 121);
            this.attivita_lv.TabIndex = 8;
            this.attivita_lv.UseCompatibleStateImageBehavior = false;
            // 
            // intrattenimento_lbl
            // 
            this.intrattenimento_lbl.AutoSize = true;
            this.intrattenimento_lbl.Location = new System.Drawing.Point(30, 380);
            this.intrattenimento_lbl.Name = "intrattenimento_lbl";
            this.intrattenimento_lbl.Size = new System.Drawing.Size(112, 20);
            this.intrattenimento_lbl.TabIndex = 9;
            this.intrattenimento_lbl.Text = "Intrattenimento";
            // 
            // intrattenimenti_lv
            // 
            this.intrattenimenti_lv.Location = new System.Drawing.Point(30, 403);
            this.intrattenimenti_lv.Name = "intrattenimenti_lv";
            this.intrattenimenti_lv.Size = new System.Drawing.Size(396, 121);
            this.intrattenimenti_lv.TabIndex = 10;
            this.intrattenimenti_lv.UseCompatibleStateImageBehavior = false;
            // 
            // modificaAttivita_btn
            // 
            this.modificaAttivita_btn.Location = new System.Drawing.Point(332, 205);
            this.modificaAttivita_btn.Name = "modificaAttivita_btn";
            this.modificaAttivita_btn.Size = new System.Drawing.Size(94, 29);
            this.modificaAttivita_btn.TabIndex = 11;
            this.modificaAttivita_btn.Text = "Modifica";
            this.modificaAttivita_btn.UseVisualStyleBackColor = true;
            // 
            // modificaIntrattenimento_btn
            // 
            this.modificaIntrattenimento_btn.Location = new System.Drawing.Point(332, 371);
            this.modificaIntrattenimento_btn.Name = "modificaIntrattenimento_btn";
            this.modificaIntrattenimento_btn.Size = new System.Drawing.Size(94, 29);
            this.modificaIntrattenimento_btn.TabIndex = 12;
            this.modificaIntrattenimento_btn.Text = "Modifica";
            this.modificaIntrattenimento_btn.UseVisualStyleBackColor = true;
            // 
            // salva_btn
            // 
            this.salva_btn.Location = new System.Drawing.Point(217, 566);
            this.salva_btn.Name = "salva_btn";
            this.salva_btn.Size = new System.Drawing.Size(94, 29);
            this.salva_btn.TabIndex = 13;
            this.salva_btn.Text = "Salva";
            this.salva_btn.UseVisualStyleBackColor = true;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(332, 566);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(94, 29);
            this.exit_btn.TabIndex = 14;
            this.exit_btn.Text = "Esci";
            this.exit_btn.UseVisualStyleBackColor = true;
            // 
            // subscribe_btn
            // 
            this.subscribe_btn.Location = new System.Drawing.Point(101, 566);
            this.subscribe_btn.Name = "subscribe_btn";
            this.subscribe_btn.Size = new System.Drawing.Size(94, 29);
            this.subscribe_btn.TabIndex = 15;
            this.subscribe_btn.Text = "Iscriviti";
            this.subscribe_btn.UseVisualStyleBackColor = true;
            // 
            // EventoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 607);
            this.Controls.Add(this.subscribe_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.salva_btn);
            this.Controls.Add(this.modificaIntrattenimento_btn);
            this.Controls.Add(this.modificaAttivita_btn);
            this.Controls.Add(this.intrattenimenti_lv);
            this.Controls.Add(this.intrattenimento_lbl);
            this.Controls.Add(this.attivita_lv);
            this.Controls.Add(this.attivita_lbl);
            this.Controls.Add(this.quota_txtbox);
            this.Controls.Add(this.quota_lbl);
            this.Controls.Add(this.numPartecipanti_num);
            this.Controls.Add(this.numPartecipanti_lbl);
            this.Controls.Add(this.pause_num);
            this.Controls.Add(this.pause_lbl);
            this.Controls.Add(this.nome_txtbox);
            this.Controls.Add(this.nome_lbl);
            this.Name = "EventoForm";
            this.Text = "EventoForm";
            ((System.ComponentModel.ISupportInitialize)(this.pause_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPartecipanti_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nome_lbl;
        private TextBox nome_txtbox;
        private Label pause_lbl;
        private NumericUpDown pause_num;
        private Label numPartecipanti_lbl;
        private NumericUpDown numPartecipanti_num;
        private Label quota_lbl;
        private TextBox quota_txtbox;
        private Label attivita_lbl;
        private ListView attivita_lv;
        private Label intrattenimento_lbl;
        private ListView intrattenimenti_lv;
        private Button modificaAttivita_btn;
        private Button modificaIntrattenimento_btn;
        private Button salva_btn;
        private Button exit_btn;
        private Button subscribe_btn;
    }
}