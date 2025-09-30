using System;
using UnityEngine;
using UnityEngine.Rendering;

public class enemyScript : MonoBehaviour
{
    public static float moveSpeed = 5f;
    public float visibleMoveSpeed;
    public GameObject gameOverText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        visibleMoveSpeed = moveSpeed;
        moveSpeed += Time.deltaTime * 0.1f;
        transform.position += Vector3.left * Time.deltaTime * moveSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            gameOverText.SetActive(true);
            Console.WriteLine("Player ded");
        }
    }
}
