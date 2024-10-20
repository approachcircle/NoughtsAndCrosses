using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Screens;
using osuTK;
using osuTK.Graphics;

namespace NoughtsAndCrosses.Game
{
    public partial class MainScreen : Screen
    {
        [BackgroundDependencyLoader]
        private void load()
        {
            var posReps = new List<PositionRepresentation>();
            for (int i = 0; i < 4; i++)
            {
                var currentPosRep = new PositionRepresentation();
                currentPosRep.SetPlayerCharacter(i.ToString().ToCharArray()[0]);
                posReps.Add(currentPosRep);
            }

            const float col_size = 250;
            GridContainer gridContainer = new GridContainer
            {
                Anchor = Anchor.Centre,
                Origin = Anchor.CentreLeft,
                ColumnDimensions = [
                    new Dimension(),
                    new Dimension(),
                    new Dimension(GridSizeMode.Absolute, col_size),
                ]
            };
            gridContainer.X = -(col_size / 2);
            gridContainer.Content = new[]
            {
                posReps.ToArray()
            };

            InternalChildren =
            [
                gridContainer
            ];
        }
    }
}
