namespace hopital.forms.users
{
    partial class ManageUsers
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
            this.titre1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.role = new System.Windows.Forms.ComboBox();
            this.username = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.speciality = new System.Windows.Forms.ComboBox();
            this.address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titre1
            // 
            this.titre1.AutoSize = true;
            this.titre1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre1.Location = new System.Drawing.Point(237, 32);
            this.titre1.Name = "titre1";
            this.titre1.Size = new System.Drawing.Size(406, 38);
            this.titre1.TabIndex = 0;
            this.titre1.Text = "Ajouter un utilisateur";
            this.titre1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titre1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(44, 114);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(197, 30);
            this.name.TabIndex = 1;
            this.name.Text = "Nom et prenom";
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(293, 114);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(197, 30);
            this.password.TabIndex = 2;
            this.password.Text = "Mot de passe";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // role
            // 
            this.role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.role.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "ADMIN ",
            "DOCTOR",
            "RECEPTIONIST",
            "PATIENT"});
            this.role.Location = new System.Drawing.Point(539, 113);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(222, 31);
            this.role.TabIndex = 3;
            this.role.Text = "Role";
            this.role.SelectedIndexChanged += new System.EventHandler(this.Role_SelectedIndexChanged);
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(44, 180);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(197, 30);
            this.username.TabIndex = 4;
            this.username.Text = "Login";
            this.username.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // phone
            // 
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(293, 180);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(197, 30);
            this.phone.TabIndex = 5;
            this.phone.Text = "Telephone";
            // 
            // speciality
            // 
            this.speciality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speciality.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speciality.FormattingEnabled = true;
            this.speciality.Items.AddRange(new object[] {
            "ADMIN ",
            "DOCTOR",
            "RECEPTIONIST",
            "PATIENT"});
            this.speciality.Location = new System.Drawing.Point(539, 179);
            this.speciality.Name = "speciality";
            this.speciality.Size = new System.Drawing.Size(222, 31);
            this.speciality.TabIndex = 6;
            this.speciality.Text = "Specialite";
            // 
            // address
            // 
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(44, 241);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(197, 30);
            this.address.TabIndex = 7;
            this.address.Text = "Adresse";
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.address);
            this.Controls.Add(this.speciality);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.username);
            this.Controls.Add(this.role);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.titre1);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.ComboBox speciality;
        private System.Windows.Forms.TextBox address;
    }
}