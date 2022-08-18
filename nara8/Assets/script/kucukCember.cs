using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class kucukCember : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    bool tuttumu;

    private void Update()
    {
        if (!tuttumu)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime); // up y ekseninde yukari dogru surekli gider

        }
    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("buyukcember"))
        {
            FindObjectOfType<score>().UpdateScore();
            transform.SetParent(other.transform); //igneleri buyuk cembere parent ettik
            other.GetComponent<buyukCember>().speed *= -1f;
            tuttumu = true;
        }
        else if (other.CompareTag("kucukcember"))
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
