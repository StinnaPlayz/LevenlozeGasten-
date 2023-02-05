using UnityEngine;

internal static class PersistentObjectsInitializer
{
    private static GameObject GetPersistentPrefab()
    {
        return Resources.Load<GameObject>("PersistentObjects");
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    private static void OnSubsystemRegistration()
    {
        PersistentObjects.Initialize(GetPersistentPrefab());
    }
}