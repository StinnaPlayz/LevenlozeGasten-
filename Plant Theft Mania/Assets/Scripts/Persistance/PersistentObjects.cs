using UnityEngine;

public static class PersistentObjects
{
    public static void Initialize(GameObject prefab)
    {
        var root = new GameObject();
        root.SetActive(false);
        var instance = Object.Instantiate(prefab, root.transform);

        foreach (var component in instance.GetComponentsInChildren<IPersistentObject>(includeInactive: true))
            component.Initialize();

        Object.DontDestroyOnLoad(root);
        instance.transform.DetachChildren();
        Object.Destroy(root);
    }
}