using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
 * |{assessment, evaluation, rating, estimate, estimation, grade}|
 * |     low     -   [ 0   -   4  ]                              |
 * |     middle  -   [ 5   -   9  ]                              |
 * |     high    -   [ 10  -   12 ]                              |
 * |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
 */

namespace quizForm
{
    class StatisticalAnalyzer
    {
        
        public static int points_addition = 0;
        public static int points_generalization = 0;
        public static int points_subtractionEqual = 0;
        public static int points_compare = 0;

        public static void CheckAnswer(String tableName, int questionId, int currentAnswer) 
        {
            int id = DBManager.TakeTrueFromDB(tableName, questionId);
            if (id == currentAnswer) 
            {
                switch (tableName) 
                {
                    case "Addition":
                        points_addition++;
                        break;

                    case "Generalization":
                        points_generalization++;
                        break;               

                    case "SubtractionEqual":
                        points_subtractionEqual++;                        
                        break;

                    case "Compare":
                        points_compare++;
                        break;

                }
            }
        }
    }
}
