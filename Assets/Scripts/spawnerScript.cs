using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    public GameObject enemy;
    public Transform spawnPoint;
    private float timer = 0f;
    public float spawnInterval = 3.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            Spawn();
            if (spawnInterval > 1.5f)
            {
                spawnInterval -= 0.025f;
            }
                
            timer = 0f;
        }   
       
    }
    void Spawn()
    {
       Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);   
    }
}
