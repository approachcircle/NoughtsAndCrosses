using osu.Framework.Allocation;
using osu.Framework.Platform;
using NUnit.Framework;

namespace NoughtsAndCrosses.Game.Tests.Visual
{
    [TestFixture]
    public partial class TestSceneNoughtsAndCrossesGame : NoughtsAndCrossesTestScene
    {
        // Add visual tests to ensure correct behaviour of your game: https://github.com/ppy/osu-framework/wiki/Development-and-Testing
        // You can make changes to classes associated with the tests and they will recompile and update immediately.

        private NoughtsAndCrossesGame game;

        [BackgroundDependencyLoader]
        private void load(GameHost host)
        {
            game = new NoughtsAndCrossesGame();
            game.SetHost(host);

            AddGame(game);
        }
    }
}