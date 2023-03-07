using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RDefine
{
    public const string TERRAIN_PREF_OCEAN = "Terrain_Ocean Variant";
    public const string TERRAIN_PREF_PLAIN = "Terrain_Plain Variant";

    public const string OBSTACLE_PREF_PLAIN_CASTLE = "Obstacle_PlainCastle Variant";

    public enum TileStatusColor 
    {
        DEFAULT, SELECTED, SEARCH, INACTIVE
    }

}
