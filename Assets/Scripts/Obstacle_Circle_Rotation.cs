using UnityEngine;

public class Obstacle_Circle_Rotation : MonoBehaviour
{
    public float rotationSpeed = 70f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
