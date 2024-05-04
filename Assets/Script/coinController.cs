using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinController : MonoBehaviour
{
/*    [SerializeField] private GameObject character;*/
    [SerializeField] private AudioSource CoinAudio;
    private void OnTriggerEnter2D(Collider2D collision)
    {
/*        if (collision.gameObject.Equals(character))
        {
            Debug.Log("Get Coin");
            // MAKA COIN AKAN HILANG DARI UI DAN INPECTOR MAKA YANG DI SCRIPT KOIN AKAN HILANG
            Destroy(gameObject);
        }*/


        // ATAU BISA MENGGUNAKAN TAG
        if(collision.CompareTag("Player")) 
        {
            CoinAudio.Play();
            /*Debug.Log("Get Coin");*/
            // MAKA COIN AKAN HILANG DARI UI DAN INPECTOR MAKA YANG DI SCRIPT KOIN AKAN HILANG
            Destroy(gameObject);
        }
    }
}
