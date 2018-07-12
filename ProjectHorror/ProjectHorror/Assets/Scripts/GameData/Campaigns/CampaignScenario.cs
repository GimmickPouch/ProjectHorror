using System;
using System.Collections.Generic;
using UnityEngine;

public class CampaignScenario : ScriptableObject
{
    public List<CDStoryChapter> GoodStoryChapters = new List<CDStoryChapter>();
    public List<CDStoryChapter> EvilStoryChapters = new List<CDStoryChapter>();

    public Deck EncounterDeck = null;

    public ChaosBag ChaosBag = null;

    public List<CDPlayer> AvailablePlayers = new List<CDPlayer>();
}
