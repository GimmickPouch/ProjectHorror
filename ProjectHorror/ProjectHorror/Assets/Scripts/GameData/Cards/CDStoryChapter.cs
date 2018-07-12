using System.Collections.Generic;

public class CDStoryChapter : BaseCardData
{
    public Alignment Alignment = Alignment.Unknown;
    public List<BaseObjective> Objectives = new List<BaseObjective>();

    public List<CDLocation> Locations = new List<CDLocation>();
    public int StartingLocation = 0;
}

public enum Alignment
{
    Unknown,
    Good,
    Evil,
    Neutral
}