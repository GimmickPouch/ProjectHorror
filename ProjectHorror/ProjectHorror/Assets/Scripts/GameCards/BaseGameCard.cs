using UnityEngine;
using UnityEngine.UI;

public class BaseGameCard : MonoBehaviour
{
    [SerializeField] protected Image _mainArt = null;

    public virtual void SetData(object data)
    {
    }
}
