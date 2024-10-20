using osu.Framework.Platform;
using osu.Framework;
using NoughtsAndCrosses.Game;

namespace NoughtsAndCrosses.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableDesktopHost(@"NoughtsAndCrosses"))
            using (osu.Framework.Game game = new NoughtsAndCrossesGame())
                host.Run(game);
        }
    }
}