namespace AppenninoInMovimento.Percorso.Tappa
{
    partial class TappaForm
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
            this.tipologia_lbl = new System.Windows.Forms.Label();
            this.lunghezza_lbl = new System.Windows.Forms.Label();
            this.lunghezza_num = new System.Windows.Forms.NumericUpDown();
            this.lunghezza_tb = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lunghezza_num)).BeginInit();
            this.SuspendLayout();
            // 
            // tipologia_lbl
            // 
            this.tipologia_lbl.AutoSize = true;
            this.tipologia_lbl.Location = new System.Drawing.Point(49, 43);
            this.tipologia_lbl.Name = "tipologia_lbl";
            this.tipologia_lbl.Size = new System.Drawing.Size(73, 20);
            this.tipologia_lbl.TabIndex = 0;
            this.tipologia_lbl.Text = "Tipologia";
            // 
            // lunghezza_lbl
            // 
            this.lunghezza_lbl.AutoSize = true;
            this.lunghezza_lbl.Location = new System.Drawing.Point(49, 104);
            this.lunghezza_lbl.Name = "lunghezza_lbl";
            this.lunghezza_lbl.Size = new System.Drawing.Size(106, 20);
            this.lunghezza_lbl.TabIndex = 1;
            this.lunghezza_lbl.Text = "Lunghezza [m]";
            // 
            // lunghezza_num
            // 
            this.lunghezza_num.Location = new System.Drawing.Point(170, 102);
            this.lunghezza_num.Name = "lunghezza_num";
            this.lunghezza_num.Size = new System.Drawing.Size(150, 27);
            this.lunghezza_num.TabIndex = 2;
            // 
            // lunghezza_tb
            // 
            this.lunghezza_tb.Location = new System.Drawing.Point(170, 43);
            this.lunghezza_tb.Name = "lunghezza_tb";
            this.lunghezza_tb.Size = new System.Drawing.Size(150, 27);
            this.lunghezza_tb.TabIndex = 3;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(135, 159);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(94, 29);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Salva";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // TappaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 214);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.lunghezza_tb);
            this.Controls.Add(this.lunghezza_num);
            this.Controls.Add(this.lunghezza_lbl);
            this.Controls.Add(this.tipologia_lbl);
            this.Name = "TappaForm";
            this.Text = "TappaForm";
            ((System.ComponentModel.ISupportInitialize)(this.lunghezza_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tipologia_lbl;
        private Label lunghezza_lbl;
        private NumericUpDown lunghezza_num;
        private TextBox lunghezza_tb;
        private Button save_btn;
    }
}