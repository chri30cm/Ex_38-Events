using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_38_Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            Metronome m = new Metronome();

            m.Tick += Ticklistener.HeardIt;
            m.Tick += Ticklistener.BiiiiipNow;
            
            m.MetroStart();
        }
    }
}
