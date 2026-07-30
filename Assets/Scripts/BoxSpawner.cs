using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject box;
    public float spawnInterval = 8f;
    private float timer = 0f;

    void Start()
    {
        BoxSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            BoxSpawn();
            timer = 0f;
        }
    }

    void BoxSpawn()
    {
        Instantiate(box, transform.position, transform.rotation);
    }
}
