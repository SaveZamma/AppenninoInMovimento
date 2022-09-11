namespace AppenninoInMovimento.Gruppo
{
    partial class GruppoForm
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
            this.partecipanti_lbl = new System.Windows.Forms.Label();
            this.partecipanti_lv = new System.Windows.Forms.ListView();
            this.save_btn = new System.Windows.Forms.Button();
            this.join_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nome_lbl
            // 
            this.nome_lbl.AutoSize = true;
            this.nome_lbl.Location = new System.Drawing.Point(55, 45);
            this.nome_lbl.Name = "nome_lbl";
            this.nome_lbl.Size = new System.Drawing.Size(50, 20);
            this.nome_lbl.TabIndex = 0;
            this.nome_lbl.Text = "Nome";
            // 
            // nome_txtbox
            // 
            this.nome_txtbox.Location = new System.Drawing.Point(111, 42);
            this.nome_txtbox.Name = "nome_txtbox";
            this.nome_txtbox.Size = new System.Drawing.Size(372, 27);
            this.nome_txtbox.TabIndex = 1;
            // 
            // partecipanti_lbl
            // 
            this.partecipanti_lbl.AutoSize = true;
            this.partecipanti_lbl.Location = new System.Drawing.Point(55, 94);
            this.partecipanti_lbl.Name = "partecipanti_lbl";
            this.partecipanti_lbl.Size = new System.Drawing.Size(61, 20);
            this.partecipanti_lbl.TabIndex = 2;
            this.partecipanti_lbl.Text = "Membri";
            // 
            // partecipanti_lv
            // 
            this.partecipanti_lv.Location = new System.Drawing.Point(55, 117);
            this.partecipanti_lv.Name = "partecipanti_lv";
            this.partecipanti_lv.Size = new System.Drawing.Size(428, 121);
            this.partecipanti_lv.TabIndex = 3;
            this.partecipanti_lv.UseCompatibleStateImageBehavior = false;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(389, 302);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(94, 29);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Salva";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // join_btn
            // 
            this.join_btn.Location = new System.Drawing.Point(389, 256);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(94, 29);
            this.join_btn.TabIndex = 5;
            this.join_btn.Text = "Unisciti";
            this.join_btn.UseVisualStyleBackColor = true;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // GruppoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 372);
            this.Controls.Add(this.join_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.partecipanti_lv);
            this.Controls.Add(this.partecipanti_lbl);
            this.Controls.Add(this.nome_txtbox);
            this.Controls.Add(this.nome_lbl);
            this.Name = "GruppoForm";
            this.Text = "GruppoForm";
            this.Load += new System.EventHandler(this.GruppoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nome_lbl;
        private TextBox nome_txtbox;
        private Label partecipanti_lbl;
        private ListView partecipanti_lv;
        private Button save_btn;
        private Button join_btn;
    }
}