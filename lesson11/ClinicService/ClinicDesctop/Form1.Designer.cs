namespace ClinicDesctop
{
    partial class Form1
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
            listViewClients = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderSurName = new ColumnHeader();
            columnHeaderFirstName = new ColumnHeader();
            columnHeaderPatronymic = new ColumnHeader();
            btnUpdate = new Button();
            Lavel1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textDocument = new TextBox();
            textSurname = new TextBox();
            textLastname = new TextBox();
            textPatronymic = new TextBox();
            textBirthday = new TextBox();
            BtnCreateClient = new Button();
            SuspendLayout();
            // 
            // listViewClients
            // 
            listViewClients.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderSurName, columnHeaderFirstName, columnHeaderPatronymic });
            listViewClients.FullRowSelect = true;
            listViewClients.GridLines = true;
            listViewClients.Location = new Point(12, 153);
            listViewClients.MultiSelect = false;
            listViewClients.Name = "listViewClients";
            listViewClients.Size = new Size(776, 285);
            listViewClients.TabIndex = 1;
            listViewClients.UseCompatibleStateImageBehavior = false;
            listViewClients.View = View.Details;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "#";
            // 
            // columnHeaderSurName
            // 
            columnHeaderSurName.Text = "Фамилия";
            columnHeaderSurName.Width = 200;
            // 
            // columnHeaderFirstName
            // 
            columnHeaderFirstName.Text = "Имя";
            columnHeaderFirstName.Width = 200;
            // 
            // columnHeaderPatronymic
            // 
            columnHeaderPatronymic.Text = "Отчество";
            columnHeaderPatronymic.Width = 200;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(673, 121);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Lavel1
            // 
            Lavel1.AutoSize = true;
            Lavel1.Location = new Point(15, 17);
            Lavel1.Name = "Lavel1";
            Lavel1.Size = new Size(61, 15);
            Lavel1.TabIndex = 3;
            Lavel1.Text = "Документ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 42);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 69);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 96);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 124);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 7;
            label4.Text = "День рождения";
            // 
            // textDocument
            // 
            textDocument.Location = new Point(113, 14);
            textDocument.Name = "textDocument";
            textDocument.Size = new Size(554, 23);
            textDocument.TabIndex = 8;
            // 
            // textSurname
            // 
            textSurname.Location = new Point(113, 41);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(554, 23);
            textSurname.TabIndex = 9;
            // 
            // textLastname
            // 
            textLastname.Location = new Point(113, 66);
            textLastname.Name = "textLastname";
            textLastname.Size = new Size(554, 23);
            textLastname.TabIndex = 10;
            // 
            // textPatronymic
            // 
            textPatronymic.Location = new Point(113, 92);
            textPatronymic.Name = "textPatronymic";
            textPatronymic.Size = new Size(554, 23);
            textPatronymic.TabIndex = 11;
            // 
            // textBirthday
            // 
            textBirthday.Location = new Point(113, 121);
            textBirthday.Name = "textBirthday";
            textBirthday.Size = new Size(554, 23);
            textBirthday.TabIndex = 12;
            // 
            // BtnCreateClient
            // 
            BtnCreateClient.Location = new Point(673, 12);
            BtnCreateClient.Name = "BtnCreateClient";
            BtnCreateClient.Size = new Size(115, 25);
            BtnCreateClient.TabIndex = 13;
            BtnCreateClient.Text = "Добавить";
            BtnCreateClient.UseVisualStyleBackColor = true;
            BtnCreateClient.Click += BtnCreateClient_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCreateClient);
            Controls.Add(textBirthday);
            Controls.Add(textPatronymic);
            Controls.Add(textLastname);
            Controls.Add(textSurname);
            Controls.Add(textDocument);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Lavel1);
            Controls.Add(btnUpdate);
            Controls.Add(listViewClients);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Моя клиника";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewClients;
        private Button btnUpdate;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderSurName;
        private ColumnHeader columnHeaderFirstName;
        private ColumnHeader columnHeaderPatronymic;
        private Label Lavel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textDocument;
        private TextBox textSurname;
        private TextBox textLastname;
        private TextBox textPatronymic;
        private TextBox textBirthday;
        private Button BtnCreateClient;
    }
}