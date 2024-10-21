using Markdig.Helpers;
using osu.Framework.Allocation;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Input.Events;
using osuTK.Graphics;

namespace NoughtsAndCrosses.Game;

public partial class PositionRepresentation : Container
{
    private Bindable<char> playerCharacter = new();
    private SpriteText characterObject;
    private Box background;

    [BackgroundDependencyLoader]
    private void load()
    {
        Anchor = Anchor.Centre;
        Origin = Anchor.Centre;
        background = new Box
        {
            Anchor = Anchor.Centre,
            Origin = Anchor.Centre,
            Colour = Color4.Gray,
            Width = 100,
            Height = 100
        };
        characterObject = new SpriteText
        {
            Anchor = Anchor.Centre,
            Origin = Anchor.Centre,
            Font = FontUsage.Default.With(size: 50)
        };
        playerCharacter.BindValueChanged(
            newValue => characterObject.Text = newValue.NewValue.ToString(),
            true);
        InternalChildren =
        [
            background,
            characterObject
        ];
        Width = 100;
        Height = 100;
    }

    protected override void Update()
    {

    }

    protected override bool OnMouseDown(MouseDownEvent e)
    {
        this.ScaleTo(0.8f);
        return true;
    }

    protected override void OnMouseUp(MouseUpEvent e)
    {
        this.ScaleTo(1);
        if (!playerCharacter.Value.IsDigit())
        {
            background
                .FadeColour(Color4.DarkRed)
                .Delay(250)
                .FadeColour(Color4.Gray, 250);
            return;
        }
        characterObject
            .FadeColour(TurnManager.IsPlayerOne ? Color4.LightGreen : Color4.LightBlue, 250)
            .FadeTo(0.75f, 250);
        playerCharacter.Value = TurnManager.IsPlayerOne ? 'X' : 'O';
        if (TurnManager.CheckVictory())
        {
            NoughtsAndCrossesGame.ScreenStack.Push(new VictoryScreen());
            return;
        }
        TurnManager.IsPlayerOne = !TurnManager.IsPlayerOne;
    }

    protected override bool OnHover(HoverEvent e)
    {
        this.FadeTo(0.75f);
        return true;
    }

    protected override void OnHoverLost(HoverLostEvent e)
    {
        this.FadeTo(1f);
    }

    public void SetCharacter(char character)
    {
        playerCharacter.Value = character;
    }

    public char GetCharacter()
    {
        return playerCharacter.Value;
    }
}
