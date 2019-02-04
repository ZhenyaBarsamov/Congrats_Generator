using System.Collections.Generic;
using System.IO;

namespace CongratsGenerator {
    class InitializeForm {
        /// <summary>
        /// Получение списка названий шрифтов
        /// </summary>
        /// <returns></returns>
        public static List<string> GetInstalledFontsNames() {
            var result = new List<string>();
            var installedFonts = new System.Drawing.Text.InstalledFontCollection();
            var installedFontFamilies = installedFonts.Families;
            foreach (var fontFamily in installedFontFamilies)
                result.Add(fontFamily.Name);

            return result;
        }

        /// <summary>
        /// Получение массива имён файлов шаблонов
        /// </summary>
        /// <returns></returns>
        public static FileInfo[] GetTemplatesNames() {
            DirectoryInfo directory = new DirectoryInfo("templates");
            return directory.GetFiles("Form*.docx");
        }
    }
}
