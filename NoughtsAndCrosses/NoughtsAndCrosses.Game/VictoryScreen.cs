using osu.Framework.Allocation;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics;
using osu.Framework.Screens;

namespace NoughtsAndCrosses.Game;

public partial class VictoryScreen : Screen
{
    [BackgroundDependencyLoader]
    private void load()
    {
        InternalChild = new SpriteText
        {
            Text = "Player " +
                   (TurnManager.IsPlayerOne ? "one" : "two") +
                   " (" + (TurnManager.IsPlayerOne ? "X" : "O") +
                   ") wins!",
            Anchor = Anchor.Centre,
            Origin = Anchor.Centre,
            Font = FontUsage.Default.With(size: 64)
        };
    }
}
