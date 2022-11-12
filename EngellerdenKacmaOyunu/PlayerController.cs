using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Karakter Kodları")]
    public float speed;
    public float horizontal;
    Rigidbody2D rb;

    [Header("Kalpler")]

    public GameObject[] kalpler; //hearts
    public int can; //Life 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }


    //Karakterin Hareket Etmesini Sağlayan Kodlar
        private void FixedUpdate() {
            rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

        //Eğer Engeller Karaktere Çarpar || Değer ise Can'ımız 1 eksilip Kalp Simgelerimizde Can ile eşdeğer bir şekilde eksilecektir
        private void OnCollisionEnter2D(Collision2D other) {
            if(other.gameObject.tag == "Engel"){
                can --;
                kalpler[can].SetActive(false);
            }
            //Eğer Can'ımız 0 ve Sıfırdan Küçükse Oyun Zamanını Durduruyor. (Geri Kalan Kodlar Size Kalmış)
            if(can <= 0){
                Time.timeScale = 0f; // Oyun Zamanını Durdurma [1 Normal Hız & 0 Durma Hızı]
                Debug.Log("Oyun Bitti");
            }
        }




}
