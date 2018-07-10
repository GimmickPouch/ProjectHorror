using System;

public class CDLocation : BaseCardData
{
    public SkillAttribute SkillCheckAttribute = SkillAttribute.Knowledge;
    public int SkillCheckDifficulty = 1;

    public bool GenerateItem = false;
    public int ItemQuantity = 0;
    public bool PerPlayer = false;

    public string ItemReferenceID = string.Empty;
}
