using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class trapController : MonoBehaviour
{
    /*
        [SerializeField] private GameObject character;*/
    [SerializeField] private AudioSource audioBoom;
    // isTrigger = false
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*     if (collision.gameObject.Equals(character))
             {
                 Debug.Log("game over");
             }*/
        /*Debug.Log("masuk dari collision");*/
        if (collision.gameObject.CompareTag("Player"))
        {
            audioBoom.Play();
            Destroy(gameObject);
        }
    }

/*    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("lepas dari collision");
    }*/



    // isTrigger = true

    /*    private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("Mengenai Trap");
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            Debug.Log("Lepas Dari Trap");
        }*/



    // Menyentuh garis hijau dan berulang kali
/*    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("stay");
    }*/
}
