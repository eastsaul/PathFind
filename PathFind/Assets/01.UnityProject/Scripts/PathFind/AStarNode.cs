using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AStarNode
{
    public TerrainController Terrain { get; private set; }
    public GameObject DestinationObj { get; private set; }

    // A Star algorithm
    public float AstarF { get; private set; } = float.MaxValue;
    public float AstarG { get; private set; } = float.MaxValue;
    public float AstarH { get;private set; } = float.MaxValue;
    // 작은 값을 찾아서 가는 로직인데 0을 넣으면 오류가 날 수 있으니까 최대값을 넣자

    public AStarNode AstarPrevNode { get; private set; } = default;

    public AStarNode(TerrainController terrain_, GameObject destinationObj_) 
    {
        Terrain = terrain_;
        DestinationObj = destinationObj_;
    }

    //! Astar 알고리즘에 사용할 비용을 설정한다.
    public void UpdateCost_Astar(float gCost, float heuristic,
        AStarNode prevNode) 
    {
        float aStarF = gCost + heuristic;

        if (aStarF < AstarF)
        {
            AstarG = gCost;
            AstarH = heuristic;
            AstarF = aStarF;

            AstarPrevNode= prevNode;
        }   // if: 비용이 더 작은 경우에만 업데이트 한다.
        else { }

    }

    //! 설정한 비용을 출력한다.
    public void ShowCost_Astar() 
    {
        GFunc.Log($"TileIdx1D: {Terrain.TileIdx1D}," +
            $"F: {AstarF}, G: {AstarG}, H: {AstarH}");
    }

}
