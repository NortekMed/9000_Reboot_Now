using System;

using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;

namespace reboot
{
    class Program
    {
        [DllImport("coredll.dll", SetLastError = true)]
        static extern int SetSystemPowerState(string psState, int StateFlags, int Options);
        const int POWER_STATE_ON = 0x00010000;
        const int POWER_STATE_OFF = 0x00020000;
        const int POWER_STATE_SUSPEND = 0x00200000;
        const int POWER_FORCE = 4096;
        const int POWER_STATE_RESET = 0x00800000;

        static void Main(string[] args)
        {
            
           /* while (true)
            {
                int hour = DateTime.Now.Hour;
                int minute = DateTime.Now.Minute;
                int seconde = DateTime.Now.Second;

                if (hour == 0)
                {
                    if (minute == 0)
                    {
                        if (seconde == 0)
                        {
                            SetSystemPowerState(null, POWER_STATE_RESET, POWER_FORCE);
                        }
                    }
                    
                }
                //Console.WriteLine(DateTime.Now.ToString("dd/MM/yy HH:mm:ss"));
                Thread.Sleep(1000);

            }*/
            SetSystemPowerState(null, POWER_STATE_RESET, POWER_FORCE);
        }
       
    }
}
