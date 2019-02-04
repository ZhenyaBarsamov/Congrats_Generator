using System;
using System.Collections.Generic;

namespace CongratsGenerator {
    class GenerateHelper {
        /// <summary>
        /// Содержится ли x в целочисленном массиве array
        /// </summary>
        /// <param name="x"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        static bool IsNumbInArray(int x, int[] array) {
            foreach (var numb in array)
                if (x == numb)
                    return true;
            return false;
        }

        /// <summary>
        /// Генерация случайного числа, не содержащегося в массиве otherNumbs
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="otherNumbs"></param>
        /// <returns></returns>
        static int GenerateNumbNotEqualToOther(Random generator, int min, int max, int[] otherNumbs) {
            int tmp;
            while (true) {
                tmp = generator.Next(min, max);
                if (!IsNumbInArray(tmp, otherNumbs))
                    break;
            }
            return tmp;
        }

        /// <summary>
        /// Получение трёх случайных разных номеров групп поздравлений
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="groupsCount"></param>
        /// <param name="group1"></param>
        /// <param name="group2"></param>
        /// <param name="group3"></param>
        public static void GetRandomGroups(Random generator, int groupsCount, out int group1, out int group2, out int group3) {
            group1 = generator.Next(1, groupsCount + 1);
            group2 = GenerateNumbNotEqualToOther(generator, 1, groupsCount + 1, new int[] { group1 });
            group3 = GenerateNumbNotEqualToOther(generator, 1, groupsCount + 1, new int[] { group1, group2 });
        }

        /// <summary>
        /// Получить следующее поздравление из группы поздравлений
        /// </summary>
        /// <param name="random"></param>
        /// <param name="group"></param>
        /// <param name="congratsCount"></param>
        /// <returns></returns>
        public static string GetNextCongrat(Random random, List<string> group, int congratsCount) {
            int randomIndex = random.Next(0, congratsCount);
            return group[randomIndex];
        }

        /// <summary>
        /// Посчитать количество поздравлений в каждой выбранной группе
        /// </summary>
        /// <param name="congrats"></param>
        /// <param name="group1"></param>
        /// <param name="group2"></param>
        /// <param name="group3"></param>
        /// <param name="cCount1"></param>
        /// <param name="cCount2"></param>
        /// <param name="cCount3"></param>
        public static void GetCongratsCountInEachGroup(Dictionary<int, List<string>> congrats, int group1, int group2, int group3,
            out int cCount1, out int cCount2, out int cCount3) {
            cCount1 = congrats[group1].Count;
            cCount2 = congrats[group2].Count;
            cCount3 = congrats[group3].Count;
        }
    }
}
