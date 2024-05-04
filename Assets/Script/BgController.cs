using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgController : MonoBehaviour
{
    // HANYA BISA DIAKSES DI FILE INI SAJA 
    private float angka;
    // BISA DIAKSES DI FILE MANA PUN
    public int kalimat; 

    private void Awake()
    {
        Debug.Log("DI PANGGIL PERTAMA");
    }
    void Start()
    {
        angka = 0;
        Debug.Log("DI PANGGIL KEDUA");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("DI PANGGIL KETIGA");
        // jadi updatenya persecond 1 frame
        angka = angka + 1 * Time.deltaTime;
        // digunakan untuk menghapus koma dalam float
        Debug.Log(angka.ToString("0"));
    }

    private void LateUpdate()
    {
        Debug.Log("DI PANGGIL KEEMPAT");
    }
}
