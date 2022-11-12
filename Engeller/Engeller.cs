using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engeller : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D nesne)
    {
        // Eğer Objenin İsmi "Platform" ise Rastgele bir şekilde Verilen Sayılar arasında Tekrar Oluşsun || Işınlansın
        if (nesne.gameObject.name == "Platform")
        {
            float xPos = Random.Range(-2.8f, 2.8f);
            float yPos = Random.Range(6.65f, 9.16f);
            transform.position = new Vector2(xPos, yPos);
        }
        // Eğer Objenin Tag'ı (Etiketi) "Player" (Karakter) ise Rastgele bir şekilde Verilen Sayılar arasında Tekrar Oluşsun || Işınlansın
        if (nesne.gameObject.tag == "Player")
        {
            float xPos = Random.Range(-2.8f, 2.8f);
            float yPos = Random.Range(6.65f, 9.16f);
            transform.position = new Vector2(xPos, yPos);
        }
    }
}
