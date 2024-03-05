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
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace ReleaseAlertGenerator
{
    public partial class settingsForm : Form
    {
        // init
        private string phonePath;
        private string programListPath;
        private string settingsPath;
        private List<string> phoneNumbersList = new List<string>();
        private List<string> programList = new List<string>();

        public string settingPath { get; }

        public settingsForm()
        {
            InitializeComponent();
        }

        static IEnumerable<string> ReadCSVFile(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';'); // Предполагается, что значения в CSV разделены точкой с запятой
                    yield return values[0]; // Возвращаем номер телефона, предполагая, что он находится в первом столбце
                }
            }
        }

        private void selectPhoneFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog phoneFileDialog = new OpenFileDialog();
            DialogResult result = phoneFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                phonePath = phoneFileDialog.FileName;
                phoneNumbersList = ReadCSVFile(phonePath).ToList();
            }

            phoneDataGrid.DataSource = phoneNumbersList;
        }

        private void selectAsFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog programFilePath = new OpenFileDialog();
            DialogResult result = programFilePath.ShowDialog();

            if (result == DialogResult.OK)
            {
                programListPath = programFilePath.FileName;
                programList = ReadCSVFile(programListPath).ToList();
            }

            AsDataGrid.DataSource = programList;
        }

        private void createSettingsFileBtn_Click(object sender, EventArgs e)
        {
            if(programList.Count != 0 && phoneNumbersList.Count != 0)
            {
                // Создаем список объектов для сериализации
                var configurationItems = new List<Dictionary<string, string>>();

                for (int i = 0; i < phoneNumbersList.Count && i < programList.Count; i++)
                {
                    configurationItems.Add(new Dictionary<string, string>
                    {
                        { "phoneNumber", phoneNumbersList[i] },
                        { "softwareName", programList[i] }
                    });
                }

                // Сериализация в JSON
                string json = JsonConvert.SerializeObject(configurationItems, Formatting.Indented);

                string currDir = Environment.CurrentDirectory + "/configuration.json";

                // Запись в файл
                File.WriteAllText(currDir, json);

                MessageBox.Show($"Конфигурационный JSON-файл успешно создан по пути {currDir}.");
            }
            else
            {
                MessageBox.Show("Выберите файлы с номерами телефонов и названиями АС и повторите попытку.");
            }
        }
    }
}
