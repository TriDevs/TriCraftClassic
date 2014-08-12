using System;
using System.Drawing;

namespace TriDevs.TriCraftClassic
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Window window = new Window(1280, 720);
            window.Run(60.0);
        }
    }
}
