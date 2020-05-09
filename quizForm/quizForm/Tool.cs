using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizForm
{
    class Tool
    {
        public static int ChooseIDForQuestion(String tableName)
        {
            List<int> idList = DBManager.TakeIdFromDB(tableName);
            Random random = new Random();
            int randomIndex = random.Next(idList.Count());
            int questionId = idList.ElementAt(randomIndex);
            return questionId;
        }

    }
}
