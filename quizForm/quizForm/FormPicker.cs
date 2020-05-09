using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace quizForm
{
    class FormPicker
    {
        // init object of forms
        public static GeneralizationForm generalizationForm = new GeneralizationForm();
        public static AdditionForm additionForm = new AdditionForm();
        public static SubtractionEqualForm subtractionEqualForm = new SubtractionEqualForm();
        public static CompareForm compareForm = new CompareForm();

        // list contains all form-objects
        //public static List<Form> formContainer = new List<Form>() { generalizationForm, additionForm, subtractionEqualForm };
        public static List<Form> formContainer = new List<Form>() { compareForm, subtractionEqualForm, additionForm, generalizationForm };
        // counterOfQuestions
        public static int counter_generalization = 3;
        public static int counter_addition = 3;
        public static int counter_subtractionEqual = 3;
        public static int counter_compare = 3;

        //
        public static String activeThemeTable = "";
        static Random numberGenerator = new Random();
        public static int pickIndex;


        //methods
        public static int numberGeneration()
        {
            pickIndex = numberGenerator.Next(formContainer.Count);
            return pickIndex;
        } // return random index of LIST

        public static void DempingManager(int index) {
            if (formContainer.ElementAt(index).GetType().Name.Contains("AdditionForm"))
            {
                if (counter_addition > 1) 
                {
                    counter_addition--;
                }
                else
                {
                    formContainer.Remove(formContainer.ElementAt(index));
                }
            }
            else if (formContainer.ElementAt(index).GetType().Name.Contains("GeneralizationForm"))
            {
                if (counter_generalization > 1)
                {
                    counter_generalization--;
                }
                else 
                {
                    formContainer.Remove(formContainer.ElementAt(index));
                }
            }
            else if(formContainer.ElementAt(index).GetType().Name.Contains("SubtractionEqualForm"))
            {
                if (counter_subtractionEqual > 1)
                {
                    counter_subtractionEqual--;
                }
                else
                {
                    formContainer.Remove(formContainer.ElementAt(index));
                }
            }
            else if (formContainer.ElementAt(index).GetType().Name.Contains("CompareForm"))
            {
                if (counter_compare > 1)
                {
                    counter_compare--;
                }
                else
                {
                    formContainer.Remove(formContainer.ElementAt(index));
                }
            }
        }













    }
}
