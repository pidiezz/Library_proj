namespace Library_proj
{
    partial class FormMenu
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
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonEmp = new System.Windows.Forms.Button();
            this.buttonBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClients
            // 
            this.buttonClients.Location = new System.Drawing.Point(46, 111);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(272, 44);
            this.buttonClients.TabIndex = 0;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonEmp
            // 
            this.buttonEmp.Location = new System.Drawing.Point(46, 183);
            this.buttonEmp.Name = "buttonEmp";
            this.buttonEmp.Size = new System.Drawing.Size(272, 46);
            this.buttonEmp.TabIndex = 1;
            this.buttonEmp.Text = "Сотрудник";
            this.buttonEmp.UseVisualStyleBackColor = true;
            this.buttonEmp.Click += new System.EventHandler(this.buttonEmp_Click);
            // 
            // buttonBox
            // 
            this.buttonBox.Location = new System.Drawing.Point(46, 256);
            this.buttonBox.Name = "buttonBox";
            this.buttonBox.Size = new System.Drawing.Size(272, 44);
            this.buttonBox.TabIndex = 2;
            this.buttonBox.Text = "Книги";
            this.buttonBox.UseVisualStyleBackColor = true;
            this.buttonBox.Click += new System.EventHandler(this.buttonBox_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 402);
            this.Controls.Add(this.buttonBox);
            this.Controls.Add(this.buttonEmp);
            this.Controls.Add(this.buttonClients);
            this.Name = "FormMenu";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonEmp;
        private System.Windows.Forms.Button buttonBox;
    }
}