using UnityEngine;
using TMPro;
public class scoreManager : MonoBehaviour
{
    public static scoreManager Instance;
    public float score = 0;
    public TMP_Text textMeshPro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = score.ToString();
    }

    public void addScore(float amount)
    {
        score += amount;
    }
}
