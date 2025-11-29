using UnityEngine;

public class FakeTracking : MonoBehaviour
{
    void Start()
    {
        var renderers = GetComponentsInChildren<Renderer>(true);
        foreach (var r in renderers)
            r.enabled = true;

             var colliders = GetComponentsInChildren<Collider>(true);
        foreach (var c in colliders)
            c.enabled = true;

             var canvases = GetComponentsInChildren<Canvas>(true);
        foreach (var canvas in canvases)
            canvas.enabled = true;

        Debug.Log("FAKE TRACKING: O alvo foi SIMULADO como detectado.");
    }
}

