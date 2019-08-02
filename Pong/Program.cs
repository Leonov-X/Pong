using System;

namespace Pong
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new AppGame())
                game.Run();
        }
    }
}
