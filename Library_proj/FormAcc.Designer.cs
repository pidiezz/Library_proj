namespace Library_proj
{
    partial class FormBook
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelDateCap = new System.Windows.Forms.Label();
            this.labelDateDeliv = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxDateCap = new System.Windows.Forms.TextBox();
            this.textBoxDateDeliv = new System.Windows.Forms.TextBox();
            this.listViewBook = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateDeliv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(23, 130);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(72, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Название";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(23, 169);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(74, 17);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Описание";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(23, 207);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(45, 17);
            this.labelGenre.TabIndex = 2;
            this.labelGenre.Text = "Жанр";
            // 
            // labelDateCap
            // 
            this.labelDateCap.AutoSize = true;
            this.labelDateCap.Location = new System.Drawing.Point(23, 248);
            this.labelDateCap.Name = "labelDateCap";
            this.labelDateCap.Size = new System.Drawing.Size(91, 17);
            this.labelDateCap.TabIndex = 3;
            this.labelDateCap.Text = "Дата взятия";
            // 
            // labelDateDeliv
            // 
            this.labelDateDeliv.AutoSize = true;
            this.labelDateDeliv.Location = new System.Drawing.Point(23, 292);
            this.labelDateDeliv.Name = "labelDateDeliv";
            this.labelDateDeliv.Size = new System.Drawing.Size(85, 17);
            this.labelDateDeliv.TabIndex = 4;
            this.labelDateDeliv.Text = "Дата сдачи";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(141, 130);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(145, 22);
            this.textBoxTitle.TabIndex = 6;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(141, 169);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(145, 22);
            this.textBoxDescription.TabIndex = 7;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(141, 207);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(145, 22);
            this.textBoxGenre.TabIndex = 8;
            // 
            // textBoxDateCap
            // 
            this.textBoxDateCap.Location = new System.Drawing.Point(141, 248);
            this.textBoxDateCap.Name = "textBoxDateCap";
            this.textBoxDateCap.Size = new System.Drawing.Size(145, 22);
            this.textBoxDateCap.TabIndex = 9;
            // 
            // textBoxDateDeliv
            // 
            this.textBoxDateDeliv.Location = new System.Drawing.Point(141, 292);
            this.textBoxDateDeliv.Name = "textBoxDateDeliv";
            this.textBoxDateDeliv.Size = new System.Drawing.Size(145, 22);
            this.textBoxDateDeliv.TabIndex = 10;
            // 
            // listViewBook
            // 
            this.listViewBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.ColumnHeader1,
            this.Desc,
            this.Genre,
            this.DateCap,
            this.DateDeliv});
            this.listViewBook.FullRowSelect = true;
            this.listViewBook.GridLines = true;
            this.listViewBook.HideSelection = false;
            this.listViewBook.Location = new System.Drawing.Point(302, 13);
            this.listViewBook.Margin = new System.Windows.Forms.Padding(4);
            this.listViewBook.MultiSelect = false;
            this.listViewBook.Name = "listViewBook";
            this.listViewBook.Size = new System.Drawing.Size(573, 425);
            this.listViewBook.TabIndex = 18;
            this.listViewBook.UseCompatibleStateImageBehavior = false;
            this.listViewBook.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Название";
            // 
            // Desc
            // 
            this.Desc.Text = "Описание";
            this.Desc.Width = 200;
            // 
            // Genre
            // 
            this.Genre.Text = "Жанр";
            // 
            // DateCap
            // 
            this.DateCap.Text = "Дата взятия";
            this.DateCap.Width = 100;
            // 
            // DateDeliv
            // 
            this.DateDeliv.Text = "Дата сдачи";
            this.DateDeliv.Width = 100;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(628, 468);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(247, 59);
            this.buttonDel.TabIndex = 27;
            this.buttonDel.Text = "Удалить ";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click_1);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(331, 468);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(254, 59);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click_1);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(39, 468);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(247, 59);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "Создать ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 540);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewBook);
            this.Controls.Add(this.textBoxDateDeliv);
            this.Controls.Add(this.textBoxDateCap);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelDateDeliv);
            this.Controls.Add(this.labelDateCap);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormBook";
            this.Text = "Книги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelDateCap;
        private System.Windows.Forms.Label labelDateDeliv;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxDateCap;
        private System.Windows.Forms.TextBox textBoxDateDeliv;
        private System.Windows.Forms.ListView listViewBook;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader Desc;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ColumnHeader DateCap;
        private System.Windows.Forms.ColumnHeader DateDeliv;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
    }
}