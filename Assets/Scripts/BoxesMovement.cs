using UnityEngine;

public class BoxesMovement : MonoBehaviour
{
    public float speed = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.right * speed) * Time.deltaTime;

        if (transform.position.x > 13.7f|| transform.position.x < -13.7f)
        {
            Destroy(gameObject);
        }
    }
}
