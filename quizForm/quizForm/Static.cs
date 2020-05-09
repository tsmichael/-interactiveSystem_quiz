using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizForm
{
    class Static
    {
        public static int count = 3;
        public static String[] table_array = { "Hello", "World", "hu", "guses" };
        public static List<String> tables = new List<String>();
        public static GeneralizationForm generalizationForm = new GeneralizationForm();
        public static AdditionForm additionForm = new AdditionForm();
        public static SubtractionEqualForm subtractionEqualForm = new SubtractionEqualForm();

        public static List<Object> formContainer = new List<Object>() { generalizationForm, additionForm, subtractionEqualForm };
        static Random numberGenerator = new Random();
        static String ind;
        public static String RANDOM() {
            for (int i = 0; i < 100; i++)
            {
                ind = numberGenerator.Next(formContainer.Count).ToString();
                if (ind == "3") {
                    return "LELELOK";
                }
            }
            //ind = numberGenerator.Next(formContainer.Count).ToString();
            return ind;
        }


        public static String OutName() {

            //genObj.ToString;

            
            return generalizationForm.GetType().Name;
        }

       

        public static void RemoveOutField() {

            foreach (String ela in tables) {
                if (ela == "Hello")
                    tables.Remove(ela);
            }  

          
        }


        public static void CountDemping() {

            count--;
        

        }
    }
}
