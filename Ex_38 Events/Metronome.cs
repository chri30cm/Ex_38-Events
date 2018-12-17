using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_38_Events
{
    public class Metronome
    {
        public event EventHandler Tick;
        public void MetroStart()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                if (Tick != null)
                {
                    Tick(this, new EventArgs());
                }
            }
        }
    }
}
