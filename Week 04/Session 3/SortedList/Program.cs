using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary gives us an unsorted list
            //Dictionary<string, int> personAge = new Dictionary<string, int>();

            // SortedList automatically sorts by the index as you add entries
            // you are only allowed one entry per index
            SortedList<string, int> personAge = new SortedList<string, int>();

            personAge["david"] = 29;

            // adding two items with the same key is not allowed
            // this will cause a run-time exception
            personAge.Add("david", 34);
            personAge["sue"] = 82;
            personAge["cathy"] = 60;

            List<double> dSortedNumber = new List<double>();
            foreach(double thisNumber in dSortedNumber)
            {

            }

            // both Dictionary<> and SortedList<> are accessed by the KeyValuePair<> data type
            foreach( KeyValuePair<string,int> thisPerson in personAge )
            {
                Console.WriteLine("person[{0}] = {1}", thisPerson.Key, thisPerson.Value);
            }

        }
    }
}
