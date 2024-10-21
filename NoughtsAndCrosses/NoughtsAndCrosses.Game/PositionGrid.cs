using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;

namespace NoughtsAndCrosses.Game;

public partial class PositionGrid : Container
{
    private const int spacing = 125;
    [BackgroundDependencyLoader]
    private void load()
    {
        var gridItems = new List<PositionRepresentation>();
        int spacingX = spacing;
        int spacingY = -(spacing * 2);
        for (int i = 0; i < 10; i++)
        {
            var posRep = new PositionRepresentation { X = spacingX, Y = spacingY };
            posRep.SetPlayerCharacter(i.ToString().ToCharArray()[0]);
            gridItems.Add(posRep);
            spacingX += spacing;
            if (i % 3 == 0)
            {
                spacingY += spacing;
                spacingX = -spacing;
            }
        }

        gridItems.RemoveAt(0);
        InternalChildren = gridItems.ToArray();
        Anchor = Anchor.Centre;
        Origin = Anchor.Centre;
    }
}