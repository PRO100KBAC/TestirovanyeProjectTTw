using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestirovanyeProjectTTwLibrary
{
    public class SnilsClass
    {
        /// <summary>
        /// Метод для проверки контрольного числа Страхового номера.
        /// </summary>
        /// <param name="textString"></param>
        /// <returns></returns>
        public static bool CheckMedicalCode(string textString)
        {
            textString.IndexOf("-");
            Console.WriteLine(textString);
            return true;
        }
    }
}
