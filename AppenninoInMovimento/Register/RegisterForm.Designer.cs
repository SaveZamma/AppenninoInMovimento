namespace AppenninoInMovimento
{
    partial class RegisterForm
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
            this.register_btn = new System.Windows.Forms.Button();
            this.CF_txtbox = new System.Windows.Forms.TextBox();
            this.nome_txtbox = new System.Windows.Forms.TextBox();
            this.cognome_txtbox = new System.Windows.Forms.TextBox();
            this.CF_lbl = new System.Windows.Forms.Label();
            this.nome_lbl = new System.Windows.Forms.Label();
            this.cognome_lbl = new System.Windows.Forms.Label();
            this.dataNascita_lbl = new System.Windows.Forms.Label();
            this.cel_lbl = new System.Windows.Forms.Label();
            this.DataNascita_datePk = new System.Windows.Forms.DateTimePicker();
            this.cel_txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(191, 283);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(94, 29);
            this.register_btn.TabIndex = 0;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            // 
            // CF_txtbox
            // 
            this.CF_txtbox.Location = new System.Drawing.Point(160, 57);
            this.CF_txtbox.Name = "CF_txtbox";
            this.CF_txtbox.Size = new System.Drawing.Size(250, 27);
            this.CF_txtbox.TabIndex = 1;
            this.CF_txtbox.MaxLength = 16;
            // 
            // nome_txtbox
            // 
            this.nome_txtbox.Location = new System.Drawing.Point(160, 97);
            this.nome_txtbox.Name = "nome_txtbox";
            this.nome_txtbox.Size = new System.Drawing.Size(250, 27);
            this.nome_txtbox.TabIndex = 2;
            // 
            // cognome_txtbox
            // 
            this.cognome_txtbox.Location = new System.Drawing.Point(160, 138);
            this.cognome_txtbox.Name = "cognome_txtbox";
            this.cognome_txtbox.Size = new System.Drawing.Size(250, 27);
            this.cognome_txtbox.TabIndex = 3;
            // 
            // CF_lbl
            // 
            this.CF_lbl.AutoSize = true;
            this.CF_lbl.Location = new System.Drawing.Point(31, 60);
            this.CF_lbl.Name = "CF_lbl";
            this.CF_lbl.Size = new System.Drawing.Size(31, 20);
            this.CF_lbl.TabIndex = 6;
            this.CF_lbl.Text = "C.F.";
            // 
            // nome_lbl
            // 
            this.nome_lbl.AutoSize = true;
            this.nome_lbl.Location = new System.Drawing.Point(31, 100);
            this.nome_lbl.Name = "nome_lbl";
            this.nome_lbl.Size = new System.Drawing.Size(50, 20);
            this.nome_lbl.TabIndex = 7;
            this.nome_lbl.Text = "Nome";
            // 
            // cognome_lbl
            // 
            this.cognome_lbl.AutoSize = true;
            this.cognome_lbl.Location = new System.Drawing.Point(31, 141);
            this.cognome_lbl.Name = "cognome_lbl";
            this.cognome_lbl.Size = new System.Drawing.Size(74, 20);
            this.cognome_lbl.TabIndex = 8;
            this.cognome_lbl.Text = "Cognome";
            // 
            // dataNascita_lbl
            // 
            this.dataNascita_lbl.AutoSize = true;
            this.dataNascita_lbl.Location = new System.Drawing.Point(31, 179);
            this.dataNascita_lbl.Name = "dataNascita_lbl";
            this.dataNascita_lbl.Size = new System.Drawing.Size(111, 20);
            this.dataNascita_lbl.TabIndex = 9;
            this.dataNascita_lbl.Text = "Data di Nascita";
            // 
            // cel_lbl
            // 
            this.cel_lbl.AutoSize = true;
            this.cel_lbl.Location = new System.Drawing.Point(31, 220);
            this.cel_lbl.Name = "cel_lbl";
            this.cel_lbl.Size = new System.Drawing.Size(67, 20);
            this.cel_lbl.TabIndex = 10;
            this.cel_lbl.Text = "Cellulare";
            // 
            // DataNascita_datePk
            // 
            this.DataNascita_datePk.Location = new System.Drawing.Point(160, 174);
            this.DataNascita_datePk.Name = "DataNascita_datePk";
            this.DataNascita_datePk.Size = new System.Drawing.Size(250, 27);
            this.DataNascita_datePk.TabIndex = 11;
            // 
            // textBox1
            // 
            this.cel_txtBox.Location = new System.Drawing.Point(160, 217);
            this.cel_txtBox.Name = "Cel_txtBox";
            this.cel_txtBox.Size = new System.Drawing.Size(250, 27);
            this.cel_txtBox.TabIndex = 12;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 357);
            this.Controls.Add(this.cel_txtBox);
            this.Controls.Add(this.DataNascita_datePk);
            this.Controls.Add(this.cel_lbl);
            this.Controls.Add(this.dataNascita_lbl);
            this.Controls.Add(this.cognome_lbl);
            this.Controls.Add(this.nome_lbl);
            this.Controls.Add(this.CF_lbl);
            this.Controls.Add(this.cognome_txtbox);
            this.Controls.Add(this.nome_txtbox);
            this.Controls.Add(this.CF_txtbox);
            this.Controls.Add(this.register_btn);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button register_btn;
        private TextBox CF_txtbox;
        private TextBox nome_txtbox;
        private TextBox cognome_txtbox;
        private Label CF_lbl;
        private Label nome_lbl;
        private Label cognome_lbl;
        private Label dataNascita_lbl;
        private Label cel_lbl;
        private DateTimePicker DataNascita_datePk;
        private TextBox cel_txtBox;
    }
}