using System;
using System.Drawing;

namespace TriDevs.TriCraftClassic
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Window window = new Window();
            window.Run(60.0);
        }
    }
}
