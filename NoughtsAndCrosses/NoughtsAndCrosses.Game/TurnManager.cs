using System;
using System.Collections.Generic;
using System.Linq;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;

namespace NoughtsAndCrosses.Game;

public class TurnManager
{
    private static readonly int[][] winning_indexes =
    {
        [
            0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7, 8
        ],
        [
            0, 3, 3, 6, 1, 4, 4, 7, 2, 5, 5, 8
        ],
        [
            0, 4, 4, 8, 2, 4, 4, 6
        ]
    };

    private static PositionGrid grid;

    public static bool IsPlayerOne { get; set; } = true;

    public static void SetGrid(PositionGrid posGrid)
    {
        grid = posGrid;
    }

    public static bool CheckVictory()
    {
        if (grid is null)
        {
            throw new NullReferenceException("cannot check victory before grid is set");
        }
        List<PositionRepresentation> posReps = grid.GetPositionRepresentations();
        if (posReps[winning_indexes[0][0]].GetCharacter() == posReps[winning_indexes[0][1]].GetCharacter()
            && posReps[winning_indexes[0][2]].GetCharacter() == posReps[winning_indexes[0][3]].GetCharacter())
        {
            return true;
        }

        if (posReps[winning_indexes[0][4]].GetCharacter() == posReps[winning_indexes[0][5]].GetCharacter()
            && posReps[winning_indexes[0][6]].GetCharacter() == posReps[winning_indexes[0][7]].GetCharacter())
        {
            return true;
        }
        if (posReps[winning_indexes[0][8]].GetCharacter() == posReps[winning_indexes[0][9]].GetCharacter()
            && posReps[winning_indexes[0][10]].GetCharacter() == posReps[winning_indexes[0][11]].GetCharacter())
        {
            return true;
        }
        if (posReps[winning_indexes[1][0]].GetCharacter() == posReps[winning_indexes[1][1]].GetCharacter()
            && posReps[winning_indexes[1][2]].GetCharacter() == posReps[winning_indexes[1][3]].GetCharacter())
        {
            return true;
        }
        if (posReps[winning_indexes[1][4]].GetCharacter() == posReps[winning_indexes[1][5]].GetCharacter()
            && posReps[winning_indexes[1][6]].GetCharacter() == posReps[winning_indexes[1][7]].GetCharacter())
        {
            return true;
        }
        if (posReps[winning_indexes[1][8]].GetCharacter() == posReps[winning_indexes[1][9]].GetCharacter()
            && posReps[winning_indexes[1][10]].GetCharacter() == posReps[winning_indexes[1][11]].GetCharacter())
        {
            return true;
        }
        if (posReps[winning_indexes[2][0]].GetCharacter() == posReps[winning_indexes[2][1]].GetCharacter()
            && posReps[winning_indexes[2][2]].GetCharacter() == posReps[winning_indexes[2][3]].GetCharacter())
        {
            return true;
        }
        if (posReps[winning_indexes[2][4]].GetCharacter() == posReps[winning_indexes[2][5]].GetCharacter()
            && posReps[winning_indexes[2][6]].GetCharacter() == posReps[winning_indexes[2][7]].GetCharacter())
        {
            return true;
        }
        return false;
    }
}
