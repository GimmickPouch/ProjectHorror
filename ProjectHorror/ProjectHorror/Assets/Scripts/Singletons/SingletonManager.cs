using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SingletonManager : MonoBehaviour
{
    private static List<MonoBehaviour> _registeredSingletons = new List<MonoBehaviour>();

    public static void RegisterSingleton<T> (T singleton) where T : MonoBehaviour
    {
        _registeredSingletons.Add(singleton);
    }

    public static T GetSingleton<T>() where T : MonoBehaviour
    {
        return (T)_registeredSingletons.Where(mb => mb.GetType() == typeof(T));
    }
}
