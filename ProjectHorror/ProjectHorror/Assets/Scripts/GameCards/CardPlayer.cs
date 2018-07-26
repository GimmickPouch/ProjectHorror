using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPlayer : BaseGameCard
{
    private CDPlayer _playerData = null;

    private int _currentHealth = 1;
    private int _currentHorror = 1;
    private int _currentResources = 1;

    public override void SetData(object data)
    {
        base.SetData(data);

        if (data is CDPlayer)
        {
            _playerData = (CDPlayer)data;
            Initiate();
        }
    }

    private void Initiate()
    {
        _currentHealth = _playerData.StartingHealth;
        _currentHorror = _playerData.StartingHorror;
        _currentResources = _playerData.StartingResources;

        SingletonManager.GetSingleton<SpriteHelper>().GetSpriteFromUrl("https://orig00.deviantart.net/d8a6/f/2016/137/5/f/native_tongue_by_nakanoart-da2sfjn.jpg", (sprite) =>
        {
            _mainArt.sprite = sprite;
        });
    }

    public void ModifyHealth(int quantity)
    {
        _currentHealth += quantity;
    }

    public void ModifyHorror(int quantity)
    {
        _currentHorror += quantity;
    }

    public void ModifyResources(int quantity)
    {
        _currentResources += quantity;
    }
}
