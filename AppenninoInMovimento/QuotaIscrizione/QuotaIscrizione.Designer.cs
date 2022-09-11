namespace AppenninoInMovimento.QuotaIscrizione
{
    partial class QuotaIscrizione
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
            this.prezzo_lbl = new System.Windows.Forms.Label();
            this.prezzo_num = new System.Windows.Forms.NumericUpDown();
            this.sconto_lbl = new System.Windows.Forms.Label();
            this.sconto_num = new System.Windows.Forms.NumericUpDown();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prezzo_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sconto_num)).BeginInit();
            this.SuspendLayout();
            // 
            // prezzo_lbl
            // 
            this.prezzo_lbl.AutoSize = true;
            this.prezzo_lbl.Location = new System.Drawing.Point(49, 45);
            this.prezzo_lbl.Name = "prezzo_lbl";
            this.prezzo_lbl.Size = new System.Drawing.Size(75, 20);
            this.prezzo_lbl.TabIndex = 0;
            this.prezzo_lbl.Text = "Prezzo [€]";
            // 
            // prezzo_num
            // 
            this.prezzo_num.Location = new System.Drawing.Point(136, 43);
            this.prezzo_num.Name = "prezzo_num";
            this.prezzo_num.Size = new System.Drawing.Size(150, 27);
            this.prezzo_num.TabIndex = 1;
            // 
            // sconto_lbl
            // 
            this.sconto_lbl.AutoSize = true;
            this.sconto_lbl.Location = new System.Drawing.Point(49, 91);
            this.sconto_lbl.Name = "sconto_lbl";
            this.sconto_lbl.Size = new System.Drawing.Size(81, 20);
            this.sconto_lbl.TabIndex = 2;
            this.sconto_lbl.Text = "Sconto [%]";
            // 
            // sconto_num
            // 
            this.sconto_num.Location = new System.Drawing.Point(136, 89);
            this.sconto_num.Name = "sconto_num";
            this.sconto_num.Size = new System.Drawing.Size(150, 27);
            this.sconto_num.TabIndex = 3;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(118, 155);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(94, 29);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Salva";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // QuotaIscrizione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 221);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.sconto_num);
            this.Controls.Add(this.sconto_lbl);
            this.Controls.Add(this.prezzo_num);
            this.Controls.Add(this.prezzo_lbl);
            this.Name = "QuotaIscrizione";
            this.Text = "QuotaIscrizione";
            ((System.ComponentModel.ISupportInitialize)(this.prezzo_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sconto_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label prezzo_lbl;
        private NumericUpDown prezzo_num;
        private Label sconto_lbl;
        private NumericUpDown sconto_num;
        private Button save_btn;
    }
}