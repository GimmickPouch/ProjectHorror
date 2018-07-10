using System;
using UnityEngine;

[Serializable]
public class BaseObjective
{
    public WinCondition WinCondition = WinCondition.CollectItem;
    public int Quantity = 1;

    public bool PerPlayer = false;

    public string EnemyReferenceID = string.Empty;
    public string ItemReferenceID = string.Empty;
    public string LocationReferenceID = string.Empty;
}

public enum WinCondition
{
    AutoAdvance,
    BeAtLocation,
    CollectItem,
    KillEnemy,
    RoundsExpired
}