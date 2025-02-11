using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_LinQ_Assignment
{
    internal static class intExtention
    {
        //Extension Method
        //Must Be In Static And Non Genaric Class
        public static int Reverse( this  int Number   ) 
        {
        int ReverseNumber = 0, Reminder=0;
            while (Number != 0) 
            {
                Reminder = Number %10 ;
                ReverseNumber = ReverseNumber *10 +Reminder;
                Number = Number /10;
            }
            return ReverseNumber;

        
         }


    }
}
