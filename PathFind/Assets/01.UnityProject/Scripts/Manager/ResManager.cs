using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResManager : GSingleton<ResManager>
{
    // ¸ðµç Æú´õ¸¦ Ã£¾Æ¼­ µñ¼Å³Ê¸®¿¡ Ä³½Ì
    private const string TERRAIN_PREF_PATH = "Prefab/ObjectTiles/Terrains";
    private const string OBSTACLE_PREF_PATH = "Prefab/ObjectTiles/Obstac";

    public Dictionary<string, GameObject> terrainPrefabs = default;
    public Dictionary<string, GameObject> obstaclePrefabs = default;

    protected override void Init()
    {
        base.Init();

        terrainPrefabs = new Dictionary<string, GameObject>();
        obstaclePrefabs = new Dictionary<string, GameObject>();

        terrainPrefabs.AddObjs(Resources.LoadAll<GameObject>(TERRAIN_PREF_PATH));
        obstaclePrefabs.AddObjs(Resources.LoadAll<GameObject>(OBSTACLE_PREF_PATH));
    }

}
