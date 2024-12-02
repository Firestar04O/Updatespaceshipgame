using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createbullet : MonoBehaviour
{
    public GameObject bullet;
    public AudioSource sfxManager;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") == true)
        {
            Fire();
        }
    }
    void Fire()
    {
        Instantiate(bullet, transform.position, transform.rotation);
        sfxManager.Play();
    }
}
