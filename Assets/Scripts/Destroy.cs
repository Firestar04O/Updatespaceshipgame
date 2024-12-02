using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameManagerContol GameManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameManager.UpdateScore(20);
            Destroy(this.gameObject);
            Destroy(collision.gameObject, (float)1);
        }
        else if (collision.gameObject.tag == "Limit")
        {
            Destroy(this.gameObject);
        }
    }
    public void SetGameManagerControl(GameManagerContol gamemanager)
    {
        GameManager = gamemanager;
    }
}

