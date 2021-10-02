using UnityEngine;

public class Spin : MonoBehaviour
{
    private bool flipped = false;
    private GaryControls controls;

    void Awake()
    {
        controls = new GaryControls();
        controls.Enable();
        controls.Gary.Flip.performed += ctx => FlipGary();
    }

    void FlipGary()
    {
        flipped = !flipped;
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, (flipped? -1 : 1), 0));
    }
}
