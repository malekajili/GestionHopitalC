﻿namespace hopital.forms.patients
{
    partial class AddPatient
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
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textGender = new System.Windows.Forms.ComboBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.titre1 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textAddress
            // 
            this.textAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAddress.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.Location = new System.Drawing.Point(293, 254);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(197, 30);
            this.textAddress.TabIndex = 15;
            this.textAddress.Text = "Adresse";
            // 
            // textGender
            // 
            this.textGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textGender.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGender.FormattingEnabled = true;
            this.textGender.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.textGender.Location = new System.Drawing.Point(537, 253);
            this.textGender.Name = "textGender";
            this.textGender.Size = new System.Drawing.Size(222, 31);
            this.textGender.TabIndex = 14;
            this.textGender.Text = "Genre";
            // 
            // textPhone
            // 
            this.textPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPhone.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.Location = new System.Drawing.Point(293, 188);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(197, 30);
            this.textPhone.TabIndex = 13;
            this.textPhone.Text = "Telephone";
            // 
            // textName
            // 
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textName.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(42, 188);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(197, 30);
            this.textName.TabIndex = 9;
            this.textName.Text = "Nom et prenom";
            // 
            // titre1
            // 
            this.titre1.AutoSize = true;
            this.titre1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre1.Location = new System.Drawing.Point(193, 44);
            this.titre1.Name = "titre1";
            this.titre1.Size = new System.Drawing.Size(348, 38);
            this.titre1.TabIndex = 8;
            this.titre1.Text = "Ajouter un patient";
            this.titre1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textEmail
            // 
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmail.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(42, 254);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(197, 30);
            this.textEmail.TabIndex = 16;
            this.textEmail.Text = "Email";
            this.textEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(293, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 35);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Enregistrer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textAge
            // 
            this.textAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAge.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAge.Location = new System.Drawing.Point(537, 188);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(222, 30);
            this.textAge.TabIndex = 18;
            this.textAge.Text = "Age";
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textGender);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.titre1);
            this.Name = "AddPatient";
            this.Text = "AddPatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.ComboBox textGender;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label titre1;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textAge;
    }
}