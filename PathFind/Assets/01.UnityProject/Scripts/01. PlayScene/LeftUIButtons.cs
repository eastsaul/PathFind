using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftUIButtons : MonoBehaviour
{
    //! A Star find path 버튼
    public void OnClickAstarFindBtn() 
    {
        GFunc.Log("A* 버튼 클릭");
        PathFinder.Instance.FindPath_Astar();
    }
}
