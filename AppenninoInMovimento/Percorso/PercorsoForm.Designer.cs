namespace AppenninoInMovimento.Percorso
{
    partial class PercorsoForm
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
            this.dislivello_lbl = new System.Windows.Forms.Label();
            this.dislivello_num = new System.Windows.Forms.NumericUpDown();
            this.tappe_lbl = new System.Windows.Forms.Label();
            this.tappe_lb = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.distanza_lbl = new System.Windows.Forms.Label();
            this.distanza_num = new System.Windows.Forms.NumericUpDown();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dislivello_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanza_num)).BeginInit();
            this.SuspendLayout();
            // 
            // dislivello_lbl
            // 
            this.dislivello_lbl.AutoSize = true;
            this.dislivello_lbl.Location = new System.Drawing.Point(44, 37);
            this.dislivello_lbl.Name = "dislivello_lbl";
            this.dislivello_lbl.Size = new System.Drawing.Size(70, 20);
            this.dislivello_lbl.TabIndex = 0;
            this.dislivello_lbl.Text = "Dislivello";
            // 
            // dislivello_num
            // 
            this.dislivello_num.Location = new System.Drawing.Point(120, 35);
            this.dislivello_num.Name = "dislivello_num";
            this.dislivello_num.Size = new System.Drawing.Size(150, 27);
            this.dislivello_num.TabIndex = 1;
            // 
            // tappe_lbl
            // 
            this.tappe_lbl.AutoSize = true;
            this.tappe_lbl.Location = new System.Drawing.Point(44, 128);
            this.tappe_lbl.Name = "tappe_lbl";
            this.tappe_lbl.Size = new System.Drawing.Size(49, 20);
            this.tappe_lbl.TabIndex = 2;
            this.tappe_lbl.Text = "Tappe";
            // 
            // tappe_lb
            // 
            this.tappe_lb.FormattingEnabled = true;
            this.tappe_lb.ItemHeight = 20;
            this.tappe_lb.Location = new System.Drawing.Point(44, 151);
            this.tappe_lb.Name = "tappe_lb";
            this.tappe_lb.Size = new System.Drawing.Size(471, 104);
            this.tappe_lb.TabIndex = 3;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(421, 116);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(94, 29);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Aggiungi";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(321, 116);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(94, 29);
            this.remove_btn.TabIndex = 5;
            this.remove_btn.Text = "Rimuovi";
            this.remove_btn.UseVisualStyleBackColor = true;
            // 
            // distanza_lbl
            // 
            this.distanza_lbl.AutoSize = true;
            this.distanza_lbl.Location = new System.Drawing.Point(293, 37);
            this.distanza_lbl.Name = "distanza_lbl";
            this.distanza_lbl.Size = new System.Drawing.Size(66, 20);
            this.distanza_lbl.TabIndex = 6;
            this.distanza_lbl.Text = "Distanza";
            // 
            // distanza_num
            // 
            this.distanza_num.Enabled = false;
            this.distanza_num.Location = new System.Drawing.Point(365, 35);
            this.distanza_num.Name = "distanza_num";
            this.distanza_num.Size = new System.Drawing.Size(150, 27);
            this.distanza_num.TabIndex = 7;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(421, 292);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(94, 29);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Salva";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // PercorsoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.distanza_num);
            this.Controls.Add(this.distanza_lbl);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.tappe_lb);
            this.Controls.Add(this.tappe_lbl);
            this.Controls.Add(this.dislivello_num);
            this.Controls.Add(this.dislivello_lbl);
            this.Name = "PercorsoForm";
            this.Text = "PercorsoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dislivello_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanza_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label dislivello_lbl;
        private NumericUpDown dislivello_num;
        private Label tappe_lbl;
        private ListBox tappe_lb;
        private Button add_btn;
        private Button remove_btn;
        private Label distanza_lbl;
        private NumericUpDown distanza_num;
        private Button save_btn;
    }
}