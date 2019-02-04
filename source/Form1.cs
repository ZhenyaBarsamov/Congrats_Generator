using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Threading;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace CongratsGenerator {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            //Инициализация списка шрифтов
            List<string> fonts = InitializeForm.GetInstalledFontsNames();
            foreach(var font in fonts) {
                fontsList.Items.Add(font);
            }
            fontsList.Text = "Monotype Corsiva"; 
            //Инициализация списка шаблонов
            try {
                var templateFiles = InitializeForm.GetTemplatesNames();
                foreach(var file in templateFiles) {
                    templatesList.Items.Add(file.Name);
                }
                templatesList.Text = (string)templatesList.Items[0];
            }
            catch(Exception) {
                MessageBox.Show("Файлы шаблонов не найдены.\n" +
                    "Создайте каталог 'templates' в директории и заполните его соответствующим образом. " +
                    "Приложение будет закрыто.", "Ошибка");
                Environment.Exit(0); //код 0 - приложение успешно завершено
            }
            //Поиск файла с настроечными данными и поздравлениями
            if (File.Exists("CongratsInputData.xlsx")) {
                optionsFilePath.Text = "CongratsInputData.xlsx";
                optionsFilePath.Enabled = false;
            }
            else {
                MessageBox.Show(
                    "Файл настроек не найден.\n" +
                    "Создайте файл 'CongratsInputData.xlsx' в директории и заполните его соответствующим образом. " +
                    "Приложение будет закрыто.", "Ошибка");
                Environment.Exit(0);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label1_Click_1(object sender, EventArgs e) {

        }

        private void Generate_Click(object sender, EventArgs e) {
            Generate.Enabled = false;
            fontsList.Enabled = false;
            templatesList.Enabled = false;

            OutputFile.CreateOutputDirectory();
            string currentDirectory = Environment.CurrentDirectory;
            object templatePath = currentDirectory + @"\templates\" + templatesList.Text;
            object inputDataPath = currentDirectory + @"\" + optionsFilePath.Text;
            string congratsFileName = OutputFile.GetNextFileName();
            object congratPath = currentDirectory + @"\congratulations\" + congratsFileName + ".docx";
            //-------------------------------------------------
            var wordApp = new Word.Application(); //запускаем word теневым образом и открываем шаблон
            Word.Document congratsDoc = wordApp.Documents.Add();

            var excelApp = new Excel.Application(); //запускаем Excel
            Excel.Workbook inputData = excelApp.Workbooks.Add(inputDataPath);
            Excel.Worksheet namesSheet = inputData.Worksheets.Item["names"];
            Excel.Worksheet congratsSheet = inputData.Worksheets.Item["congratulations"];


            //Соберём все имена
            List<string> names = OfficeWork.GetNames(namesSheet);

            //Соберём все пожелания в группы
            Dictionary<int, List<string>> congrats = OfficeWork.GetCongrats(congratsSheet);
            int groupsCount = congrats.Keys.Count;


            //Генерация файла с поздравлениями
            Random random = new Random((int)DateTime.Now.Ticks);
            GenerateHelper.GetRandomGroups(random, groupsCount, out int group1, out int group2, out int group3);
            GenerateHelper.GetCongratsCountInEachGroup(congrats, group1, group2, group3, out int congratsCount1, out int congratsCount2, out int congratsCount3);
            int sheetsLeft = names.Count; //сколько страниц осталось заполнить
            foreach (var name in names) {
                wordApp.Selection.EndKey();
                wordApp.Selection.InsertFile((string)templatePath);
                congratsDoc.Bookmarks["name"].Range.Text = name;

                congratsDoc.Bookmarks["congrat1"].Range.Text = GenerateHelper.GetNextCongrat(random, congrats[group1], congratsCount1);
                congratsDoc.Bookmarks["congrat2"].Range.Text = GenerateHelper.GetNextCongrat(random, congrats[group2], congratsCount2);
                congratsDoc.Bookmarks["congrat3"].Range.Text = GenerateHelper.GetNextCongrat(random, congrats[group3], congratsCount3);

                if (sheetsLeft != 1)
                    wordApp.Selection.InsertNewPage();
                sheetsLeft--;
            }
            
            wordApp.Selection.WholeStory(); 
            wordApp.Selection.Font.Name = fontsList.Text; //меняем шрифт всего текста
            congratsDoc.SaveAs2(congratPath);
            //-------------------------------------------------
            wordApp.Quit(false);
            excelApp.Quit();
            Thread.Sleep(500); //ждём закрытия ворда

            MessageBox.Show("Генерация поздравлений завершена.\n" +
                "Вы можете найти их в файле " + congratsFileName + ".", "Генерация завершена");

            Generate.Enabled = true;
            fontsList.Enabled = true;
            templatesList.Enabled = true;
        }

        private void templatesList_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
