using UnityEngine;

internal static class PersistentObjectsInitializer
{
    public static GameObject GetPersistentPrefab()
    {
        return Resources.Load<GameObject>("PersistentObjects");
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    public static void OnSubsystemRegistration()
    {
        PersistentObjects.Initialize(GetPersistentPrefab());
    }
}