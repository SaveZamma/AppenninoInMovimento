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
            this.vestiario_lv = new System.Windows.Forms.ListView();
            this.riposo_lv = new System.Windows.Forms.ListView();
            this.zaino_txtbox = new System.Windows.Forms.TextBox();
            this.pesoZaino_txtbox = new System.Windows.Forms.TextBox();
            this.pasti_lv = new System.Windows.Forms.ListView();
            this.attrezzatura_lv = new System.Windows.Forms.ListView();
            this.modificaPasti_btn = new System.Windows.Forms.Button();
            this.modificaVestiario_btn = new System.Windows.Forms.Button();
            this.modificaAttrezzaturaMovimento_btn = new System.Windows.Forms.Button();
            this.mdificaAttrezzaturaRiposo_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.percorso_lv = new System.Windows.Forms.ListView();
            this.percorso_lbl = new System.Windows.Forms.Label();
            this.luogo_tb = new System.Windows.Forms.TextBox();
            this.luogo_lbl = new System.Windows.Forms.Label();
            this.modificaPercorso_btn = new System.Windows.Forms.Button();
            this.join_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.durata_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficolta_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPartecipanti_num)).BeginInit();
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
            this.durata_lbl.Size = new System.Drawing.Size(54, 20);
            this.durata_lbl.TabIndex = 3;
            this.durata_lbl.Text = "Durata";
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
            this.pesoZaino_lbl.Size = new System.Drawing.Size(81, 20);
            this.pesoZaino_lbl.TabIndex = 12;
            this.pesoZaino_lbl.Text = "Peso Zaino";
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
            // vestiario_lv
            // 
            this.vestiario_lv.Location = new System.Drawing.Point(550, 48);
            this.vestiario_lv.Name = "vestiario_lv";
            this.vestiario_lv.Size = new System.Drawing.Size(586, 121);
            this.vestiario_lv.TabIndex = 21;
            this.vestiario_lv.UseCompatibleStateImageBehavior = false;
            // 
            // riposo_lv
            // 
            this.riposo_lv.Location = new System.Drawing.Point(550, 392);
            this.riposo_lv.Name = "riposo_lv";
            this.riposo_lv.Size = new System.Drawing.Size(586, 121);
            this.riposo_lv.TabIndex = 22;
            this.riposo_lv.UseCompatibleStateImageBehavior = false;
            // 
            // zaino_txtbox
            // 
            this.zaino_txtbox.Location = new System.Drawing.Point(126, 331);
            this.zaino_txtbox.Name = "zaino_txtbox";
            this.zaino_txtbox.Size = new System.Drawing.Size(340, 27);
            this.zaino_txtbox.TabIndex = 23;
            // 
            // pesoZaino_txtbox
            // 
            this.pesoZaino_txtbox.Location = new System.Drawing.Point(126, 377);
            this.pesoZaino_txtbox.Name = "pesoZaino_txtbox";
            this.pesoZaino_txtbox.Size = new System.Drawing.Size(340, 27);
            this.pesoZaino_txtbox.TabIndex = 24;
            // 
            // pasti_lv
            // 
            this.pasti_lv.Location = new System.Drawing.Point(34, 448);
            this.pasti_lv.Name = "pasti_lv";
            this.pasti_lv.Size = new System.Drawing.Size(432, 65);
            this.pasti_lv.TabIndex = 25;
            this.pasti_lv.UseCompatibleStateImageBehavior = false;
            // 
            // attrezzatura_lv
            // 
            this.attrezzatura_lv.Location = new System.Drawing.Point(550, 221);
            this.attrezzatura_lv.Name = "attrezzatura_lv";
            this.attrezzatura_lv.Size = new System.Drawing.Size(586, 121);
            this.attrezzatura_lv.TabIndex = 20;
            this.attrezzatura_lv.UseCompatibleStateImageBehavior = false;
            // 
            // modificaPasti_btn
            // 
            this.modificaPasti_btn.Location = new System.Drawing.Point(372, 416);
            this.modificaPasti_btn.Name = "modificaPasti_btn";
            this.modificaPasti_btn.Size = new System.Drawing.Size(94, 29);
            this.modificaPasti_btn.TabIndex = 26;
            this.modificaPasti_btn.Text = "Modifica";
            this.modificaPasti_btn.UseVisualStyleBackColor = true;
            this.modificaPasti_btn.Click += new System.EventHandler(this.modificaPasti_btn_Click);
            // 
            // modificaVestiario_btn
            // 
            this.modificaVestiario_btn.Location = new System.Drawing.Point(1042, 16);
            this.modificaVestiario_btn.Name = "modificaVestiario_btn";
            this.modificaVestiario_btn.Size = new System.Drawing.Size(94, 29);
            this.modificaVestiario_btn.TabIndex = 27;
            this.modificaVestiario_btn.Text = "Modifica";
            this.modificaVestiario_btn.UseVisualStyleBackColor = true;
            this.modificaVestiario_btn.Click += new System.EventHandler(this.modificaVestiario_btn_Click);
            // 
            // modificaAttrezzaturaMovimento_btn
            // 
            this.modificaAttrezzaturaMovimento_btn.Location = new System.Drawing.Point(1042, 189);
            this.modificaAttrezzaturaMovimento_btn.Name = "modificaAttrezzaturaMovimento_btn";
            this.modificaAttrezzaturaMovimento_btn.Size = new System.Drawing.Size(94, 29);
            this.modificaAttrezzaturaMovimento_btn.TabIndex = 28;
            this.modificaAttrezzaturaMovimento_btn.Text = "Modifica";
            this.modificaAttrezzaturaMovimento_btn.UseVisualStyleBackColor = true;
            this.modificaAttrezzaturaMovimento_btn.Click += new System.EventHandler(this.modificaAttrezzaturaMovimento_btn_Click);
            // 
            // mdificaAttrezzaturaRiposo_btn
            // 
            this.mdificaAttrezzaturaRiposo_btn.Location = new System.Drawing.Point(1042, 360);
            this.mdificaAttrezzaturaRiposo_btn.Name = "mdificaAttrezzaturaRiposo_btn";
            this.mdificaAttrezzaturaRiposo_btn.Size = new System.Drawing.Size(94, 29);
            this.mdificaAttrezzaturaRiposo_btn.TabIndex = 29;
            this.mdificaAttrezzaturaRiposo_btn.Text = "Modifica";
            this.mdificaAttrezzaturaRiposo_btn.UseVisualStyleBackColor = true;
            this.mdificaAttrezzaturaRiposo_btn.Click += new System.EventHandler(this.mdificaAttrezzaturaRiposo_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(1042, 692);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(94, 29);
            this.exit_btn.TabIndex = 30;
            this.exit_btn.Text = "Esci";
            this.exit_btn.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(942, 692);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(94, 29);
            this.save_btn.TabIndex = 31;
            this.save_btn.Text = "Salva";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // percorso_lv
            // 
            this.percorso_lv.Location = new System.Drawing.Point(34, 600);
            this.percorso_lv.Name = "percorso_lv";
            this.percorso_lv.Size = new System.Drawing.Size(586, 121);
            this.percorso_lv.TabIndex = 33;
            this.percorso_lv.UseCompatibleStateImageBehavior = false;
            // 
            // percorso_lbl
            // 
            this.percorso_lbl.AutoSize = true;
            this.percorso_lbl.Location = new System.Drawing.Point(34, 577);
            this.percorso_lbl.Name = "percorso_lbl";
            this.percorso_lbl.Size = new System.Drawing.Size(65, 20);
            this.percorso_lbl.TabIndex = 32;
            this.percorso_lbl.Text = "Percorso";
            // 
            // luogo_tb
            // 
            this.luogo_tb.Location = new System.Drawing.Point(126, 535);
            this.luogo_tb.Name = "luogo_tb";
            this.luogo_tb.Size = new System.Drawing.Size(340, 27);
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
            this.modificaPercorso_btn.Location = new System.Drawing.Point(526, 565);
            this.modificaPercorso_btn.Name = "modificaPercorso_btn";
            this.modificaPercorso_btn.Size = new System.Drawing.Size(94, 29);
            this.modificaPercorso_btn.TabIndex = 36;
            this.modificaPercorso_btn.Text = "Modifica";
            this.modificaPercorso_btn.UseVisualStyleBackColor = true;
            this.modificaPercorso_btn.Click += new System.EventHandler(this.modificaPercorso_btn_Click);
            // 
            // button1
            // 
            this.join_btn.Location = new System.Drawing.Point(842, 692);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(94, 29);
            this.join_btn.TabIndex = 37;
            this.join_btn.Text = "Iscriviti";
            this.join_btn.UseVisualStyleBackColor = true;
            // 
            // AttivitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 796);
            this.Controls.Add(this.join_btn);
            this.Controls.Add(this.modificaPercorso_btn);
            this.Controls.Add(this.luogo_tb);
            this.Controls.Add(this.luogo_lbl);
            this.Controls.Add(this.percorso_lv);
            this.Controls.Add(this.percorso_lbl);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.mdificaAttrezzaturaRiposo_btn);
            this.Controls.Add(this.modificaAttrezzaturaMovimento_btn);
            this.Controls.Add(this.modificaVestiario_btn);
            this.Controls.Add(this.modificaPasti_btn);
            this.Controls.Add(this.pasti_lv);
            this.Controls.Add(this.pesoZaino_txtbox);
            this.Controls.Add(this.zaino_txtbox);
            this.Controls.Add(this.riposo_lv);
            this.Controls.Add(this.vestiario_lv);
            this.Controls.Add(this.attrezzatura_lv);
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
            ((System.ComponentModel.ISupportInitialize)(this.durata_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficolta_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPartecipanti_num)).EndInit();
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
        private ListView vestiario_lv;
        private ListView riposo_lv;
        private TextBox zaino_txtbox;
        private TextBox pesoZaino_txtbox;
        private ListView pasti_lv;
        private ListView attrezzatura_lv;
        private Button modificaPasti_btn;
        private Button modificaVestiario_btn;
        private Button modificaAttrezzaturaMovimento_btn;
        private Button mdificaAttrezzaturaRiposo_btn;
        private Button exit_btn;
        private Button save_btn;
        private ListView percorso_lv;
        private Label percorso_lbl;
        private TextBox luogo_tb;
        private Label luogo_lbl;
        private Button modificaPercorso_btn;
        private Button join_btn;
    }
}