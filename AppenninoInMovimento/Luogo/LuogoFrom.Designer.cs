namespace AppenninoInMovimento.Luogo
{
    partial class LuogoFrom
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
            this.lat_lbl = new System.Windows.Forms.Label();
            this.lat_txtbox = new System.Windows.Forms.TextBox();
            this.lng_lbl = new System.Windows.Forms.Label();
            this.lng_txtbox = new System.Windows.Forms.TextBox();
            this.altitudine_lbl = new System.Windows.Forms.Label();
            this.altitudine_num = new System.Windows.Forms.NumericUpDown();
            this.comune_lbl = new System.Windows.Forms.Label();
            this.comune_tb = new System.Windows.Forms.TextBox();
            this.provincia_tb = new System.Windows.Forms.TextBox();
            this.provincia_lbl = new System.Windows.Forms.Label();
            this.frazione_tb = new System.Windows.Forms.TextBox();
            this.frazione_lbl = new System.Windows.Forms.Label();
            this.via_tb = new System.Windows.Forms.TextBox();
            this.via_lbl = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.altitudine_num)).BeginInit();
            this.SuspendLayout();
            // 
            // lat_lbl
            // 
            this.lat_lbl.AutoSize = true;
            this.lat_lbl.Location = new System.Drawing.Point(46, 43);
            this.lat_lbl.Name = "lat_lbl";
            this.lat_lbl.Size = new System.Drawing.Size(75, 20);
            this.lat_lbl.TabIndex = 0;
            this.lat_lbl.Text = "Latitudine";
            // 
            // lat_txtbox
            // 
            this.lat_txtbox.Location = new System.Drawing.Point(127, 40);
            this.lat_txtbox.Name = "lat_txtbox";
            this.lat_txtbox.Size = new System.Drawing.Size(151, 27);
            this.lat_txtbox.TabIndex = 1;
            // 
            // lng_lbl
            // 
            this.lng_lbl.AutoSize = true;
            this.lng_lbl.Location = new System.Drawing.Point(303, 43);
            this.lng_lbl.Name = "lng_lbl";
            this.lng_lbl.Size = new System.Drawing.Size(88, 20);
            this.lng_lbl.TabIndex = 2;
            this.lng_lbl.Text = "Longitudine";
            // 
            // lng_txtbox
            // 
            this.lng_txtbox.Location = new System.Drawing.Point(397, 40);
            this.lng_txtbox.Name = "lng_txtbox";
            this.lng_txtbox.Size = new System.Drawing.Size(151, 27);
            this.lng_txtbox.TabIndex = 3;
            // 
            // altitudine_lbl
            // 
            this.altitudine_lbl.AutoSize = true;
            this.altitudine_lbl.Location = new System.Drawing.Point(46, 93);
            this.altitudine_lbl.Name = "altitudine_lbl";
            this.altitudine_lbl.Size = new System.Drawing.Size(74, 20);
            this.altitudine_lbl.TabIndex = 4;
            this.altitudine_lbl.Text = "Altitudine";
            // 
            // altitudine_num
            // 
            this.altitudine_num.Location = new System.Drawing.Point(127, 91);
            this.altitudine_num.Name = "altitudine_num";
            this.altitudine_num.Size = new System.Drawing.Size(151, 27);
            this.altitudine_num.TabIndex = 5;
            // 
            // comune_lbl
            // 
            this.comune_lbl.AutoSize = true;
            this.comune_lbl.Location = new System.Drawing.Point(46, 141);
            this.comune_lbl.Name = "comune_lbl";
            this.comune_lbl.Size = new System.Drawing.Size(64, 20);
            this.comune_lbl.TabIndex = 6;
            this.comune_lbl.Text = "Comune";
            // 
            // comune_tb
            // 
            this.comune_tb.Location = new System.Drawing.Point(127, 138);
            this.comune_tb.Name = "comune_tb";
            this.comune_tb.Size = new System.Drawing.Size(151, 27);
            this.comune_tb.TabIndex = 7;
            // 
            // provincia_tb
            // 
            this.provincia_tb.Location = new System.Drawing.Point(127, 186);
            this.provincia_tb.Name = "provincia_tb";
            this.provincia_tb.Size = new System.Drawing.Size(151, 27);
            this.provincia_tb.TabIndex = 9;
            // 
            // provincia_lbl
            // 
            this.provincia_lbl.AutoSize = true;
            this.provincia_lbl.Location = new System.Drawing.Point(46, 189);
            this.provincia_lbl.Name = "provincia_lbl";
            this.provincia_lbl.Size = new System.Drawing.Size(69, 20);
            this.provincia_lbl.TabIndex = 8;
            this.provincia_lbl.Text = "Provincia";
            // 
            // frazione_tb
            // 
            this.frazione_tb.Location = new System.Drawing.Point(127, 234);
            this.frazione_tb.Name = "frazione_tb";
            this.frazione_tb.Size = new System.Drawing.Size(151, 27);
            this.frazione_tb.TabIndex = 11;
            // 
            // frazione_lbl
            // 
            this.frazione_lbl.AutoSize = true;
            this.frazione_lbl.Location = new System.Drawing.Point(46, 237);
            this.frazione_lbl.Name = "frazione_lbl";
            this.frazione_lbl.Size = new System.Drawing.Size(65, 20);
            this.frazione_lbl.TabIndex = 10;
            this.frazione_lbl.Text = "Frazione";
            // 
            // via_tb
            // 
            this.via_tb.Location = new System.Drawing.Point(127, 280);
            this.via_tb.Name = "via_tb";
            this.via_tb.Size = new System.Drawing.Size(151, 27);
            this.via_tb.TabIndex = 13;
            // 
            // via_lbl
            // 
            this.via_lbl.AutoSize = true;
            this.via_lbl.Location = new System.Drawing.Point(46, 283);
            this.via_lbl.Name = "via_lbl";
            this.via_lbl.Size = new System.Drawing.Size(30, 20);
            this.via_lbl.TabIndex = 12;
            this.via_lbl.Text = "Via";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(454, 332);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(94, 29);
            this.save_btn.TabIndex = 14;
            this.save_btn.Text = "Salva";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // LuogoFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 381);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.via_tb);
            this.Controls.Add(this.via_lbl);
            this.Controls.Add(this.frazione_tb);
            this.Controls.Add(this.frazione_lbl);
            this.Controls.Add(this.provincia_tb);
            this.Controls.Add(this.provincia_lbl);
            this.Controls.Add(this.comune_tb);
            this.Controls.Add(this.comune_lbl);
            this.Controls.Add(this.altitudine_num);
            this.Controls.Add(this.altitudine_lbl);
            this.Controls.Add(this.lng_txtbox);
            this.Controls.Add(this.lng_lbl);
            this.Controls.Add(this.lat_txtbox);
            this.Controls.Add(this.lat_lbl);
            this.Name = "LuogoFrom";
            this.Text = "Luogo";
            ((System.ComponentModel.ISupportInitialize)(this.altitudine_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lat_lbl;
        private TextBox lat_txtbox;
        private Label lng_lbl;
        private TextBox lng_txtbox;
        private Label altitudine_lbl;
        private NumericUpDown altitudine_num;
        private Label comune_lbl;
        private TextBox comune_tb;
        private TextBox provincia_tb;
        private Label provincia_lbl;
        private TextBox frazione_tb;
        private Label frazione_lbl;
        private TextBox via_tb;
        private Label via_lbl;
        private Button save_btn;
    }
}