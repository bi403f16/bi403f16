namespace App_interface
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
            this.labelBalance = new System.Windows.Forms.Label();
            this.BoxBalance = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.TextBox();
            this.Kroner = new System.Windows.Forms.Label();
            this.TankOp = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.Label();
            this.BoxAdresse = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.Label();
            this.BoxCity = new System.Windows.Forms.TextBox();
            this.Zip_code = new System.Windows.Forms.Label();
            this.BoxZip = new System.Windows.Forms.TextBox();
            this.Phonenumber = new System.Windows.Forms.Label();
            this.BoxPhone = new System.Windows.Forms.TextBox();
            this.EditProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Din profil";
            // 
            // Firstname
            // 
            this.Firstname.AutoSize = true;
            this.Firstname.Location = new System.Drawing.Point(32, 63);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(46, 13);
            this.Firstname.TabIndex = 1;
            this.Firstname.Text = "Fornavn";
            // 
            // BoxFornavn
            // 
            this.BoxFornavn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BoxFornavn.Location = new System.Drawing.Point(254, 63);
            this.BoxFornavn.MaxLength = 20;
            this.BoxFornavn.Name = "BoxFornavn";
            this.BoxFornavn.ReadOnly = true;
            this.BoxFornavn.Size = new System.Drawing.Size(158, 20);
            this.BoxFornavn.TabIndex = 2;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(32, 101);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(53, 13);
            this.Surname.TabIndex = 3;
            this.Surname.Text = "Efternavn";
            // 
            // BoxEfternavn
            // 
            this.BoxEfternavn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BoxEfternavn.Location = new System.Drawing.Point(254, 101);
            this.BoxEfternavn.MaxLength = 30;
            this.BoxEfternavn.Name = "BoxEfternavn";
            this.BoxEfternavn.ReadOnly = true;
            this.BoxEfternavn.Size = new System.Drawing.Size(158, 20);
            this.BoxEfternavn.TabIndex = 4;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(33, 275);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(75, 13);
            this.Email.TabIndex = 5;
            this.Email.Text = "E-mail adresse";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxEmail.Location = new System.Drawing.Point(254, 275);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(158, 20);
            this.textBoxEmail.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(33, 310);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(73, 13);
            this.Password.TabIndex = 7;
            this.Password.Text = "Adgangskode";
            // 
            // BoxPawo
            // 
            this.BoxPawo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BoxPawo.Location = new System.Drawing.Point(254, 307);
            this.BoxPawo.MaxLength = 36;
            this.BoxPawo.Name = "BoxPawo";
            this.BoxPawo.PasswordChar = '*';
            this.BoxPawo.ReadOnly = true;
            this.BoxPawo.Size = new System.Drawing.Size(158, 20);
            this.BoxPawo.TabIndex = 8;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(33, 343);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(105, 13);
            this.labelBalance.TabIndex = 9;
            this.labelBalance.Text = "Nuværende balance";
            // 
            // BoxBalance
            // 
            this.BoxBalance.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BoxBalance.Location = new System.Drawing.Point(254, 340);
            this.BoxBalance.MaxLength = 36;
            this.BoxBalance.Name = "BoxBalance";
            this.BoxBalance.ReadOnly = true;
            this.BoxBalance.Size = new System.Drawing.Size(158, 20);
            this.BoxBalance.TabIndex = 10;
            // 
            // Balance
            // 
            this.Balance.Location = new System.Drawing.Point(48, 422);
            this.Balance.MaxLength = 5;
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(133, 20);
            this.Balance.TabIndex = 13;
            // 
            // Kroner
            // 
            this.Kroner.AutoSize = true;
            this.Kroner.Location = new System.Drawing.Point(187, 425);
            this.Kroner.Name = "Kroner";
            this.Kroner.Size = new System.Drawing.Size(19, 13);
            this.Kroner.TabIndex = 14;
            this.Kroner.Text = "kr.";
            // 
            // TankOp
            // 
            this.TankOp.Location = new System.Drawing.Point(131, 451);
            this.TankOp.Name = "TankOp";
            this.TankOp.Size = new System.Drawing.Size(75, 23);
            this.TankOp.TabIndex = 15;
            this.TankOp.Text = "Tank op";
            this.TankOp.UseVisualStyleBackColor = true;
            this.TankOp.Click += new System.EventHandler(this.TankOp_Click);
            // 
            // History
            // 
            this.History.Location = new System.Drawing.Point(337, 485);
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
            this.Back.Text = "Log ud";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(33, 137);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 18;
            this.Address.Text = "Adresse";
            // 
            // BoxAdresse
            // 
            this.BoxAdresse.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BoxAdresse.Location = new System.Drawing.Point(254, 137);
            this.BoxAdresse.Name = "BoxAdresse";
            this.BoxAdresse.ReadOnly = true;
            this.BoxAdresse.Size = new System.Drawing.Size(158, 20);
            this.BoxAdresse.TabIndex = 19;
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(33, 173);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(19, 13);
            this.City.TabIndex = 20;
            this.City.Text = "By";
            // 
            // BoxCity
            // 
            this.BoxCity.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BoxCity.Location = new System.Drawing.Point(254, 173);
            this.BoxCity.Name = "BoxCity";
            this.BoxCity.ReadOnly = true;
            this.BoxCity.Size = new System.Drawing.Size(158, 20);
            this.BoxCity.TabIndex = 21;
            // 
            // Zip_code
            // 
            this.Zip_code.AutoSize = true;
            this.Zip_code.Location = new System.Drawing.Point(32, 210);
            this.Zip_code.Name = "Zip_code";
            this.Zip_code.Size = new System.Drawing.Size(65, 13);
            this.Zip_code.TabIndex = 22;
            this.Zip_code.Text = "Postnummer";
            // 
            // BoxZip
            // 
            this.BoxZip.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BoxZip.Location = new System.Drawing.Point(254, 207);
            this.BoxZip.Name = "BoxZip";
            this.BoxZip.ReadOnly = true;
            this.BoxZip.Size = new System.Drawing.Size(158, 20);
            this.BoxZip.TabIndex = 23;
            // 
            // Phonenumber
            // 
            this.Phonenumber.AutoSize = true;
            this.Phonenumber.Location = new System.Drawing.Point(33, 241);
            this.Phonenumber.Name = "Phonenumber";
            this.Phonenumber.Size = new System.Drawing.Size(80, 13);
            this.Phonenumber.TabIndex = 24;
            this.Phonenumber.Text = "Telefonnummer";
            // 
            // BoxPhone
            // 
            this.BoxPhone.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BoxPhone.Location = new System.Drawing.Point(254, 241);
            this.BoxPhone.Name = "BoxPhone";
            this.BoxPhone.ReadOnly = true;
            this.BoxPhone.Size = new System.Drawing.Size(158, 20);
            this.BoxPhone.TabIndex = 25;
            // 
            // EditProfile
            // 
            this.EditProfile.Location = new System.Drawing.Point(299, 381);
            this.EditProfile.Name = "EditProfile";
            this.EditProfile.Size = new System.Drawing.Size(113, 23);
            this.EditProfile.TabIndex = 26;
            this.EditProfile.Text = "Redigér oplysninger";
            this.EditProfile.UseVisualStyleBackColor = true;
            this.EditProfile.Click += new System.EventHandler(this.EditProfile_Click);
            // 
            // LogintoProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.EditProfile);
            this.Controls.Add(this.BoxPhone);
            this.Controls.Add(this.Phonenumber);
            this.Controls.Add(this.BoxZip);
            this.Controls.Add(this.Zip_code);
            this.Controls.Add(this.BoxCity);
            this.Controls.Add(this.City);
            this.Controls.Add(this.BoxAdresse);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.History);
            this.Controls.Add(this.TankOp);
            this.Controls.Add(this.Kroner);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.BoxBalance);
            this.Controls.Add(this.labelBalance);
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
            this.Load += new System.EventHandler(this.LogintoProfile_Load);
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
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox BoxBalance;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.Label Kroner;
        private System.Windows.Forms.Button TankOp;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox BoxAdresse;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.TextBox BoxCity;
        private System.Windows.Forms.Label Zip_code;
        private System.Windows.Forms.TextBox BoxZip;
        private System.Windows.Forms.Label Phonenumber;
        private System.Windows.Forms.TextBox BoxPhone;
        private System.Windows.Forms.Button EditProfile;
    }
}