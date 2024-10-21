using osu.Framework.Allocation;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Screens;

namespace NoughtsAndCrosses.Game
{
    public partial class MainScreen : Screen
    {
        private SpriteText gameInfo;
        public static Bindable<bool> PlayerHasWon { get; private set; }

        [BackgroundDependencyLoader]
        private void load()
        {
            PlayerHasWon = new Bindable<bool>();
            PlayerHasWon.ValueChanged += e =>
            {
                if (e.NewValue)
                {
                    AddInternal(new SpriteText
                    {
                        Anchor = Anchor.BottomCentre,
                        Origin = Anchor.BottomCentre,
                        Y = -50,
                        Font = FontUsage.Default.With(size: 64),
                        Text = "Player " + (TurnManager.IsPlayerOne ? "one" : "two") + " (" +
                               (TurnManager.IsPlayerOne ? "X" : "O") + ") wins!"
                    });
                }
            };
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
            gameInfo.Text += " (using " + (TurnManager.IsPlayerOne ? "X" : "O") + ")";
        }
    }
}
