using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupdatastructures
{
    class Program
    {

        //STACK


        //QUEUE
        static void addHugeListQ(Queue<string> q)
        {
            q.Clear();
            int i = 0;
            string s = "New Entry ";
            for (i = 0; i < 2000; i++)
            {
                q.Enqueue(s + i);
            }
        }


        //DICTIONARY
        static void addHugeListD(Dictionary<string, int> d)
        {
            d.Clear();
            int i = 0;
            string s = "New Entry";
            for (i = 0; i < 2000; i++)
            {
                d.Add(s, i);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
