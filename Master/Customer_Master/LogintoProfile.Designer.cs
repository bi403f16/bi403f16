namespace Customer_Master
{
    partial class LogintoProfile
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
            this.Firstname = new System.Windows.Forms.Label();
            this.BoxFornavn = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.BoxEfternavn = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.BoxPawo = new System.Windows.Forms.TextBox();
            this.ConPassword = new System.Windows.Forms.Label();
            this.BoxCopawo = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.Balance = new System.Windows.Forms.TextBox();
            this.Kroner = new System.Windows.Forms.Label();
            this.TankOp = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Din profil";
            // 
            // Firstname
            // 
            this.Firstname.AutoSize = true;
            this.Firstname.Location = new System.Drawing.Point(32, 107);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(46, 13);
            this.Firstname.TabIndex = 1;
            this.Firstname.Text = "Fornavn";
            // 
            // BoxFornavn
            // 
            this.BoxFornavn.Location = new System.Drawing.Point(254, 107);
            this.BoxFornavn.MaxLength = 20;
            this.BoxFornavn.Name = "BoxFornavn";
            this.BoxFornavn.Size = new System.Drawing.Size(158, 20);
            this.BoxFornavn.TabIndex = 2;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(32, 147);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(53, 13);
            this.Surname.TabIndex = 3;
            this.Surname.Text = "Efternavn";
            // 
            // BoxEfternavn
            // 
            this.BoxEfternavn.Location = new System.Drawing.Point(254, 147);
            this.BoxEfternavn.MaxLength = 30;
            this.BoxEfternavn.Name = "BoxEfternavn";
            this.BoxEfternavn.Size = new System.Drawing.Size(158, 20);
            this.BoxEfternavn.TabIndex = 4;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(32, 192);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(75, 13);
            this.Email.TabIndex = 5;
            this.Email.Text = "E-mail adresse";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(254, 192);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(158, 20);
            this.textBoxEmail.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(32, 239);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(73, 13);
            this.Password.TabIndex = 7;
            this.Password.Text = "Adgangskode";
            // 
            // BoxPawo
            // 
            this.BoxPawo.Location = new System.Drawing.Point(254, 239);
            this.BoxPawo.MaxLength = 36;
            this.BoxPawo.Name = "BoxPawo";
            this.BoxPawo.Size = new System.Drawing.Size(158, 20);
            this.BoxPawo.TabIndex = 8;
            this.BoxPawo.TextChanged += new System.EventHandler(this.BoxPawo_TextChanged);
            // 
            // ConPassword
            // 
            this.ConPassword.AutoSize = true;
            this.ConPassword.Location = new System.Drawing.Point(32, 287);
            this.ConPassword.Name = "ConPassword";
            this.ConPassword.Size = new System.Drawing.Size(113, 13);
            this.ConPassword.TabIndex = 9;
            this.ConPassword.Text = "Bekræft adgangskode";
            // 
            // BoxCopawo
            // 
            this.BoxCopawo.Location = new System.Drawing.Point(254, 284);
            this.BoxCopawo.MaxLength = 36;
            this.BoxCopawo.Name = "BoxCopawo";
            this.BoxCopawo.Size = new System.Drawing.Size(158, 20);
            this.BoxCopawo.TabIndex = 10;
            this.BoxCopawo.TextChanged += new System.EventHandler(this.BoxCopawo_TextChanged);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(323, 329);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(89, 23);
            this.Update.TabIndex = 11;
            this.Update.Text = "Opdater profil";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Balance
            // 
            this.Balance.Location = new System.Drawing.Point(48, 404);
            this.Balance.MaxLength = 5;
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(133, 20);
            this.Balance.TabIndex = 13;
            // 
            // Kroner
            // 
            this.Kroner.AutoSize = true;
            this.Kroner.Location = new System.Drawing.Point(187, 411);
            this.Kroner.Name = "Kroner";
            this.Kroner.Size = new System.Drawing.Size(19, 13);
            this.Kroner.TabIndex = 14;
            this.Kroner.Text = "kr.";
            // 
            // TankOp
            // 
            this.TankOp.Location = new System.Drawing.Point(131, 430);
            this.TankOp.Name = "TankOp";
            this.TankOp.Size = new System.Drawing.Size(75, 23);
            this.TankOp.TabIndex = 15;
            this.TankOp.Text = "Tank op";
            this.TankOp.UseVisualStyleBackColor = true;
            this.TankOp.Click += new System.EventHandler(this.TankOp_Click);
            // 
            // History
            // 
            this.History.Location = new System.Drawing.Point(337, 473);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(75, 23);
            this.History.TabIndex = 16;
            this.History.Text = "Gå til historik";
            this.History.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(35, 535);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 17;
            this.Back.Text = "Tilbage";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // LogintoProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.History);
            this.Controls.Add(this.TankOp);
            this.Controls.Add(this.Kroner);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.BoxCopawo);
            this.Controls.Add(this.ConPassword);
            this.Controls.Add(this.BoxPawo);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.BoxEfternavn);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.BoxFornavn);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.label1);
            this.Name = "LogintoProfile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Firstname;
        private System.Windows.Forms.TextBox BoxFornavn;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox BoxEfternavn;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox BoxPawo;
        private System.Windows.Forms.Label ConPassword;
        private System.Windows.Forms.TextBox BoxCopawo;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.Label Kroner;
        private System.Windows.Forms.Button TankOp;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button Back;
    }
}