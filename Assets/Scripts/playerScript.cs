using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class playerScript : MonoBehaviour
{
    public float jumpPower = 5.0f;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnJump() {
        rb.AddForce(Vector2.up * jumpPower, (ForceMode2D)(ForceMode)ForceMode2D.Impulse); // tweak force value as needed

    }
}
