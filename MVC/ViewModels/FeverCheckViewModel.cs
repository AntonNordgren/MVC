using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class FeverCheckViewModel
    {
        public int? Temp = null;
        public string Result { get; set; }

        public FeverCheckViewModel(int? temp, string result)
        {
            Temp = temp;
            Result = result;
        }
    }

    public static class UtilityFeverCheck
    {
        public static string CheckFever(int? temp)
        {

            if(temp == null)
            {
                return "";
            }
            else
            {
                string result;

                if (temp > 38)
                {
                    result = "fever";
                }
                else
                {
                    result = "not fever";
                }

                return result;
            }

            //if (temp != null)
            //{
            //    string result;

            //    if (temp > 38)
            //    {
            //        result = "fever";
            //    }
            //    else
            //    {
            //        result = "not fever";
            //    }

            //    return result;
            //}
            //else
            //{
            //    return "";
            //}

        }
    }
}
