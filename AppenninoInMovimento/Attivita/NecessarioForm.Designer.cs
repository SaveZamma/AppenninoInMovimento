namespace AppenninoInMovimento.Attivita
{
    partial class NecessarioForm
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
            this.necessario_lbl = new System.Windows.Forms.Label();
            this.necessario_lb = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.add_tb = new System.Windows.Forms.TextBox();
            this.remove_btn = new System.Windows.Forms.Button();
            this.end_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // necessario_lbl
            // 
            this.necessario_lbl.AutoSize = true;
            this.necessario_lbl.Location = new System.Drawing.Point(62, 122);
            this.necessario_lbl.Name = "necessario_lbl";
            this.necessario_lbl.Size = new System.Drawing.Size(81, 20);
            this.necessario_lbl.TabIndex = 0;
            this.necessario_lbl.Text = "Necessario";
            // 
            // necessario_lb
            // 
            this.necessario_lb.FormattingEnabled = true;
            this.necessario_lb.ItemHeight = 20;
            this.necessario_lb.Location = new System.Drawing.Point(62, 145);
            this.necessario_lb.Name = "necessario_lb";
            this.necessario_lb.Size = new System.Drawing.Size(435, 104);
            this.necessario_lb.TabIndex = 1;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(403, 52);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(94, 29);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Aggiungi";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // add_tb
            // 
            this.add_tb.Location = new System.Drawing.Point(62, 52);
            this.add_tb.Name = "add_tb";
            this.add_tb.Size = new System.Drawing.Size(335, 27);
            this.add_tb.TabIndex = 3;
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(403, 110);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(94, 29);
            this.remove_btn.TabIndex = 4;
            this.remove_btn.Text = "Rimuovi";
            this.remove_btn.UseVisualStyleBackColor = true;
            // 
            // end_btn
            // 
            this.end_btn.Location = new System.Drawing.Point(403, 287);
            this.end_btn.Name = "end_btn";
            this.end_btn.Size = new System.Drawing.Size(94, 29);
            this.end_btn.TabIndex = 5;
            this.end_btn.Text = "Fine";
            this.end_btn.UseVisualStyleBackColor = true;
            // 
            // NecessarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 339);
            this.Controls.Add(this.end_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.add_tb);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.necessario_lb);
            this.Controls.Add(this.necessario_lbl);
            this.Name = "NecessarioForm";
            this.Text = "Necessario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label necessario_lbl;
        private ListBox necessario_lb;
        private Button add_btn;
        private TextBox add_tb;
        private Button remove_btn;
        private Button end_btn;
    }
}