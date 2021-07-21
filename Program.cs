using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace keyboard_emulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Type("meow{Win}", 1, 200, 10));
        }

        static string Type(string message, int cycles, int delay,  int initialDelay)
        {
            Console.WriteLine($"The keypresses will start firing after {initialDelay} seconds");
            Thread.Sleep(initialDelay * 1000);

            for (int i = 0; i < cycles; i++)
            {
                Thread.Sleep(delay);
                SendKeys.SendWait(message);
            }
            return "Keypresses emulated successfully";
        }
    }
}
