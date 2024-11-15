using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public Vector3 forceDirection = new Vector3(1, 0, 0);
    public float forceStrength = 10f;

    void OnMouseDown()
    {
        // Apply force when the object is clicked
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(forceDirection.normalized * forceStrength, ForceMode.Impulse);
    }
}

