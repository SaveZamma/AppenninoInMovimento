namespace AppenninoInMovimento.Evento
{
    partial class SearchForm
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
            this.results_lb = new System.Windows.Forms.ListBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // results_lb
            // 
            this.results_lb.FormattingEnabled = true;
            this.results_lb.ItemHeight = 20;
            this.results_lb.Location = new System.Drawing.Point(46, 45);
            this.results_lb.Name = "results_lb";
            this.results_lb.Size = new System.Drawing.Size(575, 144);
            this.results_lb.TabIndex = 0;
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(527, 212);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(94, 29);
            this.close_btn.TabIndex = 1;
            this.close_btn.Text = "Chiudi";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(415, 212);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(94, 29);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Aggiungi";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 270);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.results_lb);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox results_lb;
        private Button close_btn;
        private Button add_btn;
    }
}