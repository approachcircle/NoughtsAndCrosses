using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Screens;

namespace NoughtsAndCrosses.Game
{
    public partial class MainScreen : Screen
    {
        private SpriteText gameInfo;

        [BackgroundDependencyLoader]
        private void load()
        {
            gameInfo = new SpriteText
            {
                Anchor = Anchor.TopCentre,
                Origin = Anchor.TopCentre,
                Y = 50,
                Font = FontUsage.Default.With(size: 64)
            };
            InternalChildren =
            [
                new PositionGrid(),
                gameInfo
            ];
        }

        protected override void Update()
        {
            gameInfo.Text = "Player " + (TurnManager.IsPlayerOne ? "one" : "two");
            gameInfo.Text += " (using '" + (TurnManager.IsPlayerOne ? "X" : "O") + "')";
        }
    }
}
