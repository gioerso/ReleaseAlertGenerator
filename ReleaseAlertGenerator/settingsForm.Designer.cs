namespace ReleaseAlertGenerator
{
    partial class settingsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectPhoneFile = new System.Windows.Forms.Button();
            this.selectAsFile = new System.Windows.Forms.Button();
            this.phoneDataGrid = new System.Windows.Forms.DataGridView();
            this.AsDataGrid = new System.Windows.Forms.DataGridView();
            this.createSettingsFileBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание конфигурационного JSON-файла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите файл с номерами телефонов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выберите файл с названиями АС";
            // 
            // selectPhoneFile
            // 
            this.selectPhoneFile.Location = new System.Drawing.Point(271, 37);
            this.selectPhoneFile.Name = "selectPhoneFile";
            this.selectPhoneFile.Size = new System.Drawing.Size(240, 23);
            this.selectPhoneFile.TabIndex = 3;
            this.selectPhoneFile.Text = "Выбор файла с номерами телефонов";
            this.selectPhoneFile.UseVisualStyleBackColor = true;
            this.selectPhoneFile.Click += new System.EventHandler(this.selectPhoneFile_Click);
            // 
            // selectAsFile
            // 
            this.selectAsFile.Location = new System.Drawing.Point(271, 69);
            this.selectAsFile.Name = "selectAsFile";
            this.selectAsFile.Size = new System.Drawing.Size(240, 23);
            this.selectAsFile.TabIndex = 4;
            this.selectAsFile.Text = "Выбор файла с названиями АС";
            this.selectAsFile.UseVisualStyleBackColor = true;
            this.selectAsFile.Click += new System.EventHandler(this.selectAsFile_Click);
            // 
            // phoneDataGrid
            // 
            this.phoneDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneDataGrid.Location = new System.Drawing.Point(15, 182);
            this.phoneDataGrid.Name = "phoneDataGrid";
            this.phoneDataGrid.Size = new System.Drawing.Size(240, 150);
            this.phoneDataGrid.TabIndex = 5;
            // 
            // AsDataGrid
            // 
            this.AsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsDataGrid.Location = new System.Drawing.Point(271, 182);
            this.AsDataGrid.Name = "AsDataGrid";
            this.AsDataGrid.Size = new System.Drawing.Size(240, 150);
            this.AsDataGrid.TabIndex = 6;
            // 
            // createSettingsFileBtn
            // 
            this.createSettingsFileBtn.Location = new System.Drawing.Point(15, 98);
            this.createSettingsFileBtn.Name = "createSettingsFileBtn";
            this.createSettingsFileBtn.Size = new System.Drawing.Size(496, 55);
            this.createSettingsFileBtn.TabIndex = 9;
            this.createSettingsFileBtn.Text = "Создать файл с настройками из импортированных данных";
            this.createSettingsFileBtn.UseVisualStyleBackColor = true;
            this.createSettingsFileBtn.Click += new System.EventHandler(this.createSettingsFileBtn_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 344);
            this.Controls.Add(this.createSettingsFileBtn);
            this.Controls.Add(this.AsDataGrid);
            this.Controls.Add(this.phoneDataGrid);
            this.Controls.Add(this.selectAsFile);
            this.Controls.Add(this.selectPhoneFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "settingsForm";
            this.Text = "Генератор CSV-файлов оповещений о внедрении - Окно создания конфига";
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectPhoneFile;
        private System.Windows.Forms.Button selectAsFile;
        private System.Windows.Forms.DataGridView phoneDataGrid;
        private System.Windows.Forms.DataGridView AsDataGrid;
        private System.Windows.Forms.Button createSettingsFileBtn;
    }
}