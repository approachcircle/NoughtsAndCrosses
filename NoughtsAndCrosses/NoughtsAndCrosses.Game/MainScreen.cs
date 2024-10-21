using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Screens;

namespace NoughtsAndCrosses.Game
{
    public partial class MainScreen : Screen
    {
        private const float col_size = 250;

        [BackgroundDependencyLoader]
        private void load()
        {
            InternalChildren =
            [
                new PositionGrid()
            ];
        }
    }
}
