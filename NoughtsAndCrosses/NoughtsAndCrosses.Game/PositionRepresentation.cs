using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osuTK.Graphics;

namespace NoughtsAndCrosses.Game;

public partial class PositionRepresentation : Container
{
    private char playerCharacter = ' ';
    private SpriteText characterObject;

    [BackgroundDependencyLoader]
    private void load()
    {
        Anchor = Anchor.Centre;
        Origin = Anchor.Centre;
        characterObject = new SpriteText
        {
            Anchor = Anchor.Centre,
            Origin = Anchor.Centre,
            Font = FontUsage.Default.With(size: 50)
        };
        InternalChildren =
        [
            new Box
            {
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,
                Colour = Color4.Gray,
                Width = 100,
                Height = 100
            },
            characterObject
        ];
    }

    protected override void Update()
    {
        base.Update();
        characterObject.Text = playerCharacter.ToString();
    }

    public void SetPlayerCharacter(char character)
    {
        playerCharacter = character;
    }
}
