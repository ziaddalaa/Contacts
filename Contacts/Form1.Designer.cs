namespace Contacts
{
    partial class Form1
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.listContacts = new System.Windows.Forms.ListBox();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.txtfirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(188, 166);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(112, 27);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listContacts
            // 
            this.listContacts.FormattingEnabled = true;
            this.listContacts.ItemHeight = 19;
            this.listContacts.Location = new System.Drawing.Point(501, 64);
            this.listContacts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listContacts.Name = "listContacts";
            this.listContacts.Size = new System.Drawing.Size(196, 289);
            this.listContacts.TabIndex = 2;
            // 
            // txtlastName
            // 
            this.txtlastName.Location = new System.Drawing.Point(188, 115);
            this.txtlastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(112, 27);
            this.txtlastName.TabIndex = 3;
            // 
            // txtfirstName
            // 
            this.txtfirstName.Location = new System.Drawing.Point(188, 64);
            this.txtfirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(112, 27);
            this.txtfirstName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone Number :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(104, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 60);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfirstName);
            this.Controls.Add(this.txtlastName);
            this.Controls.Add(this.listContacts);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ListBox listContacts;
        private System.Windows.Forms.TextBox txtlastName;
        private System.Windows.Forms.TextBox txtfirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
    }
}

