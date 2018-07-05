using System;
using UnityEngine;

public class BaseCardData : ScriptableObject
{
    public Guid CardId = Guid.NewGuid();
    public string Name = string.Empty;
    public int PlayCost = 0;
}
