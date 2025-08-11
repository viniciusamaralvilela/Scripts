using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 5f;
    public float jumpForce = 5f;
    public Rigidbody2D rig;
    public int coletavel = 0;

    public bool isGrounded = true;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.freezeRotation = true;
    }

    void Update()
    {
        // Movimento
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;

        // Pulo
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rig.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    public int AddTeste(int value)
    {
        coletavel += value;
        return coletavel;
    }
}
