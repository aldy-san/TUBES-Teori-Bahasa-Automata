using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ball : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "cekKena")
        {
            Debug.Log("Kena Kau");
            Cursor.visible = true;
            SceneManager.LoadScene(2);
        }
        if (other.gameObject.tag == "Menang")
        {
            Debug.Log("Menang kau");
            Cursor.visible = true;
            SceneManager.LoadScene(3);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("COLIIISINI");
    }
}
