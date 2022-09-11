namespace AppenninoInMovimento.Attivita
{
    partial class AttivitaForm
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
            this.descrizione_lbl = new System.Windows.Forms.Label();
            this.dataInizio_lbl = new System.Windows.Forms.Label();
            this.dataFine_lbl = new System.Windows.Forms.Label();
            this.durata_lbl = new System.Windows.Forms.Label();
            this.difficolata_lbl = new System.Windows.Forms.Label();
            this.periodoConsigliato_lbl = new System.Windows.Forms.Label();
            this.partecipanti_lbl = new System.Windows.Forms.Label();
            this.vestiario_lbl = new System.Windows.Forms.Label();
            this.attrezzaturaMovimento_lbl = new System.Windows.Forms.Label();
            this.attrezzaturaRiposo_lbl = new System.Windows.Forms.Label();
            this.pasti_lbl = new System.Windows.Forms.Label();
            this.zaino_lbl = new System.Windows.Forms.Label();
            this.pesoZaino_lbl = new System.Windows.Forms.Label();
            this.descrizione_txtbox = new System.Windows.Forms.TextBox();
            this.dataInizio_datepk = new System.Windows.Forms.DateTimePicker();
            this.dataFine_datepk = new System.Windows.Forms.DateTimePicker();
            this.durata_num = new System.Windows.Forms.NumericUpDown();
            this.difficolta_num = new System.Windows.Forms.NumericUpDown();
            this.periodoConsigliato_txtbox = new System.Windows.Forms.TextBox();
            this.numPartecipanti_num = new System.Windows.Forms.NumericUpDown();
            this.zaino_txtbox = new System.Windows.Forms.TextBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.percorso_lbl = new System.Windows.Forms.Label();
            this.luogo_tb = new System.Windows.Forms.TextBox();
            this.luogo_lbl = new System.Windows.Forms.Label();
            this.modificaPercorso_btn = new System.Windows.Forms.Button();
            this.join_btn = new System.Windows.Forms.Button();
            this.pasti_tb = new System.Windows.Forms.TextBox();
            this.vestiario_tb = new System.Windows.Forms.TextBox();
            this.movimento_tb = new System.Windows.Forms.TextBox();
            this.riposo_tb = new System.Windows.Forms.TextBox();
            this.percorso_lv = new System.Windows.Forms.ListView();
            this.pesoZaino_num = new System.Windows.Forms.NumericUpDown();
            this.modificaLuogo_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.durata_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficolta_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPartecipanti_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoZaino_num)).BeginInit();
            this.SuspendLayout();
            // 
            // descrizione_lbl
            // 
            this.descrizione_lbl.AutoSize = true;
            this.descrizione_lbl.Location = new System.Drawing.Point(34, 25);
            this.descrizione_lbl.Name = "descrizione_lbl";
            this.descrizione_lbl.Size = new System.Drawing.Size(86, 20);
            this.descrizione_lbl.TabIndex = 0;
            this.descrizione_lbl.Text = "Descrizione";
            // 
            // dataInizio_lbl
            // 
            this.dataInizio_lbl.AutoSize = true;
            this.dataInizio_lbl.Location = new System.Drawing.Point(34, 70);
            this.dataInizio_lbl.Name = "dataInizio_lbl";
            this.dataInizio_lbl.Size = new System.Drawing.Size(81, 20);
            this.dataInizio_lbl.TabIndex = 1;
            this.dataInizio_lbl.Text = "Data Inizio";
            // 
            // dataFine_lbl
            // 
            this.dataFine_lbl.AutoSize = true;
            this.dataFine_lbl.Location = new System.Drawing.Point(34, 114);
            this.dataFine_lbl.Name = "dataFine_lbl";
            this.dataFine_lbl.Size = new System.Drawing.Size(72, 20);
            this.dataFine_lbl.TabIndex = 2;
            this.dataFine_lbl.Text = "Data Fine";
            // 
            // durata_lbl
            // 
            this.durata_lbl.AutoSize = true;
            this.durata_lbl.Location = new System.Drawing.Point(34, 155);
            this.durata_lbl.Name = "durata_lbl";
            this.durata_lbl.Size = new System.Drawing.Size(76, 20);
            this.durata_lbl.TabIndex = 3;
            this.durata_lbl.Text = "Durata [h]";
            // 
            // difficolata_lbl
            // 
            this.difficolata_lbl.AutoSize = true;
            this.difficolata_lbl.Location = new System.Drawing.Point(34, 200);
            this.difficolata_lbl.Name = "difficolata_lbl";
            this.difficolata_lbl.Size = new System.Drawing.Size(71, 20);
            this.difficolata_lbl.TabIndex = 4;
            this.difficolata_lbl.Text = "Difficoltà";
            // 
            // periodoConsigliato_lbl
            // 
            this.periodoConsigliato_lbl.AutoSize = true;
            this.periodoConsigliato_lbl.Location = new System.Drawing.Point(34, 241);
            this.periodoConsigliato_lbl.Name = "periodoConsigliato_lbl";
            this.periodoConsigliato_lbl.Size = new System.Drawing.Size(139, 20);
            this.periodoConsigliato_lbl.TabIndex = 5;
            this.periodoConsigliato_lbl.Text = "Periodo Consigliato";
            // 
            // partecipanti_lbl
            // 
            this.partecipanti_lbl.AutoSize = true;
            this.partecipanti_lbl.Location = new System.Drawing.Point(34, 286);
            this.partecipanti_lbl.Name = "partecipanti_lbl";
            this.partecipanti_lbl.Size = new System.Drawing.Size(224, 20);
            this.partecipanti_lbl.TabIndex = 6;
            this.partecipanti_lbl.Text = "Numero Partecipanti Consigliato";
            // 
            // vestiario_lbl
            // 
            this.vestiario_lbl.AutoSize = true;
            this.vestiario_lbl.Location = new System.Drawing.Point(550, 25);
            this.vestiario_lbl.Name = "vestiario_lbl";
            this.vestiario_lbl.Size = new System.Drawing.Size(66, 20);
            this.vestiario_lbl.TabIndex = 7;
            this.vestiario_lbl.Text = "Vestiario";
            // 
            // attrezzaturaMovimento_lbl
            // 
            this.attrezzaturaMovimento_lbl.AutoSize = true;
            this.attrezzaturaMovimento_lbl.Location = new System.Drawing.Point(550, 198);
            this.attrezzaturaMovimento_lbl.Name = "attrezzaturaMovimento_lbl";
            this.attrezzaturaMovimento_lbl.Size = new System.Drawing.Size(170, 20);
            this.attrezzaturaMovimento_lbl.TabIndex = 8;
            this.attrezzaturaMovimento_lbl.Text = "Attrezzatura Movimento";
            // 
            // attrezzaturaRiposo_lbl
            // 
            this.attrezzaturaRiposo_lbl.AutoSize = true;
            this.attrezzaturaRiposo_lbl.Location = new System.Drawing.Point(550, 369);
            this.attrezzaturaRiposo_lbl.Name = "attrezzaturaRiposo_lbl";
            this.attrezzaturaRiposo_lbl.Size = new System.Drawing.Size(178, 20);
            this.attrezzaturaRiposo_lbl.TabIndex = 9;
            this.attrezzaturaRiposo_lbl.Text = "Attrezzatura per il Riposo";
            // 
            // pasti_lbl
            // 
            this.pasti_lbl.AutoSize = true;
            this.pasti_lbl.Location = new System.Drawing.Point(34, 425);
            this.pasti_lbl.Name = "pasti_lbl";
            this.pasti_lbl.Size = new System.Drawing.Size(39, 20);
            this.pasti_lbl.TabIndex = 10;
            this.pasti_lbl.Text = "Pasti";
            // 
            // zaino_lbl
            // 
            this.zaino_lbl.AutoSize = true;
            this.zaino_lbl.Location = new System.Drawing.Point(34, 334);
            this.zaino_lbl.Name = "zaino_lbl";
            this.zaino_lbl.Size = new System.Drawing.Size(47, 20);
            this.zaino_lbl.TabIndex = 11;
            this.zaino_lbl.Text = "Zaino";
            // 
            // pesoZaino_lbl
            // 
            this.pesoZaino_lbl.AutoSize = true;
            this.pesoZaino_lbl.Location = new System.Drawing.Point(34, 380);
            this.pesoZaino_lbl.Name = "pesoZaino_lbl";
            this.pesoZaino_lbl.Size = new System.Drawing.Size(104, 20);
            this.pesoZaino_lbl.TabIndex = 12;
            this.pesoZaino_lbl.Text = "Peso Zaino [g]";
            // 
            // descrizione_txtbox
            // 
            this.descrizione_txtbox.Location = new System.Drawing.Point(126, 22);
            this.descrizione_txtbox.Name = "descrizione_txtbox";
            this.descrizione_txtbox.Size = new System.Drawing.Size(340, 27);
            this.descrizione_txtbox.TabIndex = 13;
            // 
            // dataInizio_datepk
            // 
            this.dataInizio_datepk.Location = new System.Drawing.Point(126, 65);
            this.dataInizio_datepk.Name = "dataInizio_datepk";
            this.dataInizio_datepk.Size = new System.Drawing.Size(340, 27);
            this.dataInizio_datepk.TabIndex = 14;
            // 
            // dataFine_datepk
            // 
            this.dataFine_datepk.Location = new System.Drawing.Point(126, 109);
            this.dataFine_datepk.Name = "dataFine_datepk";
            this.dataFine_datepk.Size = new System.Drawing.Size(340, 27);
            this.dataFine_datepk.TabIndex = 15;
            // 
            // durata_num
            // 
            this.durata_num.DecimalPlaces = 2;
            this.durata_num.Location = new System.Drawing.Point(126, 153);
            this.durata_num.Name = "durata_num";
            this.durata_num.Size = new System.Drawing.Size(150, 27);
            this.durata_num.TabIndex = 16;
            // 
            // difficolta_num
            // 
            this.difficolta_num.Location = new System.Drawing.Point(126, 198);
            this.difficolta_num.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.difficolta_num.Name = "difficolta_num";
            this.difficolta_num.Size = new System.Drawing.Size(150, 27);
            this.difficolta_num.TabIndex = 17;
            // 
            // periodoConsigliato_txtbox
            // 
            this.periodoConsigliato_txtbox.Location = new System.Drawing.Point(188, 238);
            this.periodoConsigliato_txtbox.Name = "periodoConsigliato_txtbox";
            this.periodoConsigliato_txtbox.Size = new System.Drawing.Size(278, 27);
            this.periodoConsigliato_txtbox.TabIndex = 18;
            // 
            // numPartecipanti_num
            // 
            this.numPartecipanti_num.Location = new System.Drawing.Point(274, 279);
            this.numPartecipanti_num.Name = "numPartecipanti_num";
            this.numPartecipanti_num.Size = new System.Drawing.Size(192, 27);
            this.numPartecipanti_num.TabIndex = 19;
            // 
            // zaino_txtbox
            // 
            this.zaino_txtbox.Location = new System.Drawing.Point(126, 331);
            this.zaino_txtbox.Name = "zaino_txtbox";
            this.zaino_txtbox.Size = new System.Drawing.Size(340, 27);
            this.zaino_txtbox.TabIndex = 23;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(1042, 692);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(94, 29);
            this.exit_btn.TabIndex = 30;
            this.exit_btn.Text = "Esci";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(942, 692);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(94, 29);
            this.save_btn.TabIndex = 31;
            this.save_btn.Text = "Salva";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // percorso_lbl
            // 
            this.percorso_lbl.AutoSize = true;
            this.percorso_lbl.Location = new System.Drawing.Point(34, 602);
            this.percorso_lbl.Name = "percorso_lbl";
            this.percorso_lbl.Size = new System.Drawing.Size(65, 20);
            this.percorso_lbl.TabIndex = 32;
            this.percorso_lbl.Text = "Percorso";
            // 
            // luogo_tb
            // 
            this.luogo_tb.Enabled = false;
            this.luogo_tb.Location = new System.Drawing.Point(91, 535);
            this.luogo_tb.Name = "luogo_tb";
            this.luogo_tb.Size = new System.Drawing.Size(429, 27);
            this.luogo_tb.TabIndex = 35;
            // 
            // luogo_lbl
            // 
            this.luogo_lbl.AutoSize = true;
            this.luogo_lbl.Location = new System.Drawing.Point(34, 538);
            this.luogo_lbl.Name = "luogo_lbl";
            this.luogo_lbl.Size = new System.Drawing.Size(51, 20);
            this.luogo_lbl.TabIndex = 34;
            this.luogo_lbl.Text = "Luogo";
            // 
            // modificaPercorso_btn
            // 
            this.modificaPercorso_btn.Location = new System.Drawing.Point(526, 590);
            this.modificaPercorso_btn.Name = "modificaPercorso_btn";
            this.modificaPercorso_btn.Size = new System.Drawing.Size(94, 29);
            this.modificaPercorso_btn.TabIndex = 36;
            this.modificaPercorso_btn.Text = "Modifica";
            this.modificaPercorso_btn.UseVisualStyleBackColor = true;
            this.modificaPercorso_btn.Click += new System.EventHandler(this.modificaPercorso_btn_Click);
            // 
            // join_btn
            // 
            this.join_btn.Location = new System.Drawing.Point(842, 692);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(94, 29);
            this.join_btn.TabIndex = 37;
            this.join_btn.Text = "Iscriviti";
            this.join_btn.UseVisualStyleBackColor = true;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // pasti_tb
            // 
            this.pasti_tb.Location = new System.Drawing.Point(34, 448);
            this.pasti_tb.Name = "pasti_tb";
            this.pasti_tb.Size = new System.Drawing.Size(432, 27);
            this.pasti_tb.TabIndex = 38;
            // 
            // vestiario_tb
            // 
            this.vestiario_tb.Location = new System.Drawing.Point(550, 48);
            this.vestiario_tb.Name = "vestiario_tb";
            this.vestiario_tb.Size = new System.Drawing.Size(586, 27);
            this.vestiario_tb.TabIndex = 39;
            // 
            // movimento_tb
            // 
            this.movimento_tb.Location = new System.Drawing.Point(550, 221);
            this.movimento_tb.Name = "movimento_tb";
            this.movimento_tb.Size = new System.Drawing.Size(586, 27);
            this.movimento_tb.TabIndex = 40;
            // 
            // riposo_tb
            // 
            this.riposo_tb.Location = new System.Drawing.Point(550, 392);
            this.riposo_tb.Name = "riposo_tb";
            this.riposo_tb.Size = new System.Drawing.Size(586, 27);
            this.riposo_tb.TabIndex = 41;
            // 
            // percorso_lv
            // 
            this.percorso_lv.Location = new System.Drawing.Point(34, 625);
            this.percorso_lv.Name = "percorso_lv";
            this.percorso_lv.Size = new System.Drawing.Size(586, 121);
            this.percorso_lv.TabIndex = 33;
            this.percorso_lv.UseCompatibleStateImageBehavior = false;
            // 
            // pesoZaino_num
            // 
            this.pesoZaino_num.Location = new System.Drawing.Point(144, 378);
            this.pesoZaino_num.Name = "pesoZaino_num";
            this.pesoZaino_num.Size = new System.Drawing.Size(150, 27);
            this.pesoZaino_num.TabIndex = 42;
            // 
            // modificaLuogo_btn
            // 
            this.modificaLuogo_btn.Location = new System.Drawing.Point(526, 534);
            this.modificaLuogo_btn.Name = "modificaLuogo_btn";
            this.modificaLuogo_btn.Size = new System.Drawing.Size(94, 29);
            this.modificaLuogo_btn.TabIndex = 43;
            this.modificaLuogo_btn.Text = "Modifica";
            this.modificaLuogo_btn.UseVisualStyleBackColor = true;
            this.modificaLuogo_btn.Click += new System.EventHandler(this.modificaLuogo_btn_Click);
            // 
            // AttivitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 796);
            this.Controls.Add(this.modificaLuogo_btn);
            this.Controls.Add(this.pesoZaino_num);
            this.Controls.Add(this.riposo_tb);
            this.Controls.Add(this.movimento_tb);
            this.Controls.Add(this.vestiario_tb);
            this.Controls.Add(this.pasti_tb);
            this.Controls.Add(this.join_btn);
            this.Controls.Add(this.modificaPercorso_btn);
            this.Controls.Add(this.luogo_tb);
            this.Controls.Add(this.luogo_lbl);
            this.Controls.Add(this.percorso_lv);
            this.Controls.Add(this.percorso_lbl);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.zaino_txtbox);
            this.Controls.Add(this.numPartecipanti_num);
            this.Controls.Add(this.periodoConsigliato_txtbox);
            this.Controls.Add(this.difficolta_num);
            this.Controls.Add(this.durata_num);
            this.Controls.Add(this.dataFine_datepk);
            this.Controls.Add(this.dataInizio_datepk);
            this.Controls.Add(this.descrizione_txtbox);
            this.Controls.Add(this.pesoZaino_lbl);
            this.Controls.Add(this.zaino_lbl);
            this.Controls.Add(this.pasti_lbl);
            this.Controls.Add(this.attrezzaturaRiposo_lbl);
            this.Controls.Add(this.attrezzaturaMovimento_lbl);
            this.Controls.Add(this.vestiario_lbl);
            this.Controls.Add(this.partecipanti_lbl);
            this.Controls.Add(this.periodoConsigliato_lbl);
            this.Controls.Add(this.difficolata_lbl);
            this.Controls.Add(this.durata_lbl);
            this.Controls.Add(this.dataFine_lbl);
            this.Controls.Add(this.dataInizio_lbl);
            this.Controls.Add(this.descrizione_lbl);
            this.Name = "AttivitaForm";
            this.Text = "AttivitaForm";
            this.Load += new System.EventHandler(this.AttivitaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.durata_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficolta_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPartecipanti_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoZaino_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label descrizione_lbl;
        private Label dataInizio_lbl;
        private Label dataFine_lbl;
        private Label durata_lbl;
        private Label difficolata_lbl;
        private Label periodoConsigliato_lbl;
        private Label partecipanti_lbl;
        private Label vestiario_lbl;
        private Label attrezzaturaMovimento_lbl;
        private Label attrezzaturaRiposo_lbl;
        private Label pasti_lbl;
        private Label zaino_lbl;
        private Label pesoZaino_lbl;
        private TextBox descrizione_txtbox;
        private DateTimePicker dataInizio_datepk;
        private DateTimePicker dataFine_datepk;
        private NumericUpDown durata_num;
        private NumericUpDown difficolta_num;
        private TextBox periodoConsigliato_txtbox;
        private NumericUpDown numPartecipanti_num;
        private TextBox zaino_txtbox;
        private Button exit_btn;
        private Button save_btn;
        private Label percorso_lbl;
        private TextBox luogo_tb;
        private Label luogo_lbl;
        private Button modificaPercorso_btn;
        private Button join_btn;
        private TextBox pasti_tb;
        private TextBox vestiario_tb;
        private TextBox movimento_tb;
        private TextBox riposo_tb;
        private ListView percorso_lv;
        private NumericUpDown pesoZaino_num;
        private Button modificaLuogo_btn;
    }
}