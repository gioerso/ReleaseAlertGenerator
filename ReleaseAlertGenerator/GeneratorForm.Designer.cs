namespace ReleaseAlertGenerator
{
    partial class GeneratorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.releaseTextBox = new System.Windows.Forms.TextBox();
            this.RoVTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AsCB = new System.Windows.Forms.ComboBox();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.releaseDate = new System.Windows.Forms.DateTimePicker();
            this.settingsFormBtn = new System.Windows.Forms.Button();
            this.generateCSVBtn = new System.Windows.Forms.Button();
            this.readConfigFileBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.senderNameTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.reverseVersion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Релиз";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "РоВ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Версия";
            // 
            // resultCB
            // 
            this.resultCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resultCB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultCB.FormattingEnabled = true;
            this.resultCB.Items.AddRange(new object[] {
            "Успех",
            "Провал"});
            this.resultCB.Location = new System.Drawing.Point(183, 49);
            this.resultCB.Name = "resultCB";
            this.resultCB.Size = new System.Drawing.Size(124, 22);
            this.resultCB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Выберите результат внедрения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(96, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Конструктор CSV-файлов для рассылки SMS-сообщений";
            // 
            // releaseTextBox
            // 
            this.releaseTextBox.Location = new System.Drawing.Point(56, 105);
            this.releaseTextBox.Name = "releaseTextBox";
            this.releaseTextBox.Size = new System.Drawing.Size(251, 20);
            this.releaseTextBox.TabIndex = 6;
            // 
            // RoVTextBox
            // 
            this.RoVTextBox.Location = new System.Drawing.Point(56, 131);
            this.RoVTextBox.Name = "RoVTextBox";
            this.RoVTextBox.Size = new System.Drawing.Size(251, 20);
            this.RoVTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(313, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "АС -";
            // 
            // AsCB
            // 
            this.AsCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AsCB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AsCB.FormattingEnabled = true;
            this.AsCB.Location = new System.Drawing.Point(339, 49);
            this.AsCB.Name = "AsCB";
            this.AsCB.Size = new System.Drawing.Size(214, 22);
            this.AsCB.TabIndex = 10;
            // 
            // versionTextBox
            // 
            this.versionTextBox.Location = new System.Drawing.Point(56, 79);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.Size = new System.Drawing.Size(251, 20);
            this.versionTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Дата";
            // 
            // releaseDate
            // 
            this.releaseDate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.releaseDate.Location = new System.Drawing.Point(56, 157);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(251, 20);
            this.releaseDate.TabIndex = 13;
            // 
            // settingsFormBtn
            // 
            this.settingsFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settingsFormBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsFormBtn.Location = new System.Drawing.Point(339, 99);
            this.settingsFormBtn.Name = "settingsFormBtn";
            this.settingsFormBtn.Size = new System.Drawing.Size(214, 23);
            this.settingsFormBtn.TabIndex = 14;
            this.settingsFormBtn.Text = "Создание конфигурационного файла";
            this.settingsFormBtn.UseVisualStyleBackColor = true;
            this.settingsFormBtn.Click += new System.EventHandler(this.settingsFormBtn_Click);
            // 
            // generateCSVBtn
            // 
            this.generateCSVBtn.BackColor = System.Drawing.Color.LightGreen;
            this.generateCSVBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateCSVBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateCSVBtn.Location = new System.Drawing.Point(339, 154);
            this.generateCSVBtn.Name = "generateCSVBtn";
            this.generateCSVBtn.Size = new System.Drawing.Size(214, 23);
            this.generateCSVBtn.TabIndex = 16;
            this.generateCSVBtn.Text = "Создать CSV";
            this.generateCSVBtn.UseVisualStyleBackColor = false;
            this.generateCSVBtn.Click += new System.EventHandler(this.generateCSVBtn_Click);
            // 
            // readConfigFileBtn
            // 
            this.readConfigFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.readConfigFileBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readConfigFileBtn.Location = new System.Drawing.Point(339, 125);
            this.readConfigFileBtn.Name = "readConfigFileBtn";
            this.readConfigFileBtn.Size = new System.Drawing.Size(214, 23);
            this.readConfigFileBtn.TabIndex = 17;
            this.readConfigFileBtn.Text = "Чтение конфигурационного файла";
            this.readConfigFileBtn.UseVisualStyleBackColor = true;
            this.readConfigFileBtn.Click += new System.EventHandler(this.readConfigFileBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 14);
            this.label8.TabIndex = 18;
            this.label8.Text = "Отправитель";
            // 
            // senderNameTB
            // 
            this.senderNameTB.Location = new System.Drawing.Point(88, 184);
            this.senderNameTB.Name = "senderNameTB";
            this.senderNameTB.Size = new System.Drawing.Size(219, 20);
            this.senderNameTB.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(313, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 14);
            this.label9.TabIndex = 20;
            this.label9.Text = "Версия для отката";
            // 
            // reverseVersion
            // 
            this.reverseVersion.Location = new System.Drawing.Point(424, 77);
            this.reverseVersion.Name = "reverseVersion";
            this.reverseVersion.Size = new System.Drawing.Size(129, 20);
            this.reverseVersion.TabIndex = 21;
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 210);
            this.Controls.Add(this.reverseVersion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.senderNameTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.readConfigFileBtn);
            this.Controls.Add(this.generateCSVBtn);
            this.Controls.Add(this.settingsFormBtn);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.versionTextBox);
            this.Controls.Add(this.AsCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RoVTextBox);
            this.Controls.Add(this.releaseTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GeneratorForm";
            this.Text = "Генератор CSV-файлов оповещений о внедрении - Основное окно";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox resultCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox releaseTextBox;
        private System.Windows.Forms.TextBox RoVTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox AsCB;
        private System.Windows.Forms.TextBox versionTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker releaseDate;
        private System.Windows.Forms.Button settingsFormBtn;
        private System.Windows.Forms.Button generateCSVBtn;
        private System.Windows.Forms.Button readConfigFileBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox senderNameTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox reverseVersion;
    }
}

