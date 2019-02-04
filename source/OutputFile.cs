using System;
using System.IO;

namespace CongratsGenerator {
    class OutputFile {
        /// <summary>
        /// Создание каталога под выходные файлы в случае, если таковой отсутствует
        /// </summary>
        public static void CreateOutputDirectory() {
            DirectoryInfo outputDirectory = new DirectoryInfo("congratulations");
            if (!outputDirectory.Exists)
                outputDirectory.Create();
        }

        /// <summary>
        /// Получение имени для сохранения поздравления-порядковый номер в каталоге плюс текущее кол-во секунд и миллисекунд
        /// </summary>
        /// <returns></returns>
        public static string GetNextFileName() {
            DirectoryInfo outputDirectory = new DirectoryInfo("congratulations");
            return outputDirectory.GetFiles().Length.ToString() + DateTime.Now.Second + DateTime.Now.Millisecond;
        }
    }
}
