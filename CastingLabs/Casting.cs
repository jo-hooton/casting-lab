using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingLabs
{
    public class Casting
    {

        public int CastFromDoubleToInt(double d)
        {
            /*
             *  Cast from a double to an int and return the integer cast
             * 
            */
            return (int)d;


        }


        public string BoxThenUnbox(DateTime dateTime)
        {
            /*
             *  Create a DateTime object corresponding to 1 Jan 2001 at 1 minute
             *  after midnight
             *  
             *  Box it to an object
             *  
             *  Unbox it back to a DateTime object and return it 
             *  as a string in the format
             *  DateTime.ToString("MM/dd/yyyy HH:mm:ss")            
             */

            object dateTimeObject = (object)dateTime;

            DateTime dateTimeUnboxed = (DateTime)dateTimeObject;

            return dateTimeUnboxed.ToString("MM/dd/yyyy HH:mm:ss");
        }


    }
}
