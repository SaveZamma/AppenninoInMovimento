namespace AppenninoInMovimento
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username_lbl = new System.Windows.Forms.Label();
            this.username_txtBox = new System.Windows.Forms.TextBox();
            this.pw_lbl = new System.Windows.Forms.Label();
            this.pw_txtBox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(37, 29);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(75, 20);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "Username";
            // 
            // username_txtBox
            // 
            this.username_txtBox.Location = new System.Drawing.Point(118, 22);
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.Size = new System.Drawing.Size(260, 27);
            this.username_txtBox.TabIndex = 1;
            this.username_txtBox.TextChanged += new System.EventHandler(this.username_txtBox_TextChanged);
            // 
            // pw_lbl
            // 
            this.pw_lbl.AutoSize = true;
            this.pw_lbl.Location = new System.Drawing.Point(37, 68);
            this.pw_lbl.Name = "pw_lbl";
            this.pw_lbl.Size = new System.Drawing.Size(70, 20);
            this.pw_lbl.TabIndex = 2;
            this.pw_lbl.Text = "Password";
            // 
            // pw_txtBox
            // 
            this.pw_txtBox.Location = new System.Drawing.Point(118, 65);
            this.pw_txtBox.MaxLength = 16;
            this.pw_txtBox.Name = "pw_txtBox";
            this.pw_txtBox.PasswordChar = '*';
            this.pw_txtBox.Size = new System.Drawing.Size(260, 27);
            this.pw_txtBox.TabIndex = 3;
            this.pw_txtBox.TextChanged += new System.EventHandler(this.pw_txtBox_TextChanged);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(118, 133);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(94, 29);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(218, 133);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(94, 29);
            this.register_btn.TabIndex = 5;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 187);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pw_txtBox);
            this.Controls.Add(this.pw_lbl);
            this.Controls.Add(this.username_txtBox);
            this.Controls.Add(this.username_lbl);
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label username_lbl;
        private TextBox username_txtBox;
        private Label pw_lbl;
        private TextBox pw_txtBox;
        private Button login_btn;
        private Button register_btn;
    }
}