using System.Collections.Generic;

public class BasePlayable : BaseCardData
{
    public int PlayCost = 0;
    public List<SkillAttribute> SkillModifiers = new List<SkillAttribute>();
}
