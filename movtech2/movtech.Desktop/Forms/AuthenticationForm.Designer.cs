namespace movtech.Desktop.Forms
{
    partial class AuthenticationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonSingIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFail = new System.Windows.Forms.Label();
            this.maskedTextCPFLogin = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(42, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(42, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textPassword.Location = new System.Drawing.Point(159, 215);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(215, 29);
            this.textPassword.TabIndex = 3;
            // 
            // buttonSingIn
            // 
            this.buttonSingIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.buttonSingIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSingIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSingIn.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSingIn.Location = new System.Drawing.Point(117, 298);
            this.buttonSingIn.Name = "buttonSingIn";
            this.buttonSingIn.Size = new System.Drawing.Size(215, 58);
            this.buttonSingIn.TabIndex = 4;
            this.buttonSingIn.Text = "Entrar";
            this.buttonSingIn.UseVisualStyleBackColor = false;
            this.buttonSingIn.Click += new System.EventHandler(this.ButtonSingIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(129, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autentique - se";
            // 
            // labelFail
            // 
            this.labelFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFail.ForeColor = System.Drawing.Color.Red;
            this.labelFail.Location = new System.Drawing.Point(47, 264);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(369, 31);
            this.labelFail.TabIndex = 6;
            this.labelFail.Text = "teste";
            this.labelFail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFail.Visible = false;
            // 
            // maskedTextCPFLogin
            // 
            this.maskedTextCPFLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextCPFLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.maskedTextCPFLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.maskedTextCPFLogin.Location = new System.Drawing.Point(155, 140);
            this.maskedTextCPFLogin.Mask = "000,000,000-00";
            this.maskedTextCPFLogin.Name = "maskedTextCPFLogin";
            this.maskedTextCPFLogin.Size = new System.Drawing.Size(219, 29);
            this.maskedTextCPFLogin.TabIndex = 9;
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 436);
            this.Controls.Add(this.maskedTextCPFLogin);
            this.Controls.Add(this.labelFail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSingIn);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthenticationForm";
            this.Text = "Autenticação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonSingIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFail;
        private System.Windows.Forms.MaskedTextBox maskedTextCPFLogin;
    }
}