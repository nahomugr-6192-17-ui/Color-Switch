using UnityEngine;

public class Obstacle_Circle_Rotation : MonoBehaviour
{
    public float rotationSpeed = 70f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
