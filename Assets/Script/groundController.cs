using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundController : MonoBehaviour
{
    // memanggil object player
    [SerializeField] private GameObject character;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground")){
            character.GetComponent<playerController>().SetIsGrounded(true);
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            character.GetComponent<playerController>().SetIsGrounded(false);
        }
    }
}
