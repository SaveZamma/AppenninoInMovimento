namespace AppenninoInMovimento.MainPage
{
    partial class SearchResultForm
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
            this.result_lb = new System.Windows.Forms.ListBox();
            this.look_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result_lb
            // 
            this.result_lb.FormattingEnabled = true;
            this.result_lb.ItemHeight = 20;
            this.result_lb.Location = new System.Drawing.Point(48, 49);
            this.result_lb.Name = "result_lb";
            this.result_lb.Size = new System.Drawing.Size(497, 144);
            this.result_lb.TabIndex = 0;
            // 
            // look_btn
            // 
            this.look_btn.Location = new System.Drawing.Point(451, 228);
            this.look_btn.Name = "look_btn";
            this.look_btn.Size = new System.Drawing.Size(94, 29);
            this.look_btn.TabIndex = 1;
            this.look_btn.Text = "Visualizza";
            this.look_btn.UseVisualStyleBackColor = true;
            this.look_btn.Click += new System.EventHandler(this.look_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(340, 228);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(94, 29);
            this.remove_btn.TabIndex = 2;
            this.remove_btn.Text = "Elimina";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(229, 228);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(94, 29);
            this.update_btn.TabIndex = 3;
            this.update_btn.Text = "Modifica";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // SearchResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 294);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.look_btn);
            this.Controls.Add(this.result_lb);
            this.Name = "SearchResultForm";
            this.Text = "Risultati Ricerca";
            this.Load += new System.EventHandler(this.SearchResultForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox result_lb;
        private Button look_btn;
        private Button remove_btn;
        private Button update_btn;
    }
}