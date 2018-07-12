using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampaignManager : MonoBehaviour
{
    private static readonly GamePhase[] PhaseOrder = { GamePhase.Story, GamePhase.Player, GamePhase.Enemy, GamePhase.Roundup };
    private static int _currentGamePhase = 0;

    private Campaign _campaign = null;

    private void Awake()
    {
        SingletonManager.RegisterSingleton(this);
    }

    public void LoadCampaign(Campaign newCampaign, int scenarioIndex)
    {
        _campaign = newCampaign;

        if (_campaign == null || scenarioIndex < 0 || scenarioIndex >= _campaign.CampaignSteps.Count)
        {
            Debug.LogError("CampaignManager.LoadCampaign :: Campaign is not set up properly or was null");
            return;
        }

        SingletonManager.GetSingleton<SkillCheckManager>().InitiateManager(_campaign.CampaignSteps[scenarioIndex].ChaosBag);
        _currentGamePhase = 1; // Campaigns begin on phase 2
    }

    public Campaign Campaign
    {
        get
        {
            return _campaign;
        }
    }

    public static GamePhase CurrentPhase
    {
        get
        {
            return PhaseOrder[_currentGamePhase];
        }
    }
}

public enum GamePhase
{
    Story,
    Player,
    Enemy,
    Roundup
}