using UnityEngine;
using System.Collections;
using UnityEditor;

public class DataCreation
{
    #region Cards

    public static void CreateCardData<T>(string cardFolder = null, string cardName = null) where T : BaseCardData
    {
        ValidateFolderName(ref cardFolder);
        if (cardName == null)
        {
            cardName = "New" + typeof(T).ToString();
        }

        var asset = ScriptableObject.CreateInstance<T>();

        AssetDatabase.CreateAsset(asset, "Assets/Data/Cards/" + cardFolder + cardName + ".asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }

    [MenuItem("Data/Create/Cards/Enemy")]
    public static void CreateEnemyCardData()
    {
        CreateCardData<CDEnemy>("Enemies");
    }

    [MenuItem("Data/Create/Cards/Location")]
    public static void CreateLocationCardData()
    {
        CreateCardData<CDLocation>("Locations");
    }

    [MenuItem("Data/Create/Cards/Player")]
    public static void CreatePlayerCardData()
    {
        CreateCardData<CDPlayer>("Players");
    }

    #endregion

    #region Decks

    [MenuItem("Data/Create/Deck")]
    public static void CreateNewDeck()
    {
        var asset = ScriptableObject.CreateInstance<Deck>();

        string campaignName = PlayerPrefs.GetString("CampaignInDevelopment", "Tests");
        AssetDatabase.CreateAsset(asset, "Assets/Data/Campaigns/" + campaignName + "/Decks/NewDeck.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }

    #endregion

    #region Campaigns

    [MenuItem("Data/Create/Campaign")]
    public static void CreateNewCampaign()
    {
        var asset = ScriptableObject.CreateInstance<Campaign>();

        AssetDatabase.CreateAsset(asset, "Assets/Data/Campaigns/NewCampaign.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }

    #endregion

    private static void ValidateFolderName(ref string folderName)
    {
        if (folderName == null)
        {
            folderName = string.Empty;
        }
        else if (!folderName.EndsWith("/"))
        {
            folderName += "/";
        }
    }

    [MenuItem("Data/Set Campaign To Develop")]
    public static void SetCampaignName()
    {
        string campaignName = "Tests";
        PlayerPrefs.SetString("CampaignInDevelopment", campaignName); // TODO make this string editable
        Debug.Log("Campaign in development set to " + campaignName);
    }
}