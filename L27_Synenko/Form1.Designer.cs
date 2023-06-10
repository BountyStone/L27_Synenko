namespace L27_Synenko
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            drivesListBox = new ListBox();
            directoriesListBox = new ListBox();
            filesListBox = new ListBox();
            propertiesTextBox = new TextBox();
            pictureBox = new PictureBox();
            this.Controls.Add(pictureBox); // Додайте PictureBox до вашої форми
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Масштабувати зображення, щоб помістити його повністю в PictureBox
            pictureBox.Click += pictureBox_Click; // Додайте обробник подій Click

            contentTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // drivesListBox
            // 
            drivesListBox.FormattingEnabled = true;
            drivesListBox.ItemHeight = 20;
            drivesListBox.Location = new Point(17, 69);
            drivesListBox.Margin = new Padding(4, 5, 4, 5);
            drivesListBox.Name = "drivesListBox";
            drivesListBox.Size = new Size(196, 224);
            drivesListBox.TabIndex = 0;
            drivesListBox.SelectedIndexChanged += drivesListBox_SelectedIndexChanged;
            // 
            // directoriesListBox
            // 
            directoriesListBox.FormattingEnabled = true;
            directoriesListBox.ItemHeight = 20;
            directoriesListBox.Location = new Point(684, 69);
            directoriesListBox.Margin = new Padding(4, 5, 4, 5);
            directoriesListBox.Name = "directoriesListBox";
            directoriesListBox.Size = new Size(283, 284);
            directoriesListBox.TabIndex = 1;
            directoriesListBox.SelectedIndexChanged += directoriesListBox_SelectedIndexChanged;
            // 
            // filesListBox
            // 
            filesListBox.FormattingEnabled = true;
            filesListBox.ItemHeight = 20;
            filesListBox.Location = new Point(684, 365);
            filesListBox.Margin = new Padding(4, 5, 4, 5);
            filesListBox.Name = "filesListBox";
            filesListBox.Size = new Size(283, 284);
            filesListBox.TabIndex = 2;
            filesListBox.SelectedIndexChanged += filesListBox_SelectedIndexChanged;
            // 
            // propertiesTextBox
            // 
            propertiesTextBox.Location = new Point(311, 69);
            propertiesTextBox.Margin = new Padding(4, 5, 4, 5);
            propertiesTextBox.Multiline = true;
            propertiesTextBox.Name = "propertiesTextBox";
            propertiesTextBox.Size = new Size(284, 146);
            propertiesTextBox.TabIndex = 3;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(17, 423);
            pictureBox.Margin = new Padding(4, 5, 4, 5);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(508, 251);
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // contentTextBox
            // 
            contentTextBox.Location = new Point(311, 240);
            contentTextBox.Margin = new Padding(4, 5, 4, 5);
            contentTextBox.Multiline = true;
            contentTextBox.Name = "contentTextBox";
            contentTextBox.Size = new Size(284, 146);
            contentTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(contentTextBox);
            Controls.Add(pictureBox);
            Controls.Add(propertiesTextBox);
            Controls.Add(filesListBox);
            Controls.Add(directoriesListBox);
            Controls.Add(drivesListBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox drivesListBox;
        private System.Windows.Forms.ListBox directoriesListBox;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.TextBox propertiesTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox contentTextBox;
    }
}
