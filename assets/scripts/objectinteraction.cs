using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    private Rigidbody rb;
    private bool isHeld = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isHeld)
        {
            // Keep the object with the VR controller or mouse
            // Replace with VR controller tracking if using VR
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 2.0f));
            rb.MovePosition(newPosition);
        }
    }

    void OnMouseDown()
    {
        // Pick up object
        rb.useGravity = false;
        isHeld = true;
    }

    void OnMouseUp()
    {
        // Drop object
        isHeld = false;
        rb.useGravity = true;
    }
}

