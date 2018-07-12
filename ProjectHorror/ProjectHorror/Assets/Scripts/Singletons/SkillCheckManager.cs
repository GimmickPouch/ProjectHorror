using UnityEngine;

public class SkillCheckManager : MonoBehaviour
{
    private ChaosBag _currentChaosBag = null;

    private void Awake()
    {
        SingletonManager.RegisterSingleton(this);
    }

    // Typically called from CampaignManager
    public void InitiateManager(ChaosBag chaosBag)
    {
        _currentChaosBag = chaosBag;
    }

    public bool ActivateSkillCheck(SkillAttribute skillAttribute, int playerScore, int opposingScore)
    {
        if (_currentChaosBag == null)
        {
            Debug.LogError("SkillCheckManager.ActivateSkillCheck :: Chaos Bag is null");
            return false;
        }

        // TODO check if player wants to discard playable card

        playerScore += DrawFromChaosBag();

        return playerScore >= opposingScore;
    }

    public int DrawFromChaosBag()
    {
        return _currentChaosBag.ChaosModifiers[Random.Range(0, _currentChaosBag.ChaosModifiers.Count)];
    }
}
