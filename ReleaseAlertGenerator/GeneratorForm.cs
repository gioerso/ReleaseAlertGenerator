using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReleaseAlertGenerator
{
    public partial class GeneratorForm : Form
    {
        private static List<string> phoneNumbersList = new List<string>();
        private static List<string> programList = new List<string>();

        public GeneratorForm()
        {
            InitializeComponent();
        }

        private void settingsFormBtn_Click(object sender, EventArgs e)
        {
            settingsForm settingsForm = new settingsForm();
            settingsForm.Show();
        }

        private void readConfigFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog configFileDialog = new OpenFileDialog();
            DialogResult result = configFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string configFilePath = configFileDialog.FileName;
                ReadConfigurationJson(configFilePath);
            }

            AsCB.DataSource = programList;
        }
        static void ReadConfigurationJson(string jsonFilePath)
        {
            // Чтение JSON-файла
            string json = File.ReadAllText(jsonFilePath);

            // Десериализация JSON-строки в список словарей
            var items = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(json);

            if (items != null)
            {
                foreach (var item in items)
                {
                    if (item.ContainsKey("phoneNumber"))
                    {
                        phoneNumbersList.Add(item["phoneNumber"]);
                    }
                    if (item.ContainsKey("softwareName"))
                    {
                        programList.Add(item["softwareName"]);
                    }
                }
            }
        }
        static void WriteToCsv(string csvFilePath, List<string> phoneNumbers, string alertMessage)
        {
            using (var writer = new StreamWriter(csvFilePath))
            {
                for (int i = 0; i < phoneNumbers.Count; i++)
                {
                    // Формирование строки для записи
                    string line = $"{phoneNumbers[i]};{alertMessage}";
                    writer.WriteLine(line);
                }
            }
        }

        private void generateCSVBtn_Click(object sender, EventArgs e)
        {
            string currDir = Environment.CurrentDirectory + $"/{releaseTextBox.Text}.csv";

            string currentAS = AsCB.Text;
            string failMessage = "Произошла ошибка при установке в ПРОМ АС";
            string successMessage = "Успешное внедрение релиза АС";
            string alertMessage;


            if (resultCB.Text == "Успех")
            {
                alertMessage = $"{successMessage} {currentAS}. Дата: {releaseDate.Text} Версия: {versionTextBox.Text}. Релиз: {releaseTextBox.Text}. РоВ: {RoVTextBox.Text}. Подсистема функционирует в штатном режиме. Отправитель: {senderNameTB.Text}";
            }
            else
            {
                alertMessage = $"{failMessage} {currentAS}. Дата: {releaseDate.Text} Версия: {versionTextBox.Text}. ПО возвращено на версию {reverseVersion.Text}. Релиз: {releaseTextBox.Text}. РоВ: {RoVTextBox.Text}. Подсистема функционирует в штатном режиме. Отправитель: {senderNameTB.Text}";
            }

            WriteToCsv(currDir, phoneNumbersList, alertMessage);
            MessageBox.Show($"Данные успешно записаны в файл '{currDir}'.");
        }
    }
}
