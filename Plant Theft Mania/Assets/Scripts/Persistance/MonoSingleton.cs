using UnityEngine;

[DisallowMultipleComponent]
public abstract class MonoSingleton : MonoBehaviour, IPersistentObject
{
    private protected MonoSingleton()
    {
    }

    void IPersistentObject.Initialize()
    {
        MakeCurrent();
    }

    public abstract void MakeCurrent();
}

public abstract class MonoSingleton<T> : MonoSingleton
    where T : MonoSingleton<T>
{
    public static T Instance { get; private set; }

    public sealed override void MakeCurrent()
    {
        Instance = (T)this;
    }
}