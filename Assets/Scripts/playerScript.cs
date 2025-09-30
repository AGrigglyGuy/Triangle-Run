using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class playerScript : MonoBehaviour
{
    public float jumpPower = 6f;
    public Rigidbody2D rb;
    public AudioClip jumpSound;
    public bool isGrounded = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("floor"))
        {
            isGrounded = true;
        }
      
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("floor"))
        {
            isGrounded = false;
        }
    }

    public void OnJump() {
        if (!isGrounded) return;
        rb.AddForce(Vector2.up * jumpPower, (ForceMode2D)(ForceMode)ForceMode2D.Impulse); // tweak force value as needed
        AudioSource.PlayClipAtPoint(jumpSound, transform.position);
    }
}
