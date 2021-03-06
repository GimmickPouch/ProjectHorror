﻿using System;
using System.Collections.Generic;

public class CDPlayer : BaseCardData
{
    public int StartingHealth = 5;
    public int StartingHorror = 5;
    public int StartingResources = 5;

    public List<SkillAttributeQuantity> SkillAttributes = new List<SkillAttributeQuantity>
    {
        new SkillAttributeQuantity() { SkillAttribute = SkillAttribute.Willpower, SkillPoints = 1 },
        new SkillAttributeQuantity() { SkillAttribute = SkillAttribute.Knowledge, SkillPoints = 1 },
        new SkillAttributeQuantity() { SkillAttribute = SkillAttribute.Strength, SkillPoints = 1 },
        new SkillAttributeQuantity() { SkillAttribute = SkillAttribute.Evasiveness, SkillPoints = 1 }
    };

    public Deck PlayerDeck = null;
}

[Serializable]
public class SkillAttributeQuantity
{
    public SkillAttribute SkillAttribute = SkillAttribute.Unknown;
    public int SkillPoints = 1;
}

public enum SkillAttribute
{
    All,
    Evasiveness,
    Knowledge,
    Strength,
    Willpower,
    Unknown
}
