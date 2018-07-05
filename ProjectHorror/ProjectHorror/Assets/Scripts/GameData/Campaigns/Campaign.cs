using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campaign : ScriptableObject
{
    public string CampaignName = string.Empty;
    public Difficulty Difficulty = Difficulty.Undefined;
    public List<CampaignScenario> CampaignSteps = new List<CampaignScenario>();
}

public enum Difficulty
{
    Undefined,
    Beginner,
    Easy,
    Medium,
    Hard,
    Ultra,
    Impossible
}
