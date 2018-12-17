using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_38_Events
{
    public class Ticklistener
    {
        public static void HeardIt(object o, EventArgs e)
        {
            System.Console.WriteLine("For the record: I’m alive!");
        }

        public static void BiiiiipNow(object o, EventArgs e)
        {

           Console.WriteLine("MEEEEP!");
        }
    }
}
