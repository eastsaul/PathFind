using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftUIButtons : MonoBehaviour
{
    //! A Star find path ��ư
    public void OnClickAstarFindBtn() 
    {
        GFunc.Log("A* ��ư Ŭ��");
        PathFinder.Instance.FindPath_Astar();
    }
}
