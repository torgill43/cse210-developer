using System;
using HiLo.Game;

namespace HiLo
{
    class Program
    {
        static int Main(string[] args)
        {
            Director d = new Director();
            d.StartGame();
            return 0;
        }
    }
}