using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainController : MonoBehaviour
{
    private const string TILE_FRONT_RENDERER_OBJ_NAME = "FrontRenderer";

    private TerrainType rerrainType = TerrainType.NONE;

    public bool IsPassable { get; private set; } = false;

    public int TileIdx1D { get; private set; } = -1;

    public Vector2Int TileIdx2D { get; private set; } = default;

    #region ��ã�� �˰������� ���� ����
    private SpriteRenderer frontRenderer = default;
    private Color defaultColor = default;
    private Color selectedColor= default;
    private Color searchColor = default;
    private Color inactiveColor = default;

    #endregion  // ��ã�� �˰������� ���� ����

    private void Awake()
    {
        //frontRenderer = gameObject
    }

}