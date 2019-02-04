using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace CongratsGenerator {
    class OfficeWork {
        /// <summary>
        /// Получение имён из листа Excel
        /// </summary>
        /// <param name="namesSheet"></param>
        /// <returns></returns>
        public static List<string> GetNames(Excel.Worksheet namesSheet) {
            List<string> names = new List<string>();
            int row = 1;
            while (true) {
                dynamic currentCell = namesSheet.Cells[row, 1].Value2;

                if (currentCell == null)
                    break;


                names.Add(currentCell.ToString());
                row++;
            }

            return names;
        }

        /// <summary>
        /// Получение поздравлений из листа Excel
        /// </summary>
        /// <param name="congratsSheet"></param>
        /// <returns></returns>
        public static Dictionary<int, List<string>> GetCongrats(Excel.Worksheet congratsSheet) {
            Dictionary<int, List<string>> congrats = new Dictionary<int, List<string>>();
            int column = 1, row = 1;
            while (true) {
                dynamic currentGroupCell = congratsSheet.Cells[1, column].Value2;

                if (currentGroupCell == null)
                    break;

                congrats[column] = new List<string>();
                row = 3;
                while (true) {
                    dynamic currentCell = congratsSheet.Cells[row, column].Value2;

                    if (currentCell == null)
                        break;

                    congrats[column].Add(currentCell.ToString());

                    row++;
                }
                column++;
            }

            return congrats;
        }
    }
}
