using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    Rigidbody2D rb;

    Sprite sprite;
    // TAMPIL DI INPECTOR CUMAN HANYA BISA DI AKSES PADA FILE INI SAJA
    [SerializeField] private float jumpForce, movementSpeed;
    [SerializeField] private Animator animator;
    [SerializeField] private bool isFacingRight;
    [SerializeField] private bool isGrounded;

    // vector2 dan vector3
    /*    [SerializeField] private Vector2 posisi2;
        [SerializeField] private Vector3 posisi3;*/

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isFacingRight = true;
        isGrounded = true;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            /*Debug.Log("space input");*/
            /* transform.Translate(0, jumpForce * Time.deltaTime,0);*/

            Vector2 jump = new Vector2(0, jumpForce * Time.fixedDeltaTime);
            rb.AddForce(jump);

        }
        Berjalan();

        if (Input.GetAxis("Horizontal") > 0 && isFacingRight == false || Input.GetAxis("Horizontal") < 0 && isFacingRight == true )
        {
            Flip();
        }
        animator.SetBool("grounded", isGrounded);
    }

    void Berjalan()
    {
        // jika hanya getKey maka menekan lebih dari sekali, jika getkeydown menekan sekali ataupun ditahan tetap sekali
        // game object kecil adalah lebih spesifik sedangkan yang besar GameObject lebih umum

        // transform posisi, dan translate untuk mengerakan object X                                Y, Z
        /*        gameObject.GetComponent<Transform>().Translate(Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime, 0, 0);*/

        // atau
        /* transform.Translate(Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime, 0, 0);*/


        // atau
        /*   rb.AddForce(Vector2)*/


        // vector2 = x, y (dua dimensi)

        // vector3 = x, y, z (tiga dimensi)

        /*        Vector2.zero = (0,0);
                Vector2.up = (0,1);
                Vector2.down = (0,-1);
                Vector2.right = (1,0);
                Vector2.left = (-1,0);
                Vector2.one = (1,1);*/

        //inisialisasi vector
        /* Vector2 namaVariabel = new Vector2(x, y);*/


        /*
            (1,0)*2= (2,0)
            (1,1) * (2,2)
            (2,2):2=(1,1)
            (1,0)+(1,1)= (2,1)
        */


        // jika berjalan kiri dan ke kanan
        // (0,y)

        // jump
        // (x,0)
        float horizontalInput = Input.GetAxis("Horizontal");
        animator.SetFloat("move", Mathf.Abs(horizontalInput));

        // Hanya beri gaya jika tombol panah kiri atau kanan ditekan
        if (Mathf.Abs(horizontalInput) > 0)
        {
            Vector2 movement = new Vector2(horizontalInput * movementSpeed * Time.fixedDeltaTime, 0);
            rb.AddForce(movement);
        }
        else
        {
            // Jika tidak ada input horizontal, berhenti bergerak dengan memberikan gaya berlawanan
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }


    void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }

    // setter / getter private isGrounded
    public void SetIsGrounded(bool status)
    {
        isGrounded = status;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Water"))
        {
           /* Debug.Log("player is water");*/
        }
    }
}
