using UnityEngine;

public class PhysicsLabController : MonoBehaviour
{
    [Header("Gravity Settings")]
    public Vector3 gravity = new Vector3(0, -9.81f, 0);

    void Start()
    {
        // Set global gravity for the scene
        Physics.gravity = gravity;
    }
}

